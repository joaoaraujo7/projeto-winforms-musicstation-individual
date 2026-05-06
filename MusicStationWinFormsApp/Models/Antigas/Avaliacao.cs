using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStationWinFormsApp.models
{
    public class Avaliacao
    {
        public int Id { get; set; }
        public int Nota {  get; set; }
        public string Comentario { get; set; }
        public DateTime DataAvaliacao { get; set; }
        public Cliente Cliente {  get; set; }
        public ItemPedido ItemPedido { get; set; }
    }
}
