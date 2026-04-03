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
    public partial class TransacaoControl : UserControl
    {
        // Campos
        private TabPage? hiddenPage; // guia escondida

        // Construtores
        public TransacaoControl()
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
            tbcTransacoes.TabPages.Remove(hiddenPage);
            this.DoubleBuffered = true;
            dgvDados.ReadOnly = true;
            dtpDataTransacao.CustomFormat = "dd/MM/yyyy HH:mm";
        }

        private void AlternarTela()
        {
            TabPage tempPage = hiddenPage;

            if (tbcTransacoes.SelectedTab == tbpListagem)
            {
                tbcTransacoes.SelectedTab = tbpCadastro;
                hiddenPage = tbpListagem;
                tbcTransacoes.TabPages.Remove(hiddenPage);
                tbcTransacoes.TabPages.Add(tempPage);

            }
            else if (tbcTransacoes.SelectedTab == tbpCadastro)
            {
                tbcTransacoes.SelectedTab = tbpListagem;
                hiddenPage = tbpCadastro;
                tbcTransacoes.TabPages.Remove(tbpCadastro);
                tbcTransacoes.TabPages.Add(tempPage);
            }
        }

        private void ModoCadastro()
        {
            txtId.Visible = false;
            lblId.Visible = false;
            dtpDataTransacao.Visible = false;
            lblDataTransacao.Visible = false;

            tbpCadastro.Text = "Nova Transação";
        }

        private void ModoEdicao()
        {
            txtId.Visible = true;
            lblId.Visible = true;
            dtpDataTransacao.Visible = true;
            lblDataTransacao.Visible = true;

            txtId.Enabled = false;
            dtpDataTransacao.Enabled = false;

            tbpCadastro.Text = "Editar Transação";
        }

        private void LimparCampos()
        {
            txtId.Clear();
            
        }

        private void CarregarClienteSelecionado(Cliente cliente)
        {
            txtId.Text = cliente.Id.ToString();
        }

        private bool ValidarCampos()
        {
            
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

            MessageBox.Show("Transação salva com sucesso!");
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
