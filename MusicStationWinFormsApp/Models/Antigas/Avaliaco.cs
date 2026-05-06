using MusicStationWinFormsApp.models;

namespace MusicStationWinFormsApp.Models;

public partial class Avaliaco
{
    public int IdAvaliacao { get; set; }

    public int ServicoPedidoId { get; set; }

    public int ClienteId { get; set; }

    public int Nota { get; set; }

    public string? Comentario { get; set; }

    public DateTime DataAvaliacao { get; set; }

    public virtual models.Cliente Cliente { get; set; } = null!;

    public virtual ServicosPedido ServicoPedido { get; set; } = null!;
}