using System;
using System.Collections.Generic;

namespace MusicStationWinFormsApp.Models;

public partial class Servico
{
    public int IdServico { get; set; }

    public string Nome { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public decimal Preco { get; set; }

    public virtual ICollection<ServicoPedido> ServicosPedidos { get; set; } = new List<ServicoPedido>();
}
