USE p8g8;
go



DROP TABLE GestaoATL_Atividades;
DROP TABLE GestaoATL_Enc_Edcucacao;
DROP TABLE GestaoATL_Pessoa;
DROP TABLE GestaoATL_Professor;
DROP TABLE GestaoATL_Aluno;
DROP TABLE GestaoATL_Turma;
DROP TABLE GestaoATL_P_Autorizada;

CREATE TABLE GestaoATL_Atividades (

	Custo		INT,
	Designacao	VARCHAR(30),
	Identificador INT,
	Turma_Identificador	INT,
	Aluno_Pessoa_NumCC	VARCHAR(9),

	PRIMARY KEY (Identificador)


	);


CREATE TABLE GestaoATL_Turma (

	AnoLetivo   INT,
	NumMaxAlunos INT not null,
	Designacao	VARCHAR(30),
	Identificador	INT,
	Professor_Numfunc	INT,
	Atividades_Identificador	INT,

	PRIMARY KEY (Identificador),
	FOREIGN KEY (Atividades_Identificador) REFERENCES GestaoATL_Atividades(Identificador)

	);

CREATE TABLE GestaoATL_Pessoa (

	Nome VARCHAR(30),
	NumCC VARCHAR(9),
	Morada VARCHAR(30),
	DataNasc date,

	PRIMARY KEY (NumCC)

	);

CREATE TABLE GestaoATL_Aluno (

	NumCC VARCHAR(9),
	Turma_Identificador INT,
	Atividades_Identificador INT,


	PRIMARY KEY (NumCC),
	FOREIGN KEY (Atividades_Identificador) REFERENCES GestaoATL_Atividades(Identificador),
	FOREIGN KEY (Turma_Identificador) REFERENCES GestaoATL_Turma(Identificador),
	FOREIGN KEY (NumCC) REFERENCES GestaoATL_Pessoa(NumCC)
	
	
	);

CREATE TABLE GestaoATL_Professor (

	NumFunc INT,
	Telemovel VARCHAR(9),
	Email	VARCHAR(30),
	Turma_Identificador	INT,
	NumCC	VARCHAR(9),

	PRIMARY KEY (NumFunc),
	FOREIGN KEY (Turma_Identificador) REFERENCES GestaoATL_Turma(Identificador),
	FOREIGN KEY (NumCC) REFERENCES GestaoATL_Pessoa(NumCC)

	);



CREATE TABLE GestaoATL_P_Autorizada (

	NumCC	VARCHAR(9),

	PRIMARY KEY (NumCC),
	FOREIGN KEY (NumCC) REFERENCES GestaoATL_Aluno(NumCC)

	);



CREATE TABLE GestaoATL_Enc_Educacao (

	NumCC	VARCHAR(9),
	RelacaoAluno VARCHAR(30),
	Telemovel	VARCHAR(9),
	Email	VARCHAR(30),
	NumCC_Aluno VARCHAR(9),

	PRIMARY KEY (NumCC),
	FOREIGN KEY (NumCC) REFERENCES GestaoATL_Pessoa(NumCC),
	FOREIGN KEY (NumCC_Aluno) REFERENCES GestaoATL_P_Autorizada(NumCC)

	);

	









