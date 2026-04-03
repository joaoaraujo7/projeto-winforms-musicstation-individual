using MusicStationWinFormsApp.models.enuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStationWinFormsApp.models
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public StatusPedido Status { get; set; }
        public Cliente Cliente { get; set; }
        public List<ItemPedido> ItensPedido { get; set; } = new List<ItemPedido>();

        public Decimal Total => ItensPedido?.Sum(i => i.ValorServico) ?? 0;

        public string ClienteNome => Cliente.NomeCompleto;

    }
}
