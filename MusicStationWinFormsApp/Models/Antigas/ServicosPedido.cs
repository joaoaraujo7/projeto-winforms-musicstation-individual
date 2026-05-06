using MusicStationWinFormsApp.models;

namespace MusicStationWinFormsApp.Models;

public partial class ServicosPedido
{
    public int IdItem { get; set; }

    public int PedidoId { get; set; }

    public int ServicoId { get; set; }

    public int ProfissionalId { get; set; }

    public decimal ValorServico { get; set; }

    public string? Observacao { get; set; }

    public virtual Avaliaco? Avaliaco { get; set; }

    public virtual models.Pedido Pedido { get; set; } = null!;

    public virtual Profissionai Profissional { get; set; } = null!;

    public virtual models.Servico Servico { get; set; } = null!;
}