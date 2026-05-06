using MusicStationWinFormsApp.models;

namespace MusicStationWinFormsApp.Models;

public partial class Mensagen
{
    public int IdMensagem { get; set; }

    public int ChatId { get; set; }

    public int RemetenteId { get; set; }

    public string Conteudo { get; set; } = null!;

    public DateTime DataEnvio { get; set; }

    public bool Lida { get; set; }

    public virtual models.Chat Chat { get; set; } = null!;

    public virtual models.Usuario Remetente { get; set; } = null!;
}