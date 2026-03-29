using MusicStationWinFormsApp.models;
using MusicStationWinFormsApp.Properties;
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
    public partial class UsuarioControl : UserControl
    {
        // Campos
        private UsuarioRepository usuarioRepository;
        private BindingList<Usuario> usuarios;
        private TabPage hiddenPage; // guia escondida

        // Construtores
        public UsuarioControl()
        {
            InitializeComponent();
            ConfigurarVisual();

            // Somente para testes
            usuarioRepository = new UsuarioRepository();
            usuarios = new BindingList<Usuario>(usuarioRepository.ListarTodos()); // cria uma lista "observável, o grid atualiza automático (adicionar ou remover)
            usuarioBindingSource.DataSource = usuarios; // vira o intermediário, permite filtro, navegação e refresh
            dgvDados.DataSource = usuarioBindingSource; // liga o grid a fonte de dados
        }

        // Métodos
        private void ConfigurarVisual()
        {
            hiddenPage = tbpCadastro;
            tbcUsuarios.TabPages.Remove(hiddenPage);
            this.DoubleBuffered = true;
            dgvDados.ReadOnly = true;
            dtpDataCadastro.CustomFormat = "dd/MM/yyyy HH:mm";
        }

        private void AlternarTela()
        {
            TabPage tempPage = hiddenPage;

            if (tbcUsuarios.SelectedTab == tbpListagem)
            {
                tbcUsuarios.SelectedTab = tbpCadastro;
                hiddenPage = tbpListagem;
                tbcUsuarios.TabPages.Remove(hiddenPage);
                tbcUsuarios.TabPages.Add(tempPage);

            }
            else if (tbcUsuarios.SelectedTab == tbpCadastro)
            {
                tbcUsuarios.SelectedTab = tbpListagem;
                hiddenPage = tbpCadastro;
                tbcUsuarios.TabPages.Remove(tbpCadastro);
                tbcUsuarios.TabPages.Add(tempPage);
            }
        }

        private void ModoCadastro()
        {
            txtId.Visible = false;
            lblId.Visible = false;
            dtpDataCadastro.Visible = false;
            lblDataCadastro.Visible = false;

            tbpCadastro.Text = "Novo Usuário";
        }

        private void ModoEdicao()
        {
            txtId.Visible = true;
            lblId.Visible = true;
            dtpDataCadastro.Visible = true;
            lblDataCadastro.Visible = true;

            txtId.Enabled = false;
            dtpDataCadastro.Enabled = false;

            tbpCadastro.Text = "Editar Usuário";
        }

        private void LimparCampos()
        {
            txtId.Clear();
            txtNomeCompleto.Clear();
            txtEmail.Clear();
            txtNomeUsuario.Clear();
            txtSenha.Clear();
        }

        private void CarregarUsuarioSelecionado(Usuario usuario)
        {
            txtId.Text = usuario.IdUsuario.ToString();
            txtNomeCompleto.Text = usuario.NomeCompleto;
            txtEmail.Text = usuario.Email;
            txtNomeUsuario.Text = usuario.UsuarioNome;
            txtSenha.Text = usuario.Senha;
            dtpDataCadastro.Value = usuario.DataCadastro;
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
            return true;
        }

        public void ExecutarPesquisa()
        {
            string texto = txtPesquisa.Text.Trim().ToLower();

            // Se estiver vazio → volta lista original
            if (string.IsNullOrWhiteSpace(texto))
            {
                usuarioBindingSource.DataSource = usuarios;
                return;
            }

            List<Usuario> filtrados;

            // Busca por ID
            if (int.TryParse(texto, out int id))
            {
                filtrados = usuarios
                    .Where(u => u.IdUsuario == id)
                    .ToList();
            }
            else
            {
                filtrados = usuarios
                    .Where(u => u.NomeCompleto.ToLower().Contains(texto))
                    .ToList();
            }
            // Atualiza o grid com resultado filtrado
            usuarioBindingSource.DataSource = new BindingList<Usuario>(filtrados);
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
                Usuario usuario = new Usuario();
                usuario.IdUsuario = usuarios.Count > 0 ? usuarios.Max(u => u.IdUsuario) + 1 : 1;
                usuario.NomeCompleto = txtNomeCompleto.Text;
                usuario.Email = txtEmail.Text;
                usuario.UsuarioNome = txtNomeUsuario.Text;
                usuario.Senha = txtSenha.Text;
                usuario.DataCadastro = DateTime.Now;

                usuarios.Add(usuario);

                AlternarTela();

                MessageBox.Show("Usuário adicionado com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Edição
            else
            {
                int id = int.Parse(txtId.Text);
                Usuario usuario = usuarios.FirstOrDefault(u => u.IdUsuario == id);

                if (usuario != null)
                {
                    usuario.NomeCompleto = txtNomeCompleto.Text;
                    usuario.Email = txtEmail.Text;
                    usuario.UsuarioNome = txtNomeUsuario.Text;
                    usuario.Senha = txtSenha.Text;
                }
                dgvDados.Refresh();

                AlternarTela();

                MessageBox.Show("Usuário editado com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LimparCampos();
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
                if (dgvDados.Rows[e.RowIndex].DataBoundItem is Usuario usuarioSelecionado) // verifica se a linha selecionada é um usuário
                {
                    CarregarUsuarioSelecionado(usuarioSelecionado); // Preenche os Text Box do usuário
                }

                ModoEdicao();
                AlternarTela();
            }
            // Configuração do botão de exclusão
            else if (nomeColuna == "imgExcluir")
            {
                if (dgvDados.Rows[e.RowIndex].DataBoundItem is Usuario usuarioSelecionado)
                {
                    DialogResult result = MessageBox.Show("Deseja realmente excluir este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        // Exclui do banco
                        usuarios.Remove(usuarioSelecionado);
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
                usuarioBindingSource.DataSource = usuarios;
            }
        }
    }
}
