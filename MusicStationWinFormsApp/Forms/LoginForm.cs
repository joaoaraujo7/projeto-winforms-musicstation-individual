using MusicStationWinFormsApp.forms;
using System.Drawing.Drawing2D;

namespace MusicStationWinFormsApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Preencha usuário e senha.");
                return;
            }

            // validação de usuário e senha

            if (txtUsuario.Text == "joao" && txtSenha.Text == "hash123")
            {
                PrincipalForm tela = new PrincipalForm();
                tela.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senhas inválidos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Configurando borda personalizada no pnlUsuario e pnlSenha
        public void CustomizarPainel(object sender, PaintEventArgs e)
        {
            Control paintControl = (Control)sender;
            Color corBorda = Color.FromArgb(95, 97, 231);
            int espessura = 2; // Espessura da borda

            // Desenha a borda manual
            using (Pen pen = new Pen(corBorda, espessura))
            {
                // Ajuste para a borda não ser cortada
                e.Graphics.DrawRectangle(pen, 0, 0, paintControl.Width - 1, paintControl.Height - 1);
            }
        }

        private void pnlUsuario_Paint(object sender, PaintEventArgs e)
        {
            CustomizarPainel(sender, e);
        }

        private void pnlSenha_Paint(object sender, PaintEventArgs e)
        {
            CustomizarPainel(sender, e);
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            txtUsuario.PlaceholderText = null;
            txtUsuario.Text = "joao";
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            txtSenha.PlaceholderText = null;
            txtSenha.Text = "hash123";
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
