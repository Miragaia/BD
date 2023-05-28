use p8g8;
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

DROP SCHEMA IF EXISTS Higiliquidos;

GO
CREATE SCHEMA Higiliquidos;
GO








CREATE TABLE Higiliquidos.Empresa (
  NIF_Empresa INT NOT NULL,
  Nome varchar(64) NOT NULL,
  Email varchar(64) NOT NULL,
  Endereco varchar(64) NOT NULL,
  ContactoTelefonico INT NOT NULL,


  PRIMARY KEY (NIF_Empresa)  
);


CREATE TABLE Higiliquidos.Carrinha (
  Matricula varchar(8) NOT NULL,
  Ano INT NOT NULL,
  Marca varchar(32) NOT NULL,
  Combustivel varchar(32) NOT NULL,
  Peso INT NOT NULL,
  NIF_Empresa INT NOT NULL,

  PRIMARY KEY (Matricula),
  FOREIGN KEY (NIF_Empresa) REFERENCES Higiliquidos.Empresa(NIF_Empresa)
);


CREATE TABLE Higiliquidos.Armazem (
  ID INT NOT NULL,
  Area INT NOT NULL,
  Endereco varchar(64) NOT NULL,
  NIF_Empresa INT NOT NULL,
  
  PRIMARY KEY (ID),
  FOREIGN KEY (NIF_Empresa) REFERENCES Higiliquidos.Empresa(NIF_Empresa)  
);


CREATE TABLE Higiliquidos.Pessoa (  
  NIF INT NOT NULL,
  Nome varchar(256) NOT NULL,
  Data_de_Nascimento DATE NOT NULL,
  Email varchar(64) NOT NULL,
  Morada varchar(64) NOT NULL,
  ContactoTelefonico INT NOT NULL,
  NIF_Empresa INT NOT NULL,
  
  PRIMARY KEY (NIF),
  FOREIGN KEY (NIF_Empresa) REFERENCES Higiliquidos.Empresa(NIF_Empresa)
);  


CREATE TABLE Higiliquidos.Produto (
  ID INT NOT NULL,
  Nome VARCHAR(64) NOT NULL,
  Marca VARCHAR(64) NOT NULL,
  Tipo_de_Produto VARCHAR(64),
  IVA DECIMAL(5, 2) NOT NULL,
  Preco DECIMAL(10, 2) NOT NULL,
  Quantidade INT NOT NULL,

  PRIMARY KEY (ID)

);


CREATE TABLE Higiliquidos.Cliente (
  NIF_Cliente INT NOT NULL,
  Num_Cliente INT NOT NULL,

  PRIMARY KEY (Num_Cliente),
  FOREIGN KEY (NIF_Cliente) REFERENCES Higiliquidos.Pessoa(NIF)
);


CREATE TABLE Higiliquidos.Fornecedor (
  NIF_Fornecedor INT NOT NULL,
  Num_Fornecedor INT NOT NULL,

  PRIMARY KEY (Num_Fornecedor),
  FOREIGN KEY (NIF_Fornecedor) REFERENCES Higiliquidos.Pessoa(NIF)

);


CREATE TABLE Higiliquidos.Funcionario (
  NIF_Funcionario INT NOT NULL,
  IBAN VARCHAR(64) NOT NULL,
  Numero_SS INT NOT NULL,
  Data_Inicio_Atividade DATE NOT NULL,
  Num_Func INT NOT NULL,

  FOREIGN KEY (NIF_Funcionario) REFERENCES Higiliquidos.Pessoa(NIF),
  PRIMARY KEY (Num_Func)
);


CREATE TABLE Higiliquidos.Gerente (
  Num_Gerente INT NOT NULL,
  Num_Func INT NOT NULL,

  FOREIGN KEY(Num_Func) REFERENCES Higiliquidos.Funcionario(Num_Func),
  PRIMARY KEY (Num_Gerente)
);


CREATE TABLE Higiliquidos.Distribuidor (
  Num_Distribuidor INT NOT NULL,
  Num_Func INT NOT NULL,

  PRIMARY KEY (Num_Distribuidor),
  FOREIGN KEY (Num_Func) REFERENCES Higiliquidos.Funcionario(Num_Func)
);


CREATE TABLE Higiliquidos.Vendedor (
  Num_Vendedor INT NOT NULL,
  Num_Func INT NOT NULL,

  FOREIGN KEY (Num_Func) REFERENCES Higiliquidos.Funcionario(Num_Func),
  PRIMARY KEY (Num_Vendedor)
);


CREATE TABLE Higiliquidos.Carrinha_Distribuidor (
  Matricula varchar(8) NOT NULL,
  Num_Distribuidor INT NOT NULL,
  Data_In DATE NOT NULL,
  Data_Out DATE,

  PRIMARY KEY (Matricula, Num_Distribuidor),
  FOREIGN KEY (Matricula) REFERENCES Higiliquidos.Carrinha(Matricula),
  FOREIGN KEY (Num_Distribuidor) REFERENCES Higiliquidos.Distribuidor(Num_Distribuidor)
);


CREATE TABLE Higiliquidos.Compra (
  ID INT NOT NULL,
  Data_Compra Date,
  Quantidade INT NOT NULL,
  ID_Produto INT NOT NULL,
  ID_Armazem INT NOT NULL,
  Num_Fornecedor INT NOT NULL,

  PRIMARY KEY (ID),
  FOREIGN KEY (ID_Produto) REFERENCES Higiliquidos.Produto(ID),
  FOREIGN KEY (ID_Armazem) REFERENCES Higiliquidos.Armazem(ID),
  FOREIGN KEY (Num_Fornecedor) REFERENCES Higiliquidos.Fornecedor(Num_Fornecedor)
);


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


CREATE TABLE Higiliquidos.Entrega (
  Data_Entrega DATE NOT NULL,
  ID_Venda INT NOT NULL,
  Num_Distribuidor INT NOT NULL,

  PRIMARY KEY(ID_Venda, Num_Distribuidor),
  FOREIGN KEY (ID_Venda) REFERENCES Higiliquidos.Venda(ID),
  FOREIGN KEY (Num_Distribuidor) REFERENCES Higiliquidos.Distribuidor(Num_Distribuidor)
  );