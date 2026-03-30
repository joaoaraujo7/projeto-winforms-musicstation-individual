using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStationWinFormsApp.models
{
    public class Empresa : Usuario
    {
        // NomeCompleto (herdado) será usado como o "Nome Fantasia"
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string Telefone { get; set; }
        public string Descricao { get; set; }
    }
}
