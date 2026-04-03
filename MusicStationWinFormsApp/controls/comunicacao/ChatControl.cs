using MusicStationWinFormsApp.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicStationWinFormsApp.controls.comunicacao
{
    public partial class ChatControl : UserControl
    {
        // Campos
        private TabPage? hiddenPage; // guia escondida

        // Construtores
        public ChatControl()
        {
            InitializeComponent();
            ConfigurarVisual();

            dgvDados.AutoGenerateColumns = false;

            dgvDados.Rows.Add();
            dgvDados.Rows.Add();
            dgvDados.Rows.Add();

            dgvMensagens.ReadOnly = false;
        }

        // Métodos
        private void ConfigurarVisual()
        {
            hiddenPage = tbpCadastro;
            tbcPedidos.TabPages.Remove(hiddenPage);
            this.DoubleBuffered = true;
            dgvDados.ReadOnly = true;
            dtpDataCriacao.CustomFormat = "dd/MM/yyyy HH:mm";
        }

        private void AlternarTela()
        {
            TabPage tempPage = hiddenPage;

            if (tbcPedidos.SelectedTab == tbpListagem)
            {
                tbcPedidos.SelectedTab = tbpCadastro;
                hiddenPage = tbpListagem;
                tbcPedidos.TabPages.Remove(hiddenPage);
                tbcPedidos.TabPages.Add(tempPage);

            }
            else if (tbcPedidos.SelectedTab == tbpCadastro)
            {
                tbcPedidos.SelectedTab = tbpListagem;
                hiddenPage = tbpCadastro;
                tbcPedidos.TabPages.Remove(tbpCadastro);
                tbcPedidos.TabPages.Add(tempPage);
            }
        }

        private void ModoCadastro()
        {
            txtId.Visible = false;
            lblId.Visible = false;
            dtpDataCriacao.Visible = false;

            tbpCadastro.Text = "Novo Chat";
        }

        private void ModoEdicao()
        {
            txtId.Visible = true;
            lblId.Visible = true;
            dtpDataCriacao.Visible = true;


            txtId.Enabled = false;
            dtpDataCriacao.Enabled = false;

            tbpCadastro.Text = "Editar Chat";
        }

        private void LimparCampos()
        {
            txtId.Clear();
            cboUsuario1.SelectedIndex = -1;
            cboUsuario2.SelectedIndex = -1;
            dgvMensagens.Rows.Clear();
        }

        private void CarregarChatSelecionado(Chat chat)
        {
            txtId.Text = chat.Id.ToString();
            cboUsuario1.SelectedValue = chat.Usuario1;
            cboUsuario2.SelectedValue = chat.Usuario2;
            dtpDataCriacao.Value = chat.DataCriacao;

            dgvMensagens.DataSource = chat.Mensagens;
        }

        private bool ValidarCampos()
        {
            if (cboUsuario1.SelectedItem == null)
            {
                MessageBox.Show("Usuário 1 obrigatório");
                return false;
            }

            if (cboUsuario2.SelectedItem == null)
            {
                MessageBox.Show("Usuário 2 obrigatório");
                return false;
            }

            if (dgvMensagens.RowCount < 1)
            {
                MessageBox.Show("Tem que ter pelo menos um item.");
            }

            return true;
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
            AlternarTela();
            LimparCampos();
            dgvDados.Rows.Add();
            MessageBox.Show("Chat salvo com sucesso!");
        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            dgvMensagens.Rows.Add();
            MessageBox.Show("Item adicionado com sucesso!");
        }

        #region dgvDados
        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return; // verifica se o clique foi em uma linha / coluna válida e não no cabeçalho

            string nomeColuna = dgvDados.Columns[e.ColumnIndex].Name;
            // Configuração do botão de edição
            if (nomeColuna == "imgEditar")
            {
                ModoEdicao();
                AlternarTela();
            }
            // Configuração do botão de exclusão
            else if (nomeColuna == "imgExcluir")
            {
                DialogResult result = MessageBox.Show("Deseja realmente excluir este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    dgvDados.Rows.RemoveAt(e.RowIndex);
                }
            }
        }
        #endregion

        #region dgvItensPedido
        private void dgvItensPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return; // verifica se o clique foi em uma linha / coluna válida e não no cabeçalho

            string nomeColuna = dgvMensagens.Columns[e.ColumnIndex].Name;
            // Configuração do botão de edição
            if (nomeColuna == "imgExcluir2")
            {
                DialogResult result = MessageBox.Show("Deseja realmente excluir este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    dgvMensagens.Rows.RemoveAt(e.RowIndex);
                }
            }
        }
        #endregion
    }
}
