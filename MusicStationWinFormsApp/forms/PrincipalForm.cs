using MusicStationWinFormsApp.controls.cargos;
using MusicStationWinFormsApp.controls.dashboard;
using MusicStationWinFormsApp.controls.servicos;
using MusicStationWinFormsApp.controls.usuarios;
using MusicStationWinFormsApp.models;
using MusicStationWinFormsApp.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MusicStationWinFormsApp.forms
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
            CustomizarDesign();
            this.DoubleBuffered = true;

            // tela principal
            lblTitulo.Text = "Dashboard";
            AbrirTela(new DashboardControl());
        }

        private void CustomizarDesign()
        {
            pnlUsuarios.Visible = false;
            pnlServicos.Visible = false;
            pnlOperacoes.Visible = false;
            pnlInstrumentos.Visible = false;
            pnlFinanceiro.Visible = false;
            pnlComunicacao.Visible = false;

            this.ActiveControl = lblTitulo;
        }

        private void HideSubMenu()
        {
            pnlUsuarios.Visible = false;
            pnlServicos.Visible = false;
            pnlOperacoes.Visible = false;
            pnlInstrumentos.Visible = false;
            pnlFinanceiro.Visible = false;
            pnlComunicacao.Visible = false;

            // RESETAR TODAS AS SETAS
            btnUsuariosToggle.Image = Properties.Resources.seta_direita;
            btnServicosToggle.Image = Properties.Resources.seta_direita;
            btnOperacoesToggle.Image = Properties.Resources.seta_direita;
            btnInstrumentosToggle.Image = Properties.Resources.seta_direita;
            btnFinanceiroToggle.Image = Properties.Resources.seta_direita;
            btnComunicacaoToggle.Image = Properties.Resources.seta_direita;
        }

        private void ToggleMenu(Panel panel, Button button)
        {
            bool abrir = !panel.Visible;

            HideSubMenu();

            panel.Visible = abrir;
            button.Image = abrir
                ? Properties.Resources.seta_baixo
                : Properties.Resources.seta_direita;
        }

        private void AbrirTela(Control tela)
        {
            pnlConteudo.SuspendLayout();
            pnlConteudo.Controls.Clear();

            if (!pnlConteudo.Controls.Contains(tela))
            {
                tela.Dock = DockStyle.Fill;
                pnlConteudo.Controls.Add(tela);
            }

            tela.BringToFront();
            pnlConteudo.ResumeLayout();
        }

        #region dashboardSubMenu
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            AbrirTela(new DashboardControl());

            lblTitulo.Text = "Dashboard";
            HideSubMenu();
        }

        #endregion

        #region UsuariosSubMenu
        private void btnUsuariosToggle_Click(object sender, EventArgs e)
        {
            ToggleMenu(pnlUsuarios, btnUsuariosToggle);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirTela(new UsuarioControl());

            lblTitulo.Text = "Gestão de Usuários";
            HideSubMenu();
        }

        private void btnAdministradores_Click(object sender, EventArgs e)
        {
            AbrirTela(new AdministradorControl());

            lblTitulo.Text = "Gestão de Administradores";
            HideSubMenu();
        }

        private void btnProfissionais_Click(object sender, EventArgs e)
        {
            AbrirTela(new ProfissionalControl());

            lblTitulo.Text = "Gestão de Profissionais";
            HideSubMenu();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirTela(new ClienteControl());

            lblTitulo.Text = "Gestão de Clientes";
            HideSubMenu();
        }

        private void btnEmpresas_Click(object sender, EventArgs e)
        {
            AbrirTela(new EmpresaControl());

            lblTitulo.Text = "Gestão de Empresas";
            HideSubMenu();
        }
        #endregion

        #region ServicosSubMenu
        private void btnServicosToggle_Click(object sender, EventArgs e)
        {
            ToggleMenu(pnlServicos, btnServicosToggle);
        }

        private void btnServicos_Click(object sender, EventArgs e)
        {
            AbrirTela(new ServicoControl());

            lblTitulo.Text = "Gestão de Serviços";
            HideSubMenu();
        }

        private void btnCargos_Click(object sender, EventArgs e)
        {
            AbrirTela(new CargoControl());

            lblTitulo.Text = "Gestão de Cargos";
            HideSubMenu();
        }
        #endregion

        #region InstrumentosSubMenu
        private void btnInstrumentosToggle_Click(object sender, EventArgs e)
        {
            ToggleMenu(pnlInstrumentos, btnInstrumentosToggle);
        }

        private void btnInstrumentos_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }
        #endregion

        #region OperacoesSubMenu
        private void btnOperacoesToggle_Click(object sender, EventArgs e)
        {
            ToggleMenu(pnlOperacoes, btnOperacoesToggle);
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnLocacoes_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }
        #endregion

        #region FinanceiroSubMenu
        private void btnFinanceiroToggle_Click(object sender, EventArgs e)
        {
            ToggleMenu(pnlFinanceiro, btnFinanceiroToggle);
        }

        private void btnPagamentos_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnTransacoes_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnFormasPagamento_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }
        #endregion

        #region ComunicacaoSubMenu
        private void btnComunicacaoToggle_Click(object sender, EventArgs e)
        {
            ToggleMenu(pnlComunicacao, btnComunicacaoToggle);
        }

        private void btnChats_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnNotificacoes_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnAvaliacoes_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }
        #endregion

        #region PerfilSubmenu

        private PerfilDropdownForm dropdown;
        private void btnPerfilToggle_Click(object sender, EventArgs e)
        {
            if (dropdown == null || dropdown.IsDisposed)
            {
                dropdown = new PerfilDropdownForm();

                dropdown.OnAbrirPerfil += () =>
                {
                    AbrirTela(new PerfilControl());
                };

                dropdown.OnLogout += () =>
                {
                    this.Hide();
                    new LoginForm().Show();
                };

                Point pos = btnPerfilToggle.PointToScreen(Point.Empty);

                dropdown.Location = new Point(
                    pos.X + btnPerfilToggle.Width - dropdown.Width,
                    pos.Y + btnPerfilToggle.Height
                );

                dropdown.Show();
            }
            else
            {
                dropdown.Close();
            }
        }

        private void btnPerfilToggle_Enter(object sender, EventArgs e)
        {
            lblTitulo.Focus();
        }

        #endregion

    }
}

