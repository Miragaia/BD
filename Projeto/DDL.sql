Use p8g8
GO

DROP TABLE IF EXISTS Higiliquidos.Carrinha;

CREATE TABLE Higiliquidos.Carrinha (
  matricula varchar(64) NOT NULL,
  ano INT NOT NULL,
  marca varchar(32) NOT NULL,
  combustivel varchar(32) NOT NULL,
  peso INT,

  PRIMARY KEY ('matricula')
)
GO

DROP TABLE IF EXISTS Higiliquidos.Empresa;

CREATE TABLE Higiliquidos.Empresa (
  nome varchar(64) NOT NULL,
  email varchar(64) NOT NULL,
  endereco varchar(64) NOT NULL,
  ContactoTelefonico INT NOT NULL,

  PRIMARY KEY ('nome')
)
GO

DROP TABLE IF EXISTS Higiliquidos.Armazem;

CREATE TABLE Higiliquidos.Armazem (
  id INT NOT NULL,
  tamanho INT,
  endereco varchar(64) NOT NULL,
  
  PRIMARY KEY ('id')
)
GO

DROP TABLE IF EXISTS Higiliquidos.Pessoa;

CREATE TABLE Higiliquidos.Pessoa (
  id INT NOT NULL,
  nome varchar(64) NOT NULL,
  email varchar(64) NOT NULL,
  morada varchar(64) NOT NULL,
  ContactoTelefonico INT NOT NULL,
  NIF INT,
  Data_de_Nascimento DATE,
  
  PRIMARY KEY ('id')
)
GO



