using MusicStationWinFormsApp.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStationWinFormsApp.repository
{
    internal class CargoRepository
    {
        // crud
        public List<Cargo> ListarTodos()
        {
            List<Cargo> lista = new List<Cargo>
            {
                new Cargo { Id = 1, Nome = "Luthier", Descricao = "Constrói, repara e mantém instrumentos de cordas." },
                new Cargo { Id = 2, Nome = "Técnico de Som", Descricao = "Monta e opera sistemas de áudio." },
                new Cargo { Id = 3, Nome = "Professor de Violão", Descricao = "Ensina técnicas, teoria e prática musical."}
            };

            return lista;
        }
    }
}
