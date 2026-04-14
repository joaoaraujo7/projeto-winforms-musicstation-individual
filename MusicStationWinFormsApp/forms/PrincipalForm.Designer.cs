namespace MusicStationWinFormsApp.forms
{
    partial class PrincipalForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            pnlConteudo = new Panel();
            pnlMenuLateral = new Panel();
            pnlComunicacao = new Panel();
            btnAvaliacoes = new Button();
            btnNotificacoes = new Button();
            btnChats = new Button();
            btnComunicacaoToggle = new Button();
            pnlFinanceiro = new Panel();
            btnFormasPagamento = new Button();
            btnTransacoes = new Button();
            btnPagamentos = new Button();
            btnFinanceiroToggle = new Button();
            pnlOperacoes = new Panel();
            btnLocacoes = new Button();
            btnPedidos = new Button();
            btnOperacoesToggle = new Button();
            pnlInstrumentos = new Panel();
            btnInstrumentos = new Button();
            btnInstrumentosToggle = new Button();
            pnlServicos = new Panel();
            btnCargos = new Button();
            btnServicos = new Button();
            btnServicosToggle = new Button();
            pnlUsuarios = new Panel();
            btnEmpresas = new Button();
            btnClientes = new Button();
            btnProfissionais = new Button();
            btnAdministradores = new Button();
            btnUsuarios = new Button();
            btnUsuariosToggle = new Button();
            btnDashboard = new Button();
            pcoLogo = new PictureBox();
            pnlLogo = new Panel();
            pnlHeader = new Panel();
            pnlAreaPerfil = new Panel();
            btnPerfilToggle = new Button();
            pnlSpacer = new Panel();
            pnlMenuLateral.SuspendLayout();
            pnlComunicacao.SuspendLayout();
            pnlFinanceiro.SuspendLayout();
            pnlOperacoes.SuspendLayout();
            pnlInstrumentos.SuspendLayout();
            pnlServicos.SuspendLayout();
            pnlUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcoLogo).BeginInit();
            pnlLogo.SuspendLayout();
            pnlHeader.SuspendLayout();
            pnlAreaPerfil.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Dock = DockStyle.Left;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Gainsboro;
            lblTitulo.Location = new Point(240, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(400, 70);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestão Entidade Qualquer";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlConteudo
            // 
            pnlConteudo.Dock = DockStyle.Fill;
            pnlConteudo.Location = new Point(240, 70);
            pnlConteudo.Name = "pnlConteudo";
            pnlConteudo.Size = new Size(744, 511);
            pnlConteudo.TabIndex = 1;
            // 
            // pnlMenuLateral
            // 
            pnlMenuLateral.AutoScroll = true;
            pnlMenuLateral.BackColor = Color.FromArgb(28, 24, 22);
            pnlMenuLateral.Controls.Add(pnlComunicacao);
            pnlMenuLateral.Controls.Add(btnComunicacaoToggle);
            pnlMenuLateral.Controls.Add(pnlFinanceiro);
            pnlMenuLateral.Controls.Add(btnFinanceiroToggle);
            pnlMenuLateral.Controls.Add(pnlOperacoes);
            pnlMenuLateral.Controls.Add(btnOperacoesToggle);
            pnlMenuLateral.Controls.Add(pnlInstrumentos);
            pnlMenuLateral.Controls.Add(btnInstrumentosToggle);
            pnlMenuLateral.Controls.Add(pnlServicos);
            pnlMenuLateral.Controls.Add(btnServicosToggle);
            pnlMenuLateral.Controls.Add(pnlUsuarios);
            pnlMenuLateral.Controls.Add(btnUsuariosToggle);
            pnlMenuLateral.Controls.Add(btnDashboard);
            pnlMenuLateral.Dock = DockStyle.Left;
            pnlMenuLateral.ForeColor = Color.Gainsboro;
            pnlMenuLateral.Location = new Point(0, 70);
            pnlMenuLateral.Name = "pnlMenuLateral";
            pnlMenuLateral.Padding = new Padding(0, 0, 1, 0);
            pnlMenuLateral.Size = new Size(240, 511);
            pnlMenuLateral.TabIndex = 0;
            // 
            // pnlComunicacao
            // 
            pnlComunicacao.AutoScroll = true;
            pnlComunicacao.BackColor = Color.FromArgb(36, 32, 30);
            pnlComunicacao.Controls.Add(btnAvaliacoes);
            pnlComunicacao.Controls.Add(btnNotificacoes);
            pnlComunicacao.Controls.Add(btnChats);
            pnlComunicacao.Dock = DockStyle.Top;
            pnlComunicacao.ForeColor = Color.White;
            pnlComunicacao.Location = new Point(0, 842);
            pnlComunicacao.Margin = new Padding(3, 3, 3, 8);
            pnlComunicacao.Name = "pnlComunicacao";
            pnlComunicacao.Size = new Size(222, 122);
            pnlComunicacao.TabIndex = 12;
            // 
            // btnAvaliacoes
            // 
            btnAvaliacoes.Dock = DockStyle.Top;
            btnAvaliacoes.FlatAppearance.BorderSize = 0;
            btnAvaliacoes.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 25, 85);
            btnAvaliacoes.FlatAppearance.MouseOverBackColor = Color.FromArgb(78, 33, 111);
            btnAvaliacoes.FlatStyle = FlatStyle.Flat;
            btnAvaliacoes.ForeColor = Color.Gainsboro;
            btnAvaliacoes.Location = new Point(0, 76);
            btnAvaliacoes.Name = "btnAvaliacoes";
            btnAvaliacoes.Padding = new Padding(28, 0, 16, 0);
            btnAvaliacoes.Size = new Size(222, 38);
            btnAvaliacoes.TabIndex = 2;
            btnAvaliacoes.Text = "Avaliações";
            btnAvaliacoes.TextAlign = ContentAlignment.MiddleLeft;
            btnAvaliacoes.UseVisualStyleBackColor = true;
            btnAvaliacoes.Click += btnAvaliacoes_Click;
            // 
            // btnNotificacoes
            // 
            btnNotificacoes.Dock = DockStyle.Top;
            btnNotificacoes.FlatAppearance.BorderSize = 0;
            btnNotificacoes.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 25, 85);
            btnNotificacoes.FlatAppearance.MouseOverBackColor = Color.FromArgb(78, 33, 111);
            btnNotificacoes.FlatStyle = FlatStyle.Flat;
            btnNotificacoes.ForeColor = Color.Gainsboro;
            btnNotificacoes.Location = new Point(0, 38);
            btnNotificacoes.Name = "btnNotificacoes";
            btnNotificacoes.Padding = new Padding(28, 0, 16, 0);
            btnNotificacoes.Size = new Size(222, 38);
            btnNotificacoes.TabIndex = 1;
            btnNotificacoes.Text = "Notificações";
            btnNotificacoes.TextAlign = ContentAlignment.MiddleLeft;
            btnNotificacoes.UseVisualStyleBackColor = true;
            btnNotificacoes.Click += btnNotificacoes_Click;
            // 
            // btnChats
            // 
            btnChats.Dock = DockStyle.Top;
            btnChats.FlatAppearance.BorderSize = 0;
            btnChats.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 25, 85);
            btnChats.FlatAppearance.MouseOverBackColor = Color.FromArgb(78, 33, 111);
            btnChats.FlatStyle = FlatStyle.Flat;
            btnChats.ForeColor = Color.Gainsboro;
            btnChats.Location = new Point(0, 0);
            btnChats.Name = "btnChats";
            btnChats.Padding = new Padding(28, 0, 16, 0);
            btnChats.Size = new Size(222, 38);
            btnChats.TabIndex = 0;
            btnChats.Text = "Chats";
            btnChats.TextAlign = ContentAlignment.MiddleLeft;
            btnChats.UseVisualStyleBackColor = true;
            btnChats.Click += btnChats_Click;
            // 
            // btnComunicacaoToggle
            // 
            btnComunicacaoToggle.Dock = DockStyle.Top;
            btnComunicacaoToggle.FlatAppearance.BorderSize = 0;
            btnComunicacaoToggle.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 25, 85);
            btnComunicacaoToggle.FlatAppearance.MouseOverBackColor = Color.FromArgb(78, 33, 111);
            btnComunicacaoToggle.FlatStyle = FlatStyle.Flat;
            btnComunicacaoToggle.Font = new Font("Segoe UI", 10F);
            btnComunicacaoToggle.ForeColor = Color.Gainsboro;
            btnComunicacaoToggle.Image = Properties.Resources.seta_direita;
            btnComunicacaoToggle.ImageAlign = ContentAlignment.MiddleRight;
            btnComunicacaoToggle.Location = new Point(0, 798);
            btnComunicacaoToggle.Margin = new Padding(0, 8, 0, 0);
            btnComunicacaoToggle.Name = "btnComunicacaoToggle";
            btnComunicacaoToggle.Padding = new Padding(16, 0, 16, 0);
            btnComunicacaoToggle.Size = new Size(222, 44);
            btnComunicacaoToggle.TabIndex = 11;
            btnComunicacaoToggle.Text = "Comunicação";
            btnComunicacaoToggle.TextAlign = ContentAlignment.MiddleLeft;
            btnComunicacaoToggle.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnComunicacaoToggle.UseVisualStyleBackColor = true;
            btnComunicacaoToggle.Click += btnComunicacaoToggle_Click;
            // 
            // pnlFinanceiro
            // 
            pnlFinanceiro.AutoScroll = true;
            pnlFinanceiro.BackColor = Color.FromArgb(36, 32, 30);
            pnlFinanceiro.Controls.Add(btnFormasPagamento);
            pnlFinanceiro.Controls.Add(btnTransacoes);
            pnlFinanceiro.Controls.Add(btnPagamentos);
            pnlFinanceiro.Dock = DockStyle.Top;
            pnlFinanceiro.ForeColor = Color.White;
            pnlFinanceiro.Location = new Point(0, 676);
            pnlFinanceiro.Margin = new Padding(3, 3, 3, 8);
            pnlFinanceiro.Name = "pnlFinanceiro";
            pnlFinanceiro.Size = new Size(222, 122);
            pnlFinanceiro.TabIndex = 10;
            // 
            // btnFormasPagamento
            // 
            btnFormasPagamento.Dock = DockStyle.Top;
            btnFormasPagamento.FlatAppearance.BorderSize = 0;
            btnFormasPagamento.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 25, 85);
            btnFormasPagamento.FlatAppearance.MouseOverBackColor = Color.FromArgb(78, 33, 111);
            btnFormasPagamento.FlatStyle = FlatStyle.Flat;
            btnFormasPagamento.ForeColor = Color.Gainsboro;
            btnFormasPagamento.Location = new Point(0, 76);
            btnFormasPagamento.Name = "btnFormasPagamento";
            btnFormasPagamento.Padding = new Padding(28, 0, 16, 0);
            btnFormasPagamento.Size = new Size(222, 38);
            btnFormasPagamento.TabIndex = 2;
            btnFormasPagamento.Text = "Formas de Pagamento";
            btnFormasPagamento.TextAlign = ContentAlignment.MiddleLeft;
            btnFormasPagamento.UseVisualStyleBackColor = true;
            btnFormasPagamento.Click += btnFormasPagamento_Click;
            // 
            // btnTransacoes
            // 
            btnTransacoes.Dock = DockStyle.Top;
            btnTransacoes.FlatAppearance.BorderSize = 0;
            btnTransacoes.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 25, 85);
            btnTransacoes.FlatAppearance.MouseOverBackColor = Color.FromArgb(78, 33, 111);
            btnTransacoes.FlatStyle = FlatStyle.Flat;
            btnTransacoes.ForeColor = Color.Gainsboro;
            btnTransacoes.Location = new Point(0, 38);
            btnTransacoes.Name = "btnTransacoes";
            btnTransacoes.Padding = new Padding(28, 0, 16, 0);
            btnTransacoes.Size = new Size(222, 38);
            btnTransacoes.TabIndex = 1;
            btnTransacoes.Text = "Transações";
            btnTransacoes.TextAlign = ContentAlignment.MiddleLeft;
            btnTransacoes.UseVisualStyleBackColor = true;
            btnTransacoes.Click += btnTransacoes_Click;
            // 
            // btnPagamentos
            // 
            btnPagamentos.Dock = DockStyle.Top;
            btnPagamentos.FlatAppearance.BorderSize = 0;
            btnPagamentos.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 25, 85);
            btnPagamentos.FlatAppearance.MouseOverBackColor = Color.FromArgb(78, 33, 111);
            btnPagamentos.FlatStyle = FlatStyle.Flat;
            btnPagamentos.ForeColor = Color.Gainsboro;
            btnPagamentos.Location = new Point(0, 0);
            btnPagamentos.Name = "btnPagamentos";
            btnPagamentos.Padding = new Padding(28, 0, 16, 0);
            btnPagamentos.Size = new Size(222, 38);
            btnPagamentos.TabIndex = 0;
            btnPagamentos.Text = "Pagamentos";
            btnPagamentos.TextAlign = ContentAlignment.MiddleLeft;
            btnPagamentos.UseVisualStyleBackColor = true;
            btnPagamentos.Click += btnPagamentos_Click;
            // 
            // btnFinanceiroToggle
            // 
            btnFinanceiroToggle.Dock = DockStyle.Top;
            btnFinanceiroToggle.FlatAppearance.BorderSize = 0;
            btnFinanceiroToggle.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 25, 85);
            btnFinanceiroToggle.FlatAppearance.MouseOverBackColor = Color.FromArgb(78, 33, 111);
            btnFinanceiroToggle.FlatStyle = FlatStyle.Flat;
            btnFinanceiroToggle.Font = new Font("Segoe UI", 10F);
            btnFinanceiroToggle.ForeColor = Color.Gainsboro;
            btnFinanceiroToggle.Image = Properties.Resources.seta_direita;
            btnFinanceiroToggle.ImageAlign = ContentAlignment.MiddleRight;
            btnFinanceiroToggle.Location = new Point(0, 632);
            btnFinanceiroToggle.Margin = new Padding(0, 8, 0, 0);
            btnFinanceiroToggle.Name = "btnFinanceiroToggle";
            btnFinanceiroToggle.Padding = new Padding(16, 0, 16, 0);
            btnFinanceiroToggle.Size = new Size(222, 44);
            btnFinanceiroToggle.TabIndex = 9;
            btnFinanceiroToggle.Text = "Financeiro";
            btnFinanceiroToggle.TextAlign = ContentAlignment.MiddleLeft;
            btnFinanceiroToggle.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnFinanceiroToggle.UseVisualStyleBackColor = true;
            btnFinanceiroToggle.Click += btnFinanceiroToggle_Click;
            // 
            // pnlOperacoes
            // 
            pnlOperacoes.AutoScroll = true;
            pnlOperacoes.BackColor = Color.FromArgb(36, 32, 30);
            pnlOperacoes.Controls.Add(btnLocacoes);
            pnlOperacoes.Controls.Add(btnPedidos);
            pnlOperacoes.Dock = DockStyle.Top;
            pnlOperacoes.ForeColor = Color.White;
            pnlOperacoes.Location = new Point(0, 548);
            pnlOperacoes.Margin = new Padding(3, 3, 3, 8);
            pnlOperacoes.Name = "pnlOperacoes";
            pnlOperacoes.Size = new Size(222, 84);
            pnlOperacoes.TabIndex = 8;
            // 
            // btnLocacoes
            // 
            btnLocacoes.Dock = DockStyle.Top;
            btnLocacoes.FlatAppearance.BorderSize = 0;
            btnLocacoes.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 25, 85);
            btnLocacoes.FlatAppearance.MouseOverBackColor = Color.FromArgb(78, 33, 111);
            btnLocacoes.FlatStyle = FlatStyle.Flat;
            btnLocacoes.ForeColor = Color.Gainsboro;
            btnLocacoes.Location = new Point(0, 38);
            btnLocacoes.Name = "btnLocacoes";
            btnLocacoes.Padding = new Padding(28, 0, 16, 0);
            btnLocacoes.Size = new Size(222, 38);
            btnLocacoes.TabIndex = 1;
            btnLocacoes.Text = "Locações";
            btnLocacoes.TextAlign = ContentAlignment.MiddleLeft;
            btnLocacoes.UseVisualStyleBackColor = true;
            btnLocacoes.Click += btnLocacoes_Click;
            // 
            // btnPedidos
            // 
            btnPedidos.Dock = DockStyle.Top;
            btnPedidos.FlatAppearance.BorderSize = 0;
            btnPedidos.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 25, 85);
            btnPedidos.FlatAppearance.MouseOverBackColor = Color.FromArgb(78, 33, 111);
            btnPedidos.FlatStyle = FlatStyle.Flat;
            btnPedidos.ForeColor = Color.Gainsboro;
            btnPedidos.Location = new Point(0, 0);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Padding = new Padding(28, 0, 16, 0);
            btnPedidos.Size = new Size(222, 38);
            btnPedidos.TabIndex = 0;
            btnPedidos.Text = "Pedidos";
            btnPedidos.TextAlign = ContentAlignment.MiddleLeft;
            btnPedidos.UseVisualStyleBackColor = true;
            btnPedidos.Click += btnPedidos_Click;
            // 
            // btnOperacoesToggle
            // 
            btnOperacoesToggle.Dock = DockStyle.Top;
            btnOperacoesToggle.FlatAppearance.BorderSize = 0;
            btnOperacoesToggle.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 25, 85);
            btnOperacoesToggle.FlatAppearance.MouseOverBackColor = Color.FromArgb(78, 33, 111);
            btnOperacoesToggle.FlatStyle = FlatStyle.Flat;
            btnOperacoesToggle.Font = new Font("Segoe UI", 10F);
            btnOperacoesToggle.ForeColor = Color.Gainsboro;
            btnOperacoesToggle.Image = Properties.Resources.seta_direita;
            btnOperacoesToggle.ImageAlign = ContentAlignment.MiddleRight;
            btnOperacoesToggle.Location = new Point(0, 504);
            btnOperacoesToggle.Margin = new Padding(0, 8, 0, 0);
            btnOperacoesToggle.Name = "btnOperacoesToggle";
            btnOperacoesToggle.Padding = new Padding(16, 0, 16, 0);
            btnOperacoesToggle.Size = new Size(222, 44);
            btnOperacoesToggle.TabIndex = 7;
            btnOperacoesToggle.Text = "Operações";
            btnOperacoesToggle.TextAlign = ContentAlignment.MiddleLeft;
            btnOperacoesToggle.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnOperacoesToggle.UseVisualStyleBackColor = true;
            btnOperacoesToggle.Click += btnOperacoesToggle_Click;
            // 
            // pnlInstrumentos
            // 
            pnlInstrumentos.AutoScroll = true;
            pnlInstrumentos.BackColor = Color.FromArgb(36, 32, 30);
            pnlInstrumentos.Controls.Add(btnInstrumentos);
            pnlInstrumentos.Dock = DockStyle.Top;
            pnlInstrumentos.ForeColor = Color.White;
            pnlInstrumentos.Location = new Point(0, 458);
            pnlInstrumentos.Margin = new Padding(3, 3, 3, 8);
            pnlInstrumentos.Name = "pnlInstrumentos";
            pnlInstrumentos.Size = new Size(222, 46);
            pnlInstrumentos.TabIndex = 6;
            // 
            // btnInstrumentos
            // 
            btnInstrumentos.Dock = DockStyle.Top;
            btnInstrumentos.FlatAppearance.BorderSize = 0;
            btnInstrumentos.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 25, 85);
            btnInstrumentos.FlatAppearance.MouseOverBackColor = Color.FromArgb(78, 33, 111);
            btnInstrumentos.FlatStyle = FlatStyle.Flat;
            btnInstrumentos.ForeColor = Color.Gainsboro;
            btnInstrumentos.Location = new Point(0, 0);
            btnInstrumentos.Name = "btnInstrumentos";
            btnInstrumentos.Padding = new Padding(28, 0, 16, 0);
            btnInstrumentos.Size = new Size(222, 38);
            btnInstrumentos.TabIndex = 0;
            btnInstrumentos.Text = "Instrumentos";
            btnInstrumentos.TextAlign = ContentAlignment.MiddleLeft;
            btnInstrumentos.UseVisualStyleBackColor = true;
            btnInstrumentos.Click += btnInstrumentos_Click;
            // 
            // btnInstrumentosToggle
            // 
            btnInstrumentosToggle.Dock = DockStyle.Top;
            btnInstrumentosToggle.FlatAppearance.BorderSize = 0;
            btnInstrumentosToggle.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 25, 85);
            btnInstrumentosToggle.FlatAppearance.MouseOverBackColor = Color.FromArgb(78, 33, 111);
            btnInstrumentosToggle.FlatStyle = FlatStyle.Flat;
            btnInstrumentosToggle.Font = new Font("Segoe UI", 10F);
            btnInstrumentosToggle.ForeColor = Color.Gainsboro;
            btnInstrumentosToggle.Image = Properties.Resources.seta_direita;
            btnInstrumentosToggle.ImageAlign = ContentAlignment.MiddleRight;
            btnInstrumentosToggle.Location = new Point(0, 414);
            btnInstrumentosToggle.Margin = new Padding(0, 8, 0, 0);
            btnInstrumentosToggle.Name = "btnInstrumentosToggle";
            btnInstrumentosToggle.Padding = new Padding(16, 0, 16, 0);
            btnInstrumentosToggle.Size = new Size(222, 44);
            btnInstrumentosToggle.TabIndex = 5;
            btnInstrumentosToggle.Text = "Instrumentos";
            btnInstrumentosToggle.TextAlign = ContentAlignment.MiddleLeft;
            btnInstrumentosToggle.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnInstrumentosToggle.UseVisualStyleBackColor = true;
            btnInstrumentosToggle.Click += btnInstrumentosToggle_Click;
            // 
            // pnlServicos
            // 
            pnlServicos.AutoScroll = true;
            pnlServicos.BackColor = Color.FromArgb(36, 32, 30);
            pnlServicos.Controls.Add(btnCargos);
            pnlServicos.Controls.Add(btnServicos);
            pnlServicos.Dock = DockStyle.Top;
            pnlServicos.ForeColor = Color.White;
            pnlServicos.Location = new Point(0, 330);
            pnlServicos.Margin = new Padding(3, 3, 3, 8);
            pnlServicos.Name = "pnlServicos";
            pnlServicos.Size = new Size(222, 84);
            pnlServicos.TabIndex = 3;
            // 
            // btnCargos
            // 
            btnCargos.Dock = DockStyle.Top;
            btnCargos.FlatAppearance.BorderSize = 0;
            btnCargos.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 25, 85);
            btnCargos.FlatAppearance.MouseOverBackColor = Color.FromArgb(78, 33, 111);
            btnCargos.FlatStyle = FlatStyle.Flat;
            btnCargos.ForeColor = Color.Gainsboro;
            btnCargos.Location = new Point(0, 38);
            btnCargos.Name = "btnCargos";
            btnCargos.Padding = new Padding(28, 0, 16, 0);
            btnCargos.Size = new Size(222, 38);
            btnCargos.TabIndex = 1;
            btnCargos.Text = "Cargos";
            btnCargos.TextAlign = ContentAlignment.MiddleLeft;
            btnCargos.UseVisualStyleBackColor = true;
            btnCargos.Click += btnCargos_Click;
            // 
            // btnServicos
            // 
            btnServicos.Dock = DockStyle.Top;
            btnServicos.FlatAppearance.BorderSize = 0;
            btnServicos.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 25, 85);
            btnServicos.FlatAppearance.MouseOverBackColor = Color.FromArgb(78, 33, 111);
            btnServicos.FlatStyle = FlatStyle.Flat;
            btnServicos.ForeColor = Color.Gainsboro;
            btnServicos.Location = new Point(0, 0);
            btnServicos.Name = "btnServicos";
            btnServicos.Padding = new Padding(28, 0, 16, 0);
            btnServicos.Size = new Size(222, 38);
            btnServicos.TabIndex = 0;
            btnServicos.Text = "Serviços";
            btnServicos.TextAlign = ContentAlignment.MiddleLeft;
            btnServicos.UseVisualStyleBackColor = true;
            btnServicos.Click += btnServicos_Click;
            // 
            // btnServicosToggle
            // 
            btnServicosToggle.Dock = DockStyle.Top;
            btnServicosToggle.FlatAppearance.BorderSize = 0;
            btnServicosToggle.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 25, 85);
            btnServicosToggle.FlatAppearance.MouseOverBackColor = Color.FromArgb(78, 33, 111);
            btnServicosToggle.FlatStyle = FlatStyle.Flat;
            btnServicosToggle.Font = new Font("Segoe UI", 10F);
            btnServicosToggle.ForeColor = Color.Gainsboro;
            btnServicosToggle.Image = Properties.Resources.seta_direita;
            btnServicosToggle.ImageAlign = ContentAlignment.MiddleRight;
            btnServicosToggle.Location = new Point(0, 286);
            btnServicosToggle.Margin = new Padding(0, 8, 0, 0);
            btnServicosToggle.Name = "btnServicosToggle";
            btnServicosToggle.Padding = new Padding(16, 0, 16, 0);
            btnServicosToggle.Size = new Size(222, 44);
            btnServicosToggle.TabIndex = 4;
            btnServicosToggle.Text = "Serviços";
            btnServicosToggle.TextAlign = ContentAlignment.MiddleLeft;
            btnServicosToggle.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnServicosToggle.UseVisualStyleBackColor = true;
            btnServicosToggle.Click += btnServicosToggle_Click;
            // 
            // pnlUsuarios
            // 
            pnlUsuarios.AutoScroll = true;
            pnlUsuarios.BackColor = Color.FromArgb(36, 32, 30);
            pnlUsuarios.Controls.Add(btnEmpresas);
            pnlUsuarios.Controls.Add(btnClientes);
            pnlUsuarios.Controls.Add(btnProfissionais);
            pnlUsuarios.Controls.Add(btnAdministradores);
            pnlUsuarios.Controls.Add(btnUsuarios);
            pnlUsuarios.Dock = DockStyle.Top;
            pnlUsuarios.ForeColor = Color.White;
            pnlUsuarios.Location = new Point(0, 88);
            pnlUsuarios.Margin = new Padding(3, 3, 3, 8);
            pnlUsuarios.Name = "pnlUsuarios";
            pnlUsuarios.Size = new Size(222, 198);
            pnlUsuarios.TabIndex = 0;
            // 
            // btnEmpresas
            // 
            btnEmpresas.Dock = DockStyle.Top;
            btnEmpresas.FlatAppearance.BorderSize = 0;
            btnEmpresas.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 25, 85);
            btnEmpresas.FlatAppearance.MouseOverBackColor = Color.FromArgb(78, 33, 111);
            btnEmpresas.FlatStyle = FlatStyle.Flat;
            btnEmpresas.ForeColor = Color.Gainsboro;
            btnEmpresas.Location = new Point(0, 152);
            btnEmpresas.Name = "btnEmpresas";
            btnEmpresas.Padding = new Padding(28, 0, 16, 0);
            btnEmpresas.Size = new Size(222, 38);
            btnEmpresas.TabIndex = 4;
            btnEmpresas.Text = "Empresas";
            btnEmpresas.TextAlign = ContentAlignment.MiddleLeft;
            btnEmpresas.UseVisualStyleBackColor = true;
            btnEmpresas.Click += btnEmpresas_Click;
            // 
            // btnClientes
            // 
            btnClientes.Dock = DockStyle.Top;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 25, 85);
            btnClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(78, 33, 111);
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.ForeColor = Color.Gainsboro;
            btnClientes.Location = new Point(0, 114);
            btnClientes.Name = "btnClientes";
            btnClientes.Padding = new Padding(28, 0, 16, 0);
            btnClientes.Size = new Size(222, 38);
            btnClientes.TabIndex = 3;
            btnClientes.Text = "Clientes";
            btnClientes.TextAlign = ContentAlignment.MiddleLeft;
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnProfissionais
            // 
            btnProfissionais.Dock = DockStyle.Top;
            btnProfissionais.FlatAppearance.BorderSize = 0;
            btnProfissionais.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 25, 85);
            btnProfissionais.FlatAppearance.MouseOverBackColor = Color.FromArgb(78, 33, 111);
            btnProfissionais.FlatStyle = FlatStyle.Flat;
            btnProfissionais.ForeColor = Color.Gainsboro;
            btnProfissionais.Location = new Point(0, 76);
            btnProfissionais.Name = "btnProfissionais";
            btnProfissionais.Padding = new Padding(28, 0, 16, 0);
            btnProfissionais.Size = new Size(222, 38);
            btnProfissionais.TabIndex = 2;
            btnProfissionais.Text = "Profissionais";
            btnProfissionais.TextAlign = ContentAlignment.MiddleLeft;
            btnProfissionais.UseVisualStyleBackColor = true;
            btnProfissionais.Click += btnProfissionais_Click;
            // 
            // btnAdministradores
            // 
            btnAdministradores.Dock = DockStyle.Top;
            btnAdministradores.FlatAppearance.BorderSize = 0;
            btnAdministradores.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 25, 85);
            btnAdministradores.FlatAppearance.MouseOverBackColor = Color.FromArgb(78, 33, 111);
            btnAdministradores.FlatStyle = FlatStyle.Flat;
            btnAdministradores.ForeColor = Color.Gainsboro;
            btnAdministradores.Location = new Point(0, 38);
            btnAdministradores.Name = "btnAdministradores";
            btnAdministradores.Padding = new Padding(28, 0, 16, 0);
            btnAdministradores.Size = new Size(222, 38);
            btnAdministradores.TabIndex = 1;
            btnAdministradores.Text = "Administradores";
            btnAdministradores.TextAlign = ContentAlignment.MiddleLeft;
            btnAdministradores.UseVisualStyleBackColor = true;
            btnAdministradores.Click += btnAdministradores_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Dock = DockStyle.Top;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 25, 85);
            btnUsuarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(78, 33, 111);
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.ForeColor = Color.Gainsboro;
            btnUsuarios.Location = new Point(0, 0);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Padding = new Padding(28, 0, 16, 0);
            btnUsuarios.Size = new Size(222, 38);
            btnUsuarios.TabIndex = 0;
            btnUsuarios.Text = "Usuários";
            btnUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnUsuariosToggle
            // 
            btnUsuariosToggle.Dock = DockStyle.Top;
            btnUsuariosToggle.FlatAppearance.BorderSize = 0;
            btnUsuariosToggle.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 25, 85);
            btnUsuariosToggle.FlatAppearance.MouseOverBackColor = Color.FromArgb(78, 33, 111);
            btnUsuariosToggle.FlatStyle = FlatStyle.Flat;
            btnUsuariosToggle.Font = new Font("Segoe UI", 10F);
            btnUsuariosToggle.ForeColor = Color.Gainsboro;
            btnUsuariosToggle.Image = Properties.Resources.seta_direita;
            btnUsuariosToggle.ImageAlign = ContentAlignment.MiddleRight;
            btnUsuariosToggle.Location = new Point(0, 44);
            btnUsuariosToggle.Margin = new Padding(0, 8, 0, 0);
            btnUsuariosToggle.Name = "btnUsuariosToggle";
            btnUsuariosToggle.Padding = new Padding(16, 0, 16, 0);
            btnUsuariosToggle.Size = new Size(222, 44);
            btnUsuariosToggle.TabIndex = 1;
            btnUsuariosToggle.Text = "Gestão Usuários\r\n";
            btnUsuariosToggle.TextAlign = ContentAlignment.MiddleLeft;
            btnUsuariosToggle.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnUsuariosToggle.UseVisualStyleBackColor = true;
            btnUsuariosToggle.Click += btnUsuariosToggle_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(78, 33, 111);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 10F);
            btnDashboard.ForeColor = Color.Gainsboro;
            btnDashboard.Location = new Point(0, 0);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(16, 0, 0, 0);
            btnDashboard.Size = new Size(222, 44);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // pcoLogo
            // 
            pcoLogo.Dock = DockStyle.Fill;
            pcoLogo.Image = Properties.Resources.music_station_vetorizada;
            pcoLogo.Location = new Point(8, 8);
            pcoLogo.Margin = new Padding(0);
            pcoLogo.Name = "pcoLogo";
            pcoLogo.Size = new Size(224, 54);
            pcoLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pcoLogo.TabIndex = 0;
            pcoLogo.TabStop = false;
            // 
            // pnlLogo
            // 
            pnlLogo.Controls.Add(pcoLogo);
            pnlLogo.Dock = DockStyle.Left;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Padding = new Padding(8);
            pnlLogo.Size = new Size(240, 70);
            pnlLogo.TabIndex = 0;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(32, 28, 26);
            pnlHeader.Controls.Add(pnlAreaPerfil);
            pnlHeader.Controls.Add(pnlSpacer);
            pnlHeader.Controls.Add(lblTitulo);
            pnlHeader.Controls.Add(pnlLogo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(984, 70);
            pnlHeader.TabIndex = 1;
            // 
            // pnlAreaPerfil
            // 
            pnlAreaPerfil.Controls.Add(btnPerfilToggle);
            pnlAreaPerfil.Dock = DockStyle.Right;
            pnlAreaPerfil.Location = new Point(684, 0);
            pnlAreaPerfil.Name = "pnlAreaPerfil";
            pnlAreaPerfil.Size = new Size(300, 70);
            pnlAreaPerfil.TabIndex = 1;
            // 
            // btnPerfilToggle
            // 
            btnPerfilToggle.Dock = DockStyle.Fill;
            btnPerfilToggle.FlatAppearance.BorderSize = 0;
            btnPerfilToggle.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 25, 85);
            btnPerfilToggle.FlatAppearance.MouseOverBackColor = Color.FromArgb(78, 33, 111);
            btnPerfilToggle.FlatStyle = FlatStyle.Flat;
            btnPerfilToggle.Font = new Font("Segoe UI", 10F);
            btnPerfilToggle.ForeColor = Color.Gainsboro;
            btnPerfilToggle.Image = Properties.Resources.usuario_branco;
            btnPerfilToggle.ImageAlign = ContentAlignment.MiddleRight;
            btnPerfilToggle.Location = new Point(0, 0);
            btnPerfilToggle.Name = "btnPerfilToggle";
            btnPerfilToggle.Padding = new Padding(0, 0, 40, 0);
            btnPerfilToggle.Size = new Size(300, 70);
            btnPerfilToggle.TabIndex = 0;
            btnPerfilToggle.TabStop = false;
            btnPerfilToggle.Text = "{nomeUsuario} ({cargo})";
            btnPerfilToggle.TextAlign = ContentAlignment.MiddleLeft;
            btnPerfilToggle.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnPerfilToggle.UseVisualStyleBackColor = true;
            btnPerfilToggle.Click += btnPerfilToggle_Click;
            btnPerfilToggle.Enter += btnPerfilToggle_Enter;
            // 
            // pnlSpacer
            // 
            pnlSpacer.Dock = DockStyle.Fill;
            pnlSpacer.Location = new Point(640, 0);
            pnlSpacer.Name = "pnlSpacer";
            pnlSpacer.Size = new Size(344, 70);
            pnlSpacer.TabIndex = 0;
            // 
            // PrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 581);
            Controls.Add(pnlConteudo);
            Controls.Add(pnlMenuLateral);
            Controls.Add(pnlHeader);
            Name = "PrincipalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Music Station";
            FormClosing += PrincipalForm_FormClosing;
            pnlMenuLateral.ResumeLayout(false);
            pnlComunicacao.ResumeLayout(false);
            pnlFinanceiro.ResumeLayout(false);
            pnlOperacoes.ResumeLayout(false);
            pnlInstrumentos.ResumeLayout(false);
            pnlServicos.ResumeLayout(false);
            pnlUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcoLogo).EndInit();
            pnlLogo.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlAreaPerfil.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlUsuarios;
        private Button btnEmpresa;
        private Button btnCliente;
        private Button btnProfissional;
        private Button btnAdministrador;
        private Button btnGestaoUusuarios;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label lblTitulo;
        private Panel pnlConteudo;
        private Panel pnlMenuLateral;
        private Button btnUsuariosToggle;
        private Button btnUsuarios;
        private Button btnDashboard;
        private Panel pnlLogo;
        private PictureBox pcoLogo;
        private Panel pnlHeader;
        private Button btnProfissionais;
        private Button btnAdministradores;
        private Button btnClientes;
        private Button btnEmpresas;
        private Panel pnlServicos;
        private Button btnCargos;
        private Button btnServicos;
        private Button btnServicosToggle;
        private PictureBox pictureBox1;
        private Button btnInstrumentosToggle;
        private Panel pnlInstrumentos;
        private Button btnInstrumentos;
        private Panel pnlOperacoes;
        private Button btnLocacoes;
        private Button btnPedidos;
        private Button btnOperacoesToggle;
        private Panel pnlFinanceiro;
        private Button btnFormasPagamento;
        private Button btnTransacoes;
        private Button btnPagamentos;
        private Button btnFinanceiroToggle;
        private Panel pnlComunicacao;
        private Button btnAvaliacoes;
        private Button btnNotificacoes;
        private Button btnChats;
        private Button btnComunicacaoToggle;
        private Button btnPerfilToggle;
        private Panel pnlSpacer;
        private Panel pnlAreaPerfil;
    }
}