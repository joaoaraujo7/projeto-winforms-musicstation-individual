using MusicStationWinFormsApp.models;
using MusicStationWinFormsApp.repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicStationWinFormsApp.controls.financeiro
{
    public partial class FormaPagamentoControl : UserControl
    {
        // Campos
        private FormaPagamentoRepository formaPagamentoRepository;
        private BindingList<FormaPagamento> formaPagamentos;
        private TabPage hiddenPage; // guia escondida

        // Construtores
        public FormaPagamentoControl()
        {
            InitializeComponent();
            ConfigurarVisual();
            ConfigurarDataGrid();
            

            // Somente para testes
            formaPagamentoRepository = new FormaPagamentoRepository();
            formaPagamentos = new BindingList<FormaPagamento>(formaPagamentoRepository.ListarTodos()); // cria uma lista "observável, o grid atualiza automático (adicionar ou remover)
            formaPagamentoBindingSource.DataSource = formaPagamentos; // vira o intermediário, permite filtro, navegação e refresh
            dgvDados.DataSource = formaPagamentoBindingSource; // liga o grid a fonte de dados
        }

        // Métodos
        private void ConfigurarVisual()
        {
            hiddenPage = tbpCadastro;
            tbcFormaPagamentos.TabPages.Remove(hiddenPage);
            this.DoubleBuffered = true;
            dgvDados.ReadOnly = true;
        }

        private void ConfigurarDataGrid()
        {
            // Força o DoubleBuffered na Grid(via Reflection) - evita piscadas na tela
            typeof(DataGridView).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetProperty,
                null, dgvDados, new object[] { true });
        }

        private void AlternarTela()
        {
            TabPage tempPage = hiddenPage;

            if (tbcFormaPagamentos.SelectedTab == tbpListagem)
            {
                tbcFormaPagamentos.SelectedTab = tbpCadastro;
                hiddenPage = tbpListagem;
                tbcFormaPagamentos.TabPages.Remove(hiddenPage);
                tbcFormaPagamentos.TabPages.Add(tempPage);

            }
            else if (tbcFormaPagamentos.SelectedTab == tbpCadastro)
            {
                tbcFormaPagamentos.SelectedTab = tbpListagem;
                hiddenPage = tbpCadastro;
                tbcFormaPagamentos.TabPages.Remove(tbpCadastro);
                tbcFormaPagamentos.TabPages.Add(tempPage);
            }
        }

        private void ModoCadastro()
        {
            txtId.Visible = false;
            lblId.Visible = false;

            tbpCadastro.Text = "Nova Forma de Pagamento";
        }

        private void ModoEdicao()
        {
            txtId.Visible = true;
            lblId.Visible = true;

            txtId.Enabled = false;

            tbpCadastro.Text = "Editar Forma de Pagamento";
        }

        private void LimparCampos()
        {
            txtId.Clear();
            txtFormaPagamento.Clear();
        }

        private void CarregarFormaPagamentoSelecionada(FormaPagamento formapagamento)
        {
            txtId.Text = formapagamento.Id.ToString();
            txtFormaPagamento.Text = formapagamento?.Tipo;
        }

        private bool ValidarCampos()
        {
            if (String.IsNullOrWhiteSpace(txtFormaPagamento.Text))
            {
                MessageBox.Show("Tipo obrigatório");
                return false;
            }

            return true;
        }

        public void ExecutarPesquisa()
        {
            string texto = txtPesquisa.Text.Trim().ToLower();

            // Se estiver vazio → volta lista original
            if (string.IsNullOrWhiteSpace(texto))
            {
                formaPagamentoBindingSource.DataSource = formaPagamentos;
                return;
            }

            List<FormaPagamento> filtrados;

            // Busca por ID
            if (int.TryParse(texto, out int id))
            {
                filtrados = formaPagamentos
                    .Where(u => u.Id == id)
                    .ToList();
            }
            else
            {
                filtrados = formaPagamentos
                    .Where(u => u.Tipo.ToLower().Contains(texto))
                    .ToList();
            }
            // Atualiza o grid com resultado filtrado
            formaPagamentoBindingSource.DataSource = new BindingList<FormaPagamento>(filtrados);
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

            // Adicionar
            if (String.IsNullOrEmpty(txtId.Text))
            {
                FormaPagamento formapagamento = new FormaPagamento();
                formapagamento.Id = formaPagamentos.Count > 0 ? formaPagamentos.Max(u => u.Id) + 1 : 1;
                formapagamento.Tipo = txtFormaPagamento.Text;

                formaPagamentos.Add(formapagamento);
            }
            // Edição
            else
            {
                int id = int.Parse(txtId.Text);
                FormaPagamento formapagamento = formaPagamentos.FirstOrDefault(u => u.Id == id);

                if (formapagamento != null)
                {
                    formapagamento.Tipo = txtFormaPagamento.Text;

                }
                dgvDados.Refresh();
            }
            AlternarTela();
            LimparCampos();
            MessageBox.Show("Forma de Pagamento salvo com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ExecutarPesquisa();
        }

        #region dgvConfigs
        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return; // verifica se o clique foi em uma linha / coluna válida e não no cabeçalho

            string nomeColuna = dgvDados.Columns[e.ColumnIndex].Name;
            // Configuração do botão de edição
            if (nomeColuna == "imgEditar")
            {
                if (dgvDados.Rows[e.RowIndex].DataBoundItem is FormaPagamento formaPagamentoSelecionado) // verifica se a linha selecionada é um usuário
                {
                    CarregarFormaPagamentoSelecionada(formaPagamentoSelecionado); // Preenche os Text Box do usuário
                }

                ModoEdicao();
                AlternarTela();
            }
            // Configuração do botão de exclusão
            else if (nomeColuna == "imgExcluir")
            {
                if (dgvDados.Rows[e.RowIndex].DataBoundItem is FormaPagamento formaPagamentoSelecionado)
                {
                    DialogResult result = MessageBox.Show("Deseja realmente excluir este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        // Exclui do banco
                        formaPagamentos.Remove(formaPagamentoSelecionado);
                    }
                }
            }
        }

        private void dgvDados_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                // Muda a cor da linha quando o mouse passa por cima
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
                // Chama o método de pesquisa
                ExecutarPesquisa();

                // Impede o "beep" do Windows ao apertar Enter em um TextBox de linha única
                e.SuppressKeyPress = true;
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPesquisa.Text))
            {
                formaPagamentoBindingSource.DataSource = formaPagamentos;
            }
        }
    }
}
