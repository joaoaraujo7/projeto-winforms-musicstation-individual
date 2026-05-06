using System;
using System.Collections.Generic;
using MusicStationWinFormsApp.models;

namespace MusicStationWinFormsApp.Models;

public partial class Administradore
{
    public int IdAdmin { get; set; }

    public int UsuarioId { get; set; }

    public int NivelAcesso { get; set; }

    public string? Observacoes { get; set; }

    public virtual models.Usuario Usuario { get; set; } = null!;
}
