using System;
using System.Collections.Generic;

namespace MusicStationWinFormsApp.Models;

public partial class ServicoPedido
{
    public int IdItem { get; set; }

    public int PedidoId { get; set; }

    public int ServicoId { get; set; }

    public int ProfissionalId { get; set; }

    public decimal ValorServico { get; set; }

    public string? Observacao { get; set; }

    public virtual Avaliacao? Avaliacoes { get; set; }

    public virtual Pedido Pedido { get; set; } = null!;

    public virtual Profissional Profissional { get; set; } = null!;

    public virtual Servico Servico { get; set; } = null!;
}
