using System;
using System.Collections.Generic;

namespace MusicStationWinFormsApp.Models;

public partial class Profissional
{
    public int IdProfissional { get; set; }

    public int UsuarioId { get; set; }

    public string Telefone { get; set; } = null!;

    public virtual ICollection<ServicoPedido> ServicosPedidos { get; set; } = new List<ServicoPedido>();

    public virtual Usuario Usuario { get; set; } = null!;

    public virtual ICollection<Cargo> Cargo { get; set; } = new List<Cargo>();
}
