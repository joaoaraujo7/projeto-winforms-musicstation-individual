using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStationWinFormsApp.models
{
    public class Cliente : Usuario
    {
        public string Telefone { get; set; }
        public string Rua {  get; set; }
        public string Numero { get; set; }
    }
}
