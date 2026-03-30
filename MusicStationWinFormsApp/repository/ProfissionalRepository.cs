using MusicStationWinFormsApp.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStationWinFormsApp.repository
{
    internal class ProfissionalRepository
    {
        CargoRepository cargoRepository;
        // crud
        public List<Profissional> ListarTodos()
        {
            // Buscamos os cargos primeiro para associar 
            cargoRepository  = new CargoRepository();   
            var todosCargos = cargoRepository.ListarTodos();

            List<Profissional> lista = new List<Profissional>
            {
                new Profissional
                {
                    Id = 9, NomeCompleto = "Carlos Almeida", Email = "carlos@luthier.com", UsuarioNome = "carlos",
                    Senha = "hash999", DataCadastro = new DateTime(2025, 09, 15, 8, 20, 0),
                    Telefone = "(11)98888-8888",
                    Cargos = new List<Cargo> { todosCargos.Find(c => c.Id == 1) } // Luthier
                },
                new Profissional
                {
                    Id = 10, NomeCompleto = "Paulo Bezerra", Email = "paulo@tecnico.com", UsuarioNome = "paulo",
                    Senha = "hash888", DataCadastro = new DateTime(2025, 09, 15, 9, 45, 12),
                    Telefone = "(11)96666-6666",
                    Cargos = new List<Cargo> { todosCargos.Find(c => c.Id == 2) } // Técnico de Som
                },
                new Profissional
                {
                    Id = 11, NomeCompleto = "Ana Paula", Email = "ana@musica.com", UsuarioNome = "ana",
                    Senha = "hash777", DataCadastro = new DateTime(2025, 09, 15, 11, 10, 35),
                    Telefone = "(11)94444-4444",
                    Cargos = new List<Cargo> { todosCargos.Find(c => c.Id == 3) } // Professor de Violão
                }
            };
            return lista;
        }
    }
}
