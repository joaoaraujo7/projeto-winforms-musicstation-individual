using System;
using System.Collections.Generic;
using MusicStationWinFormsApp.models;

namespace MusicStationWinFormsApp.Models;

public partial class Notificaco
{
    public int IdNotificacao { get; set; }

    public int UsuarioId { get; set; }

    public string Titulo { get; set; } = null!;

    public string Mensagem { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public DateTime DataEnvio { get; set; }

    public bool Lida { get; set; }

    public virtual models.Usuario Usuario { get; set; } = null!;
}
