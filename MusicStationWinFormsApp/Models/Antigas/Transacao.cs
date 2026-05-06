using MusicStationWinFormsApp.models.enuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStationWinFormsApp.models
{
    public class Transacao
    {
        public int Id { get; set; }
        public StatusTransacao statusTransacao { get; set; }
        public string CodigoExterno { get; set; }
        public DateTime DataTransacao { get; set; }
        public Pagamento Pagamento { get; set; }
    }
}
