using MusicStationWinFormsApp.models.enuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStationWinFormsApp.models
{
    public class Locacao
    {
        public int Id { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataDevolucao { get; set; }
        public StatusPedido StatusPedido { get; set; }
        public Cliente Cliente { get; set; }

        public List<ItemLocacao> ItensLocacao { get; set; } = new List<ItemLocacao>();

        public Decimal Total => ItensLocacao?.Sum(i => i.Subtotal) ?? 0;

        public string ClienteNome => Cliente.NomeCompleto;
    }
}
