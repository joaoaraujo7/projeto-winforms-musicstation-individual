namespace MusicStationWinFormsApp.forms
{
    partial class PerfilControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            tlpCadastro = new TableLayoutPanel();
            txtSenhaConfirmada = new TextBox();
            lblSenhaConfirmada = new Label();
            txtObservacoes = new TextBox();
            lblObservacoes = new Label();
            txtNivelAcesso = new TextBox();
            lblNivelAcesso = new Label();
            lblDataCadastro = new Label();
            txtEmail = new TextBox();
            txtNomeUsuario = new TextBox();
            txtNovaSenha = new TextBox();
            lblNome = new Label();
            txtNomeCompleto = new TextBox();
            lblNovaSenha = new Label();
            lblEmail = new Label();
            lblUsuario = new Label();
            dtpDataCadastro = new DateTimePicker();
            flowButtons = new FlowLayoutPanel();
            btnSalvar = new Button();
            tlpCadastro.SuspendLayout();
            flowButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tlpCadastro
            // 
            tlpCadastro.BackColor = SystemColors.Control;
            tlpCadastro.ColumnCount = 2;
            tlpCadastro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.91496F));
            tlpCadastro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.08504F));
            tlpCadastro.Controls.Add(txtSenhaConfirmada, 1, 5);
            tlpCadastro.Controls.Add(lblSenhaConfirmada, 0, 5);
            tlpCadastro.Controls.Add(txtObservacoes, 1, 7);
            tlpCadastro.Controls.Add(lblObservacoes, 0, 7);
            tlpCadastro.Controls.Add(txtNivelAcesso, 1, 6);
            tlpCadastro.Controls.Add(lblNivelAcesso, 0, 6);
            tlpCadastro.Controls.Add(lblDataCadastro, 0, 10);
            tlpCadastro.Controls.Add(txtEmail, 1, 2);
            tlpCadastro.Controls.Add(txtNomeUsuario, 1, 3);
            tlpCadastro.Controls.Add(txtNovaSenha, 1, 4);
            tlpCadastro.Controls.Add(lblNome, 0, 1);
            tlpCadastro.Controls.Add(txtNomeCompleto, 1, 1);
            tlpCadastro.Controls.Add(lblNovaSenha, 0, 4);
            tlpCadastro.Controls.Add(lblEmail, 0, 2);
            tlpCadastro.Controls.Add(lblUsuario, 0, 3);
            tlpCadastro.Controls.Add(dtpDataCadastro, 1, 10);
            tlpCadastro.Controls.Add(flowButtons, 1, 11);
            tlpCadastro.Dock = DockStyle.Fill;
            tlpCadastro.Location = new Point(0, 0);
            tlpCadastro.Name = "tlpCadastro";
            tlpCadastro.Padding = new Padding(24, 24, 24, 0);
            tlpCadastro.RowCount = 12;
            tlpCadastro.RowStyles.Add(new RowStyle());
            tlpCadastro.RowStyles.Add(new RowStyle());
            tlpCadastro.RowStyles.Add(new RowStyle());
            tlpCadastro.RowStyles.Add(new RowStyle());
            tlpCadastro.RowStyles.Add(new RowStyle());
            tlpCadastro.RowStyles.Add(new RowStyle());
            tlpCadastro.RowStyles.Add(new RowStyle());
            tlpCadastro.RowStyles.Add(new RowStyle());
            tlpCadastro.RowStyles.Add(new RowStyle());
            tlpCadastro.RowStyles.Add(new RowStyle());
            tlpCadastro.RowStyles.Add(new RowStyle());
            tlpCadastro.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCadastro.Size = new Size(748, 511);
            tlpCadastro.TabIndex = 16;
            // 
            // txtSenhaConfirmada
            // 
            txtSenhaConfirmada.Dock = DockStyle.Fill;
            txtSenhaConfirmada.Font = new Font("Segoe UI", 10F);
            txtSenhaConfirmada.Location = new Point(159, 179);
            txtSenhaConfirmada.Margin = new Padding(3, 3, 3, 10);
            txtSenhaConfirmada.Name = "txtSenhaConfirmada";
            txtSenhaConfirmada.Size = new Size(562, 25);
            txtSenhaConfirmada.TabIndex = 23;
            // 
            // lblSenhaConfirmada
            // 
            lblSenhaConfirmada.AutoSize = true;
            lblSenhaConfirmada.Dock = DockStyle.Fill;
            lblSenhaConfirmada.Font = new Font("Segoe UI", 10F);
            lblSenhaConfirmada.Location = new Point(27, 176);
            lblSenhaConfirmada.Name = "lblSenhaConfirmada";
            lblSenhaConfirmada.Size = new Size(126, 38);
            lblSenhaConfirmada.TabIndex = 22;
            lblSenhaConfirmada.Text = "Confirmar Senha:";
            lblSenhaConfirmada.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtObservacoes
            // 
            txtObservacoes.Dock = DockStyle.Fill;
            txtObservacoes.Font = new Font("Segoe UI", 10F);
            txtObservacoes.Location = new Point(159, 255);
            txtObservacoes.Margin = new Padding(3, 3, 3, 10);
            txtObservacoes.Name = "txtObservacoes";
            txtObservacoes.Size = new Size(562, 25);
            txtObservacoes.TabIndex = 19;
            // 
            // lblObservacoes
            // 
            lblObservacoes.AutoSize = true;
            lblObservacoes.Dock = DockStyle.Fill;
            lblObservacoes.Font = new Font("Segoe UI", 10F);
            lblObservacoes.Location = new Point(27, 252);
            lblObservacoes.Name = "lblObservacoes";
            lblObservacoes.Size = new Size(126, 38);
            lblObservacoes.TabIndex = 18;
            lblObservacoes.Text = "Observações";
            lblObservacoes.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNivelAcesso
            // 
            txtNivelAcesso.Dock = DockStyle.Fill;
            txtNivelAcesso.Font = new Font("Segoe UI", 10F);
            txtNivelAcesso.Location = new Point(159, 217);
            txtNivelAcesso.Margin = new Padding(3, 3, 3, 10);
            txtNivelAcesso.Name = "txtNivelAcesso";
            txtNivelAcesso.Size = new Size(562, 25);
            txtNivelAcesso.TabIndex = 17;
            // 
            // lblNivelAcesso
            // 
            lblNivelAcesso.AutoSize = true;
            lblNivelAcesso.Dock = DockStyle.Fill;
            lblNivelAcesso.Font = new Font("Segoe UI", 10F);
            lblNivelAcesso.Location = new Point(27, 214);
            lblNivelAcesso.Name = "lblNivelAcesso";
            lblNivelAcesso.Size = new Size(126, 38);
            lblNivelAcesso.TabIndex = 16;
            lblNivelAcesso.Text = "Nível acesso:";
            lblNivelAcesso.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDataCadastro
            // 
            lblDataCadastro.AutoSize = true;
            lblDataCadastro.Dock = DockStyle.Fill;
            lblDataCadastro.Font = new Font("Segoe UI", 10F);
            lblDataCadastro.Location = new Point(27, 290);
            lblDataCadastro.Name = "lblDataCadastro";
            lblDataCadastro.Size = new Size(126, 38);
            lblDataCadastro.TabIndex = 14;
            lblDataCadastro.Text = "Data Cadastro:";
            lblDataCadastro.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtEmail
            // 
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(159, 65);
            txtEmail.Margin = new Padding(3, 3, 3, 10);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(562, 25);
            txtEmail.TabIndex = 3;
            // 
            // txtNomeUsuario
            // 
            txtNomeUsuario.Dock = DockStyle.Fill;
            txtNomeUsuario.Font = new Font("Segoe UI", 10F);
            txtNomeUsuario.Location = new Point(159, 103);
            txtNomeUsuario.Margin = new Padding(3, 3, 3, 10);
            txtNomeUsuario.Name = "txtNomeUsuario";
            txtNomeUsuario.Size = new Size(562, 25);
            txtNomeUsuario.TabIndex = 5;
            // 
            // txtNovaSenha
            // 
            txtNovaSenha.Dock = DockStyle.Fill;
            txtNovaSenha.Font = new Font("Segoe UI", 10F);
            txtNovaSenha.Location = new Point(159, 141);
            txtNovaSenha.Margin = new Padding(3, 3, 3, 10);
            txtNovaSenha.Name = "txtNovaSenha";
            txtNovaSenha.Size = new Size(562, 25);
            txtNovaSenha.TabIndex = 7;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Dock = DockStyle.Fill;
            lblNome.Font = new Font("Segoe UI", 10F);
            lblNome.Location = new Point(27, 24);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(126, 38);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome Completo:";
            lblNome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.Dock = DockStyle.Fill;
            txtNomeCompleto.Font = new Font("Segoe UI", 10F);
            txtNomeCompleto.Location = new Point(159, 27);
            txtNomeCompleto.Margin = new Padding(3, 3, 3, 10);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(562, 25);
            txtNomeCompleto.TabIndex = 1;
            // 
            // lblNovaSenha
            // 
            lblNovaSenha.AutoSize = true;
            lblNovaSenha.Dock = DockStyle.Fill;
            lblNovaSenha.Font = new Font("Segoe UI", 10F);
            lblNovaSenha.Location = new Point(27, 138);
            lblNovaSenha.Name = "lblNovaSenha";
            lblNovaSenha.Size = new Size(126, 38);
            lblNovaSenha.TabIndex = 6;
            lblNovaSenha.Text = "Nova senha:";
            lblNovaSenha.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Dock = DockStyle.Fill;
            lblEmail.Font = new Font("Segoe UI", 10F);
            lblEmail.Location = new Point(27, 62);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(126, 38);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            lblEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Dock = DockStyle.Fill;
            lblUsuario.Font = new Font("Segoe UI", 10F);
            lblUsuario.Location = new Point(27, 100);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(126, 38);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Nome do usuário:";
            lblUsuario.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpDataCadastro
            // 
            dtpDataCadastro.Dock = DockStyle.Fill;
            dtpDataCadastro.Enabled = false;
            dtpDataCadastro.Font = new Font("Segoe UI", 10F);
            dtpDataCadastro.Format = DateTimePickerFormat.Custom;
            dtpDataCadastro.Location = new Point(159, 293);
            dtpDataCadastro.Margin = new Padding(3, 3, 3, 10);
            dtpDataCadastro.Name = "dtpDataCadastro";
            dtpDataCadastro.ShowUpDown = true;
            dtpDataCadastro.Size = new Size(562, 25);
            dtpDataCadastro.TabIndex = 13;
            dtpDataCadastro.Value = new DateTime(2026, 3, 29, 14, 1, 24, 0);
            // 
            // flowButtons
            // 
            flowButtons.Controls.Add(btnSalvar);
            flowButtons.Dock = DockStyle.Fill;
            flowButtons.FlowDirection = FlowDirection.RightToLeft;
            flowButtons.Location = new Point(156, 328);
            flowButtons.Margin = new Padding(0);
            flowButtons.Name = "flowButtons";
            flowButtons.Size = new Size(568, 183);
            flowButtons.TabIndex = 15;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(95, 97, 231);
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 10F);
            btnSalvar.ForeColor = SystemColors.ControlLightLight;
            btnSalvar.Location = new Point(391, 3);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(174, 38);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // PerfilControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpCadastro);
            Name = "PerfilControl";
            Size = new Size(748, 511);
            tlpCadastro.ResumeLayout(false);
            tlpCadastro.PerformLayout();
            flowButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpCadastro;
        private TextBox txtSenhaConfirmada;
        private Label lblSenhaConfirmada;
        private TextBox txtObservacoes;
        private Label lblObservacoes;
        private TextBox txtNivelAcesso;
        private Label lblNivelAcesso;
        private Label lblDataCadastro;
        private TextBox txtEmail;
        private TextBox txtNomeUsuario;
        private TextBox txtNovaSenha;
        private Label lblNome;
        private TextBox txtNomeCompleto;
        private Label lblNovaSenha;
        private Label lblEmail;
        private Label lblUsuario;
        private DateTimePicker dtpDataCadastro;
        private FlowLayoutPanel flowButtons;
        private Button btnSalvar;
    }
}
