using System;
using System.Collections.Generic;
using MusicStationWinFormsApp.models;

namespace MusicStationWinFormsApp.Models;

public partial class Profissionai
{
    public int IdProfissional { get; set; }

    public int UsuarioId { get; set; }

    public string Telefone { get; set; } = null!;

    public virtual ICollection<ServicosPedido> ServicosPedidos { get; set; } = new List<ServicosPedido>();

    public virtual models.Usuario Usuario { get; set; } = null!;

    public virtual ICollection<models.Cargo> Cargos { get; set; } = new List<models.Cargo>();
}
