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

namespace MusicStationWinFormsApp.controls.financeiro
{
    public partial class PagamentoControl : UserControl
    {
        // Campos
        private TabPage? hiddenPage; // guia escondida

        // Construtores
        public PagamentoControl()
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
            tbcPagamentos.TabPages.Remove(hiddenPage);
            this.DoubleBuffered = true;
            dgvDados.ReadOnly = true;
            dtpDataPagamento.CustomFormat = "dd/MM/yyyy HH:mm";
        }

        private void AlternarTela()
        {
            TabPage tempPage = hiddenPage;

            if (tbcPagamentos.SelectedTab == tbpListagem)
            {
                tbcPagamentos.SelectedTab = tbpCadastro;
                hiddenPage = tbpListagem;
                tbcPagamentos.TabPages.Remove(hiddenPage);
                tbcPagamentos.TabPages.Add(tempPage);

            }
            else if (tbcPagamentos.SelectedTab == tbpCadastro)
            {
                tbcPagamentos.SelectedTab = tbpListagem;
                hiddenPage = tbpCadastro;
                tbcPagamentos.TabPages.Remove(tbpCadastro);
                tbcPagamentos.TabPages.Add(tempPage);
            }
        }

        private void ModoCadastro()
        {
            txtId.Visible = false;
            lblId.Visible = false;
            dtpDataPagamento.Visible = false;
            lblDataPagamento.Visible = false;

            tbpCadastro.Text = "Novo Pagamento";
        }

        private void ModoEdicao()
        {
            txtId.Visible = true;
            lblId.Visible = true;
            dtpDataPagamento.Visible = true;
            lblDataPagamento.Visible = true;

            txtId.Enabled = false;
            dtpDataPagamento.Enabled = false;

            tbpCadastro.Text = "Editar Pagamento";
        }

        private void LimparCampos()
        {
            txtId.Clear();
            txtValorPagamento.Clear();
        }

        private void CarregarClienteSelecionado(Cliente cliente)
        {
            txtId.Text = cliente.Id.ToString();
            txtValorPagamento.Text = cliente.NomeCompleto;
        }

        private bool ValidarCampos()
        {
            if (String.IsNullOrWhiteSpace(txtValorPagamento.Text))
            {
                MessageBox.Show("Nome obrigatório");
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

            MessageBox.Show("Pagamento salvo com sucesso!");
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
