using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicStationWinFormsApp.forms
{
    public partial class PerfilControl : UserControl
    {
        public PerfilControl()
        {
            InitializeComponent();
            ConfigurarDados();
        }

        private void ConfigurarDados()
        {
            dtpDataCadastro.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpDataCadastro.Enabled = false;
            txtNomeCompleto.Enabled = false;
            txtEmail.Enabled = false;
            txtNivelAcesso.Enabled = false;
            txtObservacoes.Enabled = false;
            txtNomeUsuario.Enabled = false;
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

            if (String.IsNullOrWhiteSpace(txtNivelAcesso.Text))
            {
                MessageBox.Show("Nível de acesso obrigatório");
                return false;
            }

            return true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            MessageBox.Show("Alterações salvas com sucesso!");
        }
    }
}
