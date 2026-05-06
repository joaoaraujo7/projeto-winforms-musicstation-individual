using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStationWinFormsApp.models
{
    public class Instrumento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal PrecoLocacao { get; set; }
        public int Disponivel { get; set; }

        public Empresa Empresa { get; set; } = new Empresa();
        public string EmpresaNome => Empresa?.NomeCompleto;

        public string DisponivelTexto => Disponivel == 1 ? "Sim" : "Não";
    }
}
