namespace MusicStationWinFormsApp.controls.comunicacao
{
    partial class AvaliacaoControl
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
            lblDataAvaliacoa = new Label();
            lblId = new Label();
            txtEmail = new TextBox();
            lblNota = new Label();
            txtNota = new TextBox();
            lblItemPedido = new Label();
            lblComentario = new Label();
            lblClienteNome = new Label();
            txtId = new TextBox();
            dtpDataAvaliacao = new DateTimePicker();
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
            tbcAvaliacoes = new TabControl();
            cboCliente = new ComboBox();
            lstItemPedido = new ListBox();
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
            tbcAvaliacoes.SuspendLayout();
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
            tlpCadastro.Controls.Add(lblDataAvaliacoa, 0, 5);
            tlpCadastro.Controls.Add(lblId, 0, 0);
            tlpCadastro.Controls.Add(txtEmail, 1, 2);
            tlpCadastro.Controls.Add(lblNota, 0, 1);
            tlpCadastro.Controls.Add(txtNota, 1, 1);
            tlpCadastro.Controls.Add(lblItemPedido, 0, 4);
            tlpCadastro.Controls.Add(lblComentario, 0, 2);
            tlpCadastro.Controls.Add(lblClienteNome, 0, 3);
            tlpCadastro.Controls.Add(txtId, 1, 0);
            tlpCadastro.Controls.Add(dtpDataAvaliacao, 1, 5);
            tlpCadastro.Controls.Add(flowButtons, 1, 6);
            tlpCadastro.Controls.Add(cboCliente, 1, 3);
            tlpCadastro.Controls.Add(lstItemPedido, 1, 4);
            tlpCadastro.Dock = DockStyle.Fill;
            tlpCadastro.Location = new Point(0, 0);
            tlpCadastro.Name = "tlpCadastro";
            tlpCadastro.Padding = new Padding(24, 24, 24, 0);
            tlpCadastro.RowCount = 7;
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
            // lblDataAvaliacoa
            // 
            lblDataAvaliacoa.AutoSize = true;
            lblDataAvaliacoa.Dock = DockStyle.Fill;
            lblDataAvaliacoa.Font = new Font("Segoe UI", 10F);
            lblDataAvaliacoa.Location = new Point(27, 249);
            lblDataAvaliacoa.Name = "lblDataAvaliacoa";
            lblDataAvaliacoa.Size = new Size(123, 38);
            lblDataAvaliacoa.TabIndex = 14;
            lblDataAvaliacoa.Text = "Data Avaliação:";
            lblDataAvaliacoa.TextAlign = ContentAlignment.MiddleLeft;
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
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(547, 44);
            txtEmail.TabIndex = 3;
            // 
            // lblNota
            // 
            lblNota.AutoSize = true;
            lblNota.Dock = DockStyle.Fill;
            lblNota.Font = new Font("Segoe UI", 10F);
            lblNota.Location = new Point(27, 62);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(123, 38);
            lblNota.TabIndex = 0;
            lblNota.Text = "Nota:";
            lblNota.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNota
            // 
            txtNota.Dock = DockStyle.Fill;
            txtNota.Font = new Font("Segoe UI", 10F);
            txtNota.Location = new Point(156, 65);
            txtNota.Margin = new Padding(3, 3, 3, 10);
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(547, 25);
            txtNota.TabIndex = 1;
            // 
            // lblItemPedido
            // 
            lblItemPedido.AutoSize = true;
            lblItemPedido.Dock = DockStyle.Fill;
            lblItemPedido.Font = new Font("Segoe UI", 10F);
            lblItemPedido.Location = new Point(27, 188);
            lblItemPedido.Name = "lblItemPedido";
            lblItemPedido.Size = new Size(123, 61);
            lblItemPedido.TabIndex = 6;
            lblItemPedido.Text = "Item Pedido:";
            lblItemPedido.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblComentario
            // 
            lblComentario.AutoSize = true;
            lblComentario.Dock = DockStyle.Fill;
            lblComentario.Font = new Font("Segoe UI", 10F);
            lblComentario.Location = new Point(27, 100);
            lblComentario.Name = "lblComentario";
            lblComentario.Size = new Size(123, 57);
            lblComentario.TabIndex = 2;
            lblComentario.Text = "Comentário:";
            lblComentario.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblClienteNome
            // 
            lblClienteNome.AutoSize = true;
            lblClienteNome.Dock = DockStyle.Fill;
            lblClienteNome.Font = new Font("Segoe UI", 10F);
            lblClienteNome.Location = new Point(27, 157);
            lblClienteNome.Name = "lblClienteNome";
            lblClienteNome.Size = new Size(123, 31);
            lblClienteNome.TabIndex = 4;
            lblClienteNome.Text = "Cliente:";
            lblClienteNome.TextAlign = ContentAlignment.MiddleLeft;
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
            // dtpDataAvaliacao
            // 
            dtpDataAvaliacao.Dock = DockStyle.Fill;
            dtpDataAvaliacao.Enabled = false;
            dtpDataAvaliacao.Font = new Font("Segoe UI", 10F);
            dtpDataAvaliacao.Format = DateTimePickerFormat.Custom;
            dtpDataAvaliacao.Location = new Point(156, 252);
            dtpDataAvaliacao.Margin = new Padding(3, 3, 3, 10);
            dtpDataAvaliacao.Name = "dtpDataAvaliacao";
            dtpDataAvaliacao.ShowUpDown = true;
            dtpDataAvaliacao.Size = new Size(547, 25);
            dtpDataAvaliacao.TabIndex = 13;
            dtpDataAvaliacao.Value = new DateTime(2026, 3, 29, 14, 1, 24, 0);
            // 
            // flowButtons
            // 
            flowButtons.Controls.Add(btnCancelar);
            flowButtons.Controls.Add(btnSalvar);
            flowButtons.Dock = DockStyle.Fill;
            flowButtons.FlowDirection = FlowDirection.RightToLeft;
            flowButtons.Location = new Point(153, 287);
            flowButtons.Margin = new Padding(0);
            flowButtons.Name = "flowButtons";
            flowButtons.Size = new Size(553, 188);
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
            // tbcAvaliacoes
            // 
            tbcAvaliacoes.Controls.Add(tbpListagem);
            tbcAvaliacoes.Controls.Add(tbpCadastro);
            tbcAvaliacoes.Dock = DockStyle.Fill;
            tbcAvaliacoes.Font = new Font("Segoe UI", 10F);
            tbcAvaliacoes.ItemSize = new Size(64, 0);
            tbcAvaliacoes.Location = new Point(0, 0);
            tbcAvaliacoes.Name = "tbcAvaliacoes";
            tbcAvaliacoes.SelectedIndex = 0;
            tbcAvaliacoes.Size = new Size(744, 511);
            tbcAvaliacoes.TabIndex = 10;
            // 
            // cboCliente
            // 
            cboCliente.Dock = DockStyle.Fill;
            cboCliente.FormattingEnabled = true;
            cboCliente.Location = new Point(156, 160);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(547, 25);
            cboCliente.TabIndex = 22;
            // 
            // lstItemPedido
            // 
            lstItemPedido.FormattingEnabled = true;
            lstItemPedido.ItemHeight = 17;
            lstItemPedido.Location = new Point(156, 191);
            lstItemPedido.Name = "lstItemPedido";
            lstItemPedido.Size = new Size(547, 55);
            lstItemPedido.TabIndex = 23;
            // 
            // AvaliacaoControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbcAvaliacoes);
            Name = "AvaliacaoControl";
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
            tbcAvaliacoes.ResumeLayout(false);
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
        private TabControl tbcAvaliacoes;
        private Panel pnlPesquisa;
        private DataGridViewTextBoxColumn nomeCompletoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usuarioNomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataCadastroDataGridViewTextBoxColumn;
        private TableLayoutPanel tlpPesquisa;
        private Panel pnlInternoPesquisa;
        private Panel pnlDataGrid;
        private Panel pnlExterno;
        private TableLayoutPanel tlpCadastro;
        private Label lblDataAvaliacoa;
        private Label lblId;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private Label lblNota;
        private TextBox txtNota;
        private Label lblItemPedido;
        private Label lblComentario;
        private Label lblClienteNome;
        private TextBox txtId;
        private DateTimePicker dtpDataAvaliacao;
        private FlowLayoutPanel flowButtons;
        private Button btnCancelar;
        private Button btnSalvar;
        private DataGridView dgvDados;
        private DataGridViewImageColumn imgEditar;
        private DataGridViewImageColumn imgExcluir;
        private ComboBox cboCliente;
        private ListBox lstItemPedido;
    }
}
