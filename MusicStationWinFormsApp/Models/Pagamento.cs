namespace MusicStationWinFormsApp.Models;

public partial class Pagamento
{
    public int IdPagamento { get; set; }

    public int PedidoId { get; set; }

    public int FormaPagamentoId { get; set; }

    public DateTime DataPagamento { get; set; }

    public decimal ValorPago { get; set; }

    public string Status { get; set; } = null!;

    public virtual FormaPagamento FormaPagamento { get; set; } = null!;

    public virtual Pedido Pedido { get; set; } = null!;

    public virtual TransacaoPagamento? TransacoesPagamento { get; set; }
}