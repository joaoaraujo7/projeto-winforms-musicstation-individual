namespace MusicStationWinFormsApp.controls.comunicacao
{
    partial class ChatControl
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            tbpCadastro = new TabPage();
            pnlConteudoCadastro = new Panel();
            panel3 = new Panel();
            panel6 = new Panel();
            tlpTotalButtonSalvar = new TableLayoutPanel();
            flowButtons = new FlowLayoutPanel();
            btnCancelar = new Button();
            btnSalvar = new Button();
            panel4 = new Panel();
            dgvMensagens = new DataGridView();
            dataGridViewImageColumn2 = new DataGridViewImageColumn();
            panel2 = new Panel();
            panel5 = new Panel();
            lblMensagens = new Label();
            panel1 = new Panel();
            btnAdicionarMensagem = new Button();
            tlpPedido = new TableLayoutPanel();
            cboUsuario2 = new ComboBox();
            lblDataCriacao = new Label();
            dtpDataCriacao = new DateTimePicker();
            cboUsuario1 = new ComboBox();
            lblUsuario2 = new Label();
            lblId = new Label();
            lblUsuarioNome = new Label();
            txtId = new TextBox();
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
            tbcPedidos = new TabControl();
            tbpCadastro.SuspendLayout();
            pnlConteudoCadastro.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            tlpTotalButtonSalvar.SuspendLayout();
            flowButtons.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMensagens).BeginInit();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            tlpPedido.SuspendLayout();
            tbpListagem.SuspendLayout();
            tlpPesquisa.SuspendLayout();
            pnlPesquisa.SuspendLayout();
            pnlInternoPesquisa.SuspendLayout();
            pnlDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDados).BeginInit();
            tbcPedidos.SuspendLayout();
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
            pnlConteudoCadastro.Controls.Add(panel3);
            pnlConteudoCadastro.Controls.Add(tlpPedido);
            pnlConteudoCadastro.Dock = DockStyle.Fill;
            pnlConteudoCadastro.Location = new Point(3, 3);
            pnlConteudoCadastro.Name = "pnlConteudoCadastro";
            pnlConteudoCadastro.Size = new Size(730, 475);
            pnlConteudoCadastro.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(panel2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 155);
            panel3.Name = "panel3";
            panel3.Size = new Size(730, 320);
            panel3.TabIndex = 30;
            // 
            // panel6
            // 
            panel6.Controls.Add(tlpTotalButtonSalvar);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 247);
            panel6.Name = "panel6";
            panel6.Size = new Size(730, 73);
            panel6.TabIndex = 33;
            // 
            // tlpTotalButtonSalvar
            // 
            tlpTotalButtonSalvar.BackColor = SystemColors.Control;
            tlpTotalButtonSalvar.ColumnCount = 2;
            tlpTotalButtonSalvar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.91496F));
            tlpTotalButtonSalvar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.08504F));
            tlpTotalButtonSalvar.Controls.Add(flowButtons, 1, 0);
            tlpTotalButtonSalvar.Dock = DockStyle.Fill;
            tlpTotalButtonSalvar.Location = new Point(0, 0);
            tlpTotalButtonSalvar.Name = "tlpTotalButtonSalvar";
            tlpTotalButtonSalvar.Padding = new Padding(24, 10, 24, 0);
            tlpTotalButtonSalvar.RowCount = 1;
            tlpTotalButtonSalvar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTotalButtonSalvar.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpTotalButtonSalvar.Size = new Size(730, 73);
            tlpTotalButtonSalvar.TabIndex = 16;
            // 
            // flowButtons
            // 
            flowButtons.Controls.Add(btnCancelar);
            flowButtons.Controls.Add(btnSalvar);
            flowButtons.Dock = DockStyle.Fill;
            flowButtons.FlowDirection = FlowDirection.RightToLeft;
            flowButtons.Location = new Point(153, 10);
            flowButtons.Margin = new Padding(0);
            flowButtons.Name = "flowButtons";
            flowButtons.Size = new Size(553, 63);
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
            // panel4
            // 
            panel4.Controls.Add(dgvMensagens);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 54);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(30, 10, 28, 10);
            panel4.Size = new Size(730, 193);
            panel4.TabIndex = 32;
            // 
            // dgvMensagens
            // 
            dgvMensagens.AllowUserToAddRows = false;
            dgvMensagens.AllowUserToDeleteRows = false;
            dgvMensagens.AllowUserToOrderColumns = true;
            dgvMensagens.BackgroundColor = Color.FromArgb(32, 28, 26);
            dgvMensagens.BorderStyle = BorderStyle.None;
            dgvMensagens.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMensagens.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(28, 24, 22);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle5.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(28, 24, 22);
            dataGridViewCellStyle5.SelectionForeColor = Color.Gainsboro;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvMensagens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvMensagens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMensagens.Columns.AddRange(new DataGridViewColumn[] { dataGridViewImageColumn2 });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(36, 32, 30);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(78, 33, 111);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvMensagens.DefaultCellStyle = dataGridViewCellStyle6;
            dgvMensagens.Dock = DockStyle.Fill;
            dgvMensagens.EnableHeadersVisualStyles = false;
            dgvMensagens.GridColor = Color.FromArgb(45, 45, 45);
            dgvMensagens.Location = new Point(30, 10);
            dgvMensagens.Name = "dgvMensagens";
            dgvMensagens.RowHeadersVisible = false;
            dgvMensagens.RowTemplate.Height = 40;
            dgvMensagens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMensagens.Size = new Size(672, 173);
            dgvMensagens.TabIndex = 12;
            dgvMensagens.CellClick += dgvItensPedido_CellClick;
            // 
            // dataGridViewImageColumn2
            // 
            dataGridViewImageColumn2.DataPropertyName = "imgExcluir2";
            dataGridViewImageColumn2.HeaderText = "";
            dataGridViewImageColumn2.Image = Properties.Resources.excluir;
            dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            dataGridViewImageColumn2.ToolTipText = "Excluir";
            dataGridViewImageColumn2.Width = 40;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(730, 54);
            panel2.TabIndex = 30;
            // 
            // panel5
            // 
            panel5.Controls.Add(lblMensagens);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 54);
            panel5.TabIndex = 32;
            // 
            // lblMensagens
            // 
            lblMensagens.Anchor = AnchorStyles.None;
            lblMensagens.AutoSize = true;
            lblMensagens.Location = new Point(27, 15);
            lblMensagens.Name = "lblMensagens";
            lblMensagens.Padding = new Padding(0, 5, 0, 0);
            lblMensagens.Size = new Size(79, 24);
            lblMensagens.TabIndex = 0;
            lblMensagens.Text = "Mensagens";
            lblMensagens.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAdicionarMensagem);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(514, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(216, 54);
            panel1.TabIndex = 31;
            // 
            // btnAdicionarMensagem
            // 
            btnAdicionarMensagem.BackColor = Color.FromArgb(58, 111, 232);
            btnAdicionarMensagem.FlatStyle = FlatStyle.Flat;
            btnAdicionarMensagem.Font = new Font("Segoe UI", 10F);
            btnAdicionarMensagem.ForeColor = SystemColors.ControlLightLight;
            btnAdicionarMensagem.Image = Properties.Resources.mais;
            btnAdicionarMensagem.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdicionarMensagem.Location = new Point(15, 7);
            btnAdicionarMensagem.Name = "btnAdicionarMensagem";
            btnAdicionarMensagem.Padding = new Padding(3, 0, 0, 0);
            btnAdicionarMensagem.Size = new Size(176, 40);
            btnAdicionarMensagem.TabIndex = 31;
            btnAdicionarMensagem.Text = " Adicionar Mensagem";
            btnAdicionarMensagem.TextAlign = ContentAlignment.MiddleRight;
            btnAdicionarMensagem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdicionarMensagem.UseVisualStyleBackColor = false;
            btnAdicionarMensagem.Click += btnAdicionarItem_Click;
            // 
            // tlpPedido
            // 
            tlpPedido.BackColor = SystemColors.Control;
            tlpPedido.ColumnCount = 2;
            tlpPedido.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.91496F));
            tlpPedido.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.08504F));
            tlpPedido.Controls.Add(cboUsuario2, 1, 2);
            tlpPedido.Controls.Add(lblDataCriacao, 0, 3);
            tlpPedido.Controls.Add(dtpDataCriacao, 1, 3);
            tlpPedido.Controls.Add(cboUsuario1, 1, 1);
            tlpPedido.Controls.Add(lblUsuario2, 0, 2);
            tlpPedido.Controls.Add(lblId, 0, 0);
            tlpPedido.Controls.Add(lblUsuarioNome, 0, 1);
            tlpPedido.Controls.Add(txtId, 1, 0);
            tlpPedido.Dock = DockStyle.Top;
            tlpPedido.Location = new Point(0, 0);
            tlpPedido.Name = "tlpPedido";
            tlpPedido.Padding = new Padding(24, 8, 24, 0);
            tlpPedido.RowCount = 5;
            tlpPedido.RowStyles.Add(new RowStyle());
            tlpPedido.RowStyles.Add(new RowStyle());
            tlpPedido.RowStyles.Add(new RowStyle());
            tlpPedido.RowStyles.Add(new RowStyle());
            tlpPedido.RowStyles.Add(new RowStyle());
            tlpPedido.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpPedido.Size = new Size(730, 155);
            tlpPedido.TabIndex = 15;
            // 
            // cboUsuario2
            // 
            cboUsuario2.Dock = DockStyle.Fill;
            cboUsuario2.FormattingEnabled = true;
            cboUsuario2.Location = new Point(156, 80);
            cboUsuario2.Name = "cboUsuario2";
            cboUsuario2.Size = new Size(547, 25);
            cboUsuario2.TabIndex = 28;
            // 
            // lblDataCriacao
            // 
            lblDataCriacao.AutoSize = true;
            lblDataCriacao.Dock = DockStyle.Fill;
            lblDataCriacao.Font = new Font("Segoe UI", 10F);
            lblDataCriacao.Location = new Point(27, 108);
            lblDataCriacao.Name = "lblDataCriacao";
            lblDataCriacao.Size = new Size(123, 38);
            lblDataCriacao.TabIndex = 27;
            lblDataCriacao.Text = "Data Criação:";
            lblDataCriacao.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpDataCriacao
            // 
            dtpDataCriacao.Dock = DockStyle.Fill;
            dtpDataCriacao.Enabled = false;
            dtpDataCriacao.Font = new Font("Segoe UI", 10F);
            dtpDataCriacao.Format = DateTimePickerFormat.Custom;
            dtpDataCriacao.Location = new Point(156, 111);
            dtpDataCriacao.Margin = new Padding(3, 3, 3, 10);
            dtpDataCriacao.Name = "dtpDataCriacao";
            dtpDataCriacao.ShowUpDown = true;
            dtpDataCriacao.Size = new Size(547, 25);
            dtpDataCriacao.TabIndex = 26;
            dtpDataCriacao.Value = new DateTime(2026, 3, 29, 14, 1, 24, 0);
            // 
            // cboUsuario1
            // 
            cboUsuario1.Dock = DockStyle.Fill;
            cboUsuario1.FormattingEnabled = true;
            cboUsuario1.Location = new Point(156, 49);
            cboUsuario1.Name = "cboUsuario1";
            cboUsuario1.Size = new Size(547, 25);
            cboUsuario1.TabIndex = 25;
            // 
            // lblUsuario2
            // 
            lblUsuario2.AutoSize = true;
            lblUsuario2.Dock = DockStyle.Fill;
            lblUsuario2.Font = new Font("Segoe UI", 10F);
            lblUsuario2.Location = new Point(27, 77);
            lblUsuario2.Name = "lblUsuario2";
            lblUsuario2.Size = new Size(123, 31);
            lblUsuario2.TabIndex = 22;
            lblUsuario2.Text = "Usuário 2:";
            lblUsuario2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Dock = DockStyle.Fill;
            lblId.Font = new Font("Segoe UI", 10F);
            lblId.Location = new Point(27, 8);
            lblId.Name = "lblId";
            lblId.Size = new Size(123, 38);
            lblId.TabIndex = 10;
            lblId.Text = "Id:";
            lblId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblUsuarioNome
            // 
            lblUsuarioNome.AutoSize = true;
            lblUsuarioNome.Dock = DockStyle.Fill;
            lblUsuarioNome.Font = new Font("Segoe UI", 10F);
            lblUsuarioNome.Location = new Point(27, 46);
            lblUsuarioNome.Name = "lblUsuarioNome";
            lblUsuarioNome.Size = new Size(123, 31);
            lblUsuarioNome.TabIndex = 0;
            lblUsuarioNome.Text = "Usuário 1:";
            lblUsuarioNome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtId
            // 
            txtId.Dock = DockStyle.Fill;
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI", 10F);
            txtId.Location = new Point(156, 11);
            txtId.Margin = new Padding(3, 3, 3, 10);
            txtId.Name = "txtId";
            txtId.Size = new Size(547, 25);
            txtId.TabIndex = 11;
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
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(28, 24, 22);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle7.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(28, 24, 22);
            dataGridViewCellStyle7.SelectionForeColor = Color.Gainsboro;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvDados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDados.Columns.AddRange(new DataGridViewColumn[] { imgEditar, imgExcluir });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(36, 32, 30);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(78, 33, 111);
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvDados.DefaultCellStyle = dataGridViewCellStyle8;
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
            // tbcPedidos
            // 
            tbcPedidos.Controls.Add(tbpListagem);
            tbcPedidos.Controls.Add(tbpCadastro);
            tbcPedidos.Dock = DockStyle.Fill;
            tbcPedidos.Font = new Font("Segoe UI", 10F);
            tbcPedidos.ItemSize = new Size(64, 0);
            tbcPedidos.Location = new Point(0, 0);
            tbcPedidos.Name = "tbcPedidos";
            tbcPedidos.SelectedIndex = 0;
            tbcPedidos.Size = new Size(744, 511);
            tbcPedidos.TabIndex = 10;
            // 
            // ChatControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbcPedidos);
            Name = "ChatControl";
            Size = new Size(744, 511);
            tbpCadastro.ResumeLayout(false);
            pnlConteudoCadastro.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            tlpTotalButtonSalvar.ResumeLayout(false);
            flowButtons.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMensagens).EndInit();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            tlpPedido.ResumeLayout(false);
            tlpPedido.PerformLayout();
            tbpListagem.ResumeLayout(false);
            tlpPesquisa.ResumeLayout(false);
            pnlPesquisa.ResumeLayout(false);
            pnlInternoPesquisa.ResumeLayout(false);
            pnlInternoPesquisa.PerformLayout();
            pnlDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDados).EndInit();
            tbcPedidos.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridViewTextBoxColumn nomeCompletoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usuarioNomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataCadastroDataGridViewTextBoxColumn;
        private TextBox txtSenha;
        private TextBox txtRua;
        private Label lblRua;
        private TextBox txtTelefone;
        private Label lblTelefone;
        private TextBox txtNumero;
        private Label lblNumero;
        private TabPage tbpCadastro;
        private Panel pnlConteudoCadastro;
        private Panel panel3;
        private Panel panel6;
        private TableLayoutPanel tlpTotalButtonSalvar;
        private FlowLayoutPanel flowButtons;
        private Button btnCancelar;
        private Button btnSalvar;
        private Panel panel4;
        private DataGridView dgvMensagens;
        private Panel panel2;
        private Panel panel5;
        private Label lblMensagens;
        private Panel panel1;
        private Button btnAdicionarMensagem;
        private TableLayoutPanel tlpPedido;
        private ComboBox cboUsuario1;
        private Label lblUsuario2;
        private Label lblId;
        private Label lblUsuarioNome;
        private TextBox txtId;
        private TabPage tbpListagem;
        private TableLayoutPanel tlpPesquisa;
        private Panel pnlPesquisa;
        private Button btnPesquisar;
        private Panel pnlInternoPesquisa;
        private TextBox txtPesquisa;
        private Button btnAdicionar;
        private Panel pnlDataGrid;
        private DataGridView dgvDados;
        private Panel pnlExterno;
        private TabControl tbcPedidos;
        private DataGridViewImageColumn imgEditar;
        private DataGridViewImageColumn imgExcluir;
        private DataGridViewImageColumn dataGridViewImageColumn2;
        private Label lblDataCriacao;
        private DateTimePicker dtpDataCriacao;
        private ComboBox cboUsuario2;
    }
}
