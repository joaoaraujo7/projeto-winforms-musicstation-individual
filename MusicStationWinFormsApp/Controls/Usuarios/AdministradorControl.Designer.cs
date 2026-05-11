namespace MusicStationWinFormsApp.controls.usuarios
{
    partial class AdministradorControl
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tbpCadastro = new TabPage();
            pnlConteudoCadastro = new Panel();
            tlpCadastro = new TableLayoutPanel();
            txtObservacoes = new TextBox();
            lblObservacoes = new Label();
            txtNivelAcesso = new TextBox();
            lblNivelAcesso = new Label();
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
            pnlDataGrid = new Panel();
            dgvDados = new DataGridView();
            imgEditar = new DataGridViewImageColumn();
            imgExcluir = new DataGridViewImageColumn();
            pnlExterno = new Panel();
            tlpPesquisa = new TableLayoutPanel();
            pnlPesquisa = new Panel();
            btnPesquisar = new Button();
            pnlInternoPesquisa = new Panel();
            txtPesquisa = new TextBox();
            btnAdicionar = new Button();
            tbcAdministradores = new TabControl();
            tbpCadastro.SuspendLayout();
            pnlConteudoCadastro.SuspendLayout();
            tlpCadastro.SuspendLayout();
            flowButtons.SuspendLayout();
            tbpListagem.SuspendLayout();
            pnlDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDados).BeginInit();
            pnlExterno.SuspendLayout();
            tlpPesquisa.SuspendLayout();
            pnlPesquisa.SuspendLayout();
            pnlInternoPesquisa.SuspendLayout();
            tbcAdministradores.SuspendLayout();
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
            tlpCadastro.Controls.Add(txtObservacoes, 1, 6);
            tlpCadastro.Controls.Add(lblObservacoes, 0, 6);
            tlpCadastro.Controls.Add(txtNivelAcesso, 1, 5);
            tlpCadastro.Controls.Add(lblNivelAcesso, 0, 5);
            tlpCadastro.Controls.Add(lblDataCadastro, 0, 9);
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
            tlpCadastro.Controls.Add(dtpDataCadastro, 1, 9);
            tlpCadastro.Controls.Add(flowButtons, 1, 10);
            tlpCadastro.Dock = DockStyle.Fill;
            tlpCadastro.Location = new Point(0, 0);
            tlpCadastro.Name = "tlpCadastro";
            tlpCadastro.Padding = new Padding(24, 24, 24, 0);
            tlpCadastro.RowCount = 11;
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
            // txtObservacoes
            // 
            txtObservacoes.Dock = DockStyle.Fill;
            txtObservacoes.Font = new Font("Segoe UI", 10F);
            txtObservacoes.Location = new Point(156, 255);
            txtObservacoes.Margin = new Padding(3, 3, 3, 10);
            txtObservacoes.Name = "txtObservacoes";
            txtObservacoes.Size = new Size(547, 25);
            txtObservacoes.TabIndex = 19;
            // 
            // lblObservacoes
            // 
            lblObservacoes.AutoSize = true;
            lblObservacoes.Dock = DockStyle.Fill;
            lblObservacoes.Font = new Font("Segoe UI", 10F);
            lblObservacoes.Location = new Point(27, 252);
            lblObservacoes.Name = "lblObservacoes";
            lblObservacoes.Size = new Size(123, 38);
            lblObservacoes.TabIndex = 18;
            lblObservacoes.Text = "Observações";
            lblObservacoes.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNivelAcesso
            // 
            txtNivelAcesso.Dock = DockStyle.Fill;
            txtNivelAcesso.Font = new Font("Segoe UI", 10F);
            txtNivelAcesso.Location = new Point(156, 217);
            txtNivelAcesso.Margin = new Padding(3, 3, 3, 10);
            txtNivelAcesso.Name = "txtNivelAcesso";
            txtNivelAcesso.Size = new Size(547, 25);
            txtNivelAcesso.TabIndex = 17;
            // 
            // lblNivelAcesso
            // 
            lblNivelAcesso.AutoSize = true;
            lblNivelAcesso.Dock = DockStyle.Fill;
            lblNivelAcesso.Font = new Font("Segoe UI", 10F);
            lblNivelAcesso.Location = new Point(27, 214);
            lblNivelAcesso.Name = "lblNivelAcesso";
            lblNivelAcesso.Size = new Size(123, 38);
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
            lblId.Location = new Point(27, 24);
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
            txtEmail.Location = new Point(156, 103);
            txtEmail.Margin = new Padding(3, 3, 3, 10);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(547, 25);
            txtEmail.TabIndex = 3;
            // 
            // txtNomeUsuario
            // 
            txtNomeUsuario.Dock = DockStyle.Fill;
            txtNomeUsuario.Font = new Font("Segoe UI", 10F);
            txtNomeUsuario.Location = new Point(156, 141);
            txtNomeUsuario.Margin = new Padding(3, 3, 3, 10);
            txtNomeUsuario.Name = "txtNomeUsuario";
            txtNomeUsuario.Size = new Size(547, 25);
            txtNomeUsuario.TabIndex = 5;
            // 
            // txtSenha
            // 
            txtSenha.Dock = DockStyle.Fill;
            txtSenha.Font = new Font("Segoe UI", 10F);
            txtSenha.Location = new Point(156, 179);
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
            lblNome.Location = new Point(27, 62);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(123, 38);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome Completo:";
            lblNome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.Dock = DockStyle.Fill;
            txtNomeCompleto.Font = new Font("Segoe UI", 10F);
            txtNomeCompleto.Location = new Point(156, 65);
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
            lblSenha.Location = new Point(27, 176);
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
            lblEmail.Location = new Point(27, 100);
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
            lblUsuario.Location = new Point(27, 138);
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
            dtpDataCadastro.Location = new Point(156, 293);
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
            flowButtons.Location = new Point(153, 328);
            flowButtons.Margin = new Padding(0);
            flowButtons.Name = "flowButtons";
            flowButtons.Size = new Size(553, 147);
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
            tbpListagem.Controls.Add(pnlDataGrid);
            tbpListagem.Controls.Add(pnlExterno);
            tbpListagem.Location = new Point(4, 26);
            tbpListagem.Name = "tbpListagem";
            tbpListagem.Padding = new Padding(3);
            tbpListagem.Size = new Size(736, 481);
            tbpListagem.TabIndex = 0;
            tbpListagem.Text = "Listagem";
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
            dgvDados.BackgroundColor = Color.FromArgb(32, 28, 26);
            dgvDados.BorderStyle = BorderStyle.None;
            dgvDados.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(28, 24, 22);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(28, 24, 22);
            dataGridViewCellStyle1.SelectionForeColor = Color.Gainsboro;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDados.Columns.AddRange(new DataGridViewColumn[] { imgEditar, imgExcluir });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(36, 32, 30);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(78, 33, 111);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDados.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDados.EnableHeadersVisualStyles = false;
            dgvDados.GridColor = Color.FromArgb(45, 45, 45);
            dgvDados.Location = new Point(3, 6);
            dgvDados.Name = "dgvDados";
            dgvDados.RowHeadersVisible = false;
            dgvDados.RowTemplate.Height = 40;
            dgvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDados.Size = new Size(724, 415);
            dgvDados.TabIndex = 11;
            dgvDados.CellClick += dgvDados_CellClick;
            dgvDados.CellMouseEnter += dgvDados_CellMouseEnter;
            dgvDados.CellMouseLeave += dgvDados_CellMouseLeave;
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
            pnlExterno.Controls.Add(tlpPesquisa);
            pnlExterno.Dock = DockStyle.Top;
            pnlExterno.Location = new Point(3, 3);
            pnlExterno.Name = "pnlExterno";
            pnlExterno.Size = new Size(730, 51);
            pnlExterno.TabIndex = 21;
            // 
            // tlpPesquisa
            // 
            tlpPesquisa.ColumnCount = 2;
            tlpPesquisa.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.452055F));
            tlpPesquisa.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.54794F));
            tlpPesquisa.Controls.Add(pnlPesquisa, 1, 0);
            tlpPesquisa.Controls.Add(btnAdicionar, 0, 0);
            tlpPesquisa.Dock = DockStyle.Top;
            tlpPesquisa.Location = new Point(0, 0);
            tlpPesquisa.Name = "tlpPesquisa";
            tlpPesquisa.RowCount = 1;
            tlpPesquisa.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpPesquisa.Size = new Size(730, 51);
            tlpPesquisa.TabIndex = 20;
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
            pnlPesquisa.Size = new Size(582, 40);
            pnlPesquisa.TabIndex = 14;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = SystemColors.Window;
            btnPesquisar.Dock = DockStyle.Right;
            btnPesquisar.FlatAppearance.BorderSize = 0;
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.Image = Properties.Resources.lupa;
            btnPesquisar.Location = new Point(539, 1);
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
            pnlInternoPesquisa.Size = new Size(538, 36);
            pnlInternoPesquisa.TabIndex = 20;
            // 
            // txtPesquisa
            // 
            txtPesquisa.BorderStyle = BorderStyle.None;
            txtPesquisa.Dock = DockStyle.Fill;
            txtPesquisa.Font = new Font("Segoe UI", 10F);
            txtPesquisa.Location = new Point(10, 8);
            txtPesquisa.Margin = new Padding(0);
            txtPesquisa.MaxLength = 200;
            txtPesquisa.Multiline = true;
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.PlaceholderText = "Buscar nome, email ou usuário...";
            txtPesquisa.Size = new Size(523, 20);
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
            // tbcAdministradores
            // 
            tbcAdministradores.Controls.Add(tbpListagem);
            tbcAdministradores.Controls.Add(tbpCadastro);
            tbcAdministradores.Dock = DockStyle.Fill;
            tbcAdministradores.Font = new Font("Segoe UI", 10F);
            tbcAdministradores.ItemSize = new Size(64, 0);
            tbcAdministradores.Location = new Point(0, 0);
            tbcAdministradores.Name = "tbcAdministradores";
            tbcAdministradores.SelectedIndex = 0;
            tbcAdministradores.Size = new Size(744, 511);
            tbcAdministradores.TabIndex = 10;
            // 
            // AdministradorControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbcAdministradores);
            Name = "AdministradorControl";
            Size = new Size(744, 511);
            tbpCadastro.ResumeLayout(false);
            pnlConteudoCadastro.ResumeLayout(false);
            tlpCadastro.ResumeLayout(false);
            tlpCadastro.PerformLayout();
            flowButtons.ResumeLayout(false);
            tbpListagem.ResumeLayout(false);
            pnlDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDados).EndInit();
            pnlExterno.ResumeLayout(false);
            tlpPesquisa.ResumeLayout(false);
            pnlPesquisa.ResumeLayout(false);
            pnlInternoPesquisa.ResumeLayout(false);
            pnlInternoPesquisa.PerformLayout();
            tbcAdministradores.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DateTimePicker dateTimePicker1;
        private TabPage tbpCadastro;
        private Panel pnlConteudoCadastro;
        private TabPage tbpListagem;
        private TabControl tbcAdministradores;
        private DataGridViewTextBoxColumn nomeCompletoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usuarioNomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataCadastroDataGridViewTextBoxColumn;
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
        private TextBox txtObservacoes;
        private Label lblObservacoes;
        private TextBox txtNivelAcesso;
        private Label lblNivelAcesso;
        private DataGridView dgvDados;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn senhaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn nivelAcessoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn observacoesDataGridViewTextBoxColumn;
        private DataGridViewImageColumn imgEditar;
        private DataGridViewImageColumn imgExcluir;
        private TableLayoutPanel tlpPesquisa;
        private Panel pnlPesquisa;
        private Button btnPesquisar;
        private Panel pnlInternoPesquisa;
        private TextBox txtPesquisa;
        private System.Windows.Forms.Button btnAdicionar;
    }
}