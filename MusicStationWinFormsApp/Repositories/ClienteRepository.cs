using MusicStationWinFormsApp.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStationWinFormsApp.repository
{
    internal class ClienteRepository
    {
        // crud
        public List<Cliente> ListarTodos()
        {
            List<Cliente> lista = new List<Cliente> {
        new Cliente
        {
            Id = 1, NomeCompleto = "João Lima", Email = "joao@gmail.com", UsuarioNome = "joao", Senha = "hash123",
            DataCadastro = new DateTime(2025, 10, 10, 08, 15, 23),
            Telefone = "(11)99999-9999", Rua = "Rua das Flores", Numero = "10"
        },
        new Cliente
        {
            Id = 2, NomeCompleto = "Maria Souza", Email = "maria@gmail.com", UsuarioNome = "maria", Senha = "hash234",
            DataCadastro = new DateTime(2025, 10, 10, 09, 42, 10),
            Telefone = "(11)97777-7777", Rua = "Av. Brasil", Numero = "50"
        },
        new Cliente
        {
            Id = 3, NomeCompleto = "Lucas Reis", Email = "lucas@gmail.com", UsuarioNome = "lucas", Senha = "hash345",
            DataCadastro = new DateTime(2025, 10, 10, 10, 05, 55),
            Telefone = "(11)95555-5555", Rua = "Rua das Palmeiras", Numero = "55"
        },
        new Cliente
        {
            Id = 4, NomeCompleto = "Beatriz Silva", Email = "bia@gmail.com", UsuarioNome = "bia", Senha = "hash456",
            DataCadastro = new DateTime(2025, 10, 10, 11, 27, 33),
            Telefone = "(11)93333-3333", Rua = "Av. das Nações", Numero = "200"
        },
        new Cliente
        {
            Id = 5, NomeCompleto = "Rafaela Gomes", Email = "rafa@gmail.com", UsuarioNome = "rafa", Senha = "hash567",
            DataCadastro = new DateTime(2025, 10, 10, 13, 12, 47),
            Telefone = "(11)92222-2222", Rua = "Rua Bela Vista", Numero = "75"
        },
        new Cliente
        {
            Id = 6, NomeCompleto = "Guilherme Lopes", Email = "gui@gmail.com", UsuarioNome = "gui", Senha = "hash678",
            DataCadastro = new DateTime(2025, 10, 10, 14, 55, 02),
            Telefone = "(11)91111-1111", Rua = "Av. Industrial", Numero = "15"
        },
        new Cliente
        {
            Id = 7, NomeCompleto = "Thiago Ramos", Email = "thiago@gmail.com", UsuarioNome = "thiago", Senha = "hash789",
            DataCadastro = new DateTime(2025, 10, 10, 16, 08, 19),
            Telefone = "(11)90000-0000", Rua = "Rua Rio Branco", Numero = "90"
        },
        new Cliente
        {
            Id = 8, NomeCompleto = "Patrícia Alves", Email = "paty@gmail.com", UsuarioNome = "paty", Senha = "hash890",
            DataCadastro = new DateTime(2025, 10, 10, 17, 33, 41),
            Telefone = "(11)98877-6666", Rua = "Av. Central", Numero = "120"
        }};

            return lista;
        }
    }
}
