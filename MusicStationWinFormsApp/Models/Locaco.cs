using System;
using System.Collections.Generic;
using MusicStationWinFormsApp.models;

namespace MusicStationWinFormsApp.Models;

public partial class Locaco
{
    public int IdLocacao { get; set; }

    public int ClienteId { get; set; }

    public DateTime DataInicio { get; set; }

    public DateTime DataFim { get; set; }

    public decimal ValorTotal { get; set; }

    public string Status { get; set; } = null!;

    public virtual Cliente Cliente { get; set; } = null!;

    public virtual ICollection<LocacaoIten> LocacaoItens { get; set; } = new List<LocacaoIten>();
}
