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

namespace MusicStationWinFormsApp.controls.operacao
{
    public partial class LocacaoControl : UserControl
    {
        // Campos
        private TabPage? hiddenPage; // guia escondida

        // Construtores
        public LocacaoControl()
        {
            InitializeComponent();
            ConfigurarVisual();

            dgvDados.AutoGenerateColumns = false;

            dgvDados.Rows.Add();
            dgvDados.Rows.Add();
            dgvDados.Rows.Add();

            dgvItensLocacao.ReadOnly = false;
        }

        // Métodos
        private void ConfigurarVisual()
        {
            hiddenPage = tbpCadastro;
            tbcLocacoes.TabPages.Remove(hiddenPage);
            this.DoubleBuffered = true;
            dgvDados.ReadOnly = true;
            dtpDataInicio.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpDataDevolucao.CustomFormat = "dd/MM/yyyy HH:mm";
        }

        private void AlternarTela()
        {
            TabPage tempPage = hiddenPage;

            if (tbcLocacoes.SelectedTab == tbpListagem)
            {
                tbcLocacoes.SelectedTab = tbpCadastro;
                hiddenPage = tbpListagem;
                tbcLocacoes.TabPages.Remove(hiddenPage);
                tbcLocacoes.TabPages.Add(tempPage);

            }
            else if (tbcLocacoes.SelectedTab == tbpCadastro)
            {
                tbcLocacoes.SelectedTab = tbpListagem;
                hiddenPage = tbpCadastro;
                tbcLocacoes.TabPages.Remove(tbpCadastro);
                tbcLocacoes.TabPages.Add(tempPage);
            }
        }

        private void ModoCadastro()
        {
            txtId.Visible = false;
            lblId.Visible = false;

            txtTotal.Enabled = false;

            tbpCadastro.Text = "Nova Locação";
        }

        private void ModoEdicao()
        {
            txtId.Visible = true;
            lblId.Visible = true;
            dtpDataDevolucao.Visible = true;
            lblDataDevolucao.Visible = true;

            txtId.Enabled = false;
            txtTotal.Enabled = false;

            tbpCadastro.Text = "Editar Locação";
        }

        private void LimparCampos()
        {
            txtId.Clear();
            cboInstrumento.SelectedIndex = -1;
            cboStatus.SelectedIndex = -1;
            dgvItensLocacao.Rows.Clear();
            txtTotal.Clear();
        }

        private void CarregarPedidoSelecionado(Locacao locacao)
        {
            txtId.Text = locacao.Id.ToString();
            cboInstrumento.SelectedValue = locacao.ClienteNome;
            dgvItensLocacao.DataSource = locacao.ItensLocacao;

            dtpDataDevolucao.Value = locacao.DataDevolucao;
            txtTotal.Text = locacao.Total.ToString();
        }

        private bool ValidarCampos()
        {
            if (cboInstrumento.SelectedItem == null)
            {
                MessageBox.Show("Cliente obrigatório");
                return false;
            }

            if (cboStatus.SelectedItem == null)
            {
                MessageBox.Show("Status obrigatório");
                return false;
            }

            if (dgvItensLocacao.RowCount < 1)
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
            MessageBox.Show("Locação salva com sucesso!");
        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            dgvItensLocacao.Rows.Add();
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

        #region dgvItensLocacao
        private void dgvItensLocacao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return; // verifica se o clique foi em uma linha / coluna válida e não no cabeçalho

            string nomeColuna = dgvItensLocacao.Columns[e.ColumnIndex].Name;
            // Configuração do botão de edição
            if (nomeColuna == "imgExcluir2")
            {
                DialogResult result = MessageBox.Show("Deseja realmente excluir este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    dgvItensLocacao.Rows.RemoveAt(e.RowIndex);
                }
            }
        }
        #endregion
    }
}
