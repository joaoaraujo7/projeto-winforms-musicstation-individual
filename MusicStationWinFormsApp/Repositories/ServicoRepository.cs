using MusicStationWinFormsApp.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStationWinFormsApp.repository
{
    internal class ServicoRepository
    {
        // crud
        public List<Servico> ListarTodos()
        {
            List<Servico> lista = new List<Servico> 
            {
                new Servico { Id = 1, Nome = "Conserto de Guitarra", Descricao = "Troca de cordas e regulagem", Preco = 150.00m },
                new Servico { Id = 2, Nome = "Ajuste de Mesa de Som", Descricao = "Limpeza e calibração de canais", Preco = 200.00m },
                new Servico { Id = 3, Nome = "Aula de Violão", Descricao = "Iniciação para iniciantes", Preco = 120.00m },
                new Servico { Id = 4, Nome = "Troca de Cordas", Descricao = "Substituição de cordas antigas", Preco = 80.00m },
                new Servico { Id = 5, Nome = "Manutenção de Amplificador", Descricao = "Troca de válvulas e limpeza", Preco = 250.00m },
                new Servico { Id = 6, Nome = "Aula Avançada de Violão", Descricao = "Técnicas de solo e harmonia", Preco = 130.00m },
                new Servico { Id = 7, Nome = "Regulagem de Baixo", Descricao = "Ajuste de ação e oitava", Preco = 180.00m },
                new Servico { Id = 8, Nome = "Instalação de Sistema de Som", Descricao = "Montagem completa para eventos", Preco = 500.00m }
            };

            return lista;
        }
    }
}
