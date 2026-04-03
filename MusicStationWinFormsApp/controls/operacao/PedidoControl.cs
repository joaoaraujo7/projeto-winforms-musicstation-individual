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

namespace MusicStationWinFormsApp.controls.operacao
{
    public partial class PedidoControl : UserControl
    {
        // Campos
        private TabPage? hiddenPage; // guia escondida

        // Construtores
        public PedidoControl()
        {
            InitializeComponent();
            ConfigurarVisual();

            dgvDados.AutoGenerateColumns = false;

            dgvDados.Rows.Add();
            dgvDados.Rows.Add();
            dgvDados.Rows.Add();

            dgvItensPedido.ReadOnly = false;
        }

        // Métodos
        private void ConfigurarVisual()
        {
            hiddenPage = tbpCadastro;
            tbcPedidos.TabPages.Remove(hiddenPage);
            this.DoubleBuffered = true;
            dgvDados.ReadOnly = true;
            dtpDataPedido.CustomFormat = "dd/MM/yyyy HH:mm";
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
            dtpDataPedido.Visible = false;
            lblDataPedido.Visible = false;
            txtTotal.Enabled = false;

            tbpCadastro.Text = "Novo Pedido";
        }

        private void ModoEdicao()
        {
            txtId.Visible = true;
            lblId.Visible = true;
            dtpDataPedido.Visible = true;
            lblDataPedido.Visible = true;

            txtId.Enabled = false;
            dtpDataPedido.Enabled = false;
            txtTotal.Enabled = false;

            tbpCadastro.Text = "Editar Pedido";
        }

        private void LimparCampos()
        {
            txtId.Clear();
            cboCliente.SelectedIndex = -1;
            cboStatus.SelectedIndex = -1;
            dgvItensPedido.Rows.Clear();
            txtTotal.Clear();
        }

        private void CarregarPedidoSelecionado(Pedido pedido)
        {
            txtId.Text = pedido.Id.ToString();
            cboCliente.SelectedValue = pedido.ClienteNome;
            dgvItensPedido.DataSource = pedido.ItensPedido;

            dtpDataPedido.Value = pedido.DataPedido;
            txtTotal.Text = pedido.Total.ToString();
        }

        private bool ValidarCampos()
        {
            if (cboCliente.SelectedItem == null)
            {
                MessageBox.Show("Cliente obrigatório");
                return false;
            }

            if (cboStatus.SelectedItem == null)
            {
                MessageBox.Show("Status obrigatório");
                return false;
            }

            if (dgvItensPedido.RowCount < 1)
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
            MessageBox.Show("Pedido salvo com sucesso!");
        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            dgvItensPedido.Rows.Add();
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

            string nomeColuna = dgvItensPedido.Columns[e.ColumnIndex].Name;
            // Configuração do botão de edição
            if (nomeColuna == "imgExcluir2")
            {
                DialogResult result = MessageBox.Show("Deseja realmente excluir este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
                if (result == DialogResult.Yes)
                {
                    dgvItensPedido.Rows.RemoveAt(e.RowIndex);
                }
            }
        }
        #endregion
    }
}
