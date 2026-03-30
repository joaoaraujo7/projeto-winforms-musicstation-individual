namespace MusicStationWinFormsApp.controls.usuarios
{
    partial class EmpresaControl : UserControl
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            tbpCadastro = new TabPage();
            pnlConteudoCadastro = new Panel();
            tlpCadastro = new TableLayoutPanel();
            lblDescricao = new Label();
            txtCnpj = new TextBox();
            lblCnpj = new Label();
            txtRazaoSocial = new TextBox();
            lblRazaoSocial = new Label();
            lblDataCadastro = new Label();
            lblId = new Label();
            txtEmail = new TextBox();
            txtNomeUsuario = new TextBox();
            txtSenha = new TextBox();
            lblNome = new Label();
            txtNomeCompleto = new TextBox();
            lblSenha = new Label();
            lblEmail = new Label();
            lblUsuario = new Label();
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
            empresaBindingSource = new BindingSource(components);
            pnlExterno = new Panel();
            tbcEmpresa = new TabControl();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            senhaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            razaoSocialDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cnpjDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descricaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            imgEditar = new DataGridViewImageColumn();
            imgExcluir = new DataGridViewImageColumn();
            lblTelefone = new Label();
            txtTelefone = new TextBox();
            txtDescricao = new TextBox();
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
            ((System.ComponentModel.ISupportInitialize)empresaBindingSource).BeginInit();
            tbcEmpresa.SuspendLayout();
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
            tlpCadastro.Controls.Add(txtTelefone, 1, 8);
            tlpCadastro.Controls.Add(lblTelefone, 0, 8);
            tlpCadastro.Controls.Add(lblDescricao, 0, 9);
            tlpCadastro.Controls.Add(txtDescricao, 1, 9);
            tlpCadastro.Controls.Add(txtCnpj, 1, 7);
            tlpCadastro.Controls.Add(lblCnpj, 0, 7);
            tlpCadastro.Controls.Add(txtRazaoSocial, 1, 6);
            tlpCadastro.Controls.Add(lblRazaoSocial, 0, 6);
            tlpCadastro.Controls.Add(lblDataCadastro, 0, 10);
            tlpCadastro.Controls.Add(lblId, 0, 0);
            tlpCadastro.Controls.Add(txtEmail, 1, 2);
            tlpCadastro.Controls.Add(txtNomeUsuario, 1, 3);
            tlpCadastro.Controls.Add(txtSenha, 1, 4);
            tlpCadastro.Controls.Add(lblNome, 0, 1);
            tlpCadastro.Controls.Add(txtNomeCompleto, 1, 1);
            tlpCadastro.Controls.Add(lblSenha, 0, 4);
            tlpCadastro.Controls.Add(lblEmail, 0, 2);
            tlpCadastro.Controls.Add(lblUsuario, 0, 3);
            tlpCadastro.Controls.Add(txtId, 1, 0);
            tlpCadastro.Controls.Add(dtpDataCadastro, 1, 10);
            tlpCadastro.Controls.Add(flowButtons, 1, 11);
            tlpCadastro.Dock = DockStyle.Fill;
            tlpCadastro.Location = new Point(0, 0);
            tlpCadastro.Name = "tlpCadastro";
            tlpCadastro.Padding = new Padding(24, 15, 24, 0);
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
            tlpCadastro.Size = new Size(730, 475);
            tlpCadastro.TabIndex = 15;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Dock = DockStyle.Fill;
            lblDescricao.Font = new Font("Segoe UI", 10F);
            lblDescricao.Location = new Point(27, 319);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(123, 38);
            lblDescricao.TabIndex = 24;
            lblDescricao.Text = "Descrição: ";
            lblDescricao.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCnpj
            // 
            txtCnpj.Dock = DockStyle.Fill;
            txtCnpj.Font = new Font("Segoe UI", 10F);
            txtCnpj.Location = new Point(156, 246);
            txtCnpj.Margin = new Padding(3, 3, 3, 10);
            txtCnpj.Name = "txtCnpj";
            txtCnpj.Size = new Size(547, 25);
            txtCnpj.TabIndex = 21;
            // 
            // lblCnpj
            // 
            lblCnpj.AutoSize = true;
            lblCnpj.Dock = DockStyle.Fill;
            lblCnpj.Font = new Font("Segoe UI", 10F);
            lblCnpj.Location = new Point(27, 243);
            lblCnpj.Name = "lblCnpj";
            lblCnpj.Size = new Size(123, 38);
            lblCnpj.TabIndex = 20;
            lblCnpj.Text = "Cnpj:";
            lblCnpj.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtRazaoSocial
            // 
            txtRazaoSocial.Dock = DockStyle.Fill;
            txtRazaoSocial.Font = new Font("Segoe UI", 10F);
            txtRazaoSocial.Location = new Point(156, 208);
            txtRazaoSocial.Margin = new Padding(3, 3, 3, 10);
            txtRazaoSocial.Name = "txtRazaoSocial";
            txtRazaoSocial.Size = new Size(547, 25);
            txtRazaoSocial.TabIndex = 19;
            // 
            // lblRazaoSocial
            // 
            lblRazaoSocial.AutoSize = true;
            lblRazaoSocial.Dock = DockStyle.Fill;
            lblRazaoSocial.Font = new Font("Segoe UI", 10F);
            lblRazaoSocial.Location = new Point(27, 205);
            lblRazaoSocial.Name = "lblRazaoSocial";
            lblRazaoSocial.Size = new Size(123, 38);
            lblRazaoSocial.TabIndex = 18;
            lblRazaoSocial.Text = "Razão Social";
            lblRazaoSocial.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDataCadastro
            // 
            lblDataCadastro.AutoSize = true;
            lblDataCadastro.Dock = DockStyle.Fill;
            lblDataCadastro.Font = new Font("Segoe UI", 10F);
            lblDataCadastro.Location = new Point(27, 357);
            lblDataCadastro.Name = "lblDataCadastro";
            lblDataCadastro.Size = new Size(123, 38);
            lblDataCadastro.TabIndex = 14;
            lblDataCadastro.Text = "Data Cadastro:";
            lblDataCadastro.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Dock = DockStyle.Fill;
            lblId.Font = new Font("Segoe UI", 10F);
            lblId.Location = new Point(27, 15);
            lblId.Name = "lblId";
            lblId.Size = new Size(123, 38);
            lblId.TabIndex = 10;
            lblId.Text = "Id:";
            lblId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtEmail
            // 
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(156, 94);
            txtEmail.Margin = new Padding(3, 3, 3, 10);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(547, 25);
            txtEmail.TabIndex = 3;
            // 
            // txtNomeUsuario
            // 
            txtNomeUsuario.Dock = DockStyle.Fill;
            txtNomeUsuario.Font = new Font("Segoe UI", 10F);
            txtNomeUsuario.Location = new Point(156, 132);
            txtNomeUsuario.Margin = new Padding(3, 3, 3, 10);
            txtNomeUsuario.Name = "txtNomeUsuario";
            txtNomeUsuario.Size = new Size(547, 25);
            txtNomeUsuario.TabIndex = 5;
            // 
            // txtSenha
            // 
            txtSenha.Dock = DockStyle.Fill;
            txtSenha.Font = new Font("Segoe UI", 10F);
            txtSenha.Location = new Point(156, 170);
            txtSenha.Margin = new Padding(3, 3, 3, 10);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(547, 25);
            txtSenha.TabIndex = 7;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Dock = DockStyle.Fill;
            lblNome.Font = new Font("Segoe UI", 10F);
            lblNome.Location = new Point(27, 53);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(123, 38);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome Fantasia:";
            lblNome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.Dock = DockStyle.Fill;
            txtNomeCompleto.Font = new Font("Segoe UI", 10F);
            txtNomeCompleto.Location = new Point(156, 56);
            txtNomeCompleto.Margin = new Padding(3, 3, 3, 10);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(547, 25);
            txtNomeCompleto.TabIndex = 1;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Dock = DockStyle.Fill;
            lblSenha.Font = new Font("Segoe UI", 10F);
            lblSenha.Location = new Point(27, 167);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(123, 38);
            lblSenha.TabIndex = 6;
            lblSenha.Text = "Senha:";
            lblSenha.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Dock = DockStyle.Fill;
            lblEmail.Font = new Font("Segoe UI", 10F);
            lblEmail.Location = new Point(27, 91);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(123, 38);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            lblEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Dock = DockStyle.Fill;
            lblUsuario.Font = new Font("Segoe UI", 10F);
            lblUsuario.Location = new Point(27, 129);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(123, 38);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Nome do usuário:";
            lblUsuario.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtId
            // 
            txtId.Dock = DockStyle.Fill;
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI", 10F);
            txtId.Location = new Point(156, 18);
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
            dtpDataCadastro.Location = new Point(156, 360);
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
            flowButtons.Location = new Point(153, 395);
            flowButtons.Margin = new Padding(0);
            flowButtons.Name = "flowButtons";
            flowButtons.Size = new Size(553, 80);
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
            btnPesquisar.Click += btnPesquisar_Click;
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
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            txtPesquisa.KeyDown += txtPesquisa_KeyDown;
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
            dgvDados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dgvDados.AutoGenerateColumns = false;
            dgvDados.BackgroundColor = Color.FromArgb(32, 28, 26);
            dgvDados.BorderStyle = BorderStyle.None;
            dgvDados.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(28, 24, 22);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(28, 24, 22);
            dataGridViewCellStyle3.SelectionForeColor = Color.Gainsboro;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvDados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDados.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, dataGridViewTextBoxColumn1, emailDataGridViewTextBoxColumn, dataGridViewTextBoxColumn2, senhaDataGridViewTextBoxColumn, dataGridViewTextBoxColumn3, razaoSocialDataGridViewTextBoxColumn, cnpjDataGridViewTextBoxColumn, telefoneDataGridViewTextBoxColumn, descricaoDataGridViewTextBoxColumn, imgEditar, imgExcluir });
            dgvDados.DataSource = empresaBindingSource;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(36, 32, 30);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(78, 33, 111);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvDados.DefaultCellStyle = dataGridViewCellStyle4;
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
            dgvDados.CellMouseEnter += dgvDados_CellMouseEnter;
            dgvDados.CellMouseLeave += dgvDados_CellMouseLeave;
            // 
            // empresaBindingSource
            // 
            empresaBindingSource.DataSource = typeof(models.Empresa);
            // 
            // pnlExterno
            // 
            pnlExterno.Dock = DockStyle.Top;
            pnlExterno.Location = new Point(3, 3);
            pnlExterno.Name = "pnlExterno";
            pnlExterno.Size = new Size(730, 51);
            pnlExterno.TabIndex = 21;
            // 
            // tbcEmpresa
            // 
            tbcEmpresa.Controls.Add(tbpListagem);
            tbcEmpresa.Controls.Add(tbpCadastro);
            tbcEmpresa.Dock = DockStyle.Fill;
            tbcEmpresa.Font = new Font("Segoe UI", 10F);
            tbcEmpresa.ItemSize = new Size(64, 0);
            tbcEmpresa.Location = new Point(0, 0);
            tbcEmpresa.Name = "tbcEmpresa";
            tbcEmpresa.SelectedIndex = 0;
            tbcEmpresa.Size = new Size(744, 511);
            tbcEmpresa.TabIndex = 10;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 44;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn1.DataPropertyName = "NomeCompleto";
            dataGridViewTextBoxColumn1.HeaderText = "Nome Fantasia";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 123;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.Width = 64;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn2.DataPropertyName = "UsuarioNome";
            dataGridViewTextBoxColumn2.HeaderText = "Usuario";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 79;
            // 
            // senhaDataGridViewTextBoxColumn
            // 
            senhaDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            senhaDataGridViewTextBoxColumn.DataPropertyName = "Senha";
            senhaDataGridViewTextBoxColumn.HeaderText = "Senha";
            senhaDataGridViewTextBoxColumn.Name = "senhaDataGridViewTextBoxColumn";
            senhaDataGridViewTextBoxColumn.Width = 69;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn3.DataPropertyName = "DataCadastro";
            dataGridViewTextBoxColumn3.HeaderText = "Data Cadastro";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 120;
            // 
            // razaoSocialDataGridViewTextBoxColumn
            // 
            razaoSocialDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            razaoSocialDataGridViewTextBoxColumn.DataPropertyName = "RazaoSocial";
            razaoSocialDataGridViewTextBoxColumn.HeaderText = "Razão Social";
            razaoSocialDataGridViewTextBoxColumn.Name = "razaoSocialDataGridViewTextBoxColumn";
            razaoSocialDataGridViewTextBoxColumn.Width = 106;
            // 
            // cnpjDataGridViewTextBoxColumn
            // 
            cnpjDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            cnpjDataGridViewTextBoxColumn.DataPropertyName = "Cnpj";
            cnpjDataGridViewTextBoxColumn.HeaderText = "Cnpj";
            cnpjDataGridViewTextBoxColumn.Name = "cnpjDataGridViewTextBoxColumn";
            cnpjDataGridViewTextBoxColumn.Width = 60;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            telefoneDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            telefoneDataGridViewTextBoxColumn.Width = 82;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            descricaoDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            descricaoDataGridViewTextBoxColumn.Width = 90;
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
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Dock = DockStyle.Fill;
            lblTelefone.Font = new Font("Segoe UI", 10F);
            lblTelefone.Location = new Point(27, 281);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(123, 38);
            lblTelefone.TabIndex = 27;
            lblTelefone.Text = "Telefone:";
            lblTelefone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTelefone
            // 
            txtTelefone.Dock = DockStyle.Fill;
            txtTelefone.Font = new Font("Segoe UI", 10F);
            txtTelefone.Location = new Point(156, 284);
            txtTelefone.Margin = new Padding(3, 3, 3, 10);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(547, 25);
            txtTelefone.TabIndex = 28;
            // 
            // txtDescricao
            // 
            txtDescricao.Dock = DockStyle.Fill;
            txtDescricao.Font = new Font("Segoe UI", 10F);
            txtDescricao.Location = new Point(156, 322);
            txtDescricao.Margin = new Padding(3, 3, 3, 10);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(547, 25);
            txtDescricao.TabIndex = 23;
            // 
            // EmpresaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbcEmpresa);
            Name = "EmpresaControl";
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
            ((System.ComponentModel.ISupportInitialize)empresaBindingSource).EndInit();
            tbcEmpresa.ResumeLayout(false);
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
        private TabControl tbcEmpresa;
        private Panel pnlPesquisa;
        private BindingSource empresaBindingSource;
        private DataGridViewTextBoxColumn nomeCompletoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usuarioNomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataCadastroDataGridViewTextBoxColumn;
        private TableLayoutPanel tlpPesquisa;
        private Panel pnlInternoPesquisa;
        private Panel pnlDataGrid;
        private Panel pnlExterno;
        private TableLayoutPanel tlpCadastro;
        private Label lblDataCadastro;
        private Label lblId;
        private TextBox txtEmail;
        private TextBox txtNomeUsuario;
        private TextBox txtSenha;
        private Label lblNome;
        private TextBox txtNomeCompleto;
        private Label lblSenha;
        private Label lblEmail;
        private Label lblUsuario;
        private TextBox txtId;
        private DateTimePicker dtpDataCadastro;
        private FlowLayoutPanel flowButtons;
        private Button btnCancelar;
        private Button btnSalvar;
        private TextBox txtRazaoSocial;
        private Label lblRazaoSocial;
        private TextBox txtCnpj;
        private Label lblCnpj;
        private DataGridView dgvDados;
        private Label lblDescricao;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn senhaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn razaoSocialDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cnpjDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private DataGridViewImageColumn imgEditar;
        private DataGridViewImageColumn imgExcluir;
        private TextBox txtTelefone;
        private Label lblTelefone;
        private TextBox txtDescricao;
    }
}
