namespace MusicStationWinFormsApp.Models.antigas;

public partial class FormasPagamento
{
    public int IdFormaPagamento { get; set; }

    public string Tipo { get; set; } = null!;

    public virtual ICollection<models.Pagamento> Pagamentos { get; set; } = new List<models.Pagamento>();
}
