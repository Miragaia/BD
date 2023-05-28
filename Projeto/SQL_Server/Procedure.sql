USE p8g8
GO
------------------
CREATE PROCEDURE Higiliquidos.AdicionarCarrinha (@Matricula varchar(8), @Ano INT, @Marca VARCHAR(32), @Combustivel varchar(32), @Peso INT, @Nome_Empresa varchar(64))
AS
	BEGIN
		DECLARE @count INT;
		DECLARE @erro VARCHAR(100);
		DECLARE @NIF_Empresa INT;
		SET @NIF_Empresa = (SELECT Higiliquidos.getNIFEmpresafromNome(@Nome_Empresa))
		SET @count = (SELECT Higiliquidos.checkifCarrinhaMatriculaExists(@Matricula))
		IF(@count>=1)
			RAISERROR ('A Matricula introduzida já existe, não é possível adicionar a Carrinha', 16,1);
		ELSE
			BEGIN
				BEGIN TRY
					BEGIN TRAN
								INSERT INTO Higiliquidos.Carrinha (Matricula, Ano, Marca, Combustivel, Peso, NIF_Empresa) VALUES (@Matricula, @Ano, @Marca, @Combustivel, @Peso, @NIF_Empresa)
					COMMIT TRAN
				END TRY
				BEGIN CATCH
					Rollback TRAN
					SELECT @erro = ERROR_MESSAGE(); 
					SET @erro =  'A Carrinha não foi inserida, algum valor inserido incorretamente'
					RAISERROR (@erro, 16,1);
				END CATCH
			END
	End
GO


CREATE PROCEDURE Higiliquidos.AdicionarArmazem (@ID INT, @Area INT, @Endereco VARCHAR(64), @NIF_Empresa INT)
AS
	BEGIN
		DECLARE @count INT;
		DECLARE @erro VARCHAR(100);
		DECLARE @NIF_Empresa INT;
		SET @NIF_Empresa = (SELECT Higiliquidos.getNIFEmpresafromNome(@Nome_Empresa))
		Set @count = (SELECT Higiliquidos.checkifArmazemIDExists(@ID))

		IF(@count>=1)
			RAISERROR ('O ID introduzido já existe, não é possível adicionar o Armazem', 16,1);
		ELSE
			BEGIN
				BEGIN TRY
					BEGIN TRAN
								INSERT INTO Higiliquidos.Armazem (ID, Area, Endereco, NIF_Empresa) VALUES (@ID, @Area, @Endereco, @NIF_Empresa)
					COMMIT TRAN
				END TRY
				BEGIN CATCH
					Rollback TRAN
					SELECT @erro = ERROR_MESSAGE();
					SET @erro =  'O Armazem não foi inserido, algum valor inserido incorretamente'
					RAISERROR (@erro, 16,1);
				END CATCH
			END
		

CREATE PROCEDURE Higiliquidos.AdicionarPessoa (@NIF INT, @Nome VARCHAR(256), @Data_de_Nascimento DATE, @Email varchar(64), @Morada VARCHAR(64), @ContactoTelefonico INT, Nome_Empresa varchar(64))
AS
	BEGIN
	DECLARE @count INT;
		DECLARE @erro VARCHAR(100);
		DECLARE @NIF_Empresa INT;
		SET @NIF_Empresa = (SELECT Higiliquidos.getNIFEmpresafromNome(@Nome_Empresa))
		SET @count = (SELECT Higiliquidos.checkIfNIFExists(@NIF))
		IF(@count>=1)
			RAISERROR ('O NIF introduzido já existe, não é possível adicionar a Pessoa', 16,1);
		ELSE
			BEGIN
				BEGIN TRY
					BEGIN TRAN
								INSERT INTO Higiliquidos.Pessoa(NIF, Nome, Data_de_Nascimento, Email, Morada, ContactoTelefonico, NIF_Empresa) VALUES (@NIF, @Nome, @Data_de_Nascimento, @Email, @Morada, @ContactoTelefonico, @NIF_Empresa);
					COMMIT TRAN
				END TRY
				BEGIN CATCH
					Rollback TRAN
					SELECT @erro = ERROR_MESSAGE(); 
					SET @erro =  'A Pessoa não foi inserida, algum valor inserido incorretamente'
					RAISERROR (@erro, 16,1);
				END CATCH
			END
	END
GO


CREATE PROCEDURE Higiliquidos.AdicionarProduto (@ID INT, @Nome VARCHAR(64), @Marca VARCHAR(64), @Tipo_de_Produto VARCHAR(64), @IVA DECIMAL(5, 2), @Preco DECIMAL(10, 2), @Quantidade INT)
AS
	BEGIN
		DECLARE @count INT;
		DECLARE @erro VARCHAR(100);
		SET @count = (SELECT Higiliquidos.checkifProdutoIDExists(@ID))
		IF(@count>=1)
			RAISERROR ('O NIF introduzido já existe, não é possível adicionar o Produto', 16,1);
		ELSE
			BEGIN
				BEGIN TRY
					BEGIN TRAN
								INSERT INTO Higiliquidos.Produto(ID, Nome, Marca, Tipo_de_Produto, IVA, Preco, Quantidade) VALUES (@ID, @Nome, @Marca, @Tipo_de_Produto, @IVA, @Preco, @Quantidade)
					COMMIT TRAN
				END TRY
				BEGIN CATCH
					Rollback TRAN
					SELECT @erro = ERROR_MESSAGE(); 
					SET @erro =  'O Produto não foi inserido, algum valor inserido incorretamente'
					RAISERROR (@erro, 16,1);
				END CATCH
			END
	End
GO


CREATE PROCEDURE Higiliquidos.AdicionarCliente (@NIF_Cliente INT, @Num_Cliente INT, )
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









--aqui












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

CREATE PROCEDURE Higiliquidos.AdicionarEncomenda (@ID INT, @Nome_Produto INT, @Quantidade_Produto INT) --ir buscar produto pelo nome(n é suposto criar produto novo)
AS
	BEGIN
		DECLARE @count INT;
		DECLARE @erro VARCHAR(100);
		DECLARE @ID_Produto INT;
		SET @ID_Produto = (SELECT Higiliquidos.getIDProdutofromNome(@Nome_Produto))
		SET @count = (SELECT Higiliquidos.checkifEncomendaExists(@ID))
		
		IF(@count>=1)
			RAISERROR ('O NIF introduzido já existe, não é possível adicionar o Fornecedor', 16,1);
		ELSE
			BEGIN
				BEGIN TRY
					BEGIN TRAN
								INSERT INTO Higiliquidos.Encomenda (ID, ID_Produto, Quantidade_Produto) VALUES (@ID, @ID_Produto, @Quantidade_Produto)
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


CREATE PROCEDURE Higiliquidos.AdicionarEncomenda_Fornecedor (@ID INT, @Nome_Produto INT, @Quantidade_Produto INT) --como faço? ESTA TUDO MAL(simplesmente copiei o de cima)
AS
	BEGIN
		DECLARE @count INT;
		DECLARE @erro VARCHAR(100);
		DECLARE @ID_Produto INT;
		SET @ID_Produto = (SELECT Higiliquidos.getIDProdutofromNome(@Nome_Produto))
		SET @count = (SELECT Higiliquidos.checkifEncomendaExists(@ID))
		
		IF(@count>=1)
			RAISERROR ('O NIF introduzido já existe, não é possível adicionar o Fornecedor', 16,1);
		ELSE
			BEGIN
				BEGIN TRY
					BEGIN TRAN
								INSERT INTO Higiliquidos.Encomenda (ID, ID_Produto, Quantidade_Produto) VALUES (@ID, @ID_Produto, @Quantidade_Produto)
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




CREATE PROCEDURE Higiliquidos.AdicionarEncomenda_Fornecedor (@ID INT, @Nome_Produto INT, @Quantidade_Produto INT) --como faço? ESTA TUDO MAL(simplesmente copiei o de cima)
AS
	BEGIN
		DECLARE @count INT;
		DECLARE @erro VARCHAR(100);
		DECLARE @ID_Produto INT;
		SET @ID_Produto = (SELECT Higiliquidos.getIDProdutofromNome(@Nome_Produto))
		SET @count = (SELECT Higiliquidos.checkifEncomendaExists(@ID))
		
		IF(@count>=1)
			RAISERROR ('O NIF introduzido já existe, não é possível adicionar o Fornecedor', 16,1);
		ELSE
			BEGIN
				BEGIN TRY
					BEGIN TRAN
								INSERT INTO Higiliquidos.Encomenda (ID, ID_Produto, Quantidade_Produto) VALUES (@ID, @ID_Produto, @Quantidade_Produto)
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
					SET @erro =  'O Funcionario não foi inserido, algum valor inserido incorretamente'
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
					SET @erro =  'O Gerente não foi inserido, algum valor inserido incorretamente'
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
					SET @erro =  'O Vendedor não foi inserido, algum valor inserido incorretamente'
					RAISERROR (@erro, 16,1);
				END CATCH
			END
	End
GO
--NO DISTRIBUIDOR CRIO UMA NOVA CARRINHA? OU ASSCIO A UMA JA EXISTENTE? COMO VEJO SE UMA CARRINHA JA ESTA ASSOCIADA A UM DISTRIBUIDOR?
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
					SET @erro =  'O Distribuidor não foi inserido, algum valor inserido incorretamente'
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
					SET @erro =  'O Distribuidor não foi inserido, algum valor inserido incorretamente'
					RAISERROR (@erro, 16,1);
				END CATCH
			END
	End
GO

CREATE PROCEDURE Higiliquidos.AdicionarEncomenda_Distribuidor (@OLA INT)--como faço? ESTA TUDO MAL(simplesmente copiei o de cima)
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
								
								INSERT INTO Higiliquidos.Distribuidor (NIF_Distribuidor, Matricula_Carrinha, Nun_Func) VALUES (@NIF, @Matricula_Carrinha, @Num_Func)
					COMMIT TRAN
				END TRY
				BEGIN CATCH
					Rollback TRAN
					SELECT @erro = ERROR_MESSAGE(); 
					SET @erro =  'O Distribuidor não foi inserido, algum valor inserido incorretamente'
					RAISERROR (@erro, 16,1);
				END CATCH
			END
	End
GO