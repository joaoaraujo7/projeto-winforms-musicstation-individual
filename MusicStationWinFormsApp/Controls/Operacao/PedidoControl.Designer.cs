namespace MusicStationWinFormsApp.controls.operacao
{
    partial class PedidoControl
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            tbpCadastro = new TabPage();
            pnlConteudoCadastro = new Panel();
            panel3 = new Panel();
            panel6 = new Panel();
            tlpTotalButtonSalvar = new TableLayoutPanel();
            txtTotal = new TextBox();
            lblTotalPedido = new Label();
            flowButtons = new FlowLayoutPanel();
            btnCancelar = new Button();
            btnSalvar = new Button();
            panel4 = new Panel();
            dgvItensPedido = new DataGridView();
            panel2 = new Panel();
            panel5 = new Panel();
            lblItensPedido = new Label();
            panel1 = new Panel();
            btnAdicionarItem = new Button();
            tlpPedido = new TableLayoutPanel();
            cboCliente = new ComboBox();
            dtpDataPedido = new DateTimePicker();
            lblDataPedido = new Label();
            lblId = new Label();
            lblNomeCliente = new Label();
            lblStatus = new Label();
            txtId = new TextBox();
            cboStatus = new ComboBox();
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
            dataGridViewImageColumn2 = new DataGridViewImageColumn();
            tbpCadastro.SuspendLayout();
            pnlConteudoCadastro.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            tlpTotalButtonSalvar.SuspendLayout();
            flowButtons.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).BeginInit();
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
            panel6.Location = new Point(0, 218);
            panel6.Name = "panel6";
            panel6.Size = new Size(730, 102);
            panel6.TabIndex = 33;
            // 
            // tlpTotalButtonSalvar
            // 
            tlpTotalButtonSalvar.BackColor = SystemColors.Control;
            tlpTotalButtonSalvar.ColumnCount = 2;
            tlpTotalButtonSalvar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.91496F));
            tlpTotalButtonSalvar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.08504F));
            tlpTotalButtonSalvar.Controls.Add(txtTotal, 1, 0);
            tlpTotalButtonSalvar.Controls.Add(lblTotalPedido, 0, 0);
            tlpTotalButtonSalvar.Controls.Add(flowButtons, 1, 1);
            tlpTotalButtonSalvar.Dock = DockStyle.Fill;
            tlpTotalButtonSalvar.Location = new Point(0, 0);
            tlpTotalButtonSalvar.Name = "tlpTotalButtonSalvar";
            tlpTotalButtonSalvar.Padding = new Padding(24, 10, 24, 0);
            tlpTotalButtonSalvar.RowCount = 2;
            tlpTotalButtonSalvar.RowStyles.Add(new RowStyle());
            tlpTotalButtonSalvar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTotalButtonSalvar.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpTotalButtonSalvar.Size = new Size(730, 102);
            tlpTotalButtonSalvar.TabIndex = 16;
            // 
            // txtTotal
            // 
            txtTotal.Dock = DockStyle.Fill;
            txtTotal.Font = new Font("Segoe UI", 10F);
            txtTotal.Location = new Point(156, 13);
            txtTotal.Margin = new Padding(3, 3, 3, 10);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(547, 25);
            txtTotal.TabIndex = 18;
            // 
            // lblTotalPedido
            // 
            lblTotalPedido.AutoSize = true;
            lblTotalPedido.Dock = DockStyle.Fill;
            lblTotalPedido.Font = new Font("Segoe UI", 10F);
            lblTotalPedido.Location = new Point(27, 10);
            lblTotalPedido.Name = "lblTotalPedido";
            lblTotalPedido.Size = new Size(123, 38);
            lblTotalPedido.TabIndex = 17;
            lblTotalPedido.Text = "Total Pedido:";
            lblTotalPedido.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flowButtons
            // 
            flowButtons.Controls.Add(btnCancelar);
            flowButtons.Controls.Add(btnSalvar);
            flowButtons.Dock = DockStyle.Fill;
            flowButtons.FlowDirection = FlowDirection.RightToLeft;
            flowButtons.Location = new Point(153, 48);
            flowButtons.Margin = new Padding(0);
            flowButtons.Name = "flowButtons";
            flowButtons.Size = new Size(553, 54);
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
            panel4.Controls.Add(dgvItensPedido);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 54);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(30, 10, 28, 10);
            panel4.Size = new Size(730, 164);
            panel4.TabIndex = 32;
            // 
            // dgvItensPedido
            // 
            dgvItensPedido.AllowUserToAddRows = false;
            dgvItensPedido.AllowUserToDeleteRows = false;
            dgvItensPedido.AllowUserToOrderColumns = true;
            dgvItensPedido.BackgroundColor = Color.FromArgb(32, 28, 26);
            dgvItensPedido.BorderStyle = BorderStyle.None;
            dgvItensPedido.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvItensPedido.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(28, 24, 22);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(28, 24, 22);
            dataGridViewCellStyle1.SelectionForeColor = Color.Gainsboro;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvItensPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvItensPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItensPedido.Columns.AddRange(new DataGridViewColumn[] { dataGridViewImageColumn2 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(36, 32, 30);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(78, 33, 111);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvItensPedido.DefaultCellStyle = dataGridViewCellStyle2;
            dgvItensPedido.Dock = DockStyle.Fill;
            dgvItensPedido.EnableHeadersVisualStyles = false;
            dgvItensPedido.GridColor = Color.FromArgb(45, 45, 45);
            dgvItensPedido.Location = new Point(30, 10);
            dgvItensPedido.Name = "dgvItensPedido";
            dgvItensPedido.RowHeadersVisible = false;
            dgvItensPedido.RowTemplate.Height = 40;
            dgvItensPedido.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItensPedido.Size = new Size(672, 144);
            dgvItensPedido.TabIndex = 12;
            dgvItensPedido.CellClick += dgvItensPedido_CellClick;
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
            panel5.Controls.Add(lblItensPedido);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 54);
            panel5.TabIndex = 32;
            // 
            // lblItensPedido
            // 
            lblItensPedido.Anchor = AnchorStyles.None;
            lblItensPedido.AutoSize = true;
            lblItensPedido.Location = new Point(27, 15);
            lblItensPedido.Name = "lblItensPedido";
            lblItensPedido.Padding = new Padding(0, 5, 0, 0);
            lblItensPedido.Size = new Size(104, 24);
            lblItensPedido.TabIndex = 0;
            lblItensPedido.Text = "Itens do Pedido";
            lblItensPedido.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAdicionarItem);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(552, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(178, 54);
            panel1.TabIndex = 31;
            // 
            // btnAdicionarItem
            // 
            btnAdicionarItem.BackColor = Color.FromArgb(58, 111, 232);
            btnAdicionarItem.FlatStyle = FlatStyle.Flat;
            btnAdicionarItem.Font = new Font("Segoe UI", 10F);
            btnAdicionarItem.ForeColor = SystemColors.ControlLightLight;
            btnAdicionarItem.Image = Properties.Resources.mais;
            btnAdicionarItem.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdicionarItem.Location = new Point(15, 7);
            btnAdicionarItem.Name = "btnAdicionarItem";
            btnAdicionarItem.Padding = new Padding(3, 0, 0, 0);
            btnAdicionarItem.Size = new Size(136, 40);
            btnAdicionarItem.TabIndex = 31;
            btnAdicionarItem.Text = " Adicionar Item";
            btnAdicionarItem.TextAlign = ContentAlignment.MiddleRight;
            btnAdicionarItem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdicionarItem.UseVisualStyleBackColor = false;
            btnAdicionarItem.Click += btnAdicionarItem_Click;
            // 
            // tlpPedido
            // 
            tlpPedido.BackColor = SystemColors.Control;
            tlpPedido.ColumnCount = 2;
            tlpPedido.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.91496F));
            tlpPedido.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.08504F));
            tlpPedido.Controls.Add(cboCliente, 1, 1);
            tlpPedido.Controls.Add(dtpDataPedido, 1, 2);
            tlpPedido.Controls.Add(lblDataPedido, 0, 2);
            tlpPedido.Controls.Add(lblId, 0, 0);
            tlpPedido.Controls.Add(lblNomeCliente, 0, 1);
            tlpPedido.Controls.Add(lblStatus, 0, 3);
            tlpPedido.Controls.Add(txtId, 1, 0);
            tlpPedido.Controls.Add(cboStatus, 1, 3);
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
            // cboCliente
            // 
            cboCliente.Dock = DockStyle.Fill;
            cboCliente.FormattingEnabled = true;
            cboCliente.Location = new Point(156, 49);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(547, 25);
            cboCliente.TabIndex = 25;
            // 
            // dtpDataPedido
            // 
            dtpDataPedido.Dock = DockStyle.Fill;
            dtpDataPedido.Enabled = false;
            dtpDataPedido.Font = new Font("Segoe UI", 10F);
            dtpDataPedido.Format = DateTimePickerFormat.Custom;
            dtpDataPedido.Location = new Point(156, 80);
            dtpDataPedido.Margin = new Padding(3, 3, 3, 10);
            dtpDataPedido.Name = "dtpDataPedido";
            dtpDataPedido.ShowUpDown = true;
            dtpDataPedido.Size = new Size(547, 25);
            dtpDataPedido.TabIndex = 23;
            dtpDataPedido.Value = new DateTime(2026, 3, 29, 14, 1, 24, 0);
            // 
            // lblDataPedido
            // 
            lblDataPedido.AutoSize = true;
            lblDataPedido.Dock = DockStyle.Fill;
            lblDataPedido.Font = new Font("Segoe UI", 10F);
            lblDataPedido.Location = new Point(27, 77);
            lblDataPedido.Name = "lblDataPedido";
            lblDataPedido.Size = new Size(123, 38);
            lblDataPedido.TabIndex = 22;
            lblDataPedido.Text = "Data Pedido:";
            lblDataPedido.TextAlign = ContentAlignment.MiddleLeft;
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
            // lblNomeCliente
            // 
            lblNomeCliente.AutoSize = true;
            lblNomeCliente.Dock = DockStyle.Fill;
            lblNomeCliente.Font = new Font("Segoe UI", 10F);
            lblNomeCliente.Location = new Point(27, 46);
            lblNomeCliente.Name = "lblNomeCliente";
            lblNomeCliente.Size = new Size(123, 31);
            lblNomeCliente.TabIndex = 0;
            lblNomeCliente.Text = "Cliente:";
            lblNomeCliente.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Dock = DockStyle.Fill;
            lblStatus.Font = new Font("Segoe UI", 10F);
            lblStatus.Location = new Point(27, 115);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(123, 31);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "Status:";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
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
            // cboStatus
            // 
            cboStatus.Dock = DockStyle.Fill;
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(156, 118);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(547, 25);
            cboStatus.TabIndex = 24;
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(28, 24, 22);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(28, 24, 22);
            dataGridViewCellStyle3.SelectionForeColor = Color.Gainsboro;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvDados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDados.Columns.AddRange(new DataGridViewColumn[] { imgEditar, imgExcluir });
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
            // dataGridViewImageColumn2
            // 
            dataGridViewImageColumn2.DataPropertyName = "imgExcluir2";
            dataGridViewImageColumn2.HeaderText = "";
            dataGridViewImageColumn2.Image = Properties.Resources.excluir;
            dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            dataGridViewImageColumn2.ToolTipText = "Excluir";
            dataGridViewImageColumn2.Width = 40;
            // 
            // PedidoControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbcPedidos);
            Name = "PedidoControl";
            Size = new Size(744, 511);
            tbpCadastro.ResumeLayout(false);
            pnlConteudoCadastro.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            tlpTotalButtonSalvar.ResumeLayout(false);
            tlpTotalButtonSalvar.PerformLayout();
            flowButtons.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).EndInit();
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
        private TextBox txtTotal;
        private Label lblTotalPedido;
        private FlowLayoutPanel flowButtons;
        private Button btnCancelar;
        private Button btnSalvar;
        private Panel panel4;
        private DataGridView dgvItensPedido;
        private Panel panel2;
        private Panel panel5;
        private Label lblItensPedido;
        private Panel panel1;
        private Button btnAdicionarItem;
        private TableLayoutPanel tlpPedido;
        private ComboBox cboCliente;
        private DateTimePicker dtpDataPedido;
        private Label lblDataPedido;
        private Label lblId;
        private Label lblNomeCliente;
        private Label lblStatus;
        private TextBox txtId;
        private ComboBox cboStatus;
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
    }
}
