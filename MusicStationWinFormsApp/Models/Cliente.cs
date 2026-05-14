using System;
using System.Collections.Generic;

namespace MusicStationWinFormsApp.Models;

public partial class Cliente
{
    public int IdCliente { get; set; }

    public int UsuarioId { get; set; }

    public string Telefone { get; set; } = null!;

    public string Rua { get; set; } = null!;

    public string Numero { get; set; } = null!;

    public virtual ICollection<Avaliacao> Avaliacoes { get; set; } = new List<Avaliacao>();

    public virtual ICollection<Locacao> Locacoes { get; set; } = new List<Locacao>();

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();

    public virtual Usuario Usuario { get; set; } = null!;
}
