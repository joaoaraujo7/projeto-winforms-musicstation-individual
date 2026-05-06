namespace MusicStationWinFormsApp.forms
{
    partial class PerfilDropdownForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlPerfilMenu = new Panel();
            btnEncerrarSessao = new Button();
            btnMeuPerfil = new Button();
            pnlPerfilMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPerfilMenu
            // 
            pnlPerfilMenu.BackColor = Color.FromArgb(32, 28, 26);
            pnlPerfilMenu.Controls.Add(btnEncerrarSessao);
            pnlPerfilMenu.Controls.Add(btnMeuPerfil);
            pnlPerfilMenu.Dock = DockStyle.Fill;
            pnlPerfilMenu.Location = new Point(0, 0);
            pnlPerfilMenu.Name = "pnlPerfilMenu";
            pnlPerfilMenu.Size = new Size(148, 84);
            pnlPerfilMenu.TabIndex = 1;
            // 
            // btnEncerrarSessao
            // 
            btnEncerrarSessao.Dock = DockStyle.Top;
            btnEncerrarSessao.FlatAppearance.BorderSize = 0;
            btnEncerrarSessao.FlatStyle = FlatStyle.Flat;
            btnEncerrarSessao.Font = new Font("Segoe UI", 10F);
            btnEncerrarSessao.ForeColor = Color.Gainsboro;
            btnEncerrarSessao.Location = new Point(0, 38);
            btnEncerrarSessao.Name = "btnEncerrarSessao";
            btnEncerrarSessao.Padding = new Padding(8, 0, 16, 0);
            btnEncerrarSessao.Size = new Size(148, 38);
            btnEncerrarSessao.TabIndex = 2;
            btnEncerrarSessao.Text = "Encerrar Sessão";
            btnEncerrarSessao.TextAlign = ContentAlignment.MiddleLeft;
            btnEncerrarSessao.UseVisualStyleBackColor = true;
            btnEncerrarSessao.Click += btnEncerrarSessao_Click;
            // 
            // btnMeuPerfil
            // 
            btnMeuPerfil.Dock = DockStyle.Top;
            btnMeuPerfil.FlatAppearance.BorderSize = 0;
            btnMeuPerfil.FlatStyle = FlatStyle.Flat;
            btnMeuPerfil.Font = new Font("Segoe UI", 10F);
            btnMeuPerfil.ForeColor = Color.Gainsboro;
            btnMeuPerfil.Location = new Point(0, 0);
            btnMeuPerfil.Name = "btnMeuPerfil";
            btnMeuPerfil.Padding = new Padding(8, 0, 16, 0);
            btnMeuPerfil.Size = new Size(148, 38);
            btnMeuPerfil.TabIndex = 1;
            btnMeuPerfil.Text = "Meu Perfil";
            btnMeuPerfil.TextAlign = ContentAlignment.MiddleLeft;
            btnMeuPerfil.UseVisualStyleBackColor = true;
            btnMeuPerfil.Click += btnMeuPerfil_Click;
            // 
            // FormPerfilDropdown
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(148, 84);
            Controls.Add(pnlPerfilMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPerfilDropdown";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "FormPerfilDropdown";
            TopMost = true;
            pnlPerfilMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPerfilMenu;
        private Button btnEncerrarSessao;
        private Button btnMeuPerfil;
    }
}