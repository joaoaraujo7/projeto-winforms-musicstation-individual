using System.ComponentModel;
using MusicStationWinFormsApp.Constants;
using MusicStationWinFormsApp.Helpers;
using MusicStationWinFormsApp.Models;
using MusicStationWinFormsApp.Properties;
using MusicStationWinFormsApp.Services;
using MusicStationWinFormsApp.ViewModel;

namespace MusicStationWinFormsApp.controls.usuarios
{
    public partial class AdministradorControl : UserControl
    {
        #region campos

        private readonly AdministradorService administradorService;

        private readonly BindingSource administradorBindingSource = new();
        private BindingList<AdministradorGridViewModel> administradores = new();

        private TabPage? hiddenPage; // guia escondida

        #endregion

        #region construtores

        public AdministradorControl()
        {
            InitializeComponent();

            administradorService = new AdministradorService();

            IniciarConfiguracoesIniciais();
            CarregarGrid();
        }

        #endregion

        #region metodos

        private void IniciarConfiguracoesIniciais()
        {
            hiddenPage = tbpCadastro;
            tbcAdministradores.TabPages.Remove(hiddenPage);
            DoubleBuffered = true;
            dtpDataCadastro.CustomFormat = DataFormatos.DateTimePadrao;

            ConfigurarDataGrid();
        }

        private void CarregarGrid()
        {
            administradores = new BindingList<AdministradorGridViewModel>(administradorService.ObterTodos());
            administradorBindingSource.DataSource = administradores;
            dgvDados.DataSource = administradorBindingSource;
        }

        private void ConfigurarDataGrid()
        {
            DataGridHelpers.ConfigurarPadrão(dgvDados);

            // Criar colunas

            dgvDados.Columns.Add(DataGridHelpers.Texto("colId", "Id", "IdAdmin", width: 45,
                alignment: DataGridViewContentAlignment.MiddleCenter));
            dgvDados.Columns.Add(DataGridHelpers.Texto("colNome", "Nome", "Nome", DataGridViewAutoSizeColumnMode.Fill,
                fillWeight: 25));
            dgvDados.Columns.Add(DataGridHelpers.Texto("colEmail", "Email", "Email",
                DataGridViewAutoSizeColumnMode.Fill, fillWeight: 45));
            dgvDados.Columns.Add(DataGridHelpers.Texto("colUsuarioNome", "Usuário", "UsuarioNome"));
            dgvDados.Columns.Add(DataGridHelpers.Texto("colDataCadastro", "Data Cadastro", "DataCadastro", width: 130,
                alignment: DataGridViewContentAlignment.MiddleCenter));
            dgvDados.Columns.Add(DataGridHelpers.Texto("colNivelAcesso", "Nível", "NivelAcesso", width: 70,
                alignment: DataGridViewContentAlignment.MiddleCenter));
            dgvDados.Columns.Add(DataGridHelpers.Texto("colObservacoes", "Observações", "Observacoes",
                DataGridViewAutoSizeColumnMode.Fill, fillWeight: 35));

            dgvDados.Columns.Add(DataGridHelpers.Icone("imgEditar", Resources.editar, "Editar"));
            dgvDados.Columns.Add(DataGridHelpers.Icone("imgExcluir", Resources.excluir, "Excluir"));
        }

        private void AtualizarGrid()
        {
            administradores = new BindingList<AdministradorGridViewModel>(administradorService.ObterTodos());

            administradorBindingSource.DataSource = administradores;
        }

        private void AlternarTela()
        {
            TabPage? tempPage = hiddenPage;

            if (tempPage == null) return;

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
            
            txtSenha.Enabled = true;

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
            
            txtSenha.Enabled = false;
            txtSenha.Clear();

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
            dtpDataCadastro.Value = administrador.DataCadastro;

            txtNivelAcesso.Text = administrador.NivelAcesso.ToString();
            txtObservacoes.Text = administrador.Observacoes;
        }

        public void ExecutarPesquisa()
        {
            try
            {
                string termo = txtPesquisa.Text.Trim();

                List<AdministradorGridViewModel> resultado = string.IsNullOrWhiteSpace(termo)
                    ? administradorService.ObterTodos()
                    : administradorService.Pesquisar(termo);

                administradores = new BindingList<AdministradorGridViewModel>(resultado);
                administradorBindingSource.DataSource = administradores;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao pesquisar administradores.\n\n" + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private Administrador CriarAdministradorPelosCampos()
        {
            int.TryParse(txtNivelAcesso.Text, out int nivelAcesso);

            return new Administrador
            {
                Usuario = new Usuario
                {
                    Nome = txtNomeCompleto.Text,
                    Email = txtEmail.Text,
                    UsuarioNome = txtNomeUsuario.Text,
                    SenhaHash = txtSenha.Text,
                    DataCadastro = string.IsNullOrEmpty(txtId.Text)
                        ? DateTime.Now
                        : dtpDataCadastro.Value
                },
                NivelAcesso = nivelAcesso,
                Observacoes = txtObservacoes.Text
            };
        }
        
        #endregion

        #region eventos

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
            try
            {
                Administrador administrador = CriarAdministradorPelosCampos();

                if (String.IsNullOrEmpty(txtId.Text))
                {
                    administradorService.Adicionar(administrador);
                }
                else
                {
                    administrador.IdAdmin = int.Parse(txtId.Text);
                    administradorService.Atualizar(administrador);
                }

                AtualizarGrid();
                AlternarTela();
                LimparCampos();
                
                MessageBox.Show("Administrador salvo com sucesso!");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar administrador. \n\n" + ex.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        //dgvConfigs

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
                    administradorSelecionado) // verifica se a linha selecionada é um administrador
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
                        administradorService.Remover(administradorSelecionado.IdAdmin);
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ExecutarPesquisa();
        }

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
            ExecutarPesquisa();
        }

        #endregion
    }
}