using MusicStationWinFormsApp.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStationWinFormsApp.repository
{
    internal class EmpresaRepository
    {

        public List<Empresa> ListarTodos()
        {
            List<Empresa> lista = new List<Empresa>
            {
                new Empresa
                {
                    Id = 12, 
                    NomeCompleto = "Music Station Studio",
                    Email = "contato@musicstation.com",
                    UsuarioNome = "contato",
                    Senha = "hash001",
                    DataCadastro = new DateTime(2025, 08, 01, 8, 0, 0),
            
                    // Dados fiscais e de contato:
                    RazaoSocial = "Music Station LTDA",
                    Cnpj = "12.345.678/0001-90",
                    Telefone = "(11)99999-0000",
                    Descricao = "Estúdio e loja de instrumentos musicais."
                }
             };

            return lista;
        }
    }
}
