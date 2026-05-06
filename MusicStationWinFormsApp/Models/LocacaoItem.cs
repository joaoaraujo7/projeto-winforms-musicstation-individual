using System;
using System.Collections.Generic;

namespace MusicStationWinFormsApp.Models;

public partial class LocacaoItem
{
    public int IdItem { get; set; }

    public int LocacaoId { get; set; }

    public int InstrumentoId { get; set; }

    public decimal PrecoLocacao { get; set; }

    public int Dias { get; set; }

    public decimal Subtotal { get; set; }

    public virtual Instrumento Instrumento { get; set; } = null!;

    public virtual Locacao Locacao { get; set; } = null!;
}
