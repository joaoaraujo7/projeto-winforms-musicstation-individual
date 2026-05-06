using System;
using System.Collections.Generic;

namespace MusicStationWinFormsApp.Models;

public partial class Pedido
{
    public int IdPedido { get; set; }

    public int ClienteId { get; set; }

    public DateTime DataPedido { get; set; }

    public decimal Total { get; set; }

    public string Status { get; set; } = null!;

    public virtual Cliente Cliente { get; set; } = null!;

    public virtual ICollection<Pagamento> Pagamentos { get; set; } = new List<Pagamento>();

    public virtual ICollection<ServicoPedido> ServicosPedidos { get; set; } = new List<ServicoPedido>();
}
