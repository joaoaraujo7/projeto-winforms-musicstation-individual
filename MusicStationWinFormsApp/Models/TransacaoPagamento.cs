namespace MusicStationWinFormsApp.Models;

public partial class TransacaoPagamento
{
    public int IdTransacao { get; set; }

    public int PagamentoId { get; set; }

    public string Status { get; set; } = null!;

    public string CodigoExterno { get; set; } = null!;

    public DateTime DataTransacao { get; set; }

    public virtual Pagamento Pagamento { get; set; } = null!;
}