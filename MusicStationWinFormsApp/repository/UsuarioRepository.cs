using MusicStationWinFormsApp.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStationWinFormsApp.repository
{
    internal class UsuarioRepository
    {

        // crud
        public List<Usuario> ListarTodos()
        {
            List<Usuario> lista = new List<Usuario>{
                new Usuario { IdUsuario = 1, NomeCompleto = "João Lima", Email = "joao@gmail.com", UsuarioNome = "joao", Senha = "hash123", DataCadastro = new DateTime(2025, 10, 10, 08, 15, 23) },
                new Usuario { IdUsuario = 2, NomeCompleto = "Maria Souza", Email = "maria@gmail.com", UsuarioNome = "maria", Senha = "hash234", DataCadastro = new DateTime(2025, 10, 10, 09, 42, 10) },
                new Usuario { IdUsuario = 3, NomeCompleto = "Lucas Reis", Email = "lucas@gmail.com", UsuarioNome = "lucas", Senha = "hash345", DataCadastro = new DateTime(2025, 10, 10, 10, 05, 55) },
                new Usuario { IdUsuario = 4, NomeCompleto = "Beatriz Silva", Email = "bia@gmail.com", UsuarioNome = "bia", Senha = "hash456", DataCadastro = new DateTime(2025, 10, 10, 11, 27, 33) },
                new Usuario { IdUsuario = 5, NomeCompleto = "Rafaela Gomes", Email = "rafa@gmail.com", UsuarioNome = "rafa", Senha = "hash567", DataCadastro = new DateTime(2025, 10, 10, 13, 12, 47) },
                new Usuario { IdUsuario = 6, NomeCompleto = "Guilherme Lopes", Email = "gui@gmail.com", UsuarioNome = "gui", Senha = "hash678", DataCadastro = new DateTime(2025, 10, 10, 14, 55, 02) },
                new Usuario { IdUsuario = 7, NomeCompleto = "Thiago Ramos", Email = "thiago@gmail.com", UsuarioNome = "thiago", Senha = "hash789", DataCadastro = new DateTime(2025, 10, 10, 16, 08, 19) },
                new Usuario { IdUsuario = 8, NomeCompleto = "Patrícia Alves", Email = "paty@gmail.com", UsuarioNome = "paty", Senha = "hash890", DataCadastro = new DateTime(2025, 10, 10, 17, 33, 41) },
                new Usuario { IdUsuario = 9, NomeCompleto = "Carlos Almeida", Email = "carlos@luthier.com", UsuarioNome = "carlos", Senha = "hash999", DataCadastro = new DateTime(2025, 09, 15, 08, 20, 00) },
                new Usuario { IdUsuario = 10, NomeCompleto = "Paulo Bezerra", Email = "paulo@tecnico.com", UsuarioNome = "paulo", Senha = "hash888", DataCadastro = new DateTime(2025, 09, 15, 09, 45, 12) },
                new Usuario { IdUsuario = 11, NomeCompleto = "Ana Paula", Email = "ana@musica.com", UsuarioNome = "ana", Senha = "hash777", DataCadastro = new DateTime(2025, 09, 15, 11, 10, 35) },
                new Usuario { IdUsuario = 12, NomeCompleto = "Music Station Studio", Email = "contato@musicstation.com", UsuarioNome = "contato", Senha = "hash001", DataCadastro = new DateTime(2025, 08, 01, 08, 00, 00) },
                new Usuario { IdUsuario = 13, NomeCompleto = "Admin Sistema", Email = "admin@musicstation.com", UsuarioNome = "admin", Senha = "hashadm", DataCadastro = new DateTime(2025, 08, 01, 08, 05, 00) },
                new Usuario { IdUsuario = 14, NomeCompleto = "Tiago Admin", Email = "tiago.admin@music.com", UsuarioNome = "tiago.admin", Senha = "hashadm2", DataCadastro = new DateTime(2025, 10, 01, 12, 30, 45) }};
            
            return lista;
        }
    }
}
