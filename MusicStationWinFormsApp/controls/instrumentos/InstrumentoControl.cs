using MusicStationWinFormsApp.models;
using MusicStationWinFormsApp.repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicStationWinFormsApp.controls.instrumentos
{
    public partial class InstrumentoControl : UserControl
    {
        // Campos
        private InstrumentoRepository instrumentoRepository;
        private EmpresaRepository empresaRepository;
        private BindingList<Instrumento> instrumentos;
        private TabPage? hiddenPage; // guia escondida

        // Construtores
        public InstrumentoControl()
        {
            InitializeComponent();
            ConfigurarVisual();
            ConfigurarDataGrid();

            // Somente para testes
            instrumentoRepository = new InstrumentoRepository();
            empresaRepository = new EmpresaRepository();

            instrumentos = new BindingList<Instrumento>(instrumentoRepository.ListarTodos()); // cria uma lista "observável, o grid atualiza automático (adicionar ou remover)
            instrumentoBindingSource.DataSource = instrumentos; // vira o intermediário, permite filtro, navegação e refresh
            dgvDados.DataSource = instrumentoBindingSource; // liga o grid a fonte de dados

            ConfigurarCboEmpresa();
        }

        // Métodos
        private void ConfigurarVisual()
        {
            hiddenPage = tbpCadastro;
            tbcInstrumentos.TabPages.Remove(hiddenPage);
            this.DoubleBuffered = true;
            dgvDados.ReadOnly = true;
        }

        private void ConfigurarDataGrid()
        {
            // Força o DoubleBuffered na Grid (via Reflection)
            typeof(DataGridView).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetProperty,
                null, dgvDados, new object[] { true });
        }

        private void ConfigurarCboEmpresa()
        {
            var lista = empresaRepository.ListarTodos();
            cboEmpresa.DataSource = lista;

            cboEmpresa.DisplayMember = "NomeCompleto";
            cboEmpresa.ValueMember = "Id";
            cboEmpresa.SelectedValue = -1;
        }

        private void AlternarTela()
        {
            TabPage tempPage = hiddenPage;

            if (tbcInstrumentos.SelectedTab == tbpListagem)
            {
                tbcInstrumentos.SelectedTab = tbpCadastro;
                hiddenPage = tbpListagem;
                tbcInstrumentos.TabPages.Remove(hiddenPage);
                tbcInstrumentos.TabPages.Add(tempPage);

            }
            else if (tbcInstrumentos.SelectedTab == tbpCadastro)
            {
                tbcInstrumentos.SelectedTab = tbpListagem;
                hiddenPage = tbpCadastro;
                tbcInstrumentos.TabPages.Remove(tbpCadastro);
                tbcInstrumentos.TabPages.Add(tempPage);
            }
        }

        private void ModoCadastro()
        {
            txtId.Visible = false;
            lblId.Visible = false;

            tbpCadastro.Text = "Novo Instrumento";
        }

        private void ModoEdicao()
        {
            txtId.Visible = true;
            lblId.Visible = true;

            txtId.Enabled = false;

            tbpCadastro.Text = "Editar Instrumento";
        }

        private void LimparCampos()
        {
            txtId.Clear();
            txtNome.Clear();
            txtDescricao.Clear();
            txtPreco.Clear();
            chkDisponivel.Checked = false;
            cboEmpresa.SelectedIndex = - 1;
        }

        private void CarregarInstrumentoSelecionado(Instrumento instrumento)
        {
            txtId.Text = instrumento.Id.ToString();
            txtNome.Text = instrumento.Nome;
            txtDescricao.Text = instrumento.Descricao;
            txtPreco.Text = instrumento.PrecoLocacao.ToString();
            chkDisponivel.Checked = instrumento.Disponivel == 1;

            cboEmpresa.SelectedValue = instrumento.Empresa?.Id;
        }

        private bool ValidarCampos()
        {
            if (String.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Nome obrigatório");
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                MessageBox.Show("Descrição obrigatória");
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtPreco.Text))
            {
                MessageBox.Show("Preço obrigatório");
                return false;
            }

            if (cboEmpresa.SelectedItem == null)
            {
                MessageBox.Show("Empresa obrigatória");
                return false;
            }

            return true;
        }

        public void ExecutarPesquisa()
        {
            string texto = txtPesquisa.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(texto))
            {
                instrumentoBindingSource.DataSource = instrumentos;
                return;
            }

            List<Instrumento> filtrados;

            if (int.TryParse(texto, out int id))
            {
                filtrados = instrumentos
                    .Where(c => c.Id == id)
                    .ToList();
            }
            else
            {
                filtrados = instrumentos
                    .Where(c => c.Nome.ToLower().Contains(texto))
                    .ToList();
            }

            instrumentoBindingSource.DataSource = new BindingList<Instrumento>(filtrados);
        }

        // Eventos

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            ModoCadastro();
            AlternarTela();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            AlternarTela();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            // ADICIONAR
            if (String.IsNullOrEmpty(txtId.Text))
            {
                Instrumento instrumento = new Instrumento();

                instrumento.Id = instrumentos.Count > 0 ? instrumentos.Max(c => c.Id) + 1 : 1;
                instrumento.Nome = txtNome.Text;
                instrumento.Descricao = txtDescricao.Text;

                if (decimal.TryParse(txtPreco.Text, out decimal preco))
                {
                    instrumento.PrecoLocacao = preco;
                }
                else
                {
                    instrumento.PrecoLocacao = 0;
                }

                instrumento.Disponivel = chkDisponivel.Checked ? 1 : 0;

                instrumento.Empresa = cboEmpresa.SelectedItem as Empresa;

                instrumentos.Add(instrumento);
            }
            else // EDIÇÃO
            {
                int id = int.Parse(txtId.Text);

                Instrumento instrumento = instrumentos.FirstOrDefault(c => c.Id == id);

                if (instrumento != null)
                {
                    
                    instrumento.Nome = txtNome.Text;
                    instrumento.Descricao = txtDescricao.Text;

                    if (decimal.TryParse(txtPreco.Text, out decimal preco))
                    {
                        instrumento.PrecoLocacao = preco;
                    }
                    else
                    {
                        instrumento.PrecoLocacao = 0;
                    }

                    instrumento.Disponivel = chkDisponivel.Checked ? 1 : 0;

                    instrumento.Empresa = cboEmpresa.SelectedItem as Empresa;
                }

                dgvDados.Refresh();
            }

            AlternarTela();
            LimparCampos();

            MessageBox.Show("Instrumento salvo com sucesso!");
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ExecutarPesquisa();
        }

        #region dgvConfigs
        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string nomeColuna = dgvDados.Columns[e.ColumnIndex].Name;

            if (nomeColuna == "imgEditar")
            {
                if (dgvDados.Rows[e.RowIndex].DataBoundItem is Instrumento profissionalSelecionado)
                {
                    CarregarInstrumentoSelecionado(profissionalSelecionado);
                }

                ModoEdicao();
                AlternarTela();
            }
            else if (nomeColuna == "imgExcluir")
            {
                if (dgvDados.Rows[e.RowIndex].DataBoundItem is Instrumento profissionalSelecionado)
                {
                    DialogResult result = MessageBox.Show("Deseja realmente excluir este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        instrumentos.Remove(profissionalSelecionado);
                    }
                }
            }
        }

        private void dgvDados_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvDados.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(60, 55, 52);
            }
        }

        private void dgvDados_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvDados.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(40, 36, 34);
            }
        }
        #endregion

        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ExecutarPesquisa();
                e.SuppressKeyPress = true;
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPesquisa.Text))
            {
                instrumentoBindingSource.DataSource = instrumentos;
            }
        }
    }
}
