namespace MusicStationWinFormsApp.forms
{
    partial class FormBase
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
            flowLayoutPanel2 = new FlowLayoutPanel();
            panelLogo = new Panel();
            pcoLogo = new PictureBox();
            panel2 = new Panel();
            btnUsuarios = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            btnAdministrador = new Button();
            btnProfissional = new Button();
            btnCliente = new Button();
            btnEmpresa = new Button();
            flowLayoutPanel2.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcoLogo).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.Controls.Add(panelLogo);
            flowLayoutPanel2.Controls.Add(panel2);
            flowLayoutPanel2.Dock = DockStyle.Left;
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(200, 450);
            flowLayoutPanel2.TabIndex = 9;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(pcoLogo);
            panelLogo.Location = new Point(3, 3);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(197, 86);
            panelLogo.TabIndex = 9;
            // 
            // pcoLogo
            // 
            pcoLogo.Image = Properties.Resources.music_station_vetorizada;
            pcoLogo.Location = new Point(-3, -3);
            pcoLogo.Name = "pcoLogo";
            pcoLogo.Size = new Size(200, 89);
            pcoLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pcoLogo.TabIndex = 5;
            pcoLogo.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnEmpresa);
            panel2.Controls.Add(btnCliente);
            panel2.Controls.Add(btnProfissional);
            panel2.Controls.Add(btnAdministrador);
            panel2.Controls.Add(btnUsuarios);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(3, 95);
            panel2.Name = "panel2";
            panel2.Size = new Size(197, 146);
            panel2.TabIndex = 10;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Dock = DockStyle.Top;
            btnUsuarios.FlatAppearance.BorderColor = Color.FromArgb(28, 24, 22);
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Segoe UI", 9F);
            btnUsuarios.ForeColor = Color.Transparent;
            btnUsuarios.Location = new Point(0, 23);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Padding = new Padding(20, 0, 0, 0);
            btnUsuarios.Size = new Size(197, 23);
            btnUsuarios.TabIndex = 12;
            btnUsuarios.Text = "Usuários";
            btnUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(28, 24, 22);
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderColor = Color.FromArgb(28, 24, 22);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(197, 23);
            button1.TabIndex = 0;
            button1.Text = "Gestão de Usuários";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(144, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(200, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(600, 89);
            flowLayoutPanel1.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(200, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 361);
            panel1.TabIndex = 11;
            // 
            // btnAdministrador
            // 
            btnAdministrador.Dock = DockStyle.Top;
            btnAdministrador.FlatAppearance.BorderColor = Color.FromArgb(28, 24, 22);
            btnAdministrador.FlatAppearance.BorderSize = 0;
            btnAdministrador.FlatStyle = FlatStyle.Flat;
            btnAdministrador.Font = new Font("Segoe UI", 9F);
            btnAdministrador.ForeColor = Color.Transparent;
            btnAdministrador.Location = new Point(0, 46);
            btnAdministrador.Name = "btnAdministrador";
            btnAdministrador.Padding = new Padding(20, 0, 0, 0);
            btnAdministrador.Size = new Size(197, 23);
            btnAdministrador.TabIndex = 13;
            btnAdministrador.Text = "Administradores";
            btnAdministrador.TextAlign = ContentAlignment.MiddleLeft;
            btnAdministrador.UseVisualStyleBackColor = true;
            // 
            // btnProfissional
            // 
            btnProfissional.Dock = DockStyle.Top;
            btnProfissional.FlatAppearance.BorderColor = Color.FromArgb(28, 24, 22);
            btnProfissional.FlatAppearance.BorderSize = 0;
            btnProfissional.FlatStyle = FlatStyle.Flat;
            btnProfissional.Font = new Font("Segoe UI", 9F);
            btnProfissional.ForeColor = Color.Transparent;
            btnProfissional.Location = new Point(0, 69);
            btnProfissional.Name = "btnProfissional";
            btnProfissional.Padding = new Padding(20, 0, 0, 0);
            btnProfissional.Size = new Size(197, 23);
            btnProfissional.TabIndex = 14;
            btnProfissional.Text = "Profissionais";
            btnProfissional.TextAlign = ContentAlignment.MiddleLeft;
            btnProfissional.UseVisualStyleBackColor = true;
            // 
            // btnCliente
            // 
            btnCliente.Dock = DockStyle.Top;
            btnCliente.FlatAppearance.BorderColor = Color.FromArgb(28, 24, 22);
            btnCliente.FlatAppearance.BorderSize = 0;
            btnCliente.FlatStyle = FlatStyle.Flat;
            btnCliente.Font = new Font("Segoe UI", 9F);
            btnCliente.ForeColor = Color.Transparent;
            btnCliente.Location = new Point(0, 92);
            btnCliente.Name = "btnCliente";
            btnCliente.Padding = new Padding(20, 0, 0, 0);
            btnCliente.Size = new Size(197, 23);
            btnCliente.TabIndex = 15;
            btnCliente.Text = "Clientes";
            btnCliente.TextAlign = ContentAlignment.MiddleLeft;
            btnCliente.UseVisualStyleBackColor = true;
            // 
            // btnEmpresa
            // 
            btnEmpresa.Dock = DockStyle.Top;
            btnEmpresa.FlatAppearance.BorderColor = Color.FromArgb(28, 24, 22);
            btnEmpresa.FlatAppearance.BorderSize = 0;
            btnEmpresa.FlatStyle = FlatStyle.Flat;
            btnEmpresa.Font = new Font("Segoe UI", 9F);
            btnEmpresa.ForeColor = Color.Transparent;
            btnEmpresa.Location = new Point(0, 115);
            btnEmpresa.Name = "btnEmpresa";
            btnEmpresa.Padding = new Padding(20, 0, 0, 0);
            btnEmpresa.Size = new Size(197, 23);
            btnEmpresa.TabIndex = 16;
            btnEmpresa.Text = "Empresas";
            btnEmpresa.TextAlign = ContentAlignment.MiddleLeft;
            btnEmpresa.UseVisualStyleBackColor = true;
            // 
            // FormBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 24, 22);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(flowLayoutPanel2);
            ForeColor = SystemColors.ControlText;
            Name = "FormBase";
            Text = "TelaInicial";
            flowLayoutPanel2.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcoLogo).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelMenu;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panelLogo;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel2;
        private PictureBox pcoLogo;
        private Button button1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnUsuarios;
        private Button btnEmpresa;
        private Button btnCliente;
        private Button btnProfissional;
        private Button btnAdministrador;
    }
}