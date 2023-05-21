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
  nome VARCHAR(64) NOT NULL,
  marca VARCHAR(64) NOT NULL,
  Tipo_de_Produto VARCHAR(64),
  IVA DECIMAL(5, 2) NOT NULL,
  Preco DECIMAL(10, 2) NOT NULL,
  quantidade INT NOT NULL,

  PRIMARY KEY (ID)

);


CREATE TABLE Higiliquidos.Armazem (
  ID INT NOT NULL,
  tamanho INT NOT NULL,
  endereco varchar(64) NOT NULL,
  ID_Produto INT NOT NULL,
  
  PRIMARY KEY (ID),
  FOREIGN KEY (ID_Produto) REFERENCES Higiliquidos.Produto(ID)
  
);


CREATE TABLE Higiliquidos.Carrinha (
  matricula varchar(64) NOT NULL,
  ano INT NOT NULL,
  marca varchar(32) NOT NULL,
  combustivel varchar(32) NOT NULL,
  peso INT NOT NULL,

  PRIMARY KEY (matricula)
);


CREATE TABLE Higiliquidos.Pessoa (  
  NIF INT NOT NULL,
  nome varchar(64) NOT NULL,
  Data_de_Nascimento DATE NOT NULL,
  email varchar(64) NOT NULL,
  morada varchar(64) NOT NULL,
  ContactoTelefonico INT NOT NULL,
  
  PRIMARY KEY (NIF)
);  


CREATE TABLE Higiliquidos.Empresa (
  nome varchar(64) NOT NULL,
  email varchar(64) NOT NULL,
  endereco varchar(64) NOT NULL,
  ContactoTelefonico INT NOT NULL,
  ID_Armazem INT NOT NULL,
  NIF_Pessoa INT NOT NULL,
  matricula_Carrinha varchar(64),

  PRIMARY KEY (nome),
  FOREIGN KEY (ID_Armazem) REFERENCES Higiliquidos.Armazem(ID),
  FOREIGN KEY (NIF_Pessoa) REFERENCES Higiliquidos.Pessoa(NIF),
  FOREIGN KEY (matricula_Carrinha) REFERENCES Higiliquidos.Carrinha(matricula)
);


CREATE TABLE Higiliquidos.Fornecedor (
  NIF_Fornecedor INT NOT NULL,

  PRIMARY KEY (NIF_Fornecedor),
  FOREIGN KEY (NIF_Fornecedor) REFERENCES Higiliquidos.Pessoa(NIF)

);


CREATE TABLE Higiliquidos.Encomenda (
  ID INT PRIMARY KEY,
  Data_Entrega VARCHAR(255),
  ID_Produto INT NOT NULL,
  Quantidade_Produto INT NOT NULL,
  Quantidade_Total INT NOT NULL,

  PRIMARY KEY (ID),
  FOREIGN KEY (ID_Produto) REFERENCES Higiliquidos.Produto(ID),
  FOREIGN KEY (Quantidade_Produto) REFERENCES Higiliquidos.Produto(quantidade)
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
  IBAN VARCHAR(32) NOT NULL,
  Numero_SS INT NOT NULL,
  Data_Inicio_Atividade DATE NOT NULL,
  NIF_Funcionario INT NOT NULL,
  FOREIGN KEY (NIF_Funcionario) REFERENCES Higiliquidos.Pessoa(NIF),
  PRIMARY KEY (NIF_Funcionario)
);


CREATE TABLE Higiliquidos.Vendedor (
  Permissao_Venda BOOLEAN NOT NULL,
  NIF_Vendedor INT NOT NULL,

  FOREIGN KEY (NIF_Vendedor) REFERENCES Higiliquidos.Funcionario(NIF_Funcionario),
  PRIMARY KEY (NIF_Vendedor)
);


CREATE TABLE Higiliquidos.Distribuidor (
  Permissao_Distribuir BOOLEAN NOT NULL,
  NIF_Distribuidor INT NOT NULL,
  Matricula_Carrinha varchar(64) NOT NULL,

  PRIMARY KEY (NIF_Distribuidor),
  FOREIGN KEY (NIF_Distribuidor) REFERENCES Higiliquidos.Funcionario(NIF_Funcionario),
  FOREIGN KEY (Matricula_Carrinha) REFERENCES Higiliquidos.Carrinha(matricula)
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
  data_In DATE NOT NULL,
  data_Out DATE,

  PRIMARY KEY (data_In, data_Out, Matricula_Carrinha, NIF_Distribuidor),
  FOREIGN KEY (Matricula_Carrinha) REFERENCES Higiliquidos.Carrinha(matricula),
  FOREIGN KEY (NIF_Distribuidor) REFERENCES Higiliquidos.Distribuidor(NIF_Distribuidor)
);


CREATE TABLE Higiliquidos.Gerente (
  Permissao_Venda BOOLEAN NOT NULL,
  Permissao_Gerenciar BOOLEAN NOT NULL,
  Permissao_Distribuir BOOLEAN NOT NULL,
  NIF_Gerente INT NOT NULL,
  Matricula_Carrinha varchar(64) NOT NULL,

  FOREIGN KEY (NIF_Gerente) REFERENCES Higiliquidos.Funcionario(NIF_Funcionario),
  PRIMARY KEY (NIF_Gerente)
);


CREATE TABLE Higiliquidos.Encomenda_Produto (
  ID_Encomenda INT,
  ID_Produto INT,
  quantidade INT,
  FOREIGN KEY (ID_Encomenda) REFERENCES Higiliquidos.Encomenda(ID),
  FOREIGN KEY (ID_Produto) REFERENCES Higiliquidos.Produto(ID),
  PRIMARY KEY (quantidade, ID_Encomenda, ID_Produto)
);









