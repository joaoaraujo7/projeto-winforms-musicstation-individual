using System;
using System.Collections.Generic;

namespace MusicStationWinFormsApp.Models;

public partial class Mensagem
{
    public int IdMensagem { get; set; }

    public int ChatId { get; set; }

    public int RemetenteId { get; set; }

    public string Conteudo { get; set; } = null!;

    public DateTime DataEnvio { get; set; }

    public bool Lida { get; set; }

    public virtual Chat Chat { get; set; } = null!;

    public virtual Usuario Remetente { get; set; } = null!;
}
