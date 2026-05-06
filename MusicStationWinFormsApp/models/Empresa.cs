using System;
using System.Collections.Generic;

namespace MusicStationWinFormsApp.Models;

public partial class Empresa
{
    public int IdEmpresa { get; set; }

    public int UsuarioId { get; set; }

    public string NomeFantasia { get; set; } = null!;

    public string RazaoSocial { get; set; } = null!;

    public string Cnpj { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Telefone { get; set; } = null!;

    public string? Descricao { get; set; }

    public virtual ICollection<Instrumento> Instrumentos { get; set; } = new List<Instrumento>();

    public virtual Usuario Usuario { get; set; } = null!;
}
