using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace MusicStationWinFormsApp.forms
{
    public partial class PerfilDropdownForm : Form
    {
        public PerfilDropdownForm()
        {
            InitializeComponent();
        }

        public event Action OnAbrirPerfil;
        private void btnMeuPerfil_Click(object sender, EventArgs e)
        {
            OnAbrirPerfil?.Invoke();
            this.Close();
        }

        public event Action OnLogout;

        private void btnEncerrarSessao_Click(object sender, EventArgs e)
        {
            OnLogout?.Invoke();
            this.Close();
        }

        // Quando clicar em qualquer outro lugar, fechará esse menu
        protected override void OnDeactivate(EventArgs e)
        {
            base.OnDeactivate(e);
            this.Close();
        }
    }
}