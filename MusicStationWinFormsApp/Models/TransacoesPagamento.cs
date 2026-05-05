using System;
using System.Collections.Generic;
using MusicStationWinFormsApp.models;

namespace MusicStationWinFormsApp.Models;

public partial class TransacoesPagamento
{
    public int IdTransacao { get; set; }

    public int PagamentoId { get; set; }

    public string Status { get; set; } = null!;

    public string CodigoExterno { get; set; } = null!;

    public DateTime DataTransacao { get; set; }

    public virtual Pagamento Pagamento { get; set; } = null!;
}
