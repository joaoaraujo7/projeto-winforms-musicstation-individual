using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStationWinFormsApp.models
{
    internal class Usuario
    {
        public int id_usuario { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string usuario_nome { get; set; }
        public string senha { get; set; }
        public DateTime data_cadastro { get; set; }
    }
}
