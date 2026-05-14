using System;
using System.Collections.Generic;

namespace MusicStationWinFormsApp.Models;

public partial class Avaliacao
{
    public int IdAvaliacao { get; set; }

    public int ServicoPedidoId { get; set; }

    public int ClienteId { get; set; }

    public int Nota { get; set; }

    public string? Comentario { get; set; }

    public DateTime DataAvaliacao { get; set; }

    public virtual Cliente Cliente { get; set; } = null!;

    public virtual ServicoPedido ServicoPedido { get; set; } = null!;
}
