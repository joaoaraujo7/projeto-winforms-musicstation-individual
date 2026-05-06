using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStationWinFormsApp.models
{
    public class Administrador : Usuario
    {
        public string NivelAcesso { get; set; }
        public string Observacoes { get; set; }
    }
}
