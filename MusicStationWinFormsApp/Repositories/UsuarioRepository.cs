using MusicStationWinFormsApp.Data;
using Usuario = MusicStationWinFormsApp.Models.Usuario;

namespace MusicStationWinFormsApp.repository
{
    internal class UsuarioRepository
    {
        // crud
        public List<Usuario> ListarTodos()
        {
            using (var db = new MusicStationDbContext())
            {
                return db.Usuarios.ToList();
            }
        }
    }
}