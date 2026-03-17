namespace MusicStationWinFormsApp
{
    partial class TelaLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblUsuario = new Label();
            pictureBox1 = new PictureBox();
            lblSenha = new Label();
            btnEntrar = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            txtSenha = new Guna.UI2.WinForms.Guna2TextBox();
            cboLembrarDados = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10F);
            lblUsuario.ForeColor = Color.FromArgb(174, 173, 172);
            lblUsuario.Location = new Point(156, 182);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(56, 19);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuario";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.music_station_vetorizada;
            pictureBox1.Location = new Point(240, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 10F);
            lblSenha.ForeColor = Color.FromArgb(174, 173, 172);
            lblSenha.Location = new Point(156, 247);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(46, 19);
            lblSenha.TabIndex = 8;
            lblSenha.Text = "Senha";
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(95, 97, 231);
            btnEntrar.FlatStyle = FlatStyle.Popup;
            btnEntrar.Font = new Font("Segoe UI", 10F);
            btnEntrar.ForeColor = Color.Transparent;
            btnEntrar.Location = new Point(156, 339);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(463, 28);
            btnEntrar.TabIndex = 9;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtUsuario
            // 
            txtUsuario.BorderColor = Color.FromArgb(95, 97, 231);
            txtUsuario.BorderRadius = 3;
            txtUsuario.CustomizableEdges = customizableEdges5;
            txtUsuario.DefaultText = "";
            txtUsuario.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUsuario.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUsuario.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUsuario.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUsuario.FillColor = Color.FromArgb(28, 24, 22);
            txtUsuario.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsuario.Font = new Font("Segoe UI", 9.5F);
            txtUsuario.ForeColor = Color.FromArgb(89, 89, 89);
            txtUsuario.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsuario.Location = new Point(156, 204);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderForeColor = Color.FromArgb(116, 116, 116);
            txtUsuario.PlaceholderText = "Digite seu usuário ou email...";
            txtUsuario.SelectedText = "";
            txtUsuario.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtUsuario.Size = new Size(463, 26);
            txtUsuario.TabIndex = 13;
            // 
            // txtSenha
            // 
            txtSenha.BorderColor = Color.FromArgb(95, 97, 231);
            txtSenha.BorderRadius = 3;
            txtSenha.CustomizableEdges = customizableEdges7;
            txtSenha.DefaultText = "";
            txtSenha.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSenha.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSenha.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSenha.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSenha.FillColor = Color.FromArgb(28, 24, 22);
            txtSenha.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSenha.Font = new Font("Segoe UI", 9.5F);
            txtSenha.ForeColor = Color.FromArgb(89, 89, 89);
            txtSenha.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSenha.Location = new Point(156, 269);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderForeColor = Color.FromArgb(116, 116, 116);
            txtSenha.PlaceholderText = "Digite sua senha...";
            txtSenha.SelectedText = "";
            txtSenha.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtSenha.Size = new Size(463, 26);
            txtSenha.TabIndex = 14;
            // 
            // cboLembrarDados
            // 
            cboLembrarDados.AutoSize = true;
            cboLembrarDados.Font = new Font("Segoe UI", 10F);
            cboLembrarDados.ForeColor = Color.Transparent;
            cboLembrarDados.Location = new Point(156, 310);
            cboLembrarDados.Name = "cboLembrarDados";
            cboLembrarDados.Size = new Size(104, 23);
            cboLembrarDados.TabIndex = 17;
            cboLembrarDados.Text = "Lembrar-me";
            cboLembrarDados.UseVisualStyleBackColor = true;
            cboLembrarDados.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 24, 22);
            ClientSize = new Size(800, 450);
            Controls.Add(cboLembrarDados);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(btnEntrar);
            Controls.Add(lblSenha);
            Controls.Add(pictureBox1);
            Controls.Add(lblUsuario);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "TelaLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblUsuario;
        private PictureBox pictureBox1;
        private Label lblSenha;
        private Button btnEntrar;
        private ContextMenuStrip contextMenuStrip1;
        private Guna.UI2.WinForms.Guna2TextBox txtUsuario;
        private Guna.UI2.WinForms.Guna2TextBox txtSenha;
        private CheckBox cboLembrarDados;
    }
}
