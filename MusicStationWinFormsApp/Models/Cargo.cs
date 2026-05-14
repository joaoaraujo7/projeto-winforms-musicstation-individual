using System;
using System.Collections.Generic;

namespace MusicStationWinFormsApp.Models;

public partial class Cargo
{
    public int IdCargo { get; set; }

    public string Nome { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public virtual ICollection<Profissional> Profissional { get; set; } = new List<Profissional>();
}
