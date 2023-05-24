USE p8g8
GO
------------------
CREATE PROCEDURE Higiliquidos.AdicionarPessoa (@NIF INT, @Nome VARCHAR(256), @Data_de_Nascimento DATE, @Email varchar(64), @Morada VARCHAR(256), @ContactoTelefonico VARCHAR(9))
AS
	BEGIN
		INSERT INTO Higiliquidos.Pessoa(NIF, Nome, Data_de_Nascimento, Email, morada, ContactoTelefonico) VALUES (@NIF, @Nome, @Data_de_Nascimento, @Email, @Morada, @ContactoTelefonico);
	END
GO


CREATE PROCEDURE Higiliquidos.AdicionarCliente (@NIF INT, @Nome VARCHAR(256), @Data_de_Nascimento DATE, @Email varchar(64), @Morada VARCHAR(256), @ContactoTelefonico VARCHAR(9))
AS
	BEGIN
		DECLARE @count INT;
		DECLARE @erro VARCHAR(100);
		SET @count = (SELECT Higiliquidos.checkIfNIFExists(@NIF))
		IF(@count>=1)
			RAISERROR ('O NIF introduzido j� existe, n�o � poss�vel adicionar o Cliente', 16,1);
		ELSE
			BEGIN
				BEGIN TRY
					BEGIN TRAN
								INSERT INTO Higiliquidos.Pessoa(NIF, Nome, Data_de_Nascimento, Email, morada, ContactoTelefonico) VALUES (@NIF, @Nome, @Data_de_Nascimento, @Email, @Morada, @ContactoTelefonico);
								INSERT INTO Higiliquidos.Cliente (NIF) VALUES (@NIF)
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

CREATE PROCEDURE Higiliquidos.AdicionarFuncionario (@NIF_Funcionario INT, @Nome VARCHAR(256), @Data_de_Nascimento DATE, @Email varchar(64), @Morada VARCHAR(256), @ContactoTelefonico VARCHAR(9), @IBAN VARCHAR(25), @Data_Inicio_Atividade DATE, @Numero_SS INT, @Num_Func INT)
AS
	BEGIN
		BEGIN TRAN
		    INSERT INTO Higiliquidos.Pessoa(NIF, Nome, Data_de_Nascimento, Email, morada, ContactoTelefonico) VALUES (@NIF_Funcionario, @Nome, @Data_de_Nascimento, @Email, @Morada, @ContactoTelefonico);
			INSERT INTO Higiliquidos.Funcionario(NIF_Funcionario, IBAN, Data_Inicio_Atividade, Numero_SS, Num_Func) VALUES (@NIF_Funcionario, @IBAN, @Data_Inicio_Atividade, @Numero_SS, @Num_Func)
		COMMIT TRAN
	End
GO