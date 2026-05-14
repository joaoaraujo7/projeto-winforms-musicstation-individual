namespace MusicStationWinFormsApp.Models;

public partial class FormaPagamento
{
    public int IdFormaPagamento { get; set; }

    public string Tipo { get; set; } = null!;

    public virtual ICollection<Pagamento> Pagamentos { get; set; } = new List<Pagamento>();
}