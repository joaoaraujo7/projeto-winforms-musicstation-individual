-- CRIAÇÃO DO BANCO DE DADOS
CREATE DATABASE MusicStation;
GO

-- SELECIONA O BANCO DE DADOS
USE MusicStation
GO

-- 1. TABELA USUARIOS

CREATE TABLE Usuarios (
    id_usuario INT IDENTITY (1,1) PRIMARY KEY,
    nome VARCHAR(200) NOT NULL,
    email VARCHAR(256) NOT NULL UNIQUE, -- Adicionando UNIQUE para emails
    usuario_nome VARCHAR(50) UNIQUE NOT NULL,
    senha VARCHAR (50) NOT NULL,
    data_cadastro DATE NOT NULL
);

INSERT INTO Usuarios (nome, email, usuario_nome, senha, data_cadastro)
VALUES
('João Lima', 'joao@gmail.com', 'joao', 'hash123', '2025-10-10'),
('Maria Souza', 'maria@gmail.com', 'maria', 'hash234', '2025-10-10'),
('Lucas Reis', 'lucas@gmail.com', 'lucas', 'hash345', '2025-10-10'),
('Beatriz Silva', 'bia@gmail.com', 'bia', 'hash456', '2025-10-10'),
('Rafaela Gomes', 'rafa@gmail.com', 'rafa', 'hash567', '2025-10-10'),
('Guilherme Lopes', 'gui@gmail.com', 'gui', 'hash678', '2025-10-10'),
('Thiago Ramos', 'thiago@gmail.com', 'thiago', 'hash789', '2025-10-10'),
('Patrícia Alves', 'paty@gmail.com', 'paty', 'hash890', '2025-10-10'),
('Carlos Almeida', 'carlos@luthier.com', 'carlos', 'hash999', '2025-09-15'),
('Paulo Bezerra', 'paulo@tecnico.com', 'paulo', 'hash888', '2025-09-15'),
('Ana Paula', 'ana@musica.com', 'ana', 'hash777', '2025-09-15'),
('Music Station Studio', 'contato@musicstation.com', 'contato', 'hash001', '2025-08-01'),
('Admin Sistema', 'admin@musicstation.com', 'admin', 'hashadm', '2025-08-01'),
('Tiago Admin', 'tiago.admin@music.com', 'tiago.admin', 'hashadm2', '2025-10-01');

-- 2. TABELA CLIENTES
CREATE TABLE Clientes(
	id_cliente INT IDENTITY (1,1) PRIMARY KEY,
	usuario_id INT NOT NULL UNIQUE, -- Relacionamento 1:1 com Usuarios
	telefone VARCHAR(20) NOT NULL,
	rua VARCHAR (100) NOT NULL,
	numero VARCHAR(10) NOT NULL,
	FOREIGN KEY (usuario_id) REFERENCES Usuarios(id_usuario)
);

INSERT INTO Clientes (usuario_id, telefone, rua, numero)
VALUES
(1, '(11)99999-9999', 'Rua das Flores', '10'),
(2, '(11)97777-7777', 'Av. Brasil', '50'),
(3, '(11)95555-5555', 'Rua das Palmeiras', '55'),
(4, '(11)93333-3333', 'Av. das Nações', '200'),
(5, '(11)92222-2222', 'Rua Bela Vista', '75'),
(6, '(11)91111-1111', 'Av. Industrial', '15'),
(7, '(11)90000-0000', 'Rua Rio Branco', '90'),
(8, '(11)98877-6666', 'Av. Central', '120');

-- 3. TABELA ADMINISTRADORES
CREATE TABLE Administradores(
	id_admin INT IDENTITY (1,1) PRIMARY KEY,
	usuario_id INT NOT NULL UNIQUE, -- Relacionamento 1:1 com Usuarios
	nivel_acesso VARCHAR(10) NOT NULL,
	data_criacao DATE NOT NULL,
	observacoes VARCHAR(200),
	FOREIGN KEY (usuario_id) REFERENCES Usuarios(id_usuario)
);

INSERT INTO Administradores(usuario_id, nivel_acesso, data_criacao, observacoes)
VALUES
(13, '10', '2025-08-01','Superadmin — acesso total'), 
(14, '5', '2025-10-01', 'Acesso a relatórios e suporte'); 


-- 4. TABELA PROFISSIONAIS
CREATE TABLE Profissionais (
    id_profissional INT IDENTITY(1,1) PRIMARY KEY,
    usuario_id INT NOT NULL UNIQUE, -- Relacionamento 1:1 com Usuarios
    telefone VARCHAR(20) NOT NULL,
    FOREIGN KEY (usuario_id) REFERENCES Usuarios(id_usuario)
);

INSERT INTO Profissionais (usuario_id, telefone)
VALUES
(9, '(11)98888-8888'),
(10, '(11)96666-6666'),
(11, '(11)94444-4444');


-- 5. TABELA FORMAS_PAGAMENTO
CREATE TABLE Formas_Pagamento (
    id_pagamento INT IDENTITY(1,1) PRIMARY KEY,
    tipo VARCHAR(50) NOT NULL UNIQUE
);

INSERT INTO Formas_Pagamento (tipo)
VALUES
('Cartão'),
('Dinheiro'),
('Pix');


-- 6. TABELA CARGOS
CREATE TABLE Cargos (
    id_cargo INT IDENTITY(1,1) PRIMARY KEY,
    nome VARCHAR(100) NOT NULL UNIQUE,
    descricao VARCHAR(500) NOT NULL
);

INSERT INTO Cargos (nome, descricao)
VALUES
('Luthier', 'Constrói, repara e mantém instrumentos de cordas.'),
('Técnico de Som', 'Monta e opera sistemas de áudio.'),
('Professor de Violão', 'Ensina técnicas, teoria e prática musical.');

-- 7. TABELA SERVICOS
CREATE TABLE Servicos (
    id_servico INT IDENTITY(1,1) PRIMARY KEY,
    nome VARCHAR(100) NOT NULL UNIQUE, -- CADA SERVIÇO SERÁ ÚNICO
    descricao VARCHAR(300) NOT NULL,
    preco DECIMAL(10,2) NOT NULL
);

INSERT INTO Servicos (nome, descricao, preco)
VALUES
('Conserto de Guitarra', 'Troca de cordas e regulagem', 150.00),
('Ajuste de Mesa de Som', 'Limpeza e calibração de canais', 200.00),
('Aula de Violão', 'Iniciação para iniciantes', 120.00),
('Troca de Cordas', 'Substituição de cordas antigas', 80.00),
('Manutenção de Amplificador', 'Troca de válvulas e limpeza', 250.00),
('Aula Avançada de Violão', 'Técnicas de solo e harmonia', 130.00),
('Regulagem de Baixo', 'Ajuste de ação e oitava', 180.00),
('Instalação de Sistema de Som', 'Montagem completa para eventos', 500.00);


-- 8. TABELA PEDIDOS
CREATE TABLE Pedidos (
    id_pedido INT IDENTITY(1,1) PRIMARY KEY,
    cliente_id INT NOT NULL,
    data_pedido DATE NOT NULL,
    total DECIMAL(10,2) NOT NULL,
    status VARCHAR(50) NOT NULL
		CHECK (status IN ('Pendente', 'Em andamento', 'Concluído', 'Cancelado')),
    FOREIGN KEY (cliente_id) REFERENCES Clientes(id_cliente)
);

INSERT INTO Pedidos (cliente_id, data_pedido, total, status)
VALUES
(1, '2025-11-12', 270.00, 'Concluído'),
(2, '2025-11-10', 200.00, 'Concluído'),
(3, '2025-11-08', 120.00, 'Em andamento'),
(4, '2025-11-05', 80.00, 'Concluído'),
(5, '2025-11-01', 250.00, 'Concluído'),
(6, '2025-11-02', 130.00, 'Concluído'),
(7, '2025-11-07', 180.00, 'Em andamento'),
(8, '2025-11-11', 500.00, 'Concluído');


-- 9. TABELA CHATS
CREATE TABLE Chats (
    id_chat INT IDENTITY(1,1) PRIMARY KEY,
    usuario1_id INT NOT NULL,
    usuario2_id INT NOT NULL,
    data_criacao DATETIME NOT NULL,
    FOREIGN KEY (usuario1_id) REFERENCES Usuarios(id_usuario),
    FOREIGN KEY (usuario2_id) REFERENCES Usuarios(id_usuario)
);

INSERT INTO Chats (usuario1_id, usuario2_id, data_criacao)
VALUES
(1, 9, '2025-11-10 08:00:00'),
(2, 11, '2025-11-08 09:30:00'),
(3, 10, '2025-11-01 11:00:00');

-- 10. TABELA NOTIFICACOES
CREATE TABLE Notificacoes (
    id_notificacao INT IDENTITY(1,1) PRIMARY KEY,
    usuario_id INT NOT NULL,
    titulo VARCHAR(100) NOT NULL,
    mensagem VARCHAR(300) NOT NULL,
    tipo VARCHAR(50) NOT NULL
		CHECK (tipo IN ('sistema', 'agendamento', 'mensagem', 'promocao')),
    data_envio DATETIME NOT NULL,
    lida BIT NOT NULL,
    FOREIGN KEY (usuario_id) REFERENCES Usuarios(id_usuario)
);

INSERT INTO Notificacoes (usuario_id, titulo, mensagem, tipo, data_envio, lida)
VALUES
(1, 'Pagamento aprovado', 'Seu pagamento de R$270 foi confirmado.', 'sistema', '2025-11-12 09:00:00', 1),
(2, 'Serviço concluído', 'Seu pedido foi finalizado com sucesso.', 'sistema', '2025-11-10 10:00:00', 1),
(3, 'Novo agendamento', 'Seu serviço está em andamento.', 'agendamento', '2025-11-08 12:00:00', 0),
(4, 'Nova mensagem', 'Cliente enviou uma dúvida sobre o serviço.', 'mensagem', '2025-11-09 14:30:00', 0);

-- 11. TABELA SERVICOS_PEDIDOS (Detalhe do Pedido)
CREATE TABLE Servicos_Pedidos (
    id_item INT IDENTITY(1,1) PRIMARY KEY,
    pedido_id INT NOT NULL,
    servico_id INT NOT NULL,
    profissional_id INT NOT NULL,
    valor_servico DECIMAL(10,2) NOT NULL,
    observacao VARCHAR(200) DEFAULT '-',
    FOREIGN KEY (pedido_id) REFERENCES Pedidos(id_pedido),
    FOREIGN KEY (servico_id) REFERENCES Servicos(id_servico),
    FOREIGN KEY (profissional_id) REFERENCES Profissionais(id_profissional)
);

INSERT INTO Servicos_Pedidos (pedido_id, servico_id, profissional_id, valor_servico)
VALUES
(1, 1, 1, 150.00), -- Pedido 1 (João)
(1, 3, 3, 120.00), -- Pedido 1 (João)
(2, 2, 2, 200.00), -- Pedido 2 (Maria)
(3, 3, 3, 120.00), -- Pedido 3 (Lucas)
(4, 4, 1, 80.00), -- Pedido 4 (Beatriz)
(5, 5, 2, 250.00), -- Pedido 5 (Rafaela)
(6, 6, 3, 130.00), -- Pedido 6 (Guilherme)
(7, 7, 1, 180.00), -- Pedido 7 (Thiago)
(8, 8, 2, 500.00); -- Pedido 8 (Patrícia)

-- 12. TABELA AVALIACOES
CREATE TABLE Avaliacoes (
    id_avaliacao INT IDENTITY(1,1) PRIMARY KEY,
    servico_pedido_id INT NOT NULL UNIQUE, -- Uma avaliação por item de serviço/pedido
    cliente_id INT NOT NULL,
    nota INT NOT NULL CHECK (nota BETWEEN 1 AND 5),
    comentario VARCHAR(300),
    data_avaliacao DATE NOT NULL,
    FOREIGN KEY (cliente_id) REFERENCES Clientes(id_cliente),
    FOREIGN KEY (servico_pedido_id) REFERENCES Servicos_Pedidos(id_item)
);

INSERT INTO Avaliacoes (servico_pedido_id, cliente_id, nota, comentario, data_avaliacao)
VALUES
(1, 1, 5, 'Serviço excelente!', '2025-11-12'),
(2, 2, 4, 'Bom atendimento!', '2025-11-10'),
(3, 3, 5, 'Excelente aula!', '2025-11-08'), 
(4, 4, 5, 'Muito rápido!', '2025-11-05'),
(5, 5, 4, 'Som ficou ótimo!', '2025-11-01'),
(6, 6, 5, 'Serviço impecável!', '2025-11-02');

-- 13. TABELA EMPRESAS
CREATE TABLE Empresas (
    id_empresa INT IDENTITY(1,1) PRIMARY KEY,
    usuario_id INT NOT NULL UNIQUE,
    nome_fantasia VARCHAR(150) NOT NULL,
    razao_social VARCHAR(150) NOT NULL UNIQUE,
    cnpj VARCHAR(20) NOT NULL UNIQUE, -- Adicionado UNIQUE
    email VARCHAR(256) NOT NULL,
    telefone VARCHAR(20) NOT NULL,
    descricao VARCHAR(300),
    data_cadastro DATE NOT NULL,
    FOREIGN KEY (usuario_id) REFERENCES Usuarios(id_usuario)
);

INSERT INTO Empresas (usuario_id, nome_fantasia, razao_social, cnpj, email, telefone, descricao, data_cadastro)
VALUES
(12, 'Music Station Studio', 'Music Station LTDA', '12.345.678/0001-90', 'contato@musicstation.com', '(11)99999-0000', 'Estúdio e loja de instrumentos musicais.', '2025-08-01');

-- 14. TABELA INSTRUMENTOS
CREATE TABLE Instrumentos (
    id_instrumento INT IDENTITY(1,1) PRIMARY KEY,
    empresa_id INT NOT NULL,
    nome VARCHAR(150) NOT NULL,
    descricao VARCHAR(300) NOT NULL,
    preco_locacao DECIMAL(10,2) NOT NULL,
    disponivel BIT NOT NULL,
    FOREIGN KEY (empresa_id) REFERENCES Empresas(id_empresa)
);

INSERT INTO Instrumentos (empresa_id, nome, descricao, preco_locacao, disponivel)
VALUES
(1, 'Guitarra Fender Stratocaster', 'Modelo clássico, ótimo som limpo.', 120.00, 1), -- (1 = disponível) (0 = ocupado)
(1, 'Baixo Yamaha TRBX', 'Timbre balanceado, ideal para estúdio.', 100.00, 1), 
(1, 'Teclado Roland', 'Equipamento profissional com várias oitavas.', 150.00, 1); 

-- 15. TABELA LOCACOES
CREATE TABLE Locacoes (
    id_locacao INT IDENTITY(1,1) PRIMARY KEY,
    cliente_id INT NOT NULL,
    data_inicio DATE NOT NULL,
    data_fim DATE NOT NULL,
    valor_total DECIMAL(10,2),
    status VARCHAR(50) NOT NULL
		CHECK (status IN ('ativa', 'concluída', 'atrasada', 'cancelada')),
    FOREIGN KEY (cliente_id) REFERENCES Clientes(id_cliente)
);


INSERT INTO Locacoes (cliente_id, data_inicio, data_fim, valor_total, status)
VALUES
(1, '2025-11-01', '2025-11-03', 240.00, 'concluída'),
(2, '2025-11-05', '2025-11-07', 200.00, 'concluída'),
(3, '2025-11-10', '2025-11-15', 750.00, 'ativa');

-- 16. TABELA LOCACAO_ITENS (Detalhe da Locação)
CREATE TABLE Locacao_Itens (
    id_item INT IDENTITY(1,1) PRIMARY KEY,
    locacao_id INT NOT NULL,
    instrumento_id INT NOT NULL,
    preco_locacao DECIMAL(10,2) NOT NULL,
    dias INT NOT NULL,
    subtotal DECIMAL(10,2) NOT NULL,
    UNIQUE (locacao_id, instrumento_id), -- Não permite o mesmo item ser locado duas vezes no mesmo pedido
    FOREIGN KEY (locacao_id) REFERENCES Locacoes(id_locacao),
    FOREIGN KEY (instrumento_id) REFERENCES Instrumentos(id_instrumento)
);

INSERT INTO Locacao_Itens (locacao_id, instrumento_id, preco_locacao, dias, subtotal)
VALUES 
(1, 1, 120.00, 2, 240.00), -- Guitarra
(2, 2, 100.00, 2, 200.00), -- Baixo
(3, 3, 150.00, 5, 750.00); -- Teclado

-- 17. TABELA PAGAMENTOS
CREATE TABLE Pagamentos (
    id_pagamento INT IDENTITY(1,1) PRIMARY KEY,
    pedido_id INT NOT NULL,
    forma_pagamento_id INT NOT NULL,
    data_pagamento DATE NOT NULL,
    valor_pago DECIMAL(10,2) NOT NULL,
    status VARCHAR(50) NOT NULL
		CHECK (status IN ('pendente', 'aprovado', 'recusado', 'reembolsado')),
    FOREIGN KEY (pedido_id) REFERENCES Pedidos(id_pedido),
    FOREIGN KEY (forma_pagamento_id) REFERENCES Formas_Pagamento(id_pagamento)
);

INSERT INTO Pagamentos (pedido_id, forma_pagamento_id, data_pagamento, valor_pago, status)
VALUES
(1, 3, '2025-11-12', 270.00, 'aprovado'),
(2, 1, '2025-11-10', 200.00, 'aprovado'),
(3, 3, '2025-11-08', 120.00, 'pendente'),
(4, 3, '2025-11-05', 80.00, 'aprovado'),
(5, 1, '2025-11-01', 250.00, 'aprovado'),
(6, 3, '2025-11-02', 130.00, 'aprovado'),
(7, 3, '2025-11-07', 180.00, 'pendente'),
(8, 3, '2025-11-11', 500.00, 'aprovado');

-- 18. TABELA TRANSACOES_PAGAMENTO -- registra o processo técnico da comunicação com o sistema de pagamento.
CREATE TABLE Transacoes_Pagamento (
    id_transacao INT IDENTITY(1,1) PRIMARY KEY,
    pagamento_id INT NOT NULL UNIQUE, -- Relacionamento 1:1 com Pagamentos
    status VARCHAR(50) NOT NULL
        CHECK (status IN ('processando', 'aprovado', 'recusado', 'falha')), -- Ajuste do CHECK
    codigo_externo VARCHAR(50) NOT NULL UNIQUE,
    data_transacao DATETIME NOT NULL,
    FOREIGN KEY (pagamento_id) REFERENCES Pagamentos(id_pagamento)
);

INSERT INTO Transacoes_Pagamento (pagamento_id, status, codigo_externo, data_transacao)
VALUES
(1, 'aprovado', 'TXN001', '2025-11-12 10:32:00'),
(2, 'aprovado', 'TXN002', '2025-11-10 14:18:00'),
(3, 'processando', 'TXN003', '2025-11-08 09:50:00'),
(4, 'aprovado', 'TXN004', '2025-11-05 16:10:00'),
(5, 'aprovado', 'TXN005', '2025-11-01 11:45:00'),
(6, 'aprovado', 'TXN006', '2025-11-02 19:20:00'),
(8, 'aprovado', 'TXN007', '2025-11-11 19:20:00');

-- 19. TABELA MENSAGENS
CREATE TABLE Mensagens (
    id_mensagem INT IDENTITY(1,1) PRIMARY KEY,
    chat_id INT NOT NULL,
    remetente_id INT NOT NULL,
    conteudo VARCHAR(500) NOT NULL,
    data_envio DATETIME NOT NULL,
    lida BIT NOT NULL,
    FOREIGN KEY (chat_id) REFERENCES Chats(id_chat),
    FOREIGN KEY (remetente_id) REFERENCES Usuarios(id_usuario)
);

INSERT INTO Mensagens (chat_id, remetente_id, conteudo, data_envio, lida)
VALUES
(1, 1, 'Olá, preciso de conserto rápido.', '2025-11-10 08:05:00', 1),
(1, 9, 'Claro, posso agendar para amanhã.', '2025-11-10 08:06:00', 1),
(2, 3, 'Quando posso ter aula de violão?', '2025-11-08 09:31:00', 0),
(3, 10, 'A manutenção ficou pronta!', '2025-11-01 12:10:00', 1);


-- 20. TABELA PROFISSIONAL_CARGO (Tabela N:N)
CREATE TABLE Profissional_Cargo (
    id_profissional INT NOT NULL,
    id_cargo INT NOT NULL,
    PRIMARY KEY (id_profissional, id_cargo),
    FOREIGN KEY (id_profissional) REFERENCES Profissionais(id_profissional),
    FOREIGN KEY (id_cargo) REFERENCES Cargos(id_cargo)
);

INSERT INTO Profissional_Cargo (id_profissional, id_cargo)
VALUES
(1, 1), -- Carlos Almeida (Luthier)
(2, 2), -- Paulo Bezerra (Técnico de Som)
(3, 3); -- Ana Paula (Professor de Violão)


-- ********************************************
-- SELETS PARA TODAS AS TABELAS
-- ********************************************

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