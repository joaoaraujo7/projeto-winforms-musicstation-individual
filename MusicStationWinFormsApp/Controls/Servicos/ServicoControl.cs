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

namespace MusicStationWinFormsApp.controls.servicos
{
    public partial class ServicoControl : UserControl
    {
        // Campos
        private ServicoRepository servicoRepository;
        private BindingList<Servico> servicos;
        private TabPage hiddenPage; // guia escondida

        // Construtores
        public ServicoControl()
        {
            InitializeComponent();
            ConfigurarVisual();
            ConfigurarDataGrid();

            // Somente para testes
            servicoRepository = new ServicoRepository();
            servicos = new BindingList<Servico>(servicoRepository.ListarTodos()); // cria uma lista "observável, o grid atualiza automático (adicionar ou remover)
            servicoBindingSource.DataSource = servicos; // vira o intermediário, permite filtro, navegação e refresh
            dgvDados.DataSource = servicoBindingSource; // liga o grid a fonte de dados
        }

        // Métodos
        private void ConfigurarVisual()
        {
            hiddenPage = tbpCadastro;
            tbcServicos.TabPages.Remove(hiddenPage);
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

            if (tbcServicos.SelectedTab == tbpListagem)
            {
                tbcServicos.SelectedTab = tbpCadastro;
                hiddenPage = tbpListagem;
                tbcServicos.TabPages.Remove(hiddenPage);
                tbcServicos.TabPages.Add(tempPage);

            }
            else if (tbcServicos.SelectedTab == tbpCadastro)
            {
                tbcServicos.SelectedTab = tbpListagem;
                hiddenPage = tbpCadastro;
                tbcServicos.TabPages.Remove(tbpCadastro);
                tbcServicos.TabPages.Add(tempPage);
            }
        }

        private void ModoCadastro()
        {
            txtId.Visible = false;
            lblId.Visible = false;

            tbpCadastro.Text = "Novo Serviço";
        }

        private void ModoEdicao()
        {
            txtId.Visible = true;
            lblId.Visible = true;

            txtId.Enabled = false;

            tbpCadastro.Text = "Editar Serviço";
        }

        private void LimparCampos()
        {
            txtId.Clear();
            txtNome.Clear();
            txtDescricao.Clear();
            txtPreco.Clear();
        }

        private void CarregarServicoSelecionado(Servico servico)
        {
            txtId.Text = servico.Id.ToString();
            txtNome.Text = servico.Nome;
            txtDescricao.Text = servico.Descricao;
            txtPreco.Text = servico.Preco.ToString();
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
                MessageBox.Show("Descrição obrigatório");
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtPreco.Text))
            {
                MessageBox.Show("Preço obrigatório");
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
                servicoBindingSource.DataSource = servicos;
                return;
            }

            List<Servico> filtrados;

            // Busca por ID
            if (int.TryParse(texto, out int id))
            {
                filtrados = servicos
                    .Where(u => u.Id == id)
                    .ToList();
            }
            else
            {
                filtrados = servicos
                    .Where(u => u.Nome.ToLower().Contains(texto))
                    .ToList();
            }
            // Atualiza o grid com resultado filtrado
            servicoBindingSource.DataSource = new BindingList<Servico>(filtrados);
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
                Servico servico = new Servico();
                servico.Id = servicos.Count > 0 ? servicos.Max(u => u.Id) + 1 : 1;
                servico.Nome = txtNome.Text;
                servico.Descricao = txtDescricao.Text;

                if (decimal.TryParse(txtPreco.Text, out decimal preco))
                {
                    servico.Preco = preco;
                }
                else
                {
                    servico.Preco = 0;
                }

                servicos.Add(servico);
            }
            // Edição
            else
            {
                int id = int.Parse(txtId.Text);
                Servico servico = servicos.FirstOrDefault(u => u.Id == id);

                if (servico != null)
                {
                    servico.Nome = txtNome.Text;
                    servico.Descricao = txtDescricao.Text;

                    if (decimal.TryParse(txtPreco.Text, out decimal preco))
                    {
                        servico.Preco = preco;
                    }
                    else
                    {
                        servico.Preco = 0;
                    }
                }
                dgvDados.Refresh();
            }
            AlternarTela();
            LimparCampos();
            MessageBox.Show("Serviço salvo com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (dgvDados.Rows[e.RowIndex].DataBoundItem is Servico servicoSelecionado) // verifica se a linha selecionada é um usuário
                {
                    CarregarServicoSelecionado(servicoSelecionado); // Preenche os Text Box do usuário
                }

                ModoEdicao();
                AlternarTela();
            }
            // Configuração do botão de exclusão
            else if (nomeColuna == "imgExcluir")
            {
                if (dgvDados.Rows[e.RowIndex].DataBoundItem is Servico servicoSelecionado)
                {
                    DialogResult result = MessageBox.Show("Deseja realmente excluir este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        // Exclui do banco
                        servicos.Remove(servicoSelecionado);
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
                servicoBindingSource.DataSource = servicos;
            }
        }
    }
}
