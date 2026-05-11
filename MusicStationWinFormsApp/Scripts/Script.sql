-- =========================================
-- RESET DO BANCO
-- =========================================
DROP DATABASE IF EXISTS MusicStationDb;
GO
CREATE DATABASE MusicStationDb;
GO
USE MusicStationDb;
GO

-- =========================================
-- TABELAS
-- =========================================

CREATE TABLE Usuarios (
    IdUsuario INT IDENTITY PRIMARY KEY,
    Nome VARCHAR(200) NOT NULL,
    Email VARCHAR(256) NOT NULL UNIQUE,
    UsuarioNome VARCHAR(50) NOT NULL UNIQUE,
    SenhaHash VARCHAR(255) NOT NULL,
    DataCadastro DATETIME2 NOT NULL DEFAULT SYSDATETIME()
);

CREATE TABLE Clientes (
    IdCliente INT IDENTITY PRIMARY KEY,
    UsuarioId INT NOT NULL UNIQUE,
    Telefone VARCHAR(20) NOT NULL,
    Rua VARCHAR(100) NOT NULL,
    Numero VARCHAR(10) NOT NULL,
    FOREIGN KEY (UsuarioId) REFERENCES Usuarios(IdUsuario)
);

CREATE TABLE Administradores (
    IdAdmin INT IDENTITY PRIMARY KEY,
    UsuarioId INT NOT NULL UNIQUE,
    NivelAcesso INT NOT NULL,
    Observacoes VARCHAR(200),
    FOREIGN KEY (UsuarioId) REFERENCES Usuarios(IdUsuario)
);

CREATE TABLE Profissionais (
    IdProfissional INT IDENTITY PRIMARY KEY,
    UsuarioId INT NOT NULL UNIQUE,
    Telefone VARCHAR(20) NOT NULL,
    FOREIGN KEY (UsuarioId) REFERENCES Usuarios(IdUsuario)
);

CREATE TABLE FormasPagamento (
    IdFormaPagamento INT IDENTITY PRIMARY KEY,
    Tipo VARCHAR(50) NOT NULL UNIQUE
);

CREATE TABLE Cargos (
    IdCargo INT IDENTITY PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL UNIQUE,
    Descricao VARCHAR(500) NOT NULL
);

CREATE TABLE Servicos (
    IdServico INT IDENTITY PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL UNIQUE,
    Descricao VARCHAR(300) NOT NULL,
    Preco DECIMAL(10,2) NOT NULL
);

CREATE TABLE Pedidos (
    IdPedido INT IDENTITY PRIMARY KEY,
    ClienteId INT NOT NULL,
    DataPedido DATETIME2 NOT NULL,
    Total DECIMAL(10,2) NOT NULL,
    Status VARCHAR(20) NOT NULL
        CHECK (Status IN ('Pendente', 'Processando', 'Concluido', 'Cancelado')),
    FOREIGN KEY (ClienteId) REFERENCES Clientes(IdCliente)
);

CREATE TABLE ServicosPedidos (
    IdItem INT IDENTITY PRIMARY KEY,
    PedidoId INT NOT NULL,
    ServicoId INT NOT NULL,
    ProfissionalId INT NOT NULL,
    ValorServico DECIMAL(10,2) NOT NULL,
    Observacao VARCHAR(200) DEFAULT '-',
    FOREIGN KEY (PedidoId) REFERENCES Pedidos(IdPedido),
    FOREIGN KEY (ServicoId) REFERENCES Servicos(IdServico),
    FOREIGN KEY (ProfissionalId) REFERENCES Profissionais(IdProfissional)
);

CREATE TABLE Avaliacoes (
    IdAvaliacao INT IDENTITY PRIMARY KEY,
    ServicoPedidoId INT NOT NULL UNIQUE,
    ClienteId INT NOT NULL,
    Nota INT NOT NULL CHECK (Nota BETWEEN 1 AND 5),
    Comentario VARCHAR(300),
    DataAvaliacao DATETIME2 NOT NULL,
    FOREIGN KEY (ClienteId) REFERENCES Clientes(IdCliente),
    FOREIGN KEY (ServicoPedidoId) REFERENCES ServicosPedidos(IdItem)
);

CREATE TABLE Empresas (
    IdEmpresa INT IDENTITY PRIMARY KEY,
    UsuarioId INT NOT NULL UNIQUE,
    NomeFantasia VARCHAR(150) NOT NULL,
    RazaoSocial VARCHAR(150) NOT NULL UNIQUE,
    Cnpj CHAR(18) NOT NULL UNIQUE,
    Email VARCHAR(256) NOT NULL,
    Telefone VARCHAR(20) NOT NULL,
    Descricao VARCHAR(300),
    FOREIGN KEY (UsuarioId) REFERENCES Usuarios(IdUsuario)
);

CREATE TABLE Instrumentos (
    IdInstrumento INT IDENTITY PRIMARY KEY,
    EmpresaId INT NOT NULL,
    Nome VARCHAR(150) NOT NULL,
    Descricao VARCHAR(300) NOT NULL,
    PrecoLocacao DECIMAL(10,2) NOT NULL,
    Disponivel BIT NOT NULL DEFAULT 1,
    FOREIGN KEY (EmpresaId) REFERENCES Empresas(IdEmpresa)
);

CREATE TABLE Locacoes (
    IdLocacao INT IDENTITY PRIMARY KEY,
    ClienteId INT NOT NULL,
    DataInicio DATETIME2 NOT NULL,
    DataFim DATETIME2 NOT NULL,
    ValorTotal DECIMAL(10,2) NOT NULL,
    Status VARCHAR(20) NOT NULL
        CHECK (Status IN ('Ativa', 'Concluida', 'Atrasada', 'Cancelada')),
    FOREIGN KEY (ClienteId) REFERENCES Clientes(IdCliente)
);

CREATE TABLE LocacaoItens (
    IdItem INT IDENTITY PRIMARY KEY,
    LocacaoId INT NOT NULL,
    InstrumentoId INT NOT NULL,
    PrecoLocacao DECIMAL(10,2) NOT NULL,
    Dias INT NOT NULL,
    Subtotal DECIMAL(10,2) NOT NULL,
    CONSTRAINT UQ_LocacaoItens UNIQUE (LocacaoId, InstrumentoId),
    FOREIGN KEY (LocacaoId) REFERENCES Locacoes(IdLocacao),
    FOREIGN KEY (InstrumentoId) REFERENCES Instrumentos(IdInstrumento)
);

CREATE TABLE Pagamentos (
    IdPagamento INT IDENTITY PRIMARY KEY,
    PedidoId INT NOT NULL,
    FormaPagamentoId INT NOT NULL,
    DataPagamento DATETIME2 NOT NULL,
    ValorPago DECIMAL(10,2) NOT NULL,
    Status VARCHAR(20) NOT NULL
        CHECK (Status IN ('Pendente', 'Aprovado', 'Recusado', 'Reembolsado')),
    FOREIGN KEY (PedidoId) REFERENCES Pedidos(IdPedido),
    FOREIGN KEY (FormaPagamentoId) REFERENCES FormasPagamento(IdFormaPagamento)
);

CREATE TABLE TransacoesPagamento (
    IdTransacao INT IDENTITY PRIMARY KEY,
    PagamentoId INT NOT NULL UNIQUE,
    Status VARCHAR(20) NOT NULL
        CHECK (Status IN ('Processando', 'Aprovado', 'Recusado', 'Falha')),
    CodigoExterno VARCHAR(50) NOT NULL UNIQUE,
    DataTransacao DATETIME2 NOT NULL,
    FOREIGN KEY (PagamentoId) REFERENCES Pagamentos(IdPagamento)
);

CREATE TABLE ProfissionalCargo (
    ProfissionalId INT NOT NULL,
    CargoId INT NOT NULL,
    PRIMARY KEY (ProfissionalId, CargoId),
    FOREIGN KEY (ProfissionalId) REFERENCES Profissionais(IdProfissional),
    FOREIGN KEY (CargoId) REFERENCES Cargos(IdCargo)
);

CREATE TABLE Chats (
    IdChat INT IDENTITY PRIMARY KEY,
    Usuario1Id INT NOT NULL,
    Usuario2Id INT NOT NULL,
    DataCriacao DATETIME2 NOT NULL,
    FOREIGN KEY (Usuario1Id) REFERENCES Usuarios(IdUsuario),
    FOREIGN KEY (Usuario2Id) REFERENCES Usuarios(IdUsuario)
);

CREATE TABLE Notificacoes (
    IdNotificacao INT IDENTITY PRIMARY KEY,
    UsuarioId INT NOT NULL,
    Titulo VARCHAR(100) NOT NULL,
    Mensagem VARCHAR(300) NOT NULL,
    Tipo VARCHAR(20) NOT NULL
        CHECK (Tipo IN ('Sistema','Agendamento','Mensagem','Promocao')),
    DataEnvio DATETIME2 NOT NULL,
    Lida BIT NOT NULL DEFAULT 0,
    FOREIGN KEY (UsuarioId) REFERENCES Usuarios(IdUsuario)
);

CREATE TABLE Mensagens (
    IdMensagem INT IDENTITY PRIMARY KEY,
    ChatId INT NOT NULL,
    RemetenteId INT NOT NULL,
    Conteudo VARCHAR(500) NOT NULL,
    DataEnvio DATETIME2 NOT NULL,
    Lida BIT NOT NULL,
    FOREIGN KEY (ChatId) REFERENCES Chats(IdChat),
    FOREIGN KEY (RemetenteId) REFERENCES Usuarios(IdUsuario)
);

-- =========================================
-- INSERTS (TODOS OS DADOS)
-- =========================================

INSERT INTO Usuarios (Nome, Email, UsuarioNome, SenhaHash, DataCadastro) VALUES
('João Lima','joao@gmail.com','joao','hash123','2025-10-10 08:15'),
('Maria Souza','maria@gmail.com','maria','hash234','2025-10-10 09:42'),
('Lucas Reis','lucas@gmail.com','lucas','hash345','2025-10-10 10:05'),
('Beatriz Silva','bia@gmail.com','bia','hash456','2025-10-10 11:27'),
('Rafaela Gomes','rafa@gmail.com','rafa','hash567','2025-10-10 13:12'),
('Guilherme Lopes','gui@gmail.com','gui','hash678','2025-10-10 14:55'),
('Thiago Ramos','thiago@gmail.com','thiago','hash789','2025-10-10 16:08'),
('Patricia Alves','paty@gmail.com','paty','hash890','2025-10-10 17:33'),
('Carlos Almeida','carlos@luthier.com','carlos','hash999','2025-09-15 08:20'),
('Paulo Bezerra','paulo@tecnico.com','paulo','hash888','2025-09-15 09:45'),
('Ana Paula','ana@musica.com','ana','hash777','2025-09-15 11:10'),
('Music Station Studio','contato@musicstation.com','contato','hash001','2025-08-01 08:00'),
('Admin Sistema','admin@musicstation.com','admin','hashadm','2025-08-01 08:05'),
('Tiago Admin','tiago.admin@music.com','tiago.admin','hashadm2','2025-10-01 12:30');

INSERT INTO Clientes (UsuarioId, Telefone, Rua, Numero) VALUES
(1,'(11)99999-9999','Rua das Flores','10'),
(2,'(11)97777-7777','Av Brasil','50'),
(3,'(11)95555-5555','Rua das Palmeiras','55'),
(4,'(11)93333-3333','Av das Nacoes','200'),
(5,'(11)92222-2222','Rua Bela Vista','75'),
(6,'(11)91111-1111','Av Industrial','15'),
(7,'(11)90000-0000','Rua Rio Branco','90'),
(8,'(11)98877-6666','Av Central','120');

INSERT INTO Administradores (UsuarioId, NivelAcesso, Observacoes) VALUES
(13,10,'Superadmin'),
(14,5,'Relatorios e suporte');

INSERT INTO Profissionais (UsuarioId, Telefone) VALUES
(9,'(11)98888-8888'),
(10,'(11)96666-6666'),
(11,'(11)94444-4444');

INSERT INTO FormasPagamento (Tipo) VALUES
('Cartao'),
('Dinheiro'),
('Pix');

INSERT INTO Cargos (Nome, Descricao) VALUES
('Luthier','Instrumentos de corda'),
('Tecnico de Som','Audio profissional'),
('Professor de Violao','Aulas de violao');

INSERT INTO Servicos (Nome, Descricao, Preco) VALUES
('Conserto de Guitarra','Regulagem geral',150),
('Ajuste de Mesa de Som','Calibracao',200),
('Aula de Violao','Iniciantes',120),
('Troca de Cordas','Substituicao',80),
('Manutencao de Amplificador','Revisao',250),
('Aula Avancada de Violao','Tecnicas',130),
('Regulagem de Baixo','Ajuste',180),
('Instalacao de Som','Eventos',500);

INSERT INTO Pedidos (ClienteId, DataPedido, Total, Status) VALUES
(1,'2025-11-12 10:15',270,'Concluido'),
(2,'2025-11-10 14:20',200,'Concluido'),
(3,'2025-11-08 11:00',120,'Processando'),
(4,'2025-11-05 09:30',80,'Concluido'),
(5,'2025-11-01 08:45',250,'Concluido'),
(6,'2025-11-02 13:50',130,'Concluido'),
(7,'2025-11-07 16:10',180,'Processando'),
(8,'2025-11-11 18:20',500,'Concluido');

INSERT INTO ServicosPedidos (PedidoId, ServicoId, ProfissionalId, ValorServico) VALUES
(1,1,1,150),
(1,3,3,120),
(2,2,2,200),
(3,3,3,120),
(4,4,1,80),
(5,5,2,250),
(6,6,3,130),
(7,7,1,180),
(8,8,2,500);

INSERT INTO Avaliacoes (ServicoPedidoId, ClienteId, Nota, Comentario, DataAvaliacao) VALUES
(1,1,5,'Excelente','2025-11-12'),
(2,2,4,'Bom','2025-11-10'),
(3,3,5,'Otimo','2025-11-08'),
(4,4,5,'Rapido','2025-11-05'),
(5,5,4,'Boa qualidade','2025-11-01'),
(6,6,5,'Perfeito','2025-11-02');

INSERT INTO Empresas (UsuarioId, NomeFantasia, RazaoSocial, Cnpj, Email, Telefone, Descricao) VALUES
(12,'Music Station Studio','Music Station LTDA','12.345.678/0001-90',
 'contato@musicstation.com','(11)99999-0000','Estudio musical');

 INSERT INTO Instrumentos (EmpresaId, Nome, Descricao, PrecoLocacao, Disponivel) VALUES
(1,'Guitarra Fender','Classica',120,1),
(1,'Baixo Yamaha','Balanceado',100,1),
(1,'Teclado Roland','Profissional',150,1);

INSERT INTO Locacoes (ClienteId, DataInicio, DataFim, ValorTotal, Status) VALUES
(1,'2025-11-01','2025-11-03',240,'Concluida'),
(2,'2025-11-05','2025-11-07',200,'Concluida'),
(3,'2025-11-10','2025-11-15',750,'Ativa');

INSERT INTO LocacaoItens (LocacaoId, InstrumentoId, PrecoLocacao, Dias, Subtotal) VALUES
(1,1,120,2,240),
(2,2,100,2,200),
(3,3,150,5,750);

INSERT INTO Pagamentos (PedidoId, FormaPagamentoId, DataPagamento, ValorPago, Status) VALUES
(1,3,'2025-11-12 10:30',270,'Aprovado'),
(2,1,'2025-11-10 14:25',200,'Aprovado'),
(3,3,'2025-11-08 09:30',120,'Pendente'),
(4,3,'2025-11-05 15:20',80,'Aprovado'),
(5,1,'2025-11-01 11:40',250,'Aprovado'),
(6,3,'2025-11-02 18:10',130,'Aprovado'),
(7,3,'2025-11-07 17:45',180,'Pendente'),
(8,3,'2025-11-11 19:00',500,'Aprovado');

INSERT INTO TransacoesPagamento (PagamentoId, Status, CodigoExterno, DataTransacao) VALUES
(1,'Aprovado','TXN001','2025-11-12 10:32'),
(2,'Aprovado','TXN002','2025-11-10 14:18'),
(3,'Processando','TXN003','2025-11-08 09:50'),
(4,'Aprovado','TXN004','2025-11-05 16:10'),
(5,'Aprovado','TXN005','2025-11-01 11:45'),
(6,'Aprovado','TXN006','2025-11-02 19:20'),
(8,'Aprovado','TXN007','2025-11-11 19:20');

INSERT INTO ProfissionalCargo (ProfissionalId, CargoId) VALUES
(1,1),
(2,2),
(3,3);

INSERT INTO Chats (Usuario1Id, Usuario2Id, DataCriacao) VALUES
(1, 9, '2025-11-10 08:00'),
(2, 11, '2025-11-08 09:30'),
(3, 10, '2025-11-01 11:00');

INSERT INTO Notificacoes (UsuarioId, Titulo, Mensagem, Tipo, DataEnvio, Lida) VALUES
(1, 'Pagamento aprovado', 'Seu pagamento de R$270 foi confirmado.', 'Sistema', '2025-11-12 09:00', 1),
(2, 'Servico concluido', 'Seu pedido foi finalizado com sucesso.', 'Sistema', '2025-11-10 10:00', 1),
(3, 'Novo agendamento', 'Seu servico esta em andamento.', 'Agendamento', '2025-11-08 12:00', 0),
(4, 'Nova mensagem', 'Cliente enviou uma duvida.', 'Mensagem', '2025-11-09 14:30', 0);

INSERT INTO Mensagens (ChatId, RemetenteId, Conteudo, DataEnvio, Lida) VALUES
(1, 1, 'Ola, preciso de conserto rapido.', '2025-11-10 08:05', 1),
(1, 9, 'Claro, posso agendar para amanha.', '2025-11-10 08:06', 1),
(2, 3, 'Quando posso ter aula de violao?', '2025-11-08 09:31', 0),
(3, 10, 'A manutencao ficou pronta!', '2025-11-01 12:10', 1);

-- ********************************************
-- SELETS PARA TODAS AS TABELAS
-- ********************************************

Use MusicStationDb;

-- 1. TABELA USUARIOS
SELECT * FROM Usuarios;

-- 2. TABELA CLIENTES
SELECT * FROM Clientes;

-- 3. TABELA ADMINISTRADORES
SELECT * FROM Administradores;

-- 4. TABELA PROFISSIONAIS
SELECT * FROM Profissionais;

-- 5. TABELA FORMAS_PAGAMENTO
SELECT * FROM Formas_Pagamento;

-- 6. TABELA CARGOS
SELECT * FROM Cargos;

-- 7. TABELA SERVICOS
SELECT * FROM Servicos;

-- 8. TABELA PEDIDOS
SELECT * FROM Pedidos;

-- 9. TABELA CHATS
SELECT * FROM Chats;

-- 10. TABELA NOTIFICACOES
SELECT * FROM Notificacoes;

-- 11. TABELA SERVICOS_PEDIDOS
SELECT * FROM Servicos_Pedidos;

-- 12. TABELA AVALIACOES
SELECT * FROM Avaliacoes;

-- 13. TABELA EMPRESAS
SELECT * FROM Empresas;

-- 14. TABELA INSTRUMENTOS
SELECT * FROM Instrumentos;

-- 15. TABELA LOCACOES
SELECT * FROM Locacoes;

-- 16. TABELA LOCACAO_ITENS
SELECT * FROM Locacao_Itens;

-- 17. TABELA PAGAMENTOS
SELECT * FROM Pagamentos;

-- 18. TABELA TRANSACOES_PAGAMENTO
SELECT * FROM Transacoes_Pagamento;

-- 19. TABELA MENSAGENS
SELECT * FROM Mensagens;

-- 20. TABELA PROFISSIONAL_CARGO
SELECT * FROM Profissional_Cargo;