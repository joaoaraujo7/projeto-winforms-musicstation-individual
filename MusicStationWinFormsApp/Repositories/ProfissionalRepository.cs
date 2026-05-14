using Microsoft.EntityFrameworkCore;
using MusicStationWinFormsApp.Data;
using MusicStationWinFormsApp.Models;

namespace MusicStationWinFormsApp.Repositories
{
    internal class ProfissionalRepository
    {
        // crud
        public List<Profissional> ObterTodos()
        {
            using (var db = new MusicStationDbContext())
            {
                return db.Profissionais
                    .AsNoTracking()
                    .Include(p => p.Usuario)
                    .Include(p => p.Cargos)
                    .ToList();
            }
        }

        public Profissional? ObterPorId(int id)
        {
            using (var db = new MusicStationDbContext())
            {
                return db.Profissionais
                    .AsNoTracking()
                    .Include(p => p.Usuario)
                    .Include(p => p.Cargos)
                    .FirstOrDefault(p => p.IdProfissional == id);
            }
        }

        public void Adicionar(Profissional profissional)
        {
            using (var db = new MusicStationDbContext())
            {
                db.Profissionais.Add(profissional);
                db.SaveChanges();
            }
        }

        public void Atualizar(Profissional profissionalAtualizado)
        {
            using (var db = new MusicStationDbContext())
            {
                Profissional? profissionalExistente = db.Profissionais
                    .Include(p => p.Usuario)
                    .Include(p => p.Cargos)
                    .FirstOrDefault(p => p.IdProfissional == profissionalAtualizado.IdProfissional);

                if (profissionalExistente == null) return;

                profissionalExistente.Telefone = profissionalAtualizado.Telefone;

                profissionalExistente.Cargos.Clear();

                foreach (var cargoAtualizado in profissionalAtualizado.Cargos)
                {
                    Cargo? cargo = db.Cargos.Find(cargoAtualizado.IdCargo);

                    if (cargo != null)
                    {
                        profissionalExistente.Cargos.Add(cargo);
                    }
                }

                profissionalExistente.Usuario.Nome = profissionalAtualizado.Usuario.Nome;
                profissionalExistente.Usuario.Email = profissionalAtualizado.Usuario.Email;
                profissionalExistente.Usuario.UsuarioNome = profissionalAtualizado.Usuario.UsuarioNome;
                profissionalExistente.Usuario.DataCadastro = profissionalAtualizado.Usuario.DataCadastro;

                db.SaveChanges();
            }
        }

        public void Remover(int id)
        {
            using (var db = new MusicStationDbContext())
            {
                Profissional? profissional = db.Profissionais
                    .Include(p => p.Usuario)
                    .Include(p => p.Cargos)
                    .FirstOrDefault(p => p.IdProfissional == id);

                if (profissional == null) return;

                db.Profissionais.Remove(profissional);
                db.Usuarios.Remove(profissional.Usuario);

                db.SaveChanges();
            }
        }

        public List<Profissional> Pesquisar(string termo)
        {
            using (var db = new MusicStationDbContext())
            {
                termo = termo.Trim();

                return db.Profissionais
                    .AsNoTracking()
                    .Include(p => p.Usuario)
                    .Include(p => p.Cargos)
                    .Where(p =>
                        p.Usuario.Nome.Contains(termo) ||
                        p.Usuario.UsuarioNome.Contains(termo) ||
                        p.Usuario.Email.Contains(termo) ||
                        p.Cargos.Any(c => c.Nome.Contains(termo)))
                    .ToList();
            }
        }
    }
}