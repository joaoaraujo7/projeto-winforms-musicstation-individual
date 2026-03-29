namespace MusicStationWinFormsApp
{
    partial class LoginForm
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
            lblUsuario = new Label();
            pcoLogo = new PictureBox();
            lblSenha = new Label();
            btnEntrar = new Button();
            cboLembrarDados = new CheckBox();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pnlUsuario = new Panel();
            pnlSenha = new Panel();
            ((System.ComponentModel.ISupportInitialize)pcoLogo).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            pnlUsuario.SuspendLayout();
            pnlSenha.SuspendLayout();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10F);
            lblUsuario.ForeColor = Color.Gainsboro;
            lblUsuario.Location = new Point(0, 0);
            lblUsuario.Margin = new Padding(0);
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
            lblSenha.ForeColor = Color.Gainsboro;
            lblSenha.Location = new Point(0, 72);
            lblSenha.Margin = new Padding(0);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(46, 19);
            lblSenha.TabIndex = 8;
            lblSenha.Text = "Senha";
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(95, 97, 231);
            btnEntrar.FlatStyle = FlatStyle.Popup;
            btnEntrar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnEntrar.ForeColor = Color.Transparent;
            btnEntrar.Location = new Point(3, 176);
            btnEntrar.Margin = new Padding(3, 5, 3, 3);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(471, 40);
            btnEntrar.TabIndex = 9;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // cboLembrarDados
            // 
            cboLembrarDados.AutoSize = true;
            cboLembrarDados.FlatStyle = FlatStyle.Flat;
            cboLembrarDados.Font = new Font("Segoe UI", 10F);
            cboLembrarDados.ForeColor = Color.Transparent;
            cboLembrarDados.Location = new Point(3, 140);
            cboLembrarDados.Name = "cboLembrarDados";
            cboLembrarDados.Padding = new Padding(0, 5, 0, 0);
            cboLembrarDados.Size = new Size(101, 28);
            cboLembrarDados.TabIndex = 17;
            cboLembrarDados.Text = "Lembrar-me";
            cboLembrarDados.UseVisualStyleBackColor = true;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(28, 24, 22);
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Dock = DockStyle.Fill;
            txtUsuario.Font = new Font("Segoe UI", 10F);
            txtUsuario.ForeColor = Color.Gray;
            txtUsuario.Location = new Point(12, 10);
            txtUsuario.Margin = new Padding(0);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Digite seu usuario ou email...";
            txtUsuario.Size = new Size(447, 20);
            txtUsuario.TabIndex = 18;
            txtUsuario.Enter += txtUsuario_Enter;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(28, 24, 22);
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Dock = DockStyle.Fill;
            txtSenha.Font = new Font("Segoe UI", 10F);
            txtSenha.ForeColor = Color.Gray;
            txtSenha.Location = new Point(12, 10);
            txtSenha.Margin = new Padding(0);
            txtSenha.Multiline = true;
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Digite sua senha...";
            txtSenha.Size = new Size(447, 20);
            txtSenha.TabIndex = 19;
            txtSenha.UseSystemPasswordChar = true;
            txtSenha.Enter += txtSenha_Enter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(lblUsuario);
            flowLayoutPanel1.Controls.Add(pnlUsuario);
            flowLayoutPanel1.Controls.Add(lblSenha);
            flowLayoutPanel1.Controls.Add(pnlSenha);
            flowLayoutPanel1.Controls.Add(cboLembrarDados);
            flowLayoutPanel1.Controls.Add(btnEntrar);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(148, 182);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(485, 226);
            flowLayoutPanel1.TabIndex = 20;
            // 
            // pnlUsuario
            // 
            pnlUsuario.BackColor = Color.FromArgb(28, 24, 22);
            pnlUsuario.Controls.Add(txtUsuario);
            pnlUsuario.Location = new Point(3, 22);
            pnlUsuario.Margin = new Padding(3, 3, 3, 10);
            pnlUsuario.Name = "pnlUsuario";
            pnlUsuario.Padding = new Padding(12, 10, 12, 10);
            pnlUsuario.Size = new Size(471, 40);
            pnlUsuario.TabIndex = 21;
            pnlUsuario.Paint += pnlUsuario_Paint;
            // 
            // pnlSenha
            // 
            pnlSenha.BackColor = Color.FromArgb(28, 24, 22);
            pnlSenha.Controls.Add(txtSenha);
            pnlSenha.Location = new Point(3, 94);
            pnlSenha.Name = "pnlSenha";
            pnlSenha.Padding = new Padding(12, 10, 12, 10);
            pnlSenha.Size = new Size(471, 40);
            pnlSenha.TabIndex = 22;
            pnlSenha.Paint += pnlSenha_Paint;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 24, 22);
            ClientSize = new Size(800, 450);
            Controls.Add(pcoLogo);
            Controls.Add(flowLayoutPanel1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Login";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pcoLogo).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            pnlUsuario.ResumeLayout(false);
            pnlUsuario.PerformLayout();
            pnlSenha.ResumeLayout(false);
            pnlSenha.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblUsuario;
        private PictureBox pcoLogo;
        private Label lblSenha;
        private Button btnEntrar;
        private CheckBox cboLembrarDados;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel pnlSenha;
        private Panel pnlUsuario;
    }
}
