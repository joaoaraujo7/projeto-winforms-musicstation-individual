using Microsoft.EntityFrameworkCore;
using MusicStationWinFormsApp.Data;
using MusicStationWinFormsApp.Models;

namespace MusicStationWinFormsApp.Repositories
{
    internal class AdministradorRepository
    {
        public List<Administrador> ObterTodos()
        {
            using (var db = new MusicStationDbContext())
            {
                return db.Administradores
                    .AsNoTracking()
                    .Include(u => u.Usuario)
                    .ToList();
            }
        }

        public Administrador? ObterPorId(int id)
        {
            using (var db = new MusicStationDbContext())
            {
                 return db.Administradores
                     .AsNoTracking()
                     .Include(a => a.Usuario)
                     .FirstOrDefault(a => a.IdAdmin == id);
            }
        }

        public void Adicionar(Administrador administrador)
        {
            using (var db = new MusicStationDbContext())
            {
                db.Administradores.Add(administrador);
                db.SaveChanges();
            }
        }

        public void Atualizar(Administrador administradorAtualizado)
        {
            using (var db = new MusicStationDbContext())
            {
                Administrador? administradorExistente = db.Administradores
                    .Include(a => a.Usuario)
                    .FirstOrDefault(a => a.IdAdmin == administradorAtualizado.IdAdmin);

                if (administradorExistente == null) return;
                
                administradorExistente.NivelAcesso = administradorAtualizado.NivelAcesso;
                administradorExistente.Observacoes = administradorAtualizado.Observacoes;
                
                administradorExistente.Usuario.Nome = administradorAtualizado.Usuario.Nome;
                administradorExistente.Usuario.Email = administradorAtualizado.Usuario.Email;
                administradorExistente.Usuario.UsuarioNome = administradorAtualizado.Usuario.UsuarioNome;
                // criar campo para redefinir senha
                // administradorExistente.Usuario.SenhaHash = administradorAtualizado.Usuario.SenhaHash; 
                administradorExistente.Usuario.DataCadastro = administradorAtualizado.Usuario.DataCadastro;
                
                db.SaveChanges();
            }
        }

        public void Remover(int id)
        {
            using (var db = new MusicStationDbContext())
            {
                Administrador? administrador = db.Administradores
                    .Include(a => a.Usuario)
                    .FirstOrDefault(a => a.IdAdmin == id);

                if (administrador == null) return;

                db.Administradores.Remove(administrador);
                db.Usuarios.Remove(administrador.Usuario);
                
                db.SaveChanges();
            }
        }
        
        public List<Administrador> Pesquisar(string termo)
        {
            using (var db = new MusicStationDbContext())
            {
                termo = termo.Trim();

                return db.Administradores
                    .AsNoTracking()
                    .Include(a => a.Usuario)
                    .Where(a =>
                        a.Usuario.Nome.Contains(termo) ||
                        a.Usuario.UsuarioNome.Contains(termo) ||
                        a.Usuario.Email.Contains(termo))
                    .ToList();
            }
        }
    }
}