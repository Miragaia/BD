use p8g8;

DROP VIEW IF EXISTS Higiliquidos.View_Vendas;
DROP VIEW IF EXISTS Higiliquidos.ViewPessoa;
DROP VIEW IF EXISTS Higiliquidos.View_Fornecedores;
DROP VIEW IF EXISTS Higiliquidos.View_Clientes;
DROP VIEW IF EXISTS Higiliquidos.View_Funcionario;
DROP VIEW IF EXISTS Higiliquidos.View_Distribuidor;
DROP VIEW IF EXISTS Higiliquidos.View_Gerentes;
DROP VIEW IF EXISTS Higiliquidos.View_Vendedor;

DROP TABLE IF EXISTS Higiliquidos.Entrega;
DROP TABLE IF EXISTS Higiliquidos.Venda;
DROP TABLE IF EXISTS Higiliquidos.Compra;
DROP TABLE IF EXISTS Higiliquidos.Carrinha_Distribuidor;
DROP TABLE IF EXISTS Higiliquidos.Vendedor;
DROP TABLE IF EXISTS Higiliquidos.Distribuidor;
DROP TABLE IF EXISTS Higiliquidos.Gerente;
DROP TABLE IF EXISTS Higiliquidos.Funcionario;
DROP TABLE IF EXISTS Higiliquidos.Fornecedor;
DROP TABLE IF EXISTS Higiliquidos.Cliente;
DROP TABLE IF EXISTS Higiliquidos.Produto;
DROP TABLE IF EXISTS Higiliquidos.Pessoa;
DROP TABLE IF EXISTS Higiliquidos.Armazem;
DROP TABLE IF EXISTS Higiliquidos.Carrinha;	
DROP TABLE IF EXISTS Higiliquidos.Empresa;



GO
--CREATE SCHEMA Higiliquidos;
--GO


CREATE TABLE Higiliquidos.Empresa (
  NIF_Empresa INT NOT NULL,
  Nome varchar(64) NOT NULL,
  Email varchar(64) NOT NULL,
  Endereco varchar(64) NOT NULL,
  ContactoTelefonico INT NOT NULL,


  PRIMARY KEY (NIF_Empresa)  
);
GO

CREATE TABLE Higiliquidos.Carrinha (
  Matricula varchar(8) NOT NULL,
  Ano INT,
  Marca varchar(32),
  Combustivel varchar(32),
  Peso INT,
  NIF_Empresa INT,

  PRIMARY KEY (Matricula),
  FOREIGN KEY (NIF_Empresa) REFERENCES Higiliquidos.Empresa(NIF_Empresa)
);
GO

CREATE TABLE Higiliquidos.Armazem (
  ID INT NOT NULL,
  Area INT,
  Endereco varchar(64) NOT NULL,
  NIF_Empresa INT,
  
  PRIMARY KEY (ID),
  FOREIGN KEY (NIF_Empresa) REFERENCES Higiliquidos.Empresa(NIF_Empresa)  
);
GO

CREATE TABLE Higiliquidos.Pessoa (  
  NIF INT NOT NULL,
  Nome varchar(256) NOT NULL,
  Data_de_Nascimento DATE,
  Email varchar(64) NOT NULL,
  Morada varchar(64),
  ContactoTelefonico INT NOT NULL,
  NIF_Empresa INT,
  
  PRIMARY KEY (NIF),
  FOREIGN KEY (NIF_Empresa) REFERENCES Higiliquidos.Empresa(NIF_Empresa)
);  
GO

CREATE TABLE Higiliquidos.Produto (
  ID INT NOT NULL,
  Nome VARCHAR(64) NOT NULL,
  Marca VARCHAR(64),
  Tipo_de_Produto VARCHAR(64),
  IVA DECIMAL(5, 2) NOT NULL,
  Preco DECIMAL(10, 2) NOT NULL,
  Quantidade INT NOT NULL,

  PRIMARY KEY (ID)

);
GO

CREATE TABLE Higiliquidos.Cliente (
  NIF_Cliente INT NOT NULL,
  Num_Cliente INT NOT NULL,

  PRIMARY KEY (Num_Cliente),
  FOREIGN KEY (NIF_Cliente) REFERENCES Higiliquidos.Pessoa(NIF)
);
GO

CREATE TABLE Higiliquidos.Fornecedor (
  NIF_Fornecedor INT NOT NULL,
  Num_Fornecedor INT NOT NULL,

  PRIMARY KEY (Num_Fornecedor),
  FOREIGN KEY (NIF_Fornecedor) REFERENCES Higiliquidos.Pessoa(NIF)

);
GO

CREATE TABLE Higiliquidos.Funcionario (
  NIF_Funcionario INT NOT NULL,
  IBAN VARCHAR(64) NOT NULL,
  Numero_SS INT NOT NULL,
  Data_Inicio_Atividade DATE NOT NULL,
  Num_Func INT NOT NULL,

  FOREIGN KEY (NIF_Funcionario) REFERENCES Higiliquidos.Pessoa(NIF),
  PRIMARY KEY (Num_Func)
);
GO

CREATE TABLE Higiliquidos.Gerente (
  Num_Gerente INT NOT NULL,
  Num_Func INT NOT NULL,

  FOREIGN KEY(Num_Func) REFERENCES Higiliquidos.Funcionario(Num_Func),
  PRIMARY KEY (Num_Gerente)
);
GO

CREATE TABLE Higiliquidos.Distribuidor (
  Num_Distribuidor INT NOT NULL,
  Num_Func INT NOT NULL,

  PRIMARY KEY (Num_Distribuidor),
  FOREIGN KEY (Num_Func) REFERENCES Higiliquidos.Funcionario(Num_Func)
);
GO

CREATE TABLE Higiliquidos.Vendedor (
  Num_Vendedor INT NOT NULL,
  Num_Func INT NOT NULL,

  FOREIGN KEY (Num_Func) REFERENCES Higiliquidos.Funcionario(Num_Func),
  PRIMARY KEY (Num_Vendedor)
);
GO

CREATE TABLE Higiliquidos.Carrinha_Distribuidor (
  Matricula varchar(8) NOT NULL,
  Num_Distribuidor INT NOT NULL,
  Data_In DATE NOT NULL,
  Data_Out DATE,

  PRIMARY KEY (Matricula, Num_Distribuidor),
  FOREIGN KEY (Matricula) REFERENCES Higiliquidos.Carrinha(Matricula),
  FOREIGN KEY (Num_Distribuidor) REFERENCES Higiliquidos.Distribuidor(Num_Distribuidor)
);
GO

CREATE TABLE Higiliquidos.Compra (
  ID INT NOT NULL,
  Data_Compra Date NOT NULL,
  Quantidade INT NOT NULL,
  ID_Produto INT NOT NULL,
  ID_Armazem INT NOT NULL,
  Num_Fornecedor INT NOT NULL,

  PRIMARY KEY (ID),
  FOREIGN KEY (ID_Produto) REFERENCES Higiliquidos.Produto(ID),
  FOREIGN KEY (ID_Armazem) REFERENCES Higiliquidos.Armazem(ID),
  FOREIGN KEY (Num_Fornecedor) REFERENCES Higiliquidos.Fornecedor(Num_Fornecedor)
);
GO

CREATE TABLE Higiliquidos.Venda (
  ID INT NOT NULL,
  Quantidade INT NOT NULL,
  ID_Produto INT NOT NULL,
  ID_Armazem INT NOT NULL,
  Num_Vendedor INT NOT NULL,
  Num_Distribuidor INT NOT NULL,
  Num_Cliente INT NOT NULL,

  PRIMARY KEY (ID),
  FOREIGN KEY (ID_Produto) REFERENCES Higiliquidos.Produto(ID),
  FOREIGN KEY (ID_Armazem) REFERENCES Higiliquidos.Armazem(ID),
  FOREIGN KEY (Num_Cliente) REFERENCES Higiliquidos.Cliente(Num_Cliente),
  FOREIGN KEY (Num_Vendedor) REFERENCES Higiliquidos.Vendedor(Num_Vendedor),
  FOREIGN KEY (Num_Distribuidor) REFERENCES Higiliquidos.Distribuidor(Num_Distribuidor)
);
GO

CREATE TABLE Higiliquidos.Entrega (
  Data_Entrega DATE,
  ID_Venda INT NOT NULL,
  Num_Distribuidor INT NOT NULL,

  PRIMARY KEY(ID_Venda, Num_Distribuidor),
  FOREIGN KEY (ID_Venda) REFERENCES Higiliquidos.Venda(ID),
  FOREIGN KEY (Num_Distribuidor) REFERENCES Higiliquidos.Distribuidor(Num_Distribuidor)
  );
  GO

