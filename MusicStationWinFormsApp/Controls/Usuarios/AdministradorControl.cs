using System.ComponentModel;
using System.Reflection;
using MusicStationWinFormsApp.Models;
using MusicStationWinFormsApp.Properties;
using MusicStationWinFormsApp.repository;
using MusicStationWinFormsApp.ViewModel;

namespace MusicStationWinFormsApp.controls.usuarios
{
    public partial class AdministradorControl : UserControl
    {
        // Campos
        private readonly AdministradorRepository administradorRepository;

        private readonly BindingSource administradorBindingSource = new();
        private BindingList<AdministradorGridViewModel> administradores = new();

        private TabPage? hiddenPage; // guia escondida

        // Construtores
        public AdministradorControl()
        {
            InitializeComponent();

            administradorRepository = new AdministradorRepository();

            IniciarConfiguracoesIniciais();
            CarregarGrid();
        }

        // Métodos
        private void IniciarConfiguracoesIniciais()
        {
            hiddenPage = tbpCadastro;
            tbcAdministradores.TabPages.Remove(hiddenPage);
            this.DoubleBuffered = true;
            dtpDataCadastro.CustomFormat = "dd/MM/yyyy HH:mm";

            ConfigurarDataGrid();
        }

        private void CarregarGrid()
        {
            administradores = new BindingList<AdministradorGridViewModel>(administradorRepository.ObterTodos());
            administradorBindingSource.DataSource = administradores;
            dgvDados.DataSource = administradorBindingSource;
        }

        private void ConfigurarDataGrid()
        {
            // Força o DoubleBuffered na Grid (via Reflection)
            typeof(DataGridView).InvokeMember("DoubleBuffered",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                null, dgvDados, new object[] { true });

            dgvDados.AutoGenerateColumns = false;
            dgvDados.ReadOnly = true;

            dgvDados.Columns.Clear();


            // Criar colunas

            dgvDados.Columns.Add(CriarColunaTexto("colId", "Id", "IdAdmin", DataGridViewAutoSizeColumnMode.AllCells));

            dgvDados.Columns.Add(CriarColunaTexto("colNome", "Nome", "Nome", DataGridViewAutoSizeColumnMode.AllCells));

            dgvDados.Columns.Add(CriarColunaTexto("colEmail", "Email", "Email", DataGridViewAutoSizeColumnMode.Fill));

            dgvDados.Columns.Add(CriarColunaTexto("colUsuarioNome", "Usuário", "UsuarioNome", DataGridViewAutoSizeColumnMode.AllCells));

            dgvDados.Columns.Add(CriarColunaTexto("colDataCadastro", "Data Cadastro", "DataCadastro", DataGridViewAutoSizeColumnMode.AllCells));

            dgvDados.Columns.Add(CriarColunaTexto("colNivelAcesso", "Nível", "NivelAcesso", DataGridViewAutoSizeColumnMode.AllCells));

            dgvDados.Columns.Add(CriarColunaTexto("colObservacoes", "Observações", "Observacoes", DataGridViewAutoSizeColumnMode.Fill));

            dgvDados.Columns.Add(CriarColunaIcone("imgEditar", Resources.editar, "Editar", 36));

            dgvDados.Columns.Add(CriarColunaIcone("imgExcluir", Resources.excluir, "Excluir", 36));

            dgvDados.Columns["colId"].Width = 45;
            dgvDados.Columns["colUsuarioNome"].Width = 100;
            dgvDados.Columns["colDataCadastro"].Width = 130;
            dgvDados.Columns["colNivelAcesso"].Width = 70;

            dgvDados.Columns["colNome"].FillWeight = 30;
            dgvDados.Columns["colEmail"].FillWeight = 45;
            dgvDados.Columns["colObservacoes"].FillWeight = 35;

            dgvDados.Columns["colId"].DefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleCenter;

            dgvDados.Columns["colNivelAcesso"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dgvDados.Columns["imgEditar"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dgvDados.Columns["imgExcluir"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dgvDados.Columns["imgEditar"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvDados.Columns["imgExcluir"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            dgvDados.Columns["imgEditar"].Resizable = DataGridViewTriState.False;
            dgvDados.Columns["imgExcluir"].Resizable = DataGridViewTriState.False;
        }

        private void AtualizarGrid()
        {
            administradores.Clear();

            List<AdministradorGridViewModel> dados = administradorRepository.ObterTodos();

            foreach (AdministradorGridViewModel administrador in dados)
            {
                administradores.Add(administrador);
            }
        }

        private void AlternarTela()
        {
            TabPage tempPage = hiddenPage;

            if (tbcAdministradores.SelectedTab == tbpListagem)
            {
                tbcAdministradores.SelectedTab = tbpCadastro;
                hiddenPage = tbpListagem;
                tbcAdministradores.TabPages.Remove(hiddenPage);
                tbcAdministradores.TabPages.Add(tempPage);
            }
            else if (tbcAdministradores.SelectedTab == tbpCadastro)
            {
                tbcAdministradores.SelectedTab = tbpListagem;
                hiddenPage = tbpCadastro;
                tbcAdministradores.TabPages.Remove(tbpCadastro);
                tbcAdministradores.TabPages.Add(tempPage);
            }
        }

        private void ModoCadastro()
        {
            txtId.Visible = false;
            lblId.Visible = false;
            dtpDataCadastro.Visible = false;
            lblDataCadastro.Visible = false;

            tbpCadastro.Text = "Novo Administrador";
        }

        private void ModoEdicao()
        {
            txtId.Visible = true;
            lblId.Visible = true;
            dtpDataCadastro.Visible = true;
            lblDataCadastro.Visible = true;

            txtId.Enabled = false;
            dtpDataCadastro.Enabled = false;

            tbpCadastro.Text = "Editar Administrador";
        }

        private void LimparCampos()
        {
            txtId.Clear();
            txtNomeCompleto.Clear();
            txtEmail.Clear();
            txtNomeUsuario.Clear();
            txtSenha.Clear();
            txtNivelAcesso.Clear();
            txtObservacoes.Clear();
        }

        private void CarregarAdministradorSelecionado(AdministradorGridViewModel administrador)
        {
            txtId.Text = administrador.IdAdmin.ToString();
            txtNomeCompleto.Text = administrador.Nome;
            txtEmail.Text = administrador.Email;
            txtNomeUsuario.Text = administrador.UsuarioNome;
            txtSenha.Text = "$(@*##(@*!$@";
            dtpDataCadastro.Value = administrador.DataCadastro;

            txtNivelAcesso.Text = administrador.NivelAcesso.ToString();
            txtObservacoes.Text = administrador.Observacoes;
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

            if (String.IsNullOrWhiteSpace(txtNivelAcesso.Text))
            {
                MessageBox.Show("Nível de acesso obrigatório");
                return false;
            }

            return true;
        }

        public void ExecutarPesquisa()
        {
            string texto = txtPesquisa.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(texto))
            {
                administradorBindingSource.DataSource = administradores;
                return;
            }

            List<AdministradorGridViewModel> filtrados;

            if (int.TryParse(texto, out int id))
            {
                filtrados = administradores
                    .Where(a => a.IdAdmin == id)
                    .ToList();
            }
            else
            {
                filtrados = administradores
                    .Where(a => a.UsuarioNome.ToLower().Contains(texto))
                    .ToList();
            }

            administradorBindingSource.DataSource = new BindingList<AdministradorGridViewModel>(filtrados);
        }

        #region helpersDataGrid

        private DataGridViewTextBoxColumn CriarColunaTexto(string name, string header, string property, DataGridViewAutoSizeColumnMode sizeMode)
        {
            return new DataGridViewTextBoxColumn
            {
                Name = name,
                HeaderText = header,
                DataPropertyName = property,
                AutoSizeMode = sizeMode
            };
        }

        private DataGridViewImageColumn CriarColunaIcone(string name, Image image, string toolTip, int width)
        {
            return new DataGridViewImageColumn
            {
                Name = name,
                HeaderText = "",
                ToolTipText = toolTip,
                Image = image,
                Width = width
            };
        }

        #endregion

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
                Administrador administrador = new Administrador
                {
                    Usuario = new Usuario
                    {
                        Nome = txtNomeCompleto.Text,
                        Email = txtEmail.Text,
                        UsuarioNome = txtNomeUsuario.Text,
                        SenhaHash = txtSenha.Text,
                        DataCadastro = DateTime.Now
                    },

                    NivelAcesso = int.Parse(txtNivelAcesso.Text),
                    Observacoes = txtObservacoes.Text
                };

                // Adidcionar método de create admin
                // administradorRepository.Adicionar(administrador);
            }
            else // EDIÇÃO
            {
                int id = int.Parse(txtId.Text);
                /*
                Administrador? administrador = administradores.FirstOrDefault(a => a.IdAdmin == id);

                if (administrador != null)
                {
                    administrador.Usuario.Nome = txtNomeCompleto.Text;
                    administrador.Usuario.Email = txtEmail.Text;
                    administrador.Usuario.UsuarioNome = txtNomeUsuario.Text;
                    administrador.Usuario.SenhaHash = txtSenha.Text;

                    administrador.NivelAcesso = int.Parse(txtNivelAcesso.Text);
                    administrador.Observacoes = txtObservacoes.Text;
                }
                */
                dgvDados.Refresh();
            }

            AtualizarGrid();
            AlternarTela();
            LimparCampos();

            MessageBox.Show("Administrador salvo com sucesso!");
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ExecutarPesquisa();
        }

        #region dgvConfigs

        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return; // verifica se o clique foi em uma linha / coluna válida e não no cabeçalho

            string nomeColuna = dgvDados.Columns[e.ColumnIndex].Name;
            // Configuração do botão de edição
            if (nomeColuna == "imgEditar")
            {
                if (dgvDados.Rows[e.RowIndex]
                        .DataBoundItem is AdministradorGridViewModel
                    administradorSelecionado) // verifica se a linha selecionada é um usuário
                {
                    CarregarAdministradorSelecionado(administradorSelecionado); // Preenche os Text Box do usuário
                }

                ModoEdicao();
                AlternarTela();
            }
            // Configuração do botão de exclusão
            else if (nomeColuna == "imgExcluir")
            {
                if (dgvDados.Rows[e.RowIndex].DataBoundItem is AdministradorGridViewModel administradorSelecionado)
                {
                    DialogResult result = MessageBox.Show("Deseja realmente excluir este registro?", "Confirmação",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        // Exclui do banco
                        administradores.Remove(administradorSelecionado);
                        AtualizarGrid();
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
                administradorBindingSource.DataSource = administradores;
            }
        }
    }
}