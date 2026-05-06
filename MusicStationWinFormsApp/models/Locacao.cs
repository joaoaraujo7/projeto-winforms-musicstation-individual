using System;
using System.Collections.Generic;

namespace MusicStationWinFormsApp.Models;

public partial class Locacao
{
    public int IdLocacao { get; set; }

    public int ClienteId { get; set; }

    public DateTime DataInicio { get; set; }

    public DateTime DataFim { get; set; }

    public decimal ValorTotal { get; set; }

    public string Status { get; set; } = null!;

    public virtual Cliente Cliente { get; set; } = null!;

    public virtual ICollection<LocacaoItem> LocacaoItens { get; set; } = new List<LocacaoItem>();
}
