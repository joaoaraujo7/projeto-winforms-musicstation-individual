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
    public partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panelFinanceiro.Height > 50)
            {
                panelFinanceiro.Height = 45; // Fecha
            }
            else
            {
                panelFinanceiro.Height = 150; // Abre
            }
        }
    }
}
