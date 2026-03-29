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

namespace MusicStationWinFormsApp.controls.usuarios;

public partial class ClienteControl : UserControl
{
    // Campos
    private ClienteRepository clienteRepository;
    private BindingList<Cliente> clientes;
    private TabPage? hiddenPage; // guia escondida

    // Construtores
    public ClienteControl()
    {
        InitializeComponent();
        ConfigurarVisual();

        // Força o DoubleBuffered na Grid (via Reflection)
        typeof(DataGridView).InvokeMember("DoubleBuffered",
            System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetProperty,
            null, dgvDados, new object[] { true });

        // Somente para testes
        clienteRepository = new ClienteRepository();
        clientes = new BindingList<Cliente>(clienteRepository.ListarTodos()); // cria uma lista "observável, o grid atualiza automático (adicionar ou remover)
        clienteBindingSource.DataSource = clientes; // vira o intermediário, permite filtro, navegação e refresh
        dgvDados.DataSource = clienteBindingSource; // liga o grid a fonte de dados
    }

    // Métodos
    private void ConfigurarVisual()
    {
        hiddenPage = tbpCadastro;
        tbcClientes.TabPages.Remove(hiddenPage);
        this.DoubleBuffered = true;
        dgvDados.ReadOnly = true;
        dtpDataCadastro.CustomFormat = "dd/MM/yyyy HH:mm";
    }

    private void AlternarTela()
    {
        TabPage tempPage = hiddenPage;

        if (tbcClientes.SelectedTab == tbpListagem)
        {
            tbcClientes.SelectedTab = tbpCadastro;
            hiddenPage = tbpListagem;
            tbcClientes.TabPages.Remove(hiddenPage);
            tbcClientes.TabPages.Add(tempPage);

        }
        else if (tbcClientes.SelectedTab == tbpCadastro)
        {
            tbcClientes.SelectedTab = tbpListagem;
            hiddenPage = tbpCadastro;
            tbcClientes.TabPages.Remove(tbpCadastro);
            tbcClientes.TabPages.Add(tempPage);
        }
    }

    private void ModoCadastro()
    {
        txtId.Visible = false;
        lblId.Visible = false;
        dtpDataCadastro.Visible = false;
        lblDataCadastro.Visible = false;

        tbpCadastro.Text = "Novo Cliente";
    }

    private void ModoEdicao()
    {
        txtId.Visible = true;
        lblId.Visible = true;
        dtpDataCadastro.Visible = true;
        lblDataCadastro.Visible = true;

        txtId.Enabled = false;
        dtpDataCadastro.Enabled = false;

        tbpCadastro.Text = "Editar Cliente";
    }

    private void LimparCampos()
    {
        txtId.Clear();
        txtNomeCompleto.Clear();
        txtEmail.Clear();
        txtNomeUsuario.Clear();
        txtSenha.Clear();
        txtTelefone.Clear();
        txtRua.Clear();
        txtNumero.Clear();
    }

    private void CarregarClienteSelecionado(Cliente cliente)
    {
        txtId.Text = cliente.Id.ToString();
        txtNomeCompleto.Text = cliente.NomeCompleto;
        txtEmail.Text = cliente.Email;
        txtNomeUsuario.Text = cliente.UsuarioNome;
        txtSenha.Text = cliente.Senha;
        dtpDataCadastro.Value = cliente.DataCadastro;

        txtTelefone.Text = cliente.Telefone;
        txtRua.Text = cliente.Rua;
        txtNumero.Text = cliente.Numero;
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

        if (String.IsNullOrWhiteSpace(txtRua.Text))
        {
            MessageBox.Show("Rua obrigatória");
            return false;
        }

        if (String.IsNullOrWhiteSpace(txtNumero.Text))
        {
            MessageBox.Show("Numero obrigatória");
            return false;
        }
        return true;
    }

    public void ExecutarPesquisa()
    {
        string texto = txtPesquisa.Text.Trim().ToLower();

        if (string.IsNullOrWhiteSpace(texto))
        {
            clienteBindingSource.DataSource = clientes;
            return;
        }

        List<Cliente> filtrados;

        if (int.TryParse(texto, out int id))
        {
            filtrados = clientes
                .Where(c => c.Id == id)
                .ToList();
        }
        else
        {
            filtrados = clientes
                .Where(c => c.NomeCompleto.ToLower().Contains(texto))
                .ToList();
        }

        clienteBindingSource.DataSource = new BindingList<Cliente>(filtrados);
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

        // NOVO CLIENTE
        if (String.IsNullOrEmpty(txtId.Text))
        {
            Cliente cliente = new Cliente();

            cliente.Id = clientes.Count > 0 ? clientes.Max(c => c.Id) + 1 : 1;
            cliente.NomeCompleto = txtNomeCompleto.Text;
            cliente.Email = txtEmail.Text;
            cliente.UsuarioNome = txtNomeUsuario.Text;
            cliente.Senha = txtSenha.Text;
            cliente.DataCadastro = DateTime.Now;

            cliente.Telefone = txtTelefone.Text;
            cliente.Rua = txtRua.Text;
            cliente.Numero = txtNumero.Text;

            clientes.Add(cliente);
        }
        else // EDIÇÃO
        {
            int id = int.Parse(txtId.Text);

            Cliente cliente = clientes.FirstOrDefault(c => c.Id == id);

            if (cliente != null)
            {
                cliente.NomeCompleto = txtNomeCompleto.Text;
                cliente.Email = txtEmail.Text;
                cliente.UsuarioNome = txtNomeUsuario.Text;
                cliente.Senha = txtSenha.Text;

                cliente.Telefone = txtTelefone.Text;
                cliente.Rua = txtRua.Text;
                cliente.Numero = txtNumero.Text;
            }

            dgvDados.Refresh();
        }

        AlternarTela();
        LimparCampos();

        MessageBox.Show("Cliente salvo com sucesso!");
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
            if (dgvDados.Rows[e.RowIndex].DataBoundItem is Cliente clienteSelecionado) // verifica se a linha selecionada é um usuário
            {
                CarregarClienteSelecionado(clienteSelecionado); // Preenche os Text Box do usuário
            }

            ModoEdicao();
            AlternarTela();
        }
        // Configuração do botão de exclusão
        else if (nomeColuna == "imgExcluir")
        {
            if (dgvDados.Rows[e.RowIndex].DataBoundItem is Cliente clienteSelecionado)
            {
                DialogResult result = MessageBox.Show("Deseja realmente excluir este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Exclui do banco
                    clientes.Remove(clienteSelecionado);
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
            clienteBindingSource.DataSource = clientes;
        }
    }
}
