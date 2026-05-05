using System;
using System.Collections.Generic;
using MusicStationWinFormsApp.models;

namespace MusicStationWinFormsApp.Models;

public partial class LocacaoIten
{
    public int IdItem { get; set; }

    public int LocacaoId { get; set; }

    public int InstrumentoId { get; set; }

    public decimal PrecoLocacao { get; set; }

    public int Dias { get; set; }

    public decimal Subtotal { get; set; }

    public virtual Instrumento Instrumento { get; set; } = null!;

    public virtual Locaco Locacao { get; set; } = null!;
}
