use p8g8;


DROP TABLE IF EXISTS Higiliquidos.Produto;
DROP TABLE IF EXISTS Higiliquidos.Armazem;
DROP TABLE IF EXISTS Higiliquidos.Carrinha;
DROP TABLE IF EXISTS Higiliquidos.Pessoa;
DROP TABLE IF EXISTS Higiliquidos.Empresa;
DROP TABLE IF EXISTS Higiliquidos.Fornecedor;
DROP TABLE IF EXISTS Higiliquidos.Encomenda;
DROP TABLE IF EXISTS Higiliquidos.Encomenda_Fornecedor;
DROP TABLE IF EXISTS Higiliquidos.Cliente;
DROP TABLE IF EXISTS Higiliquidos.Encomenda_Cliente;  
DROP TABLE IF EXISTS Higiliquidos.Funcionario;
DROP TABLE IF EXISTS Higiliquidos.Vendedor;
DROP TABLE IF EXISTS Higiliquidos.Distribuidor;
DROP TABLE IF EXISTS Higiliquidos.Encomenda_Distribuidor;
DROP TABLE IF EXISTS Higiliquidos.Carrinha_Distribuidor;
DROP TABLE IF EXISTS Higiliquidos.Gerente;
DROP TABLE IF EXISTS Higiliquidos.Encomenda_Produto;



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


CREATE TABLE Higiliquidos.Armazem (
  ID INT NOT NULL,
  Tamanho INT NOT NULL,
  Endereco varchar(64) NOT NULL,
  ID_Produto INT NOT NULL,
  
  PRIMARY KEY (ID),
  FOREIGN KEY (ID_Produto) REFERENCES Higiliquidos.Produto(ID)
  
);


CREATE TABLE Higiliquidos.Carrinha (
  Matricula varchar(64) NOT NULL,
  Ano INT NOT NULL,
  Marca varchar(32) NOT NULL,
  Combustivel varchar(32) NOT NULL,
  Peso INT NOT NULL,

  PRIMARY KEY (matricula)
);


CREATE TABLE Higiliquidos.Pessoa (  
  NIF INT NOT NULL,
  Nome varchar(256) NOT NULL,
  Data_de_Nascimento DATE NOT NULL,
  Email varchar(64) NOT NULL,
  Morada varchar(64) NOT NULL,
  ContactoTelefonico INT NOT NULL,
  
  PRIMARY KEY (NIF)
);  


CREATE TABLE Higiliquidos.Empresa (
  Nome varchar(64) NOT NULL,
  Email varchar(64) NOT NULL,
  Endereco varchar(64) NOT NULL,
  ContactoTelefonico INT NOT NULL,
  ID_Armazem INT NOT NULL,
  NIF_Pessoa INT NOT NULL,
  Matricula_Carrinha varchar(64),

  PRIMARY KEY (Nome),
  FOREIGN KEY (ID_Armazem) REFERENCES Higiliquidos.Armazem(ID),
  FOREIGN KEY (NIF_Pessoa) REFERENCES Higiliquidos.Pessoa(NIF),
  FOREIGN KEY (Matricula_Carrinha) REFERENCES Higiliquidos.Carrinha(Matricula)
);


CREATE TABLE Higiliquidos.Fornecedor (
  NIF_Fornecedor INT NOT NULL,

  PRIMARY KEY (NIF_Fornecedor),
  FOREIGN KEY (NIF_Fornecedor) REFERENCES Higiliquidos.Pessoa(NIF)

);


CREATE TABLE Higiliquidos.Encomenda (
  ID INT NOT NULL,
  ID_Produto INT NOT NULL,
  Quantidade_Produto INT NOT NULL,

  PRIMARY KEY (ID),
  FOREIGN KEY (ID_Produto) REFERENCES Higiliquidos.Produto(ID),
  FOREIGN KEY (Quantidade_Produto) REFERENCES Higiliquidos.Produto(Quantidade)
);


CREATE TABLE Higiliquidos.Encomenda_Fornecedor (
  NIF_Fornecedor INT NOT NULL,
  ID_Encomenda INT NOT NULL,

  PRIMARY KEY (ID_Encomenda),
  FOREIGN KEY (NIF_Fornecedor) REFERENCES Higiliquidos.Fornecedor(NIF_Fornecedor),
  FOREIGN KEY (ID_Encomenda) REFERENCES Higiliquidos.Encomenda(ID)

);


CREATE TABLE Higiliquidos.Cliente (
  NIF_Cliente INT NOT NULL,

  PRIMARY KEY (NIF_Cliente),
  FOREIGN KEY (NIF_Cliente) REFERENCES Higiliquidos.Pessoa(NIF)
);


CREATE TABLE Higiliquidos.Encomenda_Cliente (
  NIF_Cliente INT NOT NULL,
  ID_Encomenda INT NOT NULL,

  PRIMARY KEY (ID_Encomenda),
  FOREIGN KEY (NIF_Cliente) REFERENCES Higiliquidos.Cliente(NIF_Cliente),
  FOREIGN KEY (ID_Encomenda) REFERENCES Higiliquidos.Encomenda(ID)

);


CREATE TABLE Higiliquidos.Funcionario (
  NIF_Funcionario INT NOT NULL,
  IBAN VARCHAR(32) NOT NULL,
  Numero_SS INT NOT NULL,
  Data_Inicio_Atividade DATE NOT NULL,
  Num_Func INT NOT NULL,

  FOREIGN KEY (NIF_Funcionario) REFERENCES Higiliquidos.Pessoa(NIF),
  PRIMARY KEY (NIF_Funcionario)
);


CREATE TABLE Higiliquidos.Vendedor (
  NIF_Vendedor INT NOT NULL,
  Num_Func INT NOT NULL,

  FOREIGN KEY (NIF_Vendedor) REFERENCES Higiliquidos.Funcionario(NIF_Funcionario),
  FOREIGN KEY (Num_Func) REFERENCES Higiliquidos.Funcionario(Num_Func),
  PRIMARY KEY (NIF_Vendedor)
);


CREATE TABLE Higiliquidos.Distribuidor (
  NIF_Distribuidor INT NOT NULL,
  Matricula_Carrinha varchar(64) NOT NULL,
  Num_Func INT NOT NULL,

  PRIMARY KEY (NIF_Distribuidor),
  FOREIGN KEY (NIF_Distribuidor) REFERENCES Higiliquidos.Funcionario(NIF_Funcionario),
  FOREIGN KEY (Matricula_Carrinha) REFERENCES Higiliquidos.Carrinha(Matricula),
  FOREIGN KEY (Num_Func) REFERENCES Higiliquidos.Funcionario(Num_Func)
);


CREATE TABLE Higiliquidos.Encomenda_Distribuidor (
  NIF_Distribuidor INT NOT NULL,
  ID_Encomenda INT NOT NULL,
  Data_Entrega DATE NOT NULL,

  PRIMARY KEY (Data_Entrega,  ID_Encomenda),
  FOREIGN KEY (NIF_Distribuidor) REFERENCES Higiliquidos.Distribuidor(NIF_Distribuidor),
  FOREIGN KEY (ID_Encomenda) REFERENCES Higiliquidos.Encomenda(ID)

);


CREATE TABLE Higiliquidos.Carrinha_Distribuidor (
  Matricula_Carrinha varchar(64) NOT NULL,
  NIF_Distribuidor INT NOT NULL,
  Data_In DATE NOT NULL,
  Data_Out DATE,

  PRIMARY KEY (Matricula_Carrinha, NIF_Distribuidor),
  FOREIGN KEY (Matricula_Carrinha) REFERENCES Higiliquidos.Carrinha(Matricula),
  FOREIGN KEY (NIF_Distribuidor) REFERENCES Higiliquidos.Distribuidor(NIF_Distribuidor)
);


CREATE TABLE Higiliquidos.Gerente (
  NIF_Gerente INT NOT NULL,
  Matricula_Carrinha varchar(64) NOT NULL,
  Num_Func INT NOT NULL,

  FOREIGN KEY (NIF_Gerente) REFERENCES Higiliquidos.Funcionario(NIF_Funcionario),
  FOREIGN KEY(Num_Func) REFERENCES Higiliquidos.Funcionario(Num_Func),
  PRIMARY KEY (NIF_Gerente)
);


CREATE TABLE Higiliquidos.Encomenda_Produto (
  ID_Encomenda INT,
  ID_Produto INT,
  Quantidade INT,
  FOREIGN KEY (ID_Encomenda) REFERENCES Higiliquidos.Encomenda(ID),
  FOREIGN KEY (ID_Produto) REFERENCES Higiliquidos.Produto(ID),
  PRIMARY KEY (Quantidade, ID_Encomenda, ID_Produto)
);









