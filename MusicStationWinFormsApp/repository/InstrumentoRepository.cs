using MusicStationWinFormsApp.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStationWinFormsApp.repository
{
    internal class InstrumentoRepository
    {
        private EmpresaRepository empresaRepository = new EmpresaRepository();

        // crud
        public List<Instrumento> ListarTodos()
        {
            List<Empresa> empresas = empresaRepository.ListarTodos();

            List<Instrumento> lista = new List<Instrumento>
            {
                new Instrumento
                {
                    Id = 1,
                    Nome = "Guitarra Fender Stratocaster",
                    Descricao = "Cor Sunburst, 3 captadores single coil",
                    PrecoLocacao = 150.00M,
                    Disponivel = 1,
                    // Preenchendo a composição da Empresa
                    Empresa = empresas.First(e => e.Id == 12)
                },
                new Instrumento
                {
                    Id = 2,
                    Nome = "Baixo Yamaha TRBX304",
                    Descricao = "Ativo, 4 cordas, cor preta",
                    PrecoLocacao = 120.00M,
                    Disponivel = 1,
                    Empresa = empresas.First(e => e.Id == 12)
                },
                new Instrumento
                {
                    Id = 3,
                    Nome = "Bateria Pearl Export",
                    Descricao = "Bateria completa com ferragens, sem pratos",
                    PrecoLocacao = 250.00M,
                    Disponivel = 0,
                    Empresa = empresas.First(e => e.Id == 12)
                } };

            return lista;
        }
    }
}
