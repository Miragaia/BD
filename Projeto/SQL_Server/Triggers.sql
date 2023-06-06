--INSERT PERSON IN PESSOATABLE -----------------------------------
DROP TRIGGER Higiliquidos.addPersona
GO
CREATE TRIGGER Higiliquidos.addPersona ON Higiliquidos.Pessoa
AFTER INSERT, UPDATE
AS
	SET NOCOUNT ON;
	DECLARE @total AS int;
	DECLARE @totalTelemovel AS int;
	DECLARE @NIFPerson AS int;
	DECLARE @numTele AS int;
	DECLARE @dataNasc DATE;
	SELECT @dataNasc = Data_de_Nascimento FROM inserted;
	SELECT @NIFPerson = NIF FROM INSERTED;
	SELECT @numTele = ContactoTelefonico FROM INSERTED;
	
	IF (@dataNasc IS NOT NULL) AND (TRY_CONVERT(DATE, @dataNasc, 103) IS NULL)
	BEGIN
		RAISERROR('A data de nascimento deve estar no formato dd/mm/aaaa.', 20, 1);
		ROLLBACK;
	END

	IF LEN(@NIFPerson) <> 9
	BEGIN
		RAISERROR('NIF tem de ter 9 números!' , 20, 1);
		ROLLBACK TRAN;
	END

	IF LEN(@numTele) <> 9
	BEGIN
		RAISERROR('Número de Telemovel tem de ter 9 números!' , 20, 1);
		ROLLBACK TRAN;
	END

	SELECT @totalTelemovel = count(*) FROM Higiliquidos.Pessoa WHERE ContactoTelefonico = @numTele
	IF @totalTelemovel > 1
	BEGIN 
		RAISERROR('Número de telemovel repetido na base de dados!' , 20, 1);
		ROLLBACK TRAN;
	END

	SELECT @total = count(*) FROM Higiliquidos.Pessoa where NIF = @NIFPerson;
	IF @total > 1
	BEGIN 
		RAISERROR('NIF repetido na base de dados!' , 20, 1);
		ROLLBACK TRAN;
	END
GO