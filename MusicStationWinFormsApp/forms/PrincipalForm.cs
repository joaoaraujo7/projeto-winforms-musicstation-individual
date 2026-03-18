using MusicStationWinFormsApp.controls.usuarios;
using MusicStationWinFormsApp.models;
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
        }

        private void CustomizarDesign()
        {
            pnlUsuarios.Visible = false;
            pnlServicos.Visible = false;
            pnlOperacoes.Visible = false;
            pnlInstrumentos.Visible = false;
            pnlFinanceiro.Visible = false;
            pnlComunicacao.Visible = false;
        }

        private void HideSubMenu()
        {
            if (pnlUsuarios.Visible)
            {
                pnlUsuarios.Visible = false;
            }

            if (pnlServicos.Visible)
            {
                pnlServicos.Visible = false;
            }

            if (pnlOperacoes.Visible)
            {
                pnlOperacoes.Visible = false;
            }

            if (pnlInstrumentos.Visible)
            {
                pnlInstrumentos.Visible = false;
            }

            if (pnlFinanceiro.Visible)
            {
                pnlFinanceiro.Visible = false;
            }

            if (pnlComunicacao.Visible)
            {
                pnlComunicacao.Visible = false;
            }
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        #region UsuariosSubMenu
        private void btnUsuariosToggle_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlUsuarios);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirTela(new UsuarioControl());
            HideSubMenu();
        }

        private void btnAdministradores_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnProfissionais_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnEmpresas_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }
        #endregion

        #region ServicosSubMenu
        private void btnServicosToggle_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlServicos);
        }

        private void btnServicos_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnCargos_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }
        #endregion

        #region InstrumentosSubMenu
        private void btnInstrumentosToggle_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlInstrumentos);
        }

        private void btnInstrumentos_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }
        #endregion

        #region OperacoesSubMenu
        private void btnOperacoesToggle_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlOperacoes);
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
            ShowSubMenu(pnlFinanceiro);
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
            ShowSubMenu(pnlComunicacao);
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

        private void AbrirTela(Control tela)
        {
            pnlConteudo.Controls.Clear();
            tela.Dock = DockStyle.Fill;
            pnlConteudo.Controls.Add(tela);
        }

        private PerfilDropdownForm dropdown;
        private void btnPerfilToggle_Click(object sender, EventArgs e)
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

        #endregion

        
    }
}

