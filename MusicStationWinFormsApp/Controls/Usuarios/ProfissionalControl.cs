using System.ComponentModel;
using System.Reflection;
using MusicStationWinFormsApp.Models;
using MusicStationWinFormsApp.Repositories;

namespace MusicStationWinFormsApp.controls.usuarios
{
    public partial class ProfissionalControl : UserControl
    {
        // Campos
        private ProfissionalRepository profissionalRepository;
        private BindingList<Profissional> profissionais;
        private CargoRepository cargoRepository;
        private TabPage? hiddenPage; // guia escondida

        // Construtores
        public ProfissionalControl()
        {
            InitializeComponent();
            ConfigurarVisual();
            ConfigurarDataGrid();

            // Somente para testes
            profissionalRepository = new ProfissionalRepository();
            profissionais =
                new BindingList<Profissional>(profissionalRepository
                    .ListarTodos()); // cria uma lista "observável, o grid atualiza automático (adicionar ou remover)
            profissionalBindingSource.DataSource =
                profissionais; // vira o intermediário, permite filtro, navegação e refresh
            dgvDados.DataSource = profissionalBindingSource; // liga o grid a fonte de dados

            CarregarCargos();
        }

        // Métodos
        private void ConfigurarVisual()
        {
            hiddenPage = tbpCadastro;
            tbcProfissionais.TabPages.Remove(hiddenPage);
            this.DoubleBuffered = true;
            dgvDados.ReadOnly = true;
            dtpDataCadastro.CustomFormat = "dd/MM/yyyy HH:mm";
        }

        private void ConfigurarDataGrid()
        {
            // Força o DoubleBuffered na Grid (via Reflection)
            typeof(DataGridView).InvokeMember("DoubleBuffered",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                null, dgvDados, new object[] { true });
        }

        private void CarregarCargos()
        {
            cargoRepository = new CargoRepository();
            List<Cargo> listaDeCargos = cargoRepository.ListarTodos();
            clbCargos.DataSource = listaDeCargos;
            clbCargos.DisplayMember = "Nome";
            clbCargos.ValueMember = "Id";
        }

        private List<Cargo> CargosSelecionados()
        {
            return clbCargos.CheckedItems
                .Cast<Cargo>()
                .ToList();
        }

        // marcar cargos na edição
        private void MarcarCargos(List<Cargo> cargos)
        {
            var ids = cargos.Select(c => c.Id).ToHashSet();

            for (int i = 0; i < clbCargos.Items.Count; i++)
            {
                var cargo = (Cargo)clbCargos.Items[i];
                clbCargos.SetItemChecked(i, ids.Contains(cargo.Id));
            }
        }

        private void AlternarTela()
        {
            TabPage tempPage = hiddenPage;

            if (tbcProfissionais.SelectedTab == tbpListagem)
            {
                tbcProfissionais.SelectedTab = tbpCadastro;
                hiddenPage = tbpListagem;
                tbcProfissionais.TabPages.Remove(hiddenPage);
                tbcProfissionais.TabPages.Add(tempPage);
            }
            else if (tbcProfissionais.SelectedTab == tbpCadastro)
            {
                tbcProfissionais.SelectedTab = tbpListagem;
                hiddenPage = tbpCadastro;
                tbcProfissionais.TabPages.Remove(tbpCadastro);
                tbcProfissionais.TabPages.Add(tempPage);
            }
        }

        private void ModoCadastro()
        {
            txtId.Visible = false;
            lblId.Visible = false;
            dtpDataCadastro.Visible = false;
            lblDataCadastro.Visible = false;

            tbpCadastro.Text = "Novo Profissional";
        }

        private void ModoEdicao()
        {
            txtId.Visible = true;
            lblId.Visible = true;
            dtpDataCadastro.Visible = true;
            lblDataCadastro.Visible = true;

            txtId.Enabled = false;
            dtpDataCadastro.Enabled = false;

            tbpCadastro.Text = "Editar Profissional";
        }

        private void LimparCampos()
        {
            txtId.Clear();
            txtNomeCompleto.Clear();
            txtEmail.Clear();
            txtNomeUsuario.Clear();
            txtSenha.Clear();
            txtTelefone.Clear();

            // limpar checkboxes corretamente
            for (int i = 0; i < clbCargos.Items.Count; i++)
            {
                clbCargos.SetItemChecked(i, false);
            }
        }

        private void CarregarProfissionalSelecionado(Profissional profissional)
        {
            txtId.Text = profissional.Id.ToString();
            txtNomeCompleto.Text = profissional.NomeCompleto;
            txtEmail.Text = profissional.Email;
            txtNomeUsuario.Text = profissional.UsuarioNome;
            txtSenha.Text = profissional.Senha;
            dtpDataCadastro.Value = profissional.DataCadastro;

            txtTelefone.Text = profissional.Telefone;

            // carregar cargos
            clbCargos.ClearSelected(); // evita bug visual

            this.BeginInvoke(new Action(() => // joga a execução pro final da fila da UI.
            {
                MarcarCargos(profissional.Cargos ?? new List<Cargo>());
            }));
        }

        private bool ValidarCampos()
        {
            if (String.IsNullOrWhiteSpace(txtNomeCompleto.Text))
            {
                MessageBox.Show("Nome obrigatório");
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email obrigatório");
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtNomeUsuario.Text))
            {
                MessageBox.Show("Nome do usuário obrigatório");
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Senha obrigatória");
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtTelefone.Text))
            {
                MessageBox.Show("Telefone obrigatória");
                return false;
            }

            if (CargosSelecionados().Count == 0)
            {
                MessageBox.Show("Cargos obrigatório");
                return false;
            }

            return true;
        }

        public void ExecutarPesquisa()
        {
            string texto = txtPesquisa.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(texto))
            {
                profissionalBindingSource.DataSource = profissionais;
                return;
            }

            List<Profissional> filtrados;

            if (int.TryParse(texto, out int id))
            {
                filtrados = profissionais
                    .Where(c => c.Id == id)
                    .ToList();
            }
            else
            {
                filtrados = profissionais
                    .Where(c => c.NomeCompleto.ToLower().Contains(texto))
                    .ToList();
            }

            profissionalBindingSource.DataSource = new BindingList<Profissional>(filtrados);
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
                Profissional profissional = new Profissional();

                profissional.Id = profissionais.Count > 0 ? profissionais.Max(c => c.Id) + 1 : 1;
                profissional.NomeCompleto = txtNomeCompleto.Text;
                profissional.Email = txtEmail.Text;
                profissional.UsuarioNome = txtNomeUsuario.Text;
                profissional.Senha = txtSenha.Text;
                profissional.DataCadastro = DateTime.Now;
                profissional.Telefone = txtTelefone.Text;

                List<Cargo> cargos = CargosSelecionados();

                profissional.Cargos = cargos; // 🔧 CORRIGIDO

                profissionais.Add(profissional);
            }
            else // EDIÇÃO
            {
                int id = int.Parse(txtId.Text);

                Profissional profissional = profissionais.FirstOrDefault(c => c.Id == id);

                if (profissional != null)
                {
                    profissional.NomeCompleto = txtNomeCompleto.Text;
                    profissional.Email = txtEmail.Text;
                    profissional.UsuarioNome = txtNomeUsuario.Text;
                    profissional.Senha = txtSenha.Text;
                    profissional.Telefone = txtTelefone.Text;

                    // 🔧 ADICIONADO: atualizar cargos
                    profissional.Cargos = CargosSelecionados();
                }

                dgvDados.Refresh();
            }

            AlternarTela();
            LimparCampos();

            MessageBox.Show("Profissional salvo com sucesso!");
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
                if (dgvDados.Rows[e.RowIndex].DataBoundItem is Profissional profissionalSelecionado)
                {
                    CarregarProfissionalSelecionado(profissionalSelecionado);
                }

                ModoEdicao();
                AlternarTela();
            }
            else if (nomeColuna == "imgExcluir")
            {
                if (dgvDados.Rows[e.RowIndex].DataBoundItem is Profissional profissionalSelecionado)
                {
                    DialogResult result = MessageBox.Show("Deseja realmente excluir este registro?", "Confirmação",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        profissionais.Remove(profissionalSelecionado);
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
                profissionalBindingSource.DataSource = profissionais;
            }
        }
    }
}