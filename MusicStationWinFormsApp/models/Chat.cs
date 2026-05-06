using System;
using System.Collections.Generic;

namespace MusicStationWinFormsApp.Models;

public partial class Chat
{
    public int IdChat { get; set; }

    public int Usuario1Id { get; set; }

    public int Usuario2Id { get; set; }

    public DateTime DataCriacao { get; set; }

    public virtual ICollection<Mensagem> Mensagens { get; set; } = new List<Mensagem>();

    public virtual Usuario Usuario1 { get; set; } = null!;

    public virtual Usuario Usuario2 { get; set; } = null!;
}
