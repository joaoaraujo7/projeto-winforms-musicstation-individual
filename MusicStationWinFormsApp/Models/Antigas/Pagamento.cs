using MusicStationWinFormsApp.models.enuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStationWinFormsApp.models
{
    public class Pagamento
    {
        public int Id { get; set; }
        public Decimal ValorPago { get; set; }
        public StatusPagamento StatusPagamento { get; set; }
        public DateTime DataPagamento { get; set; }

        public Pedido Pedido { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
    }
}
