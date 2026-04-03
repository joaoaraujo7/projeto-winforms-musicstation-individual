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

namespace MusicStationWinFormsApp.controls.usuarios
{
    public partial class AdministradorControl : UserControl
    {
        // Campos
        private AdministradorRepository administradorRepository;
        private BindingList<Administrador> administradores;
        private TabPage? hiddenPage; // guia escondida

        // Construtores
        public AdministradorControl()
        {
            InitializeComponent();
            ConfigurarVisual();
            ConfigurarDataGrid();

            // Somente para testes
            administradorRepository = new AdministradorRepository();
            administradores = new BindingList<Administrador>(administradorRepository.ListarTodos()); // cria uma lista "observável, o grid atualiza automático (adicionar ou remover)
            administradorBindingSource.DataSource = administradores; // vira o intermediário, permite filtro, navegação e refresh
            dgvDados.DataSource = administradorBindingSource; // liga o grid a fonte de dados
        }

        // Métodos
        private void ConfigurarVisual()
        {
            hiddenPage = tbpCadastro;
            tbcAdministradores.TabPages.Remove(hiddenPage);
            this.DoubleBuffered = true;
            dgvDados.ReadOnly = true;
            dtpDataCadastro.CustomFormat = "dd/MM/yyyy HH:mm";
        }

        private void ConfigurarDataGrid()
        {
            // Força o DoubleBuffered na Grid (via Reflection)
            typeof(DataGridView).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetProperty,
                null, dgvDados, new object[] { true });

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

        private void CarregarClienteSelecionado(Administrador administrador)
        {
            txtId.Text = administrador.Id.ToString();
            txtNomeCompleto.Text = administrador.NomeCompleto;
            txtEmail.Text = administrador.Email;
            txtNomeUsuario.Text = administrador.UsuarioNome;
            txtSenha.Text = administrador.Senha;
            dtpDataCadastro.Value = administrador.DataCadastro;

            txtNivelAcesso.Text = administrador.NivelAcesso;
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

            List<Administrador> filtrados;

            if (int.TryParse(texto, out int id))
            {
                filtrados = administradores
                    .Where(c => c.Id == id)
                    .ToList();
            }
            else
            {
                filtrados = administradores
                    .Where(c => c.NomeCompleto.ToLower().Contains(texto))
                    .ToList();
            }

            administradorBindingSource.DataSource = new BindingList<Administrador>(filtrados);
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
                Administrador administrador = new Administrador();

                administrador.Id = administradores.Count > 0 ? administradores.Max(c => c.Id) + 1 : 1;
                administrador.NomeCompleto = txtNomeCompleto.Text;
                administrador.Email = txtEmail.Text;
                administrador.UsuarioNome = txtNomeUsuario.Text;
                administrador.Senha = txtSenha.Text;
                administrador.DataCadastro = DateTime.Now;

                administrador.NivelAcesso = txtNivelAcesso.Text;
                administrador.Observacoes = txtObservacoes.Text;

                administradores.Add(administrador);
            }
            else // EDIÇÃO
            {
                int id = int.Parse(txtId.Text);

                Administrador administrador = administradores.FirstOrDefault(c => c.Id == id);

                if (administrador != null)
                {
                    administrador.NomeCompleto = txtNomeCompleto.Text;
                    administrador.Email = txtEmail.Text;
                    administrador.UsuarioNome = txtNomeUsuario.Text;
                    administrador.Senha = txtSenha.Text;

                    administrador.NivelAcesso = txtNivelAcesso.Text;
                    administrador.Observacoes = txtObservacoes.Text;
                }

                dgvDados.Refresh();
            }

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
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return; // verifica se o clique foi em uma linha / coluna válida e não no cabeçalho

            string nomeColuna = dgvDados.Columns[e.ColumnIndex].Name;
            // Configuração do botão de edição
            if (nomeColuna == "imgEditar")
            {
                if (dgvDados.Rows[e.RowIndex].DataBoundItem is Administrador clienteSelecionado) // verifica se a linha selecionada é um usuário
                {
                    CarregarClienteSelecionado(clienteSelecionado); // Preenche os Text Box do usuário
                }

                ModoEdicao();
                AlternarTela();
            }
            // Configuração do botão de exclusão
            else if (nomeColuna == "imgExcluir")
            {
                if (dgvDados.Rows[e.RowIndex].DataBoundItem is Administrador clienteSelecionado)
                {
                    DialogResult result = MessageBox.Show("Deseja realmente excluir este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        // Exclui do banco
                        administradores.Remove(clienteSelecionado);
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