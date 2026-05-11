using MusicStationWinFormsApp.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStationWinFormsApp.repository
{
    internal class FormaPagamentoRepository
    {
        public List<FormaPagamento> ListarTodos()
        {
            List<FormaPagamento> lista = new List<FormaPagamento>
            {
                new FormaPagamento { Id = 1, Tipo = "Dinheiro"},
                new FormaPagamento { Id = 2, Tipo = "Cartão"},
                new FormaPagamento { Id = 3, Tipo = "Pix"},
            };

            return lista;
        }
    }
}
