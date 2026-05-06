using System;
using System.Collections.Generic;

namespace MusicStationWinFormsApp.Models;

public partial class Notificacao
{
    public int IdNotificacao { get; set; }

    public int UsuarioId { get; set; }

    public string Titulo { get; set; } = null!;

    public string Mensagem { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public DateTime DataEnvio { get; set; }

    public bool Lida { get; set; }

    public virtual Usuario Usuario { get; set; } = null!;
}
