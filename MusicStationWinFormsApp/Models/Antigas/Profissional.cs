using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStationWinFormsApp.models
{
    public class Profissional : Usuario
    {
        public string Telefone { get; set; }
        public List<Cargo> Cargos { get; set; } = new List<Cargo>();

        public string CargosDescricao
        {
            get
            {
                return string.Join(", ", Cargos.Select(c => c.Nome));
            }
        }
    }
}
