USE p8g8;
GO

CREATE FUNCTION Higiliquidos.checkIfNIFExists (@NIF INT) RETURNS INT
AS
	BEGIN
		DECLARE @counter INT
		SELECT @counter=COUNT(1) FROM Higiliquidos.Pessoa WHERE NIF = @NIF
		RETURN @counter
	END
GO

CREATE FUNCTION Higiliquidos.checkIfNum_FuncExists(@Num_Func INT) RETURNS INT
AS
	BEGIN
        DECLARE @NIF INT
		DECLARE @counter INT
        DECLARE @counterPessoa INT
		DECLARE @counterDistribuidor INT
		DECLARE @counterVendedor INT
		DECLARE @counterGerente INT

		--Check if Pessoa exists
		SELECT @NIFPessoa = Higiliquidos.getNIFFuncfromNum_Func(@Num_Func)
        

		IF @NIFPessoa IS NOT NULL
			SET @counterPessoa=(SELECT Higiliquidos.checkIfNIFExists(@NIFPessoa))
		
		IF(@counterPessoa IS NOT NULL)
			--Check if gerente exists
			SELECT @counterGerente = COUNT(1) FROM Higiliquidos.Gerente WHERE Num_Func = @Num_Func
			--Check if distribuidor exists
			SELECT @counterDistribuidor = COUNT(1) FROM Higiliquidos.Distribuidor WHERE Num_Func = @Num_Func
			--Check if vendedor exists
			SELECT @counterVendedor = COUNT(1) FROM Higiliquidos.Vendedor WHERE Num_Func = @Num_Func

		IF(@counterGerente = 1 OR @counterDistribuidor = 1 OR @counterVendedor = 1)
			SET @counter = 1
		ELSE
			SET @counter = 0

		RETURN @counter
	END
GO

DROP FUNCTION Higiliquidos.checkIfNum_FuncExists

CREATE FUNCTION Higiliquidos.checkifProdutoIDExists (@ID INT) RETURNS INT
AS
	BEGIN
		DECLARE @counter INT;
		SELECT @counter = COUNT(*) FROM Higiliquidos.Produto WHERE ID = @ID;
		RETURN @counter;
	END;
GO

CREATE FUNCTION Higiliquidos.checkifArmazemIDExists (@ID INT) RETURNS INT
AS
	BEGIN
		DECLARE @counter INT;
		SELECT @counter = COUNT(*) FROM Higiliquidos.Armazem WHERE ID = @ID;
		RETURN @counter;
	END;
GO

CREATE FUNCTION Higiliquidos.checkifCarrinhaMatriculaExists (@matricula VARCHAR(64)) RETURNS INT
AS
	BEGIN
		DECLARE @counter INT;
		SELECT @counter = COUNT(*) FROM Higiliquidos.Carrinha WHERE matricula = @matricula;
		RETURN @counter;
	END;
GO

CREATE FUNCTION Higiliquidos.checkifNifFornecedorExists (@NIF INT) RETURNS INT
AS
    BEGIN
        DECLARE @NIF_Exists INT;
        SELECT @NIF_Exists = COUNT(1) FROM Higiliquidos.Fornecedor WHERE NIF_Fornecedor = @NIF;
        RETURN @NIF_Exists;
    END;
GO

CREATE FUNCTION Higiliquidos.checkifNifClienteExists (@NIF INT) RETURNS INT
AS
    BEGIN
        DECLARE @NIF_Exists INT;
        SELECT @NIF_Exists = COUNT(1) FROM Higiliquidos.Cliente WHERE NIF_Cliente = @NIF;
        RETURN @NIF_Exists;
    END;
GO  --FIZ PARA TODAS AS PESSOAS, SABER SE TEMOS DE FAZER SO PARA As diferentes pessoas só OU PARa AS 3

CREATE FUNCTION Higiliquidos.checkifEmpresaExists(@nome VARCHAR(64)) RETURNS INT
AS
	BEGIN
		DECLARE @counter INT;
		SELECT @counter = COUNT(*) FROM Higiliquidos.Empresa WHERE nome = @nome;
		RETURN @counter;
	END;
GO

CREATE FUNCTION Higiliquidos.checkifEncomendaExists(@ID INT) RETURNS INT
AS
	BEGIN
		DECLARE @counter INT;
		SELECT @counter = COUNT(*) FROM Higiliquidos.Encomenda WHERE ID = @ID;
		RETURN @counter;
	END;
GO

CREATE FUNCTION Higiliquidos.checkifEncomenda_FornecedorExists(@ID INT) RETURNS INT
AS
	BEGIN
		DECLARE @counter INT;
		SELECT @counter = COUNT(*) FROM Higiliquidos.Encomenda_Fornecedor WHERE ID = @ID;
		RETURN @counter;
	END;
GO

CREATE FUNCTION Higiliquidos.checkifEncomenda_ClienteExists(@ID INT) RETURNS INT
AS
	BEGIN
		DECLARE @counter INT;
		SELECT @counter = COUNT(*) FROM Higiliquidos.Encomenda_Cliente WHERE ID = @ID;
		RETURN @counter;
	END;
GO

CREATE FUNCTION Higiliquidos.checkifEncomenda_DistribuidorExists(@ID_Encomenda INT) RETURNS INT
AS
	BEGIN
		DECLARE @counter INT;
		SELECT @counter = COUNT(*) FROM Higiliquidos.Encomenda_Distribuidor WHERE ID = @ID_Encomenda;
		RETURN @counter;
	END;
GO

CREATE FUNCTION Higiliquidos.checkifCarrinha_DistribuidorExists(@Matricula_Carrinha VARCHAR(64), @NIF_Distribuidor INT) RETURNS INT
AS
	BEGIN
		DECLARE @counter INT;
		SELECT @counter = COUNT(*) FROM Higiliquidos.Carrinha_Distribuidor WHERE Matricula_Carrinha = @Matricula_Carrinha AND NIF_Distribuidor = @NIF_Distribuidor;
		RETURN @counter;
	END;
GO

CREATE FUNCTION Higiliquidos.checkifEncomenda_ProdutoExists(@ID_Encomenda INT, @ID_Produto INT, @Quantidade INT) RETURNS INT
AS
	BEGIN
		DECLARE @counter INT;
		SELECT @counter = COUNT(*) FROM Higiliquidos.Encomenda_Produto WHERE ID_Encomenda = @ID_Encomenda AND ID_Produto = @ID_Produto AND Quantidade = @Quantidade;
		RETURN @counter;
	END;
GO

CREATE FUNCTION Higiliquidos.getNIFFuncfromNum_Func(@Num_Func INT) RETURNS INT
AS
	BEGIN	
		DECLARE @NIF_Funcionario INT
		DECLARE @counter INT
		DECLARE @counterDistribuidor INT
		DECLARE @counterVendedor INT
		DECLARE @counterGerente INT

		SELECT @counterGerente = COUNT(1) FROM Higiliquidos.Gerente WHERE Num_Func = @Num_Func
			
		SELECT @counterDistribuidor = COUNT(1) FROM Higiliquidos.Distribuidor WHERE Num_Func = @Num_Func
			
		SELECT @counterVendedor = COUNT(1) FROM Higiliquidos.Vendedor WHERE Num_Func = @Num_Func

		IF @counterGerente = 1
			SET @NIFFUNC = (SELECT NIF FROM Higiliquidos.Gerente WHERE Num_Func = @Num_Func)
		IF @counterDistribuidor = 1
			SET @NIFFUNC = (SELECT NIF FROM Higiliquidos.OperadorAdega WHERE Num_Func = @Num_Func)
		IF @counterVendedor = 1
			SET @NIFFUNC = (SELECT NIF FROM Higiliquidos.OperadorAgricola WHERE Num_Func = @Num_Func)

		RETURN @NIFFunc --means that there is no one with this employee number if zero
	END
GO

DROP FUNCTION Higiliquidos.getNIFFuncfromNum_Func

CREATE FUNCTION Higiliquidos.getNIFfromNome (@nome VARCHAR(64)) RETURNS INT
AS
	BEGIN
		DECLARE @NIF INT
		SELECT @NIF = NIF FROM Higiliquidos.Pessoa WHERE nome = @nome
		RETURN @NIF
	END
GO

CREATE FUNCTION Higiliquidos.getIDArmazemfromTamanho (@tamanho INT) RETURNS INT
AS
	BEGIN
		DECLARE @ID INT
		SELECT @ID = ID FROM Higiliquidos.Armazem WHERE tamanho = @tamanho
		RETURN @ID
	END
GO

CREATE FUNCTION Higiliquidos.getIDProdutofromNome (@nome VARCHAR(64)) RETURNS INT
AS
	BEGIN
		DECLARE @ID INT
		SELECT @ID = ID FROM Higiliquidos.Produto WHERE nome = @nome
		RETURN @ID
	END
GO

CREATE FUNCTION Higiliquidos.getIDProdutofromMarca (@marca VARCHAR(64)) RETURNS INT
AS
	BEGIN
		DECLARE @ID INT
		SELECT @ID = ID FROM Higiliquidos.Produto WHERE marca = @marca
		RETURN @ID
	END
GO

CREATE FUNCTION Higiliquidos.getIDProdutofromTipo (@Tipo_de_Produto VARCHAR(64)) RETURNS INT
AS
	BEGIN
		DECLARE @ID INT
		SELECT @ID = ID FROM Higiliquidos.Produto WHERE Tipo_de_Produto = @Tipo_de_Produto
		RETURN @ID
	END
GO

CREATE FUNCTION Higiliquidos.getIDProdutofromPreco (@Preco DECIMAL(10, 2)) RETURNS INT
AS
	BEGIN
		DECLARE @ID INT
		SELECT @ID = ID FROM Higiliquidos.Produto WHERE Preco = @Preco
		RETURN @ID
	END
GO

CREATE FUNCTION Higiliquidos.getMatriculaCarrinhafromMarca (@Marca VARCHAR(32)) RETURNS VARCHAR(64)
AS
	BEGIN
		DECLARE @Matricula VARCHAR(64)
		SELECT @Matricula = matricula FROM Higiliquidos.Carrinha WHERE marca = @Marca
		RETURN @Matricula
	END
GO

CREATE FUNCTION Higiliquidos.getMatriculaCarrinhafromCombustivel (@Combustivel VARCHAR(32)) RETURNS VARCHAR(64)
AS
	BEGIN
		DECLARE @Matricula VARCHAR(64)
		SELECT @Matricula = matricula FROM Higiliquidos.Carrinha WHERE combustivel = @Combustivel
		RETURN @Matricula
	END
GO

CREATE FUNCTION Higiliquidos.getIDEncomendafromData_Entega (@Data_Entrega varchar(255)) RETURNS INT
AS
	BEGIN
		DECLARE @ID INT
		SELECT @ID = ID FROM Higiliquidos.Encomenda WHERE Data_Entrega = @Data_Entrega
		RETURN @ID
	END
GO

CREATE FUNCTION Higiliquidos.getIDEncomenda_FornecedorfromNIF_Fornecedor (@NIF_Fornecedor INT, @ID_Encomenda INT) RETURNS INT
AS
	BEGIN
		DECLARE @ID INT
		SELECT @ID = ID FROM Higiliquidos.Encomenda_Fornecedor WHERE NIF_Fornecedor = @NIF_Fornecedor AND ID_Encomenda = @ID_Encomenda
		RETURN @ID
	END
GO

CREATE FUNCTION Higiliquidos.getIDEncomenda_ClientefromNIF_Cliente (@NIF_Cliente INT, @ID_Encomenda INT) RETURNS INT
AS
	BEGIN
		DECLARE @ID INT
		SELECT @ID = ID FROM Higiliquidos.Encomenda_Cliente WHERE NIF_Cliente = @NIF_Cliente AND ID_Encomenda = @ID_Encomenda
		RETURN @ID
	END
GO

CREATE FUNCTION Higiliquidos.getIDEncomenda_DistribuidorfromNIF_Distribuidor (@NIF_Distribuidor INT, @ID_Encomenda INT) RETURNS INT
AS
	BEGIN
		DECLARE @ID INT
		SELECT @ID = ID FROM Higiliquidos.Encomenda_Distribuidor WHERE NIF_Distribuidor = @NIF_Distribuidor AND ID_Encomenda = @ID_Encomenda
		RETURN @ID
	END
GO

CREATE FUNCTION Higiliquidos.getIDCarrinha_DistribuidorfromMatricula_Carrinha (@Matricula_Carrinha VARCHAR(64), @NIF_Distribuidor INT) RETURNS INT
AS
	BEGIN
		DECLARE @ID INT
		SELECT @ID = ID FROM Higiliquidos.Carrinha_Distribuidor WHERE Matricula_Carrinha = @Matricula_Carrinha AND NIF_Distribuidor = @NIF_Distribuidor
		RETURN @ID
	END
GO

CREATE FUNCTION Higiliquidos.getIDEncomenda_ProdutofromID_Encomenda (@ID_Encomenda INT, @ID_Produto INT, @Quantidade INT) RETURNS INT
AS
	BEGIN
		DECLARE @ID INT
		SELECT @ID = ID FROM Higiliquidos.Encomenda_Produto WHERE ID_Encomenda = @ID_Encomenda AND ID_Produto = @ID_Produto AND Quantidade = @Quantidade
		RETURN @ID
	END
GO

--Fiz getNIFXXXXfromNome mas ainda falta essa implementação no DDl penso eu

CREATE FUNCTION Higiliquidos.getNIF_FornecedorfromNome (@nome VARCHAR(64)) RETURNS INT
AS
	BEGIN
		DECLARE @NIF INT
		SELECT @NIF = NIF_Fornecedor FROM Higiliquidos.Fornecedor WHERE nome = @nome
		RETURN @NIF
	END
GO

CREATE FUNCTION Higiliquidos.getNIF_ClientefromNome (@nome VARCHAR(64)) RETURNS INT
AS
	BEGIN
		DECLARE @NIF INT
		SELECT @NIF = NIF_Cliente FROM Higiliquidos.Cliente WHERE nome = @nome
		RETURN @NIF
	END
GO

CREATE FUNCTION Higiliquidos.getNIF_DistribuidorfromNome (@nome VARCHAR(64)) RETURNS INT
AS
	BEGIN
		DECLARE @NIF INT
		SELECT @NIF = NIF_Distribuidor FROM Higiliquidos.Distribuidor WHERE nome = @nome
		RETURN @NIF
	END
GO

CREATE FUNCTION Higiliquidos.getNIF_GerentefromNome (@nome VARCHAR(64)) RETURNS INT
AS
	BEGIN
		DECLARE @NIF INT
		SELECT @NIF = NIF_Gerente FROM Higiliquidos.Gerente WHERE nome = @nome
		RETURN @NIF
	END
GO

CREATE FUNCTION Higiliquidos.getNIF_VendedorfromNome (@nome VARCHAR(64)) RETURNS INT
AS
	BEGIN
		DECLARE @NIF INT
		SELECT @NIF = NIF_Vendedor FROM Higiliquidos.Vendedor WHERE nome = @nome
		RETURN @NIF
	END
GO

CREATE FUNCTION Higiliquidos.getNIF_DistribuidorfromMatricula_Carrinha (@Matricula_Carrinha VARCHAR(64)) RETURNS INT
AS
	BEGIN
		DECLARE @NIF INT
		SELECT @NIF = NIF_Distribuidor FROM Higiliquidos.Carrinha_Distribuidor WHERE Matricula_Carrinha = @Matricula_Carrinha
		RETURN @NIF
	END
GO

CREATE FUNCTION Higiliquidos.getNIF_FornecedorfromID_Encomenda (@ID_Encomenda INT) RETURNS INT
AS
	BEGIN
		DECLARE @NIF INT
		SELECT @NIF = NIF_Fornecedor FROM Higiliquidos.Encomenda_Fornecedor WHERE ID_Encomenda = @ID_Encomenda
		RETURN @NIF
	END
GO

CREATE FUNCTION Higiliquidos.getNIF_ClientefromID_Encomenda (@ID_Encomenda INT) RETURNS INT
AS
	BEGIN
		DECLARE @NIF INT
		SELECT @NIF = NIF_Cliente FROM Higiliquidos.Encomenda_Cliente WHERE ID_Encomenda = @ID_Encomenda
		RETURN @NIF
	END
GO

CREATE FUNCTION Higiliquidos.getNIF_DistribuidorfromID_Encomenda (@ID_Encomenda INT) RETURNS INT
AS
	BEGIN
		DECLARE @NIF INT
		SELECT @NIF = NIF_Distribuidor FROM Higiliquidos.Encomenda_Distribuidor WHERE ID_Encomenda = @ID_Encomenda
		RETURN @NIF
	END
GO

