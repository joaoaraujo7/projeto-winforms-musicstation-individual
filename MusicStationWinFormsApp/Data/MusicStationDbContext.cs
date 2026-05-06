using Microsoft.EntityFrameworkCore;
using MusicStationWinFormsApp.Models;

namespace MusicStationWinFormsApp.Data;

public partial class MusicStationDbContext : DbContext
{
    public MusicStationDbContext()
    {
    }

    public MusicStationDbContext(DbContextOptions<MusicStationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Administrador> Administradores { get; set; }

    public virtual DbSet<Avaliacao> Avaliacoes { get; set; }

    public virtual DbSet<Cargo> Cargos { get; set; }

    public virtual DbSet<Chat> Chats { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Empresa> Empresas { get; set; }

    public virtual DbSet<FormaPagamento> FormasPagamento { get; set; }

    public virtual DbSet<Instrumento> Instrumentos { get; set; }

    public virtual DbSet<LocacaoItem> LocacaoItens { get; set; }

    public virtual DbSet<Locacao> Locacoes { get; set; }

    public virtual DbSet<Mensagem> Mensagens { get; set; }

    public virtual DbSet<Notificacao> Notificacoes { get; set; }

    public virtual DbSet<Pagamento> Pagamentos { get; set; }

    public virtual DbSet<Pedido> Pedidos { get; set; }

    public virtual DbSet<Profissional> Profissionais { get; set; }

    public virtual DbSet<Servico> Servicos { get; set; }

    public virtual DbSet<ServicoPedido> ServicosPedidos { get; set; }

    public virtual DbSet<TransacaoPagamento> TransacoesPagamento { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=MusicStationDB;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Administrador>(entity =>
        {
            entity.HasKey(e => e.IdAdmin).HasName("PK__Administ__4C3F97F4938063B8");

            entity.HasIndex(e => e.UsuarioId, "UQ__Administ__2B3DE7B9E4EFF428").IsUnique();

            entity.Property(e => e.Observacoes)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.Usuario).WithOne(p => p.Administradores)
                .HasForeignKey<Administrador>(d => d.UsuarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Administr__Usuar__412EB0B6");
        });

        modelBuilder.Entity<Avaliacao>(entity =>
        {
            entity.HasKey(e => e.IdAvaliacao).HasName("PK__Avaliaco__78C432D8FAF74B39");

            entity.HasIndex(e => e.ServicoPedidoId, "UQ__Avaliaco__8D33B1E73A804B48").IsUnique();

            entity.Property(e => e.Comentario)
                .HasMaxLength(300)
                .IsUnicode(false);

            entity.HasOne(d => d.Cliente).WithMany(p => p.Avaliacoes)
                .HasForeignKey(d => d.ClienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Avaliacoe__Clien__5BE2A6F2");

            entity.HasOne(d => d.ServicoPedido).WithOne(p => p.Avaliacoes)
                .HasForeignKey<Avaliacao>(d => d.ServicoPedidoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Avaliacoe__Servi__5CD6CB2B");
        });

        modelBuilder.Entity<Cargo>(entity =>
        {
            entity.HasKey(e => e.IdCargo).HasName("PK__Cargos__6C985625C578D44B");

            entity.HasIndex(e => e.Nome, "UQ__Cargos__7D8FE3B2E016F478").IsUnique();

            entity.Property(e => e.Descricao)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Chat>(entity =>
        {
            entity.HasKey(e => e.IdChat).HasName("PK__Chats__3817F38C42A5FCFF");

            entity.HasOne(d => d.Usuario1).WithMany(p => p.ChatsUsuario1)
                .HasForeignKey(d => d.Usuario1Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Chats__Usuario1I__00200768");

            entity.HasOne(d => d.Usuario2).WithMany(p => p.ChatsUsuario2)
                .HasForeignKey(d => d.Usuario2Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Chats__Usuario2I__01142BA1");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.IdCliente).HasName("PK__Clientes__D594664261C0826A");

            entity.HasIndex(e => e.UsuarioId, "UQ__Clientes__2B3DE7B93D8DB8CD").IsUnique();

            entity.Property(e => e.Numero)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Rua)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Telefone)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Usuario).WithOne(p => p.Clientes)
                .HasForeignKey<Cliente>(d => d.UsuarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Clientes__Usuari__3D5E1FD2");
        });

        modelBuilder.Entity<Empresa>(entity =>
        {
            entity.HasKey(e => e.IdEmpresa).HasName("PK__Empresas__5EF4033E8A2ABBB5");

            entity.HasIndex(e => e.UsuarioId, "UQ__Empresas__2B3DE7B9F6D946E7").IsUnique();

            entity.HasIndex(e => e.RazaoSocial, "UQ__Empresas__448779F09807009D").IsUnique();

            entity.HasIndex(e => e.Cnpj, "UQ__Empresas__A299CC929B1B9B6F").IsUnique();

            entity.Property(e => e.Cnpj)
                .HasMaxLength(18)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descricao)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.NomeFantasia)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.RazaoSocial)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Telefone)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Usuario).WithOne(p => p.Empresas)
                .HasForeignKey<Empresa>(d => d.UsuarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Empresas__Usuari__628FA481");
        });

        modelBuilder.Entity<FormaPagamento>(entity =>
        {
            entity.HasKey(e => e.IdFormaPagamento).HasName("PK__FormasPa__848425F8531E724C");

            entity.HasIndex(e => e.Tipo, "UQ__FormasPa__8E762CB47B1C0076").IsUnique();

            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Instrumento>(entity =>
        {
            entity.HasKey(e => e.IdInstrumento).HasName("PK__Instrume__02DD6503A2ABBED5");

            entity.Property(e => e.Descricao)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Disponivel).HasDefaultValue(true);
            entity.Property(e => e.Nome)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.PrecoLocacao).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Empresa).WithMany(p => p.Instrumentos)
                .HasForeignKey(d => d.EmpresaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Instrumen__Empre__66603565");
        });

        modelBuilder.Entity<LocacaoItem>(entity =>
        {
            entity.HasKey(e => e.IdItem).HasName("PK__LocacaoI__51E84262175B44F3");

            entity.HasIndex(e => new { e.LocacaoId, e.InstrumentoId }, "UQ_LocacaoItens").IsUnique();

            entity.Property(e => e.PrecoLocacao).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Subtotal).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Instrumento).WithMany(p => p.LocacaoItens)
                .HasForeignKey(d => d.InstrumentoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__LocacaoIt__Instr__6EF57B66");

            entity.HasOne(d => d.Locacao).WithMany(p => p.LocacaoItens)
                .HasForeignKey(d => d.LocacaoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__LocacaoIt__Locac__6E01572D");
        });

        modelBuilder.Entity<Locacao>(entity =>
        {
            entity.HasKey(e => e.IdLocacao).HasName("PK__Locacoes__A12B2045B81BD028");

            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ValorTotal).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Cliente).WithMany(p => p.Locacoes)
                .HasForeignKey(d => d.ClienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Locacoes__Client__6A30C649");
        });

        modelBuilder.Entity<Mensagem>(entity =>
        {
            entity.HasKey(e => e.IdMensagem).HasName("PK__Mensagen__8F46D1C74CA6C6B9");

            entity.Property(e => e.Conteudo)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.Chat).WithMany(p => p.Mensagens)
                .HasForeignKey(d => d.ChatId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Mensagens__ChatI__08B54D69");

            entity.HasOne(d => d.Remetente).WithMany(p => p.Mensagens)
                .HasForeignKey(d => d.RemetenteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Mensagens__Remet__09A971A2");
        });

        modelBuilder.Entity<Notificacao>(entity =>
        {
            entity.HasKey(e => e.IdNotificacao).HasName("PK__Notifica__046D3872BEF8DFC4");

            entity.Property(e => e.Mensagem)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Titulo)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Usuario).WithMany(p => p.Notificacoes)
                .HasForeignKey(d => d.UsuarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Notificac__Usuar__05D8E0BE");
        });

        modelBuilder.Entity<Pagamento>(entity =>
        {
            entity.HasKey(e => e.IdPagamento).HasName("PK__Pagament__D474651EB6DD2DB9");

            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ValorPago).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.FormaPagamento).WithMany(p => p.Pagamentos)
                .HasForeignKey(d => d.FormaPagamentoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Pagamento__Forma__73BA3083");

            entity.HasOne(d => d.Pedido).WithMany(p => p.Pagamentos)
                .HasForeignKey(d => d.PedidoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Pagamento__Pedid__72C60C4A");
        });

        modelBuilder.Entity<Pedido>(entity =>
        {
            entity.HasKey(e => e.IdPedido).HasName("PK__Pedidos__9D335DC3BE71D79A");

            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Total).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Cliente).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.ClienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Pedidos__Cliente__5165187F");
        });

        modelBuilder.Entity<Profissional>(entity =>
        {
            entity.HasKey(e => e.IdProfissional).HasName("PK__Profissi__B9503FBCD03E7042");

            entity.HasIndex(e => e.UsuarioId, "UQ__Profissi__2B3DE7B9778672FE").IsUnique();

            entity.Property(e => e.Telefone)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Usuario).WithOne(p => p.Profissionais)
                .HasForeignKey<Profissional>(d => d.UsuarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Profissio__Usuar__44FF419A");

            entity.HasMany(d => d.Cargo).WithMany(p => p.Profissional)
                .UsingEntity<Dictionary<string, object>>(
                    "ProfissionalCargo",
                    r => r.HasOne<Cargo>().WithMany()
                        .HasForeignKey("CargoId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Profissio__Cargo__7D439ABD"),
                    l => l.HasOne<Profissional>().WithMany()
                        .HasForeignKey("ProfissionalId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Profissio__Profi__7C4F7684"),
                    j =>
                    {
                        j.HasKey("ProfissionalId", "CargoId").HasName("PK__Profissi__0C0F3CF11F7E0DC2");
                    });
        });

        modelBuilder.Entity<Servico>(entity =>
        {
            entity.HasKey(e => e.IdServico).HasName("PK__Servicos__474DDE3AD2DA01F0");

            entity.HasIndex(e => e.Nome, "UQ__Servicos__7D8FE3B202C59631").IsUnique();

            entity.Property(e => e.Descricao)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Preco).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<ServicoPedido>(entity =>
        {
            entity.HasKey(e => e.IdItem).HasName("PK__Servicos__51E84262E29AD1D3");

            entity.Property(e => e.Observacao)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValue("-");
            entity.Property(e => e.ValorServico).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Pedido).WithMany(p => p.ServicosPedidos)
                .HasForeignKey(d => d.PedidoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ServicosP__Pedid__5535A963");

            entity.HasOne(d => d.Profissional).WithMany(p => p.ServicosPedidos)
                .HasForeignKey(d => d.ProfissionalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ServicosP__Profi__571DF1D5");

            entity.HasOne(d => d.Servico).WithMany(p => p.ServicosPedidos)
                .HasForeignKey(d => d.ServicoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ServicosP__Servi__5629CD9C");
        });

        modelBuilder.Entity<TransacaoPagamento>(entity =>
        {
            entity.HasKey(e => e.IdTransacao).HasName("PK__Transaco__D44F6292C81207A2");

            entity.HasIndex(e => e.CodigoExterno, "UQ__Transaco__67DB613140FBF115").IsUnique();

            entity.HasIndex(e => e.PagamentoId, "UQ__Transaco__977DE7F21695F4DD").IsUnique();

            entity.Property(e => e.CodigoExterno)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Pagamento).WithOne(p => p.TransacoesPagamento)
                .HasForeignKey<TransacaoPagamento>(d => d.PagamentoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Transacoe__Pagam__797309D9");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__Usuarios__5B65BF9785E002FB");

            entity.HasIndex(e => e.UsuarioNome, "UQ__Usuarios__4A3FCF8B5B5D038F").IsUnique();

            entity.HasIndex(e => e.Email, "UQ__Usuarios__A9D10534FEB0BE2E").IsUnique();

            entity.Property(e => e.DataCadastro).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.Email)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.Nome)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.SenhaHash)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioNome)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
