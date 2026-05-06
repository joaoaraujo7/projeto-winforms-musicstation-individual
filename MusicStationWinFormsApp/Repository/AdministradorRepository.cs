using MusicStationWinFormsApp.Data;
using MusicStationWinFormsApp.models;

namespace MusicStationWinFormsApp.repository
{
    internal class AdministradorRepository
    {
        public List<Administrador> ListarTodos()
        {
            List<Administrador> lista = new List<Administrador>
            {
                new Administrador
                {
                    // Dados herdados de Usuario (ID 13 no SQL)
                    Id = 13,
                    NomeCompleto = "Admin Sistema",
                    Email = "admin@musicstation.com",
                    UsuarioNome = "admin",
                    Senha = "hashadm",
                    DataCadastro = new DateTime(2025, 08, 01, 08, 05, 00),

                    // Dados específicos de Administrador
                    NivelAcesso = "10",
                    Observacoes = "Superadmin — acesso total"
                },
                new Administrador
                {
                    // Dados herdados de Usuario (ID 14 no SQL)
                    Id = 14,
                    NomeCompleto = "Tiago Admin",
                    Email = "tiago.admin@music.com",
                    UsuarioNome = "tiago.admin",
                    Senha = "hashadm2",
                    DataCadastro = new DateTime(2025, 10, 01, 12, 30, 45),

                    // Dados específicos de Administrador
                    NivelAcesso = "5",
                    Observacoes = "Acesso a relatórios e suporte"
                }
            };
            return lista;
        }
    }
}