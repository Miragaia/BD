USE p8g8
GO

CREATE SCHEMA stock;

GO

CREATE TABLE stock.produto(
	codigo		INT				NOT NULL,
	nome		VARCHAR(30)		NOT NULL,
	iva		DECIMAL(3,2)	NOT NULL,
	preco		Money			NOT NULL,
	unidades		INT				NOT NULL

	PRIMARY KEY(codigo)
);
GO

CREATE TABLE stock.tipo_fornecedor(
	codigo		INT		NOT NULL,
	designacao		VarChar(20),

	PRIMARY KEY(codigo)
);
GO

CREATE TABLE stock.fornecedor(
	nif					INT			NOT NULL,
	nome				VarChar(30)	NOT NULL,
	endereco			VarChar(40) NOT NULL,
	fax					INT,
	condpag				INT			NOT NULL,
	tipo				INT			NOT NULL references stock.tipo_fornecedor (codigo),

	primary key (nif)
);
GO

CREATE TABLE stock.encomenda(
	data				DATE,
	numero				INT			NOT NULL,
	fornecedor			INT			NOT NULL references stock.fornecedor (nif),

	PRIMARY KEY(numero)
);
GO



CREATE TABLE stock.item(
	unidades		INT		NOT NULL,
	numEnc			INT		NOT NULL	references stock.encomenda (numero),		
	codProd			INT		NOT NULL	references stock.produto (codigo),
	
	
	PRIMARY KEY(codProd,numEnc)
);
GO