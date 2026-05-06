namespace MusicStationWinFormsApp.controls.comunicacao
{
    partial class NotificacaoControl
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tbpCadastro = new TabPage();
            pnlConteudoCadastro = new Panel();
            tlpCadastro = new TableLayoutPanel();
            lblUsuario = new Label();
            lblDataEnvio = new Label();
            lblId = new Label();
            txtMensagem = new TextBox();
            lblTitulo = new Label();
            txtTitulo = new TextBox();
            lblMensagem = new Label();
            lblTipoNotificacao = new Label();
            txtId = new TextBox();
            dtpDataCadastro = new DateTimePicker();
            flowButtons = new FlowLayoutPanel();
            btnCancelar = new Button();
            btnSalvar = new Button();
            tbpListagem = new TabPage();
            tlpPesquisa = new TableLayoutPanel();
            pnlPesquisa = new Panel();
            btnPesquisar = new Button();
            pnlInternoPesquisa = new Panel();
            txtPesquisa = new TextBox();
            btnAdicionar = new Button();
            pnlDataGrid = new Panel();
            dgvDados = new DataGridView();
            imgEditar = new DataGridViewImageColumn();
            imgExcluir = new DataGridViewImageColumn();
            pnlExterno = new Panel();
            tbcNotificacoes = new TabControl();
            cboTipoNotificacao = new ComboBox();
            cboUsuario = new ComboBox();
            chkLida = new CheckBox();
            lblLida = new Label();
            tbpCadastro.SuspendLayout();
            pnlConteudoCadastro.SuspendLayout();
            tlpCadastro.SuspendLayout();
            flowButtons.SuspendLayout();
            tbpListagem.SuspendLayout();
            tlpPesquisa.SuspendLayout();
            pnlPesquisa.SuspendLayout();
            pnlInternoPesquisa.SuspendLayout();
            pnlDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDados).BeginInit();
            tbcNotificacoes.SuspendLayout();
            SuspendLayout();
            // 
            // tbpCadastro
            // 
            tbpCadastro.BackColor = SystemColors.Control;
            tbpCadastro.Controls.Add(pnlConteudoCadastro);
            tbpCadastro.Location = new Point(4, 26);
            tbpCadastro.Name = "tbpCadastro";
            tbpCadastro.Padding = new Padding(3);
            tbpCadastro.Size = new Size(736, 481);
            tbpCadastro.TabIndex = 1;
            tbpCadastro.Text = "Cadastro";
            // 
            // pnlConteudoCadastro
            // 
            pnlConteudoCadastro.Controls.Add(tlpCadastro);
            pnlConteudoCadastro.Dock = DockStyle.Fill;
            pnlConteudoCadastro.Location = new Point(3, 3);
            pnlConteudoCadastro.Name = "pnlConteudoCadastro";
            pnlConteudoCadastro.Size = new Size(730, 475);
            pnlConteudoCadastro.TabIndex = 2;
            // 
            // tlpCadastro
            // 
            tlpCadastro.BackColor = SystemColors.Control;
            tlpCadastro.ColumnCount = 2;
            tlpCadastro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.91496F));
            tlpCadastro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.08504F));
            tlpCadastro.Controls.Add(cboUsuario, 1, 5);
            tlpCadastro.Controls.Add(lblUsuario, 0, 5);
            tlpCadastro.Controls.Add(lblDataEnvio, 0, 8);
            tlpCadastro.Controls.Add(lblId, 0, 0);
            tlpCadastro.Controls.Add(txtMensagem, 1, 2);
            tlpCadastro.Controls.Add(lblTitulo, 0, 1);
            tlpCadastro.Controls.Add(txtTitulo, 1, 1);
            tlpCadastro.Controls.Add(lblLida, 0, 4);
            tlpCadastro.Controls.Add(lblMensagem, 0, 2);
            tlpCadastro.Controls.Add(lblTipoNotificacao, 0, 3);
            tlpCadastro.Controls.Add(txtId, 1, 0);
            tlpCadastro.Controls.Add(dtpDataCadastro, 1, 8);
            tlpCadastro.Controls.Add(flowButtons, 1, 9);
            tlpCadastro.Controls.Add(cboTipoNotificacao, 1, 3);
            tlpCadastro.Controls.Add(chkLida, 1, 4);
            tlpCadastro.Dock = DockStyle.Fill;
            tlpCadastro.Location = new Point(0, 0);
            tlpCadastro.Name = "tlpCadastro";
            tlpCadastro.Padding = new Padding(24, 24, 24, 0);
            tlpCadastro.RowCount = 10;
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
            tlpCadastro.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpCadastro.Size = new Size(730, 475);
            tlpCadastro.TabIndex = 15;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Dock = DockStyle.Fill;
            lblUsuario.Font = new Font("Segoe UI", 10F);
            lblUsuario.Location = new Point(27, 216);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(123, 31);
            lblUsuario.TabIndex = 18;
            lblUsuario.Text = "Usuário";
            lblUsuario.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDataEnvio
            // 
            lblDataEnvio.AutoSize = true;
            lblDataEnvio.Dock = DockStyle.Fill;
            lblDataEnvio.Font = new Font("Segoe UI", 10F);
            lblDataEnvio.Location = new Point(27, 247);
            lblDataEnvio.Name = "lblDataEnvio";
            lblDataEnvio.Size = new Size(123, 38);
            lblDataEnvio.TabIndex = 14;
            lblDataEnvio.Text = "Data Envio:";
            lblDataEnvio.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Dock = DockStyle.Fill;
            lblId.Font = new Font("Segoe UI", 10F);
            lblId.Location = new Point(27, 24);
            lblId.Name = "lblId";
            lblId.Size = new Size(123, 38);
            lblId.TabIndex = 10;
            lblId.Text = "Id:";
            lblId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtMensagem
            // 
            txtMensagem.Dock = DockStyle.Fill;
            txtMensagem.Font = new Font("Segoe UI", 10F);
            txtMensagem.Location = new Point(156, 103);
            txtMensagem.Margin = new Padding(3, 3, 3, 10);
            txtMensagem.Multiline = true;
            txtMensagem.Name = "txtMensagem";
            txtMensagem.Size = new Size(547, 43);
            txtMensagem.TabIndex = 3;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 10F);
            lblTitulo.Location = new Point(27, 62);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(123, 38);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Título:";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTitulo
            // 
            txtTitulo.Dock = DockStyle.Fill;
            txtTitulo.Font = new Font("Segoe UI", 10F);
            txtTitulo.Location = new Point(156, 65);
            txtTitulo.Margin = new Padding(3, 3, 3, 10);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(547, 25);
            txtTitulo.TabIndex = 1;
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.Dock = DockStyle.Fill;
            lblMensagem.Font = new Font("Segoe UI", 10F);
            lblMensagem.Location = new Point(27, 100);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(123, 56);
            lblMensagem.TabIndex = 2;
            lblMensagem.Text = "Mensagem:";
            lblMensagem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTipoNotificacao
            // 
            lblTipoNotificacao.AutoSize = true;
            lblTipoNotificacao.Dock = DockStyle.Fill;
            lblTipoNotificacao.Font = new Font("Segoe UI", 10F);
            lblTipoNotificacao.Location = new Point(27, 156);
            lblTipoNotificacao.Name = "lblTipoNotificacao";
            lblTipoNotificacao.Size = new Size(123, 31);
            lblTipoNotificacao.TabIndex = 4;
            lblTipoNotificacao.Text = "Tipo notificação:";
            lblTipoNotificacao.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtId
            // 
            txtId.Dock = DockStyle.Fill;
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI", 10F);
            txtId.Location = new Point(156, 27);
            txtId.Margin = new Padding(3, 3, 3, 10);
            txtId.Name = "txtId";
            txtId.Size = new Size(547, 25);
            txtId.TabIndex = 11;
            // 
            // dtpDataCadastro
            // 
            dtpDataCadastro.Dock = DockStyle.Fill;
            dtpDataCadastro.Enabled = false;
            dtpDataCadastro.Font = new Font("Segoe UI", 10F);
            dtpDataCadastro.Format = DateTimePickerFormat.Custom;
            dtpDataCadastro.Location = new Point(156, 250);
            dtpDataCadastro.Margin = new Padding(3, 3, 3, 10);
            dtpDataCadastro.Name = "dtpDataCadastro";
            dtpDataCadastro.ShowUpDown = true;
            dtpDataCadastro.Size = new Size(547, 25);
            dtpDataCadastro.TabIndex = 13;
            dtpDataCadastro.Value = new DateTime(2026, 3, 29, 14, 1, 24, 0);
            // 
            // flowButtons
            // 
            flowButtons.Controls.Add(btnCancelar);
            flowButtons.Controls.Add(btnSalvar);
            flowButtons.Dock = DockStyle.Fill;
            flowButtons.FlowDirection = FlowDirection.RightToLeft;
            flowButtons.Location = new Point(153, 285);
            flowButtons.Margin = new Padding(0);
            flowButtons.Name = "flowButtons";
            flowButtons.Size = new Size(553, 190);
            flowButtons.TabIndex = 15;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ControlDark;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10F);
            btnCancelar.ForeColor = SystemColors.ControlLightLight;
            btnCancelar.Location = new Point(467, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(83, 38);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += Cancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(95, 97, 231);
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 10F);
            btnSalvar.ForeColor = SystemColors.ControlLightLight;
            btnSalvar.Location = new Point(287, 3);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(174, 38);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // tbpListagem
            // 
            tbpListagem.BackColor = SystemColors.Control;
            tbpListagem.Controls.Add(tlpPesquisa);
            tbpListagem.Controls.Add(pnlDataGrid);
            tbpListagem.Controls.Add(pnlExterno);
            tbpListagem.Location = new Point(4, 26);
            tbpListagem.Name = "tbpListagem";
            tbpListagem.Padding = new Padding(3);
            tbpListagem.Size = new Size(736, 481);
            tbpListagem.TabIndex = 0;
            tbpListagem.Text = "Listagem";
            // 
            // tlpPesquisa
            // 
            tlpPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tlpPesquisa.ColumnCount = 2;
            tlpPesquisa.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.452055F));
            tlpPesquisa.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.54794F));
            tlpPesquisa.Controls.Add(pnlPesquisa, 1, 0);
            tlpPesquisa.Controls.Add(btnAdicionar, 0, 0);
            tlpPesquisa.Location = new Point(3, 3);
            tlpPesquisa.Name = "tlpPesquisa";
            tlpPesquisa.RowCount = 1;
            tlpPesquisa.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpPesquisa.Size = new Size(730, 51);
            tlpPesquisa.TabIndex = 19;
            // 
            // pnlPesquisa
            // 
            pnlPesquisa.BackColor = SystemColors.Window;
            pnlPesquisa.BorderStyle = BorderStyle.FixedSingle;
            pnlPesquisa.Controls.Add(btnPesquisar);
            pnlPesquisa.Controls.Add(pnlInternoPesquisa);
            pnlPesquisa.Location = new Point(145, 3);
            pnlPesquisa.Name = "pnlPesquisa";
            pnlPesquisa.Padding = new Padding(1);
            pnlPesquisa.RightToLeft = RightToLeft.No;
            pnlPesquisa.Size = new Size(562, 40);
            pnlPesquisa.TabIndex = 14;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = SystemColors.Window;
            btnPesquisar.Dock = DockStyle.Right;
            btnPesquisar.FlatAppearance.BorderSize = 0;
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.Image = Properties.Resources.lupa;
            btnPesquisar.Location = new Point(519, 1);
            btnPesquisar.Margin = new Padding(0);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(40, 36);
            btnPesquisar.TabIndex = 12;
            btnPesquisar.TextAlign = ContentAlignment.MiddleRight;
            btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // pnlInternoPesquisa
            // 
            pnlInternoPesquisa.Controls.Add(txtPesquisa);
            pnlInternoPesquisa.Dock = DockStyle.Left;
            pnlInternoPesquisa.Location = new Point(1, 1);
            pnlInternoPesquisa.Margin = new Padding(0);
            pnlInternoPesquisa.Name = "pnlInternoPesquisa";
            pnlInternoPesquisa.Padding = new Padding(10, 8, 5, 8);
            pnlInternoPesquisa.Size = new Size(522, 36);
            pnlInternoPesquisa.TabIndex = 20;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Anchor = AnchorStyles.Left;
            txtPesquisa.BorderStyle = BorderStyle.None;
            txtPesquisa.Font = new Font("Segoe UI", 10F);
            txtPesquisa.Location = new Point(10, 8);
            txtPesquisa.Margin = new Padding(0);
            txtPesquisa.MaxLength = 200;
            txtPesquisa.Multiline = true;
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.PlaceholderText = "Digite o nome ou id...";
            txtPesquisa.Size = new Size(507, 24);
            txtPesquisa.TabIndex = 13;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.FromArgb(58, 111, 232);
            btnAdicionar.FlatStyle = FlatStyle.Flat;
            btnAdicionar.Font = new Font("Segoe UI", 10F);
            btnAdicionar.ForeColor = SystemColors.ControlLightLight;
            btnAdicionar.Image = Properties.Resources.mais;
            btnAdicionar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdicionar.Location = new Point(3, 3);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Padding = new Padding(3, 0, 0, 0);
            btnAdicionar.Size = new Size(136, 40);
            btnAdicionar.TabIndex = 11;
            btnAdicionar.Text = " Adicionar Novo";
            btnAdicionar.TextAlign = ContentAlignment.MiddleRight;
            btnAdicionar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // pnlDataGrid
            // 
            pnlDataGrid.Controls.Add(dgvDados);
            pnlDataGrid.Dock = DockStyle.Fill;
            pnlDataGrid.Location = new Point(3, 54);
            pnlDataGrid.Name = "pnlDataGrid";
            pnlDataGrid.Padding = new Padding(20);
            pnlDataGrid.Size = new Size(730, 424);
            pnlDataGrid.TabIndex = 20;
            // 
            // dgvDados
            // 
            dgvDados.AllowUserToAddRows = false;
            dgvDados.AllowUserToDeleteRows = false;
            dgvDados.AllowUserToOrderColumns = true;
            dgvDados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dgvDados.BackgroundColor = Color.FromArgb(32, 28, 26);
            dgvDados.BorderStyle = BorderStyle.None;
            dgvDados.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(28, 24, 22);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle5.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(28, 24, 22);
            dataGridViewCellStyle5.SelectionForeColor = Color.Gainsboro;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvDados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDados.Columns.AddRange(new DataGridViewColumn[] { imgEditar, imgExcluir });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(36, 32, 30);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(78, 33, 111);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvDados.DefaultCellStyle = dataGridViewCellStyle6;
            dgvDados.EnableHeadersVisualStyles = false;
            dgvDados.GridColor = Color.FromArgb(45, 45, 45);
            dgvDados.Location = new Point(20, 17);
            dgvDados.Name = "dgvDados";
            dgvDados.RowHeadersVisible = false;
            dgvDados.RowTemplate.Height = 40;
            dgvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDados.Size = new Size(690, 391);
            dgvDados.TabIndex = 11;
            dgvDados.CellClick += dgvDados_CellClick;
            // 
            // imgEditar
            // 
            imgEditar.HeaderText = "";
            imgEditar.Image = Properties.Resources.editar;
            imgEditar.Name = "imgEditar";
            imgEditar.ToolTipText = "Editar";
            imgEditar.Width = 40;
            // 
            // imgExcluir
            // 
            imgExcluir.HeaderText = "";
            imgExcluir.Image = Properties.Resources.excluir;
            imgExcluir.Name = "imgExcluir";
            imgExcluir.ToolTipText = "Excluir";
            imgExcluir.Width = 40;
            // 
            // pnlExterno
            // 
            pnlExterno.Dock = DockStyle.Top;
            pnlExterno.Location = new Point(3, 3);
            pnlExterno.Name = "pnlExterno";
            pnlExterno.Size = new Size(730, 51);
            pnlExterno.TabIndex = 21;
            // 
            // tbcNotificacoes
            // 
            tbcNotificacoes.Controls.Add(tbpListagem);
            tbcNotificacoes.Controls.Add(tbpCadastro);
            tbcNotificacoes.Dock = DockStyle.Fill;
            tbcNotificacoes.Font = new Font("Segoe UI", 10F);
            tbcNotificacoes.ItemSize = new Size(64, 0);
            tbcNotificacoes.Location = new Point(0, 0);
            tbcNotificacoes.Name = "tbcNotificacoes";
            tbcNotificacoes.SelectedIndex = 0;
            tbcNotificacoes.Size = new Size(744, 511);
            tbcNotificacoes.TabIndex = 10;
            // 
            // cboTipoNotificacao
            // 
            cboTipoNotificacao.Dock = DockStyle.Left;
            cboTipoNotificacao.FormattingEnabled = true;
            cboTipoNotificacao.Location = new Point(156, 159);
            cboTipoNotificacao.Name = "cboTipoNotificacao";
            cboTipoNotificacao.Size = new Size(259, 25);
            cboTipoNotificacao.TabIndex = 22;
            // 
            // cboUsuario
            // 
            cboUsuario.Dock = DockStyle.Left;
            cboUsuario.FormattingEnabled = true;
            cboUsuario.Location = new Point(156, 219);
            cboUsuario.Name = "cboUsuario";
            cboUsuario.Size = new Size(259, 25);
            cboUsuario.TabIndex = 26;
            // 
            // chkLida
            // 
            chkLida.AutoSize = true;
            chkLida.Location = new Point(156, 190);
            chkLida.Name = "chkLida";
            chkLida.Size = new Size(50, 23);
            chkLida.TabIndex = 23;
            chkLida.Text = "Sim";
            chkLida.UseVisualStyleBackColor = true;
            // 
            // lblLida
            // 
            lblLida.AutoSize = true;
            lblLida.Dock = DockStyle.Fill;
            lblLida.Font = new Font("Segoe UI", 10F);
            lblLida.Location = new Point(27, 187);
            lblLida.Name = "lblLida";
            lblLida.Size = new Size(123, 29);
            lblLida.TabIndex = 6;
            lblLida.Text = "Lida:";
            lblLida.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // NotificacaoControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbcNotificacoes);
            Name = "NotificacaoControl";
            Size = new Size(744, 511);
            tbpCadastro.ResumeLayout(false);
            pnlConteudoCadastro.ResumeLayout(false);
            tlpCadastro.ResumeLayout(false);
            tlpCadastro.PerformLayout();
            flowButtons.ResumeLayout(false);
            tbpListagem.ResumeLayout(false);
            tlpPesquisa.ResumeLayout(false);
            pnlPesquisa.ResumeLayout(false);
            pnlInternoPesquisa.ResumeLayout(false);
            pnlInternoPesquisa.PerformLayout();
            pnlDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDados).EndInit();
            tbcNotificacoes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DateTimePicker dateTimePicker1;
        private TabPage tbpCadastro;
        private Panel pnlConteudoCadastro;
        private TabPage tbpListagem;
        private TextBox txtPesquisa;
        private Button btnPesquisar;
        private Button btnAdicionar;
        private TabControl tbcNotificacoes;
        private Panel pnlPesquisa;
        private DataGridViewTextBoxColumn nomeCompletoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usuarioNomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataCadastroDataGridViewTextBoxColumn;
        private TableLayoutPanel tlpPesquisa;
        private Panel pnlInternoPesquisa;
        private Panel pnlDataGrid;
        private Panel pnlExterno;
        private TableLayoutPanel tlpCadastro;
        private Label lblDataEnvio;
        private Label lblId;
        private TextBox txtMensagem;
        private Label lblTitulo;
        private TextBox txtTitulo;
        private Label lblMensagem;
        private Label lblTipoNotificacao;
        private TextBox txtId;
        private DateTimePicker dtpDataCadastro;
        private FlowLayoutPanel flowButtons;
        private Button btnCancelar;
        private Button btnSalvar;
        private Label lblUsuario;
        private DataGridView dgvDados;
        private DataGridViewImageColumn imgEditar;
        private DataGridViewImageColumn imgExcluir;
        private ComboBox cboTipoNotificacao;
        private ComboBox cboUsuario;
        private Label lblLida;
        private CheckBox chkLida;
    }
}
