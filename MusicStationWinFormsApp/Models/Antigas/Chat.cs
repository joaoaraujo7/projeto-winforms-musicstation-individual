using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStationWinFormsApp.models
{
    public class Chat
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public Usuario Usuario1 { get; set; }
        public Usuario Usuario2 { get; set; }
        public List<Mensagem> Mensagens { get; set; } = new List<Mensagem>();
    }
}
