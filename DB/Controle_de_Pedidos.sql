

use BDRAFAEL2;
CREATE TABLE ProdutosGrupos (
    GrupID INTEGER PRIMARY KEY IDENTITY(1,1) NOT NULL,
    GrupDescricao VARCHAR(30)
);

CREATE TABLE Produtos (
    ProdCodigo INTEGER PRIMARY KEY IDENTITY(1,1) NOT NULL,
    ProdDescricao VARCHAR(50),
    ProdUnidade VARCHAR(20),
    ProdGpCodigo INTEGER,
    ProdValorCompra NUMERIC (13,2),
    ProdValorVenda NUMERIC (13,2)
);

CREATE TABLE PedidosItens (
    ItPeID INTEGER PRIMARY KEY IDENTITY(1,1) NOT NULL,
    ItPePedido INTEGER,
    ItPeProduto INTEGER,
    ItPeQuant NUMERIC (5,2),
    ItPeValorUnitario NUMERIC (13,2),
    ItPeValorTotal NUMERIC (13,2)
);

CREATE TABLE Pedidos (
    PediID INTEGER PRIMARY KEY IDENTITY(1,1) NOT NULL,
    PediData DATE,
    PediObservacao VARCHAR(100),
    PediValorTotal INTEGER,
    PediCliente INTEGER
);

CREATE TABLE Clientes (
    ClieCodigo INTEGER PRIMARY KEY IDENTITY(1,1) NOT NULL,
    ClieNome VARCHAR(40),
    ClieEndereco VARCHAR(50),
    ClieCep VARCHAR(9),
    ClieCidade VARCHAR(30),
    ClieEstado VARCHAR(2),
    ClieDataCadastro DATE
);
 
ALTER TABLE Produtos ADD CONSTRAINT FK_Produtos_2
    FOREIGN KEY (ProdGpCodigo)
    REFERENCES ProdutosGrupos (GrupID)
    ON DELETE CASCADE;
 
ALTER TABLE PedidosItens ADD CONSTRAINT FK_PedidosItens_2
    FOREIGN KEY (ItPePedido)
    REFERENCES Pedidos (PediID)
    ON DELETE CASCADE;
 
ALTER TABLE PedidosItens ADD CONSTRAINT FK_PedidosItens_3
    FOREIGN KEY (ItPeProduto)
    REFERENCES Produtos (ProdCodigo)
    ON DELETE CASCADE;
 
ALTER TABLE Pedidos ADD CONSTRAINT FK_Pedidos_2
    FOREIGN KEY (PediCliente)
    REFERENCES Clientes (ClieCodigo)
    ON DELETE CASCADE;