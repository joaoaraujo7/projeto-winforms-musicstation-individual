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
    public partial class AvaliacaoControl : UserControl
    {
        // Campos
        private TabPage? hiddenPage; // guia escondida

        // Construtores
        public AvaliacaoControl()
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
            tbcAvaliacoes.TabPages.Remove(hiddenPage);
            this.DoubleBuffered = true;
            dgvDados.ReadOnly = true;
            dtpDataAvaliacao.CustomFormat = "dd/MM/yyyy HH:mm";
        }

        private void AlternarTela()
        {
            TabPage tempPage = hiddenPage;

            if (tbcAvaliacoes.SelectedTab == tbpListagem)
            {
                tbcAvaliacoes.SelectedTab = tbpCadastro;
                hiddenPage = tbpListagem;
                tbcAvaliacoes.TabPages.Remove(hiddenPage);
                tbcAvaliacoes.TabPages.Add(tempPage);

            }
            else if (tbcAvaliacoes.SelectedTab == tbpCadastro)
            {
                tbcAvaliacoes.SelectedTab = tbpListagem;
                hiddenPage = tbpCadastro;
                tbcAvaliacoes.TabPages.Remove(tbpCadastro);
                tbcAvaliacoes.TabPages.Add(tempPage);
            }
        }

        private void ModoCadastro()
        {
            txtId.Visible = false;
            lblId.Visible = false;
            dtpDataAvaliacao.Visible = false;
            lblDataAvaliacoa.Visible = false;

            tbpCadastro.Text = "Nova Avaliação";
        }

        private void ModoEdicao()
        {
            txtId.Visible = true;
            lblId.Visible = true;
            dtpDataAvaliacao.Visible = true;
            lblDataAvaliacoa.Visible = true;

            txtId.Enabled = false;
            dtpDataAvaliacao.Enabled = false;

            tbpCadastro.Text = "Editar Avaliação";
        }

        private void LimparCampos()
        {
            txtId.Clear();
            txtNota.Clear();
            txtEmail.Clear();
        }

        private void CarregarAvaliacaoSelecionado(Cliente cliente)
        {
            txtId.Text = cliente.Id.ToString();
            txtNota.Text = cliente.NomeCompleto;
            txtEmail.Text = cliente.Email;
            
        }

        private bool ValidarCampos()
        {
            if (String.IsNullOrWhiteSpace(txtNota.Text))
            {
                MessageBox.Show("Nome obrigatório");
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtEmail.Text))
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

            MessageBox.Show("Avaliação salva com sucesso!");
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
