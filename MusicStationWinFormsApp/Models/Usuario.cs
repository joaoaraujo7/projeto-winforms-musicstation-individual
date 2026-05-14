using System;
using System.Collections.Generic;

namespace MusicStationWinFormsApp.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string Nome { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string UsuarioNome { get; set; } = null!;

    public string SenhaHash { get; set; } = null!;

    public DateTime DataCadastro { get; set; }

    public virtual Administrador? Administradores { get; set; }

    public virtual ICollection<Chat> ChatsUsuario1 { get; set; } = new List<Chat>();

    public virtual ICollection<Chat> ChatsUsuario2 { get; set; } = new List<Chat>();

    public virtual Cliente? Clientes { get; set; }

    public virtual Empresa? Empresas { get; set; }

    public virtual ICollection<Mensagem> Mensagens { get; set; } = new List<Mensagem>();

    public virtual ICollection<Notificacao> Notificacoes { get; set; } = new List<Notificacao>();

    public virtual Profissional? Profissionais { get; set; }
}
