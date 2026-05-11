using MusicStationWinFormsApp.Models;
using MusicStationWinFormsApp.Repositories;
using MusicStationWinFormsApp.ViewModel;

namespace MusicStationWinFormsApp.Services;

public class AdministradorService
{
    private readonly AdministradorRepository administradorRepository = new();

    public List<AdministradorGridViewModel> ObterTodos()
    {
        List<Administrador> administradores = administradorRepository.ObterTodos();

        return administradores.Select(a => new AdministradorGridViewModel
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

    public Administrador? ObterPorId(int id)
    {
        return administradorRepository.ObterPorId(id);
    }

    public void Adicionar(Administrador administrador)
    {
        ValidarAdministrador(administrador, validarSenha: true);
        administradorRepository.Adicionar(administrador);
    }

    public void Atualizar(Administrador administradorAtualizado)
    {
        ValidarAdministrador(administradorAtualizado, validarSenha: false);
        administradorRepository.Atualizar(administradorAtualizado);
    }

    public void Remover(int id)
    {
        administradorRepository.Remover(id);
    }

    public List<AdministradorGridViewModel> Pesquisar(string termo)
    {
        List<Administrador> administradores = administradorRepository.Pesquisar(termo);

        return administradores
            .Select(a => new AdministradorGridViewModel
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

    private static void ValidarAdministrador(Administrador administrador, bool validarSenha)
    {
        if (String.IsNullOrWhiteSpace(administrador.Usuario.Nome))
        {
            throw new InvalidOperationException("Nome obrigatório.");
        }

        if (String.IsNullOrWhiteSpace(administrador.Usuario.Email))
        {
            throw new InvalidOperationException("Email obrigatório.");
        }

        if (String.IsNullOrWhiteSpace(administrador.Usuario.UsuarioNome))
        {
            throw new InvalidOperationException("Nome do Usuário obrigatório.");
        }

        if (validarSenha && String.IsNullOrWhiteSpace(administrador.Usuario.SenhaHash))
        {
            throw new InvalidOperationException("Senha obrigatória.");
        }

        if (administrador.NivelAcesso <= 0)
        {
            throw new InvalidOperationException("Nível de acesso inválido.");
        }
    }
    
    //  validação de email e usuário repetidos
    // implmenetar existe email e usuário no repository 
}