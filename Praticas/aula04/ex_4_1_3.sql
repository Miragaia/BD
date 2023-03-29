USE p8g8
GO

DROP TABLE IF exists encomenda_Composta;
DROP TABLE IF exists encomenda_Produto;
DROP TABLE IF exists encomenda_Fornecedor;
DROP TABLE IF exists encomenda_Encomenda;
DROP TABLE IF exists encomenda_Armazem;
DROP TABLE IF exists encomenda_Empresa;


--CREATE TABLE Stocks_Empresa (
--	[Nome]	varchar(20) NOT NULL PRIMARY KEY,
--);
--GO

CREATE TABLE Stocks_Armazem (
	[Codigo]	int NOT NULL PRIMARY KEY,
	[Morada] varchar(38) NOT NULL,
	[Produto_Codigo] int NOT NULL references Stocks_Produto([Codigo]),
);
GO

--CREATE TABLE Stocks_Produto(
--	[Codigo]		int NOT NULL PRIMARY KEY,
--	[Nome]			varchar(20) NOT NULL,
--	[Preco]			int NOT NULL,
--	[IVA]			int NOT NULL,
--	[Arm_Quan_Pr]	int,
--	[E_Nome] [varchar](20) NOT NULL references Stocks_Empresa([Nome])
--);
--GO

--CREATE TABLE Stocks_Encomenda(
--	[Num_Encomenda]	int NOT NULL PRIMARY KEY,
--	[Data_Realizada]date NOT NULL,
--	[Forneced_nome]	varchar(20) NOT NULL UNIQUE,
--	[Quantidade] int NOT NULL,
--	[Produto_Codigo] int NOT NULL references Stocks_Produto([Codigo]),
--);
--GO

--CREATE TABLE Stocks_Cond_Pagamento(
-- [Codigo] int NOT NULL PRIMARY KEY,
-- [Pagamento] int NOT NULL,
-- [Prazo] varchar(20) NOT NULL,
-- );
-- GO

 --CREATE TABLE Stocks_Tipo_Fornecedor(
 --[Codigo] int NOT NULL PRIMARY KEY,
 --[Nome] varchar(20) NOT NULL,
 --);
 --GO

--CREATE TABLE Stocks_Fornecedor(
--	[Nome]			varchar(20) NOT NULL PRIMARY KEY,
--	[Inf_fiscal]	varchar(50) NOT NULL,
--	[Endereço]		varchar(50) NOT NULL,
--	[Codigo_inter]	int NOT NULL IDENTITY,
--	[Fax]			varchar(20) NOT NULL,
--	[Pagamento]		int NOT NULL,
--	[Codigo_Cond_Pagamento] int NOT NULL references Stocks_Cond_Pagamento([Codigo]),
--	[Codigo_Tipo_Fornecedor] int NOT NULL references Stocks_Tipo_Fornecedor([Codigo]),
--);
--GO


