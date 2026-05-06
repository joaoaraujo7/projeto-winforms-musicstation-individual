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
    public partial class EmpresaControl : UserControl
    {
        // Campos
        private EmpresaRepository empresaRepository;
        private BindingList<Empresa> empresas;
        private TabPage? hiddenPage; // guia escondida

        // Construtores
        public EmpresaControl()
        {
            InitializeComponent();
            ConfigurarVisual();
            ConfigurarDataGrid();

            // Somente para testes
            empresaRepository = new EmpresaRepository();
            empresas = new BindingList<Empresa>(empresaRepository.ListarTodos()); // cria uma lista "observável, o grid atualiza automático (adicionar ou remover)
            empresaBindingSource.DataSource = empresas; // vira o intermediário, permite filtro, navegação e refresh
            dgvDados.DataSource = empresaBindingSource; // liga o grid a fonte de dados
        }

        // Métodos
        private void ConfigurarVisual()
        {
            hiddenPage = tbpCadastro;
            tbcEmpresa.TabPages.Remove(hiddenPage);
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

            if (tbcEmpresa.SelectedTab == tbpListagem)
            {
                tbcEmpresa.SelectedTab = tbpCadastro;
                hiddenPage = tbpListagem;
                tbcEmpresa.TabPages.Remove(hiddenPage);
                tbcEmpresa.TabPages.Add(tempPage);

            }
            else if (tbcEmpresa.SelectedTab == tbpCadastro)
            {
                tbcEmpresa.SelectedTab = tbpListagem;
                hiddenPage = tbpCadastro;
                tbcEmpresa.TabPages.Remove(tbpCadastro);
                tbcEmpresa.TabPages.Add(tempPage);
            }
        }

        private void ModoCadastro()
        {
            txtId.Visible = false;
            lblId.Visible = false;
            dtpDataCadastro.Visible = false;
            lblDataCadastro.Visible = false;

            tbpCadastro.Text = "Novo Empresa";
        }

        private void ModoEdicao()
        {
            txtId.Visible = true;
            lblId.Visible = true;
            dtpDataCadastro.Visible = true;
            lblDataCadastro.Visible = true;

            txtId.Enabled = false;
            dtpDataCadastro.Enabled = false;

            tbpCadastro.Text = "Editar Empresa";
        }

        private void LimparCampos()
        {
            txtId.Clear();
            txtNomeCompleto.Clear();
            txtEmail.Clear();
            txtNomeUsuario.Clear();
            txtSenha.Clear();
            txtTelefone.Clear();
            txtRazaoSocial.Clear();
            txtCnpj.Clear();
        }

        private void CarregarEmpresaSelecionada(Empresa empresa)
        {
            txtId.Text = empresa.Id.ToString();
            txtNomeCompleto.Text = empresa.NomeCompleto;
            txtEmail.Text = empresa.Email;
            txtNomeUsuario.Text = empresa.UsuarioNome;
            txtSenha.Text = empresa.Senha;
            dtpDataCadastro.Value = empresa.DataCadastro;

            txtRazaoSocial.Text = empresa.RazaoSocial;
            txtCnpj.Text = empresa.Cnpj;
            txtTelefone.Text = empresa.Telefone;
            txtDescricao.Text = empresa.Descricao;
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

            if (String.IsNullOrWhiteSpace(txtRazaoSocial.Text))
            {
                MessageBox.Show("Razão social obrigatório");
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtCnpj.Text))
            {
                MessageBox.Show("Cnpj obrigatório");
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtTelefone.Text))
            {
                MessageBox.Show("Telefone obrigatório");
                return false;
            }

            return true;
        }

        public void ExecutarPesquisa()
        {
            string texto = txtPesquisa.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(texto))
            {
                empresaBindingSource.DataSource = empresas;
                return;
            }

            List<Empresa> filtrados;

            if (int.TryParse(texto, out int id))
            {
                filtrados = empresas
                    .Where(c => c.Id == id)
                    .ToList();
            }
            else
            {
                filtrados = empresas
                    .Where(c => c.NomeCompleto.ToLower().Contains(texto))
                    .ToList();
            }

            empresaBindingSource.DataSource = new BindingList<Empresa>(filtrados);
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
                Empresa empresa = new Empresa();

                empresa.Id = empresas.Count > 0 ? empresas.Max(c => c.Id) + 1 : 1;
                empresa.NomeCompleto = txtNomeCompleto.Text;
                empresa.Email = txtEmail.Text;
                empresa.UsuarioNome = txtNomeUsuario.Text;
                empresa.Senha = txtSenha.Text;
                empresa.DataCadastro = DateTime.Now;

                empresa.RazaoSocial = txtRazaoSocial.Text;
                empresa.Cnpj = txtCnpj.Text;
                empresa.Telefone = txtTelefone.Text;
                empresa.Descricao = txtDescricao.Text;

                empresas.Add(empresa);
            }
            else // EDIÇÃO
            {
                int id = int.Parse(txtId.Text);

                Empresa empresa = empresas.FirstOrDefault(c => c.Id == id);

                if (empresa != null)
                {
                    empresa.NomeCompleto = txtNomeCompleto.Text;
                    empresa.Email = txtEmail.Text;
                    empresa.UsuarioNome = txtNomeUsuario.Text;
                    empresa.Senha = txtSenha.Text;

                    empresa.RazaoSocial = txtRazaoSocial.Text;
                    empresa.Cnpj = txtCnpj.Text;
                    empresa.Telefone = txtTelefone.Text;
                    empresa.Descricao = txtDescricao.Text;
                }

                dgvDados.Refresh();
            }

            AlternarTela();
            LimparCampos();

            MessageBox.Show("Empresa salva com sucesso!");
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
                if (dgvDados.Rows[e.RowIndex].DataBoundItem is Empresa empresaSelecionada) // verifica se a linha selecionada é um usuário
                {
                    CarregarEmpresaSelecionada(empresaSelecionada); // Preenche os Text Box do usuário
                }

                ModoEdicao();
                AlternarTela();
            }
            // Configuração do botão de exclusão
            else if (nomeColuna == "imgExcluir")
            {
                if (dgvDados.Rows[e.RowIndex].DataBoundItem is Empresa empresaSelecionada)
                {
                    DialogResult result = MessageBox.Show("Deseja realmente excluir este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        // Exclui do banco
                        empresas.Remove(empresaSelecionada);
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
                empresaBindingSource.DataSource = empresas;
            }
        }
    }
}
