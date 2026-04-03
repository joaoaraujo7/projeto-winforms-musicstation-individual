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
    public partial class NotificacaoControl : UserControl
    {
        // Campos
        private TabPage? hiddenPage; // guia escondida

        // Construtores
        public NotificacaoControl()
        {
            InitializeComponent();
            ConfigurarVisual();

            dgvDados.AutoGenerateColumns = false;

            dgvDados.Rows.Add();
            dgvDados.Rows.Add();
            dgvDados.Rows.Add();
        }

        // Métodos
        private void ConfigurarVisual()
        {
            hiddenPage = tbpCadastro;
            tbcNotificacoes.TabPages.Remove(hiddenPage);
            this.DoubleBuffered = true;
            dgvDados.ReadOnly = true;
            dtpDataCadastro.CustomFormat = "dd/MM/yyyy HH:mm";
        }

        private void AlternarTela()
        {
            TabPage tempPage = hiddenPage;

            if (tbcNotificacoes.SelectedTab == tbpListagem)
            {
                tbcNotificacoes.SelectedTab = tbpCadastro;
                hiddenPage = tbpListagem;
                tbcNotificacoes.TabPages.Remove(hiddenPage);
                tbcNotificacoes.TabPages.Add(tempPage);

            }
            else if (tbcNotificacoes.SelectedTab == tbpCadastro)
            {
                tbcNotificacoes.SelectedTab = tbpListagem;
                hiddenPage = tbpCadastro;
                tbcNotificacoes.TabPages.Remove(tbpCadastro);
                tbcNotificacoes.TabPages.Add(tempPage);
            }
        }

        private void ModoCadastro()
        {
            txtId.Visible = false;
            lblId.Visible = false;
            dtpDataCadastro.Visible = false;
            lblDataEnvio.Visible = false;

            tbpCadastro.Text = "Nova Notificação";
        }

        private void ModoEdicao()
        {
            txtId.Visible = true;
            lblId.Visible = true;
            dtpDataCadastro.Visible = true;
            lblDataEnvio.Visible = true;

            txtId.Enabled = false;
            dtpDataCadastro.Enabled = false;

            tbpCadastro.Text = "Editar Notificação";
        }

        private void LimparCampos()
        {
            txtId.Clear();
            txtTitulo.Clear();
            txtMensagem.Clear();
        }

        private void CarregarClienteSelecionado(Cliente cliente)
        {
            txtId.Text = cliente.Id.ToString();
            txtTitulo.Text = cliente.NomeCompleto;
            txtMensagem.Text = cliente.Email;
        }

        private bool ValidarCampos()
        {
            if (String.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                MessageBox.Show("Nome obrigatório");
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtMensagem.Text))
            {
                MessageBox.Show("Email obrigatório");
                return false;
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

            MessageBox.Show("Notificação salva com sucesso!");
        }

        #region dgvConfigs
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
            }
        }
        #endregion
    }
}
