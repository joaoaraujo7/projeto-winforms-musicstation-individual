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
            lblUsuario = new Label();
            pcoLogo = new PictureBox();
            lblSenha = new Label();
            btnEntrar = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            cboLembrarDados = new CheckBox();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pcoLogo).BeginInit();
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
            // pcoLogo
            // 
            pcoLogo.Image = Properties.Resources.music_station_vetorizada;
            pcoLogo.Location = new Point(240, 69);
            pcoLogo.Name = "pcoLogo";
            pcoLogo.Size = new Size(296, 92);
            pcoLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pcoLogo.TabIndex = 4;
            pcoLogo.TabStop = false;
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
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(28, 24, 22);
            txtUsuario.Font = new Font("Segoe UI", 10F);
            txtUsuario.ForeColor = SystemColors.ControlDark;
            txtUsuario.Location = new Point(156, 207);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Digite seu usuario ou email...";
            txtUsuario.Size = new Size(463, 25);
            txtUsuario.TabIndex = 18;
            txtUsuario.Text = "joao";
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(28, 24, 22);
            txtSenha.Font = new Font("Segoe UI", 10F);
            txtSenha.ForeColor = SystemColors.ControlDark;
            txtSenha.Location = new Point(156, 269);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "DIgite sua senha...";
            txtSenha.Size = new Size(463, 25);
            txtSenha.TabIndex = 19;
            txtSenha.Text = "hash123";
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 24, 22);
            ClientSize = new Size(800, 450);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(cboLembrarDados);
            Controls.Add(btnEntrar);
            Controls.Add(lblSenha);
            Controls.Add(pcoLogo);
            Controls.Add(lblUsuario);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "TelaLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Login";
            ((System.ComponentModel.ISupportInitialize)pcoLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblUsuario;
        private PictureBox pcoLogo;
        private Label lblSenha;
        private Button btnEntrar;
        private ContextMenuStrip contextMenuStrip1;
        private CheckBox cboLembrarDados;
        private TextBox txtUsuario;
        private TextBox txtSenha;
    }
}
