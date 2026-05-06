using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStationWinFormsApp.models
{
    public class Servico
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        // Propriedade formatada para o DataGridView ou ComboBox
        public string NomeComPreco => $"{Nome} - {Preco:C2}";
    }
}
