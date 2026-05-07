using MusicStationWinFormsApp.Data;
using MusicStationWinFormsApp.Models;
using MusicStationWinFormsApp.ViewModel;

namespace MusicStationWinFormsApp.repository
{
    internal class AdministradorRepository
    {
        public List<AdministradorGridViewModel> ObterTodos()
        {
            using (var db = new MusicStationDbContext())
            {
                return db.Administradores.Select(a => new AdministradorGridViewModel
                {
                    IdAdmin = a.IdAdmin,
                    Nome = a.Usuario.Nome,
                    Email = a.Usuario.Email,
                    UsuarioNome = a.Usuario.UsuarioNome,
                    DataCadastro = a.Usuario.DataCadastro,
                    NivelAcesso = a.NivelAcesso,
                    Observacoes = a.Observacoes
                })
                .ToList();
            }
        }
    }
}