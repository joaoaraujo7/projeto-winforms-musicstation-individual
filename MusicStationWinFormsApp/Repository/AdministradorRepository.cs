using MusicStationWinFormsApp.Data;
using MusicStationWinFormsApp.Models;

namespace MusicStationWinFormsApp.repository
{
    internal class AdministradorRepository
    {
        public List<Administrador> ListarTodos()
        {
            using (var db = new MusicStationDbContext())
            {
                return db.Administradores.ToList();
            }
        }
    }
}