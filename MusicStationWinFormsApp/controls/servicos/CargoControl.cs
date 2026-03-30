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

namespace MusicStationWinFormsApp.controls.cargos
{
    public partial class CargoControl : UserControl
    {
        // Campos
        private CargoRepository cargoRepository;
        private BindingList<Cargo> cargos;
        private TabPage hiddenPage; // guia escondida

        // Construtores
        public CargoControl()
        {
            InitializeComponent();
            ConfigurarVisual();
            ConfigurarDataGrid();

            // Somente para testes
            cargoRepository = new CargoRepository();
            cargos = new BindingList<Cargo>(cargoRepository.ListarTodos()); // cria uma lista "observável, o grid atualiza automático (adicionar ou remover)
            cargoBindingSource.DataSource = cargos; // vira o intermediário, permite filtro, navegação e refresh
            dgvDados.DataSource = cargoBindingSource; // liga o grid a fonte de dados
        }

        // Métodos
        private void ConfigurarVisual()
        {
            hiddenPage = tbpCadastro;
            tbcCargos.TabPages.Remove(hiddenPage);
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

            if (tbcCargos.SelectedTab == tbpListagem)
            {
                tbcCargos.SelectedTab = tbpCadastro;
                hiddenPage = tbpListagem;
                tbcCargos.TabPages.Remove(hiddenPage);
                tbcCargos.TabPages.Add(tempPage);

            }
            else if (tbcCargos.SelectedTab == tbpCadastro)
            {
                tbcCargos.SelectedTab = tbpListagem;
                hiddenPage = tbpCadastro;
                tbcCargos.TabPages.Remove(tbpCadastro);
                tbcCargos.TabPages.Add(tempPage);
            }
        }

        private void ModoCadastro()
        {
            txtId.Visible = false;
            lblId.Visible = false;

            tbpCadastro.Text = "Novo Cargo";
        }

        private void ModoEdicao()
        {
            txtId.Visible = true;
            lblId.Visible = true;

            txtId.Enabled = false;

            tbpCadastro.Text = "Editar Cargo";
        }

        private void LimparCampos()
        {
            txtId.Clear();
            txtNome.Clear();
            txtDescricao.Clear();
        }

        private void CarregarCargoSelecionado(Cargo cargo)
        {
            txtId.Text = cargo.Id.ToString();
            txtNome.Text = cargo.Nome;
            txtDescricao.Text = cargo.Descricao;
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

            return true;
        }

        public void ExecutarPesquisa()
        {
            string texto = txtPesquisa.Text.Trim().ToLower();

            // Se estiver vazio → volta lista original
            if (string.IsNullOrWhiteSpace(texto))
            {
                cargoBindingSource.DataSource = cargos;
                return;
            }

            List<Cargo> filtrados;

            // Busca por ID
            if (int.TryParse(texto, out int id))
            {
                filtrados = cargos
                    .Where(u => u.Id == id)
                    .ToList();
            }
            else
            {
                filtrados = cargos
                    .Where(u => u.Nome.ToLower().Contains(texto))
                    .ToList();
            }
            // Atualiza o grid com resultado filtrado
            cargoBindingSource.DataSource = new BindingList<Cargo>(filtrados);
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
                Cargo cargo = new Cargo();
                cargo.Id = cargos.Count > 0 ? cargos.Max(u => u.Id) + 1 : 1;
                cargo.Nome = txtNome.Text;
                cargo.Descricao = txtDescricao.Text;

                cargos.Add(cargo);
            }
            // Edição
            else
            {
                int id = int.Parse(txtId.Text);
                Cargo cargo = cargos.FirstOrDefault(u => u.Id == id);

                if (cargo != null)
                {
                    cargo.Nome = txtNome.Text;
                    cargo.Descricao = txtDescricao.Text;

                }
                dgvDados.Refresh();
            }
            AlternarTela();
            LimparCampos();
            MessageBox.Show("Cargo salvo com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (dgvDados.Rows[e.RowIndex].DataBoundItem is Cargo cargoSelecionado) // verifica se a linha selecionada é um usuário
                {
                    CarregarCargoSelecionado(cargoSelecionado); // Preenche os Text Box do usuário
                }

                ModoEdicao();
                AlternarTela();
            }
            // Configuração do botão de exclusão
            else if (nomeColuna == "imgExcluir")
            {
                if (dgvDados.Rows[e.RowIndex].DataBoundItem is Cargo cargoSelecionado)
                {
                    DialogResult result = MessageBox.Show("Deseja realmente excluir este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        // Exclui do banco
                        cargos.Remove(cargoSelecionado);
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
                cargoBindingSource.DataSource = cargos;
            }
        }
    }
}
