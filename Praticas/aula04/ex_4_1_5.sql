USE p8g8;
go

CREATE TABLE Conferencia_Instituicao(

	Nome	VARCHAR(30),
	Endereço	VARCHAR(40),

	PRIMARY KEY (Nome),

	);

CREATE TABLE Conferencia_Artigo (
	
	Titulo VARCHAR(30),
	Num_Registo	INT,

	PRIMARY KEY(Num_Registo)

	);

CREATE TABLE Conferencia_Estudante (

	Nome VARCHAR(30),
	Comprovativo	VARCHAR(30)

	PRIMARY KEY (Nome)

	);

CREATE TABLE Conferencia_Nestudante (

	Nome	VARCHAR(30),
	Comprovativo	VARCHAR(30)

	PRIMARY KEY (Nome)
	);	

CREATE TABLE Conferencia_Pessoa (

	Nome	VARCHAR(30),
	Código INT,
	Email	VARCHAR(30),
	Instituição	VARCHAR(30),

	PRIMARY KEY	(Código)

	);

CREATE TABLE Conferencia_Autor (

	
	Nome	VARCHAR(30),
	N_registo	INT,
	Titulo	VARCHAR(30),
	Num_Artigo	INT,

	PRIMARY KEY (N_registo),
	FOREIGN KEY (Num_Artigo) REFERENCES Conferencia_Artigo(Num_Registo)

	);

CREATE TABLE Conferencia_Participante (
	
	Nome VARCHAR(30),
	Morada	VARCHAR(30),
	Email	VARCHAR(30),
	Instituição	VARCHAR(30),
	DataInscrição	date,

	PRIMARY KEY (Nome),


	);



ALTER TABLE Conferencia_Nestudante ADD CONSTRAINT Nestudante FOREIGN KEY (Nome) REFERENCES Conferencia_Participante (Nome);
ALTER TABLE Conferencia_Estudante ADD CONSTRAINT Estudante FOREIGN KEY (Nome) REFERENCES Conferencia_Participante (Nome);
ALTER TABLE Conferencia_Pessoa ADD CONSTRAINT P_Instituicao FOREIGN KEY (Nome) REFERENCES Conferencia_Instituicao (Nome);
ALTER TABLE Conferencia_Autor ADD CONSTRAINT P_Autor FOREIGN KEY (Nome) REFERENCES Conferencia_Pessoa (Nome);





