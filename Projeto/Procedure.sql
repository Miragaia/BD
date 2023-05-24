USE p8g8
GO
------------------
CREATE PROCEDURE Higiliquidos.AdicionarPessoa (@NIF INT, @Nome VARCHAR(256), @Data_de_Nascimento DATE, @Email varchar(64), @Morada VARCHAR(256), @ContactoTelefonico VARCHAR(9))
AS
	BEGIN
		INSERT INTO Higiliquidos.Pessoa(NIF, Nome, Data_de_Nascimento, Email, Morada, ContactoTelefonico) VALUES (@NIF, @Nome, @Data_de_Nascimento, @Email, @Morada, @ContactoTelefonico);
	END
GO


CREATE PROCEDURE Higiliquidos.AdicionarCliente (@NIF INT, @Nome VARCHAR(256), @Data_de_Nascimento DATE, @Email varchar(64), @Morada VARCHAR(256), @ContactoTelefonico VARCHAR(9))
AS
	BEGIN
		DECLARE @count INT;
		DECLARE @erro VARCHAR(100);
		SET @count = (SELECT Higiliquidos.checkIfNIFExists(@NIF))
		IF(@count>=1)
			RAISERROR ('O NIF introduzido já existe, não é possível adicionar o Cliente', 16,1);
		ELSE
			BEGIN
				BEGIN TRY
					BEGIN TRAN
								INSERT INTO Higiliquidos.Pessoa(NIF, Nome, Data_de_Nascimento, Email, Morada, ContactoTelefonico) VALUES (@NIF, @Nome, @Data_de_Nascimento, @Email, @Morada, @ContactoTelefonico);
								INSERT INTO Higiliquidos.Cliente (NIF_Cliente) VALUES (@NIF)
					COMMIT TRAN
				END TRY
				BEGIN CATCH
					Rollback TRAN
					SELECT @erro = ERROR_MESSAGE(); 
					SET @erro =  'O Cliente não foi inserido, algum valor inserido incorretamento'
					RAISERROR (@erro, 16,1);
				END CATCH
			END
	End
GO


CREATE PROCEDURE Higiliquidos.AdicionarFornecedor (@NIF INT, @Nome VARCHAR(256), @Data_de_Nascimento DATE, @Email varchar(64), @Morada VARCHAR(256), @ContactoTelefonico VARCHAR(9))
AS
	BEGIN
		DECLARE @count INT;
		DECLARE @erro VARCHAR(100);
		SET @count = (SELECT Higiliquidos.checkIfNIFExists(@NIF))
		IF(@count>=1)
			RAISERROR ('O NIF introduzido já existe, não é possível adicionar o Fornecedor', 16,1);
		ELSE
			BEGIN
				BEGIN TRY
					BEGIN TRAN
								INSERT INTO Higiliquidos.Pessoa (NIF, Nome, Data_de_Nascimento, Email, Morada, ContactoTelefonico) VALUES (@NIF, @Nome, @Data_de_Nascimento, @Email, @Morada, @ContactoTelefonico);
								INSERT INTO Higiliquidos.Fornecedor (NIF_Fornecedor) VALUES (@NIF)
					COMMIT TRAN
				END TRY
				BEGIN CATCH
					Rollback TRAN
					SELECT @erro = ERROR_MESSAGE(); 
					SET @erro =  'O Fornecedor não foi inserido, algum valor inserido incorretamento'
					RAISERROR (@erro, 16,1);
				END CATCH
			END
	End
GO


CREATE PROCEDURE Higiliquidos.AdicionarFuncionario (@NIF INT, @Nome VARCHAR(256), @Data_de_Nascimento DATE, @Email varchar(64), @Morada VARCHAR(256), @ContactoTelefonico VARCHAR(9), @IBAN VARCHAR(25), @Data_Inicio_Atividade DATE, @Numero_SS INT, @Num_Func INT)
AS
	BEGIN
		DECLARE @count INT;
		DECLARE @erro VARCHAR(100);
		SET @count = (SELECT Higiliquidos.checkIfNIFExists(@NIF))
		IF(@count>=1)
			RAISERROR ('O NIF introduzido já existe, não é possível adicionar o Funcionario', 16,1);
		ELSE
			BEGIN
				BEGIN TRY
					BEGIN TRAN
								INSERT INTO Higiliquidos.Pessoa(NIF, Nome, Data_de_Nascimento, Email, Morada, ContactoTelefonico) VALUES (@NIF, @Nome, @Data_de_Nascimento, @Email, @Morada, @ContactoTelefonico);
								INSERT INTO Higiliquidos.Funcionario(NIF_Funcionario, IBAN, Data_Inicio_Atividade, Numero_SS, Num_Func) VALUES (@NIF, @IBAN, @Data_Inicio_Atividade, @Numero_SS, @Num_Func)
					COMMIT TRAN
				END TRY
				BEGIN CATCH
					Rollback TRAN
					SELECT @erro = ERROR_MESSAGE(); 
					SET @erro =  'O Funcionario não foi inserido, algum valor inserido incorretamento'
					RAISERROR (@erro, 16,1);
				END CATCH
			END
	End
GO


CREATE PROCEDURE Higiliquidos.AdicionarVendedor (@NIF INT, @Nome VARCHAR(256), @Data_de_Nascimento DATE, @Email varchar(64), @Morada VARCHAR(256), @ContactoTelefonico VARCHAR(9), @IBAN VARCHAR(25), @Data_Inicio_Atividade DATE, @Numero_SS INT, @Num_Func INT)
AS
	BEGIN
		DECLARE @count INT;
		DECLARE @erro VARCHAR(100);
		SET @count = (SELECT Higiliquidos.checkIfNIFExists(@NIF))
		IF(@count>=1)
			RAISERROR ('O NIF introduzido já existe, não é possível adicionar o Vendedor', 16,1);
		ELSE
			BEGIN
				BEGIN TRY
					BEGIN TRAN
								INSERT INTO Higiliquidos.Pessoa(NIF, Nome, Data_de_Nascimento, Email, Morada, ContactoTelefonico) VALUES (@NIF, @Nome, @Data_de_Nascimento, @Email, @Morada, @ContactoTelefonico);
								INSERT INTO Higiliquidos.Funcionario(NIF_Funcionario, IBAN, Data_Inicio_Atividade, Numero_SS, Num_Func) VALUES (@NIF, @IBAN, @Data_Inicio_Atividade, @Numero_SS, @Num_Func)
								INSERT INTO Higiliquidos.Vendedor (NIF_Vendedor, Num_Func) VALUES (@NIF, @Num_Func)
					COMMIT TRAN
				END TRY
				BEGIN CATCH
					Rollback TRAN
					SELECT @erro = ERROR_MESSAGE(); 
					SET @erro =  'O Vendedor não foi inserido, algum valor inserido incorretamento'
					RAISERROR (@erro, 16,1);
				END CATCH
			END
	End
GO

CREATE PROCEDURE Higiliquidos.AdicionarDistribuidor (@NIF INT, @Nome VARCHAR(256), @Data_de_Nascimento DATE, @Email varchar(64), @Morada VARCHAR(256), @ContactoTelefonico VARCHAR(9), @IBAN VARCHAR(25), @Data_Inicio_Atividade DATE, @Numero_SS INT, @Num_Func INT, @Matricula_Carrinha varchar(64))
AS
	BEGIN
		DECLARE @count INT;
		DECLARE @erro VARCHAR(100);
		SET @count = (SELECT Higiliquidos.checkIfNIFExists(@NIF))
		IF(@count>=1)
			RAISERROR ('O NIF introduzido já existe, não é possível adicionar o Distribuidor', 16,1);
		ELSE
			BEGIN
				BEGIN TRY
					BEGIN TRAN
								INSERT INTO Higiliquidos.Pessoa(NIF, Nome, Data_de_Nascimento, Email, Morada, ContactoTelefonico) VALUES (@NIF, @Nome, @Data_de_Nascimento, @Email, @Morada, @ContactoTelefonico);
								INSERT INTO Higiliquidos.Funcionario(NIF_Funcionario, IBAN, Data_Inicio_Atividade, Numero_SS, Num_Func) VALUES (@NIF, @IBAN, @Data_Inicio_Atividade, @Numero_SS, @Num_Func)
								INSERT INTO Higiliquidos.Distribuidor (NIF_Distribuidor, Matricula_Carrinha, Nun_Func) VALUES (@NIF, @Matricula_Carrinha, @Num_Func)
					COMMIT TRAN
				END TRY
				BEGIN CATCH
					Rollback TRAN
					SELECT @erro = ERROR_MESSAGE(); 
					SET @erro =  'O Distribuidor não foi inserido, algum valor inserido incorretamento'
					RAISERROR (@erro, 16,1);
				END CATCH
			END
	End
GO

CREATE PROCEDURE Higiliquidos.AdicionarGerente (@NIF INT, @Nome VARCHAR(256), @Data_de_Nascimento DATE, @Email varchar(64), @Morada VARCHAR(256), @ContactoTelefonico VARCHAR(9), @IBAN VARCHAR(25), @Data_Inicio_Atividade DATE, @Numero_SS INT, @Num_Func INT)
AS
	BEGIN
		DECLARE @count INT;
		DECLARE @erro VARCHAR(100);
		SET @count = (SELECT Higiliquidos.checkIfNIFExists(@NIF))
		IF(@count>=1)
			RAISERROR ('O NIF introduzido já existe, não é possível adicionar o Gerente', 16,1);
		ELSE
			BEGIN
				BEGIN TRY
					BEGIN TRAN
								INSERT INTO Higiliquidos.Pessoa(NIF, Nome, Data_de_Nascimento, Email, Morada, ContactoTelefonico) VALUES (@NIF, @Nome, @Data_de_Nascimento, @Email, @Morada, @ContactoTelefonico);
								INSERT INTO Higiliquidos.Funcionario(NIF_Funcionario, IBAN, Data_Inicio_Atividade, Numero_SS, Num_Func) VALUES (@NIF, @IBAN, @Data_Inicio_Atividade, @Numero_SS, @Num_Func)
								INSERT INTO Higiliquidos.Gerente (NIF_Gerente, Num_Func) VALUES (@NIF, @Num_Func)
					COMMIT TRAN
				END TRY
				BEGIN CATCH
					Rollback TRAN
					SELECT @erro = ERROR_MESSAGE(); 
					SET @erro =  'O Gerente não foi inserido, algum valor inserido incorretamento'
					RAISERROR (@erro, 16,1);
				END CATCH
			END
	End
GO