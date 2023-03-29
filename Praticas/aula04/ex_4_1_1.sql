USE p8g8
GO

CREATE TABLE RentACar_Balcao (
	[Numero][int] NOT NULL PRIMARY KEY,
	[Nome][varchar](256) NOT NULL,
	[Endereco][varchar](1024) NOT NULL,
)
GO

CREATE TABLE RentACar_Cliente (
	[NIF][int] NOT NULL PRIMARY KEY,
	[Nome][varchar](256) NOT NULL,
	[Endereco][varchar](1024) NOT NULL,
	[num_carta][varchar](32) NOT NULL,
)
GO

CREATE TABLE RentACar_TipoVeiculo(
	[Codigo][int] NOT NULL IDENTITY PRIMARY KEY,
	[Designacao][varchar](128) NOT NULL,
	[ArCondicionado][bit] NOT NULL,
)
GO

CREATE TABLE RentACar_Veiculo(
	[Matricula][varchar](16) NOT NULL PRIMARY KEY,
	[Ano] [int] NOT NULL,
	[Marca] [varchar](256) NOT NULL,
	[TipoVeiculo_Codigo] [int] NOT NULL REFERENCES RentACar_TipoVeiculo ([Codigo]),
)
GO

CREATE TABLE RentACar_Ligeiro(
	[TipoVeiculo_Codigo][int] NOT NULL PRIMARY KEY REFERENCES RentACar_TipoVeiculo ([Codigo]),
	[Portas][int] NOT NULL,
	[Combustivel][varchar](30) NOT NULL,
	[NumLugares][int] NOT NULL,
)
GO

CREATE TABLE RentACar_Pesado(
	[TipoVeiculo_Codigo][int] NOT NULL PRIMARY KEY REFERENCES RentACar_TipoVeiculo ([Codigo]),
	Peso[int] NOT NULL,
	[Passageiros][int] NOT NULL,
)
GO


CREATE TABLE RentACar_Aluguer (
	[Numero][int] NOT NULL PRIMARY KEY,
	[Duracao][int] NOT NULL,
	[Data][int] NOT NULL,
	[Balcao_Numero][int] NOT NULL REFERENCES RentACar_Balcao([Numero]),
	[Cliente_NIF][int] NOT NULL REFERENCES RentACar_Cliente([NIF]),
	[Veiculo_Matricula][varchar](16) NOT NULL REFERENCES RentACar_Veiculo([Matricula]),
)
GO

CREATE TABLE RentACar_Similaridade(
	[Codigo1][int] NOT NULL REFERENCES RentACar_TipoVeiculo ([Codigo]),
	[Codigo2][int] NOT NULL REFERENCES RentACar_TipoVeiculo ([Codigo]),
	PRIMARY KEY	([Codigo1],[Codigo2]),
)
GO
