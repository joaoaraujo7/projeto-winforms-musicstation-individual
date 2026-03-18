using MusicStationWinFormsApp.forms;

namespace MusicStationWinFormsApp
{
    public partial class LoginForm : Form 
    {
        public LoginForm()
        {
            InitializeComponent();
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
                MessageBox.Show("Usuário ou senhas inválidos");
            }
        }
    }
}
