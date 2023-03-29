use p8g8
go

CREATE TABLE Medicamentos_Especialidade(
	tipoEspecialidade				VARCHAR(30)		NOT NULL,	
	codigo							INT				NOT NULL,
	PRIMARY KEY(codigo) 
);

CREATE TABLE Medicamentos_Medico (
	n_id							INT				NOT NULL,
	Nome							VARCHAR(30)		NOT NULL,
	codigoEspecialidade				INT				NOT NULL,
	PRIMARY KEY(n_id),
	FOREIGN KEY(codigoEspecialidade) REFERENCES	Medicamentos_Especialidade(codigo));


CREATE TABLE Medicamentos_Paciente(
	DataNasc						DATE				NOT NULL,
	endereco						VARCHAR(20), 
	Nome							VARCHAR(30)			NOT NULL,
	N_utente						INT					NOT NULL,
	PRIMARY KEY(N_utente),
);


CREATE TABLE Medicamentos_Farmacia (
	Telefone						INT					NOT NULL,
	Endereco						VARCHAR(30),	
	Nome							INT 				NOT NULL,
	F_NIF							INT					NOT NULL,
	PRIMARY KEY(F_NIF),
	); 

CREATE TABLE Medicamentos_Farmacos(
	Nome_comercial					VARCHAR(20)			NOT NULL,
	Formula							VARCHAR(20) 		NOT NULL,
	PRIMARY KEY(Formula),
);

CREATE TABLE Medicamentos_Prescricao(
	Dataa							DATE,				 
	n_prescricao					INT					NOT NULL,
	Medico_responsavel				INT,
	Farmacia						INT,
	Paciente						INT,
	Farmacos						VARCHAR(20),
	PRIMARY KEY(n_prescricao),
	FOREIGN KEY(Medico_responsavel)	REFERENCES Medicamentos_Medico(n_id),
	FOREIGN KEY(Farmacia)	REFERENCES Medicamentos_Farmacia(F_NIF),
	FOREIGN KEY(Paciente)	REFERENCES Medicamentos_Paciente(N_utente),
	FOREIGN KEY(Farmacos)	REFERENCES Medicamentos_Farmacos(Formula));



CREATE TABLE Medicamentos_CompanhiaFarmaceutica(
	N_Registo_nacional				INT					NOT NULL,
	Nome							VARCHAR(20),
	Telefone						INT					NOT NULL,
	PRIMARY KEY(N_Registo_Nacional),
);

CREATE TABLE Medicamentos_ProduzirMedicamentos(
	companhia_farmaceutica			INT					NOT NULL,
	medicamentos					VARCHAR(20)			NOT NULL,
	PRIMARY KEY (companhia_farmaceutica, medicamentos),
	FOREIGN KEY(companhia_farmaceutica)		REFERENCES	Medicamentos_CompanhiaFarmaceutica(N_Registo_nacional),
	FOREIGN KEY(medicamentos)				REFERENCES Medicamentos_Farmacos(Formula));


CREATE TABLE Medicamentos_Venda(
	Farmacia						INT					NOT NULL,
	Produtos						VARCHAR(20)			NOT NULL,
	PRIMARY KEY (Farmacia, Produtos),
	FOREIGN KEY(Farmacia)	REFERENCES	Medicamentos_Farmacia(F_NIF),
	FOREIGN KEY(Produtos)	REFERENCES  Medicamentos_Farmacos(Formula));

