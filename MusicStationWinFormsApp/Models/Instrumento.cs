using System;
using System.Collections.Generic;

namespace MusicStationWinFormsApp.Models;

public partial class Instrumento
{
    public int IdInstrumento { get; set; }

    public int EmpresaId { get; set; }

    public string Nome { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public decimal PrecoLocacao { get; set; }

    public bool Disponivel { get; set; }

    public virtual Empresa Empresa { get; set; } = null!;

    public virtual ICollection<LocacaoItem> LocacaoItens { get; set; } = new List<LocacaoItem>();
}
