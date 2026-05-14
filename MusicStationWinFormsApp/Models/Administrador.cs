namespace MusicStationWinFormsApp.Models;

public partial class Administrador
{
    public int IdAdmin { get; set; }

    public int UsuarioId { get; set; }

    public int NivelAcesso { get; set; }

    public string? Observacoes { get; set; }

    public virtual Usuario Usuario { get; set; } = null!;
}