DROP PROCEDURE getClients
GO
CREATE PROCEDURE getClients
AS
	BEGIN
		SET NOCOUNT ON;
		SELECT * FROM view_clients
	END
GO

DROP PROCEDURE filterClients
GO
CREATE PROCEDURE filterClients
(
    @nif INT = NULL,
    @nome VARCHAR(256) = NULL,
	@num_cliente INT = NULL,
	@dataNasc Date = NULL,
	@email VARCHAR(64) = NULL,
    @morada VARCHAR(64) = NULL,
	@telemovel INT = NULL
)
AS
BEGIN
	SET NOCOUNT ON;
    SELECT DISTINCT * 
    FROM view_clients
    WHERE (@nif IS NULL OR NIF = @nif)
        AND (@nome IS NULL OR Nome LIKE ISNULL(@nome, '') + '%')
        AND (@num_cliente IS NULL OR Num_Cliente = @num_cliente)
        AND (@dataNasc IS NULL OR Data_de_Nascimento >= @dataNasc)
        AND (@email IS NULL OR Email LIKE ISNULL(@email, '') + '%')
        AND (@morada IS NULL OR Morada LIKE ISNULL(@morada, '') + '%')
        AND (@telemovel IS NULL OR ContactoTelefonico = @telemovel)
END
GO


DROP PROCEDURE addClient
GO
CREATE PROCEDURE addClient 
(
    @nif INT = NULL,
    @nome VARCHAR(256) = NULL,
	@num_cliente INT = NULL,
	@dataNasc Date = NULL,
	@email VARCHAR(64) = NULL,
    @morada VARCHAR(64) = NULL,
	@telemovel INT = NULL
	
	
)
AS
	BEGIN
		DECLARE @count INT;
		DECLARE @erro VARCHAR(100);
		SET @count = (SELECT Higiliquidos.checkIfNIFExists(@nif))
		IF(@count>=1)
			RAISERROR ('O NIF introduzido já existe, não é possível adicionar o Cliente', 16,1);
		ELSE
			BEGIN
				BEGIN TRY
					BEGIN TRAN
							INSERT INTO Higiliquidos.Pessoa(NIF, Nome, Data_de_Nascimento, Email, Morada, ContactoTelefonico, NIF_Empresa)
							VALUES(@nif, @nome, @dataNasc, @email, @morada, @telemovel, 203551783);
	
							INSERT INTO Higiliquidos.Cliente(NIF_Cliente, Num_Cliente)
							VALUES(@nif, @num_cliente);
					COMMIT TRAN
				END TRY
				BEGIN CATCH
					Rollback TRAN
							SELECT @erro = ERROR_MESSAGE(); 
							SET @erro =  'O Cliente não foi inserido, algum valor inserido incorretamento'
							RAISERROR (@erro, 16,1);
				END CATCH
			END
	END
GO

DROP PROCEDURE deleteClient
GO
CREATE PROCEDURE deleteClient
(
    @nif INT
)
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM Higiliquidos.Cliente WHERE NIF_Cliente=@nif
	DELETE FROM Higiliquidos.Pessoa WHERE NIF=@nif
END
GO



--Fornecedor
DROP PROCEDURE getFornecedores
GO
CREATE PROCEDURE getFornecedores
AS
	BEGIN
		SET NOCOUNT ON;
		SELECT * FROM view_fornecedores
	END
GO


DROP PROCEDURE filterFornecedores
GO
CREATE PROCEDURE filterFornecedores
(
    @nif INT = NULL,
    @nome VARCHAR(256) = NULL,
	@num_fornecedor INT = NULL,
	@dataNasc Date = NULL,
	@email VARCHAR(64) = NULL,
    @morada VARCHAR(64) = NULL,
	@telemovel INT = NULL
)
AS
BEGIN
	SET NOCOUNT ON;
    SELECT DISTINCT * 
    FROM view_fornecedores
    WHERE (@nif IS NULL OR NIF = @nif)
        AND (@nome IS NULL OR Nome LIKE ISNULL(@nome, '') + '%')
        AND (@num_fornecedor IS NULL OR Num_Fornecedor = @num_fornecedor)
        AND (@dataNasc IS NULL OR Data_de_Nascimento >= @dataNasc)
        AND (@email IS NULL OR Email LIKE ISNULL(@email, '') + '%')
        AND (@morada IS NULL OR Morada LIKE ISNULL(@morada, '') + '%')
        AND (@telemovel IS NULL OR ContactoTelefonico = @telemovel)
END
GO



DROP PROCEDURE addFornecedor
GO
CREATE PROCEDURE addFornecedor
(
    @nif INT = NULL,
    @nome VARCHAR(256) = NULL,
	@num_fornecedor INT = NULL,
	@dataNasc DATE = NULL,
	@email VARCHAR(64) = NULL,
    @morada VARCHAR(64) = NULL,
	@telemovel INT = NULL
	
	
)
AS
	BEGIN
		DECLARE @count INT;
		DECLARE @erro VARCHAR(100);
		SET @count = (SELECT Higiliquidos.checkIfNIFExists(@nif))
		
		IF(@count>=1)
			RAISERROR ('O NIF introduzido já existe, não é possível adicionar o Fornecedor', 16,1);
		ELSE
			BEGIN
				BEGIN TRY
					BEGIN TRAN
							SET NOCOUNT ON;
							INSERT INTO Higiliquidos.Pessoa(NIF, Nome, Data_de_Nascimento, Email, Morada, ContactoTelefonico, NIF_Empresa)
							VALUES(@nif, @nome, @dataNasc, @email, @morada, @telemovel, 203551783);
	
							INSERT INTO Higiliquidos.Fornecedor(NIF_Fornecedor, Num_Fornecedor)
							VALUES(@nif, @num_fornecedor);
					COMMIT TRAN
				END TRY
				BEGIN CATCH
					Rollback TRAN
					SELECT @erro = ERROR_MESSAGE(); 
					SET @erro =  'O Fornecedor não foi inserido, algum valor inserido incorretamento'
					RAISERROR (@erro, 16,1);
				END CATCH
			END
	END
GO

DROP PROCEDURE deleteFornecedor
GO
CREATE PROCEDURE deleteFornecedor
(
    @nif INT
)
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM Higiliquidos.Fornecedor WHERE NIF_Fornecedor=@nif
	DELETE FROM Higiliquidos.Pessoa WHERE NIF=@nif
END
GO





DROP PROCEDURE getProdutos
GO
CREATE PROCEDURE getProdutos
AS
	BEGIN
		SET NOCOUNT ON;
		SELECT * FROM view_produtos
	END
GO

DROP PROCEDURE addProduto
GO
CREATE PROCEDURE addProduto
(
    @id INT = NULL,
	@nome VARCHAR(64) = NULL,
	@marca VARCHAR(64) = NULL,
	@type VARCHAR(64) = NULL,
    @iva DECIMAL(5, 2) = NULL,
	@preco DECIMAL(10, 2) = NULL,
	@quant INT = NULL,
	@id_arm INT = NULL
	
	
)
AS
	BEGIN
		DECLARE @count INT;
		DECLARE @count2 INT;
		DECLARE @erro VARCHAR(100);
		SET @count = (SELECT Higiliquidos.checkifProdutoIDExists (@id))
		SET @count2 = (SELECT Higiliquidos.checkifArmazemIDExists (@id_arm))

		IF(@count2<1)
			RAISERROR ('O ID do armazem introduzido não existe, não é possível adicionar o produto', 16,1);
		ELSE
			BEGIN
			IF(@count>=1)
				RAISERROR ('O ID introduzido já existe, não é possível adicionar o produto', 16,1);
			ELSE
				BEGIN
				SET NOCOUNT ON;
				INSERT INTO Higiliquidos.Produto (ID, Nome, Marca, Tipo_de_Produto, IVA, Preco, Quantidade)
				VALUES(@id, @nome, @marca, @type, @iva, @preco, @quant);
				END
			END
	END
GO


DROP PROCEDURE filterProdutos
GO
CREATE PROCEDURE filterProdutos
(
    @id INT = NULL,
	@nome VARCHAR(64) = NULL,
	@marca VARCHAR(64) = NULL,
	@type VARCHAR(64) = NULL,
	@preco DECIMAL(10, 2) = NULL,
	@id_arm INT = NULL
)
AS
BEGIN
	SET NOCOUNT ON;
    SELECT DISTINCT * 
    FROM view_produtos
    WHERE (@id IS NULL OR ID = @id)
        AND (@nome IS NULL OR Nome LIKE ISNULL(@nome, '') + '%')
		AND (@marca IS NULL OR Marca LIKE ISNULL(@marca, '') + '%')
		AND (@type IS NULL OR Tipo_de_Produto LIKE ISNULL(@type, '') + '%')
		AND (@preco IS NULL OR Preco >= @preco)
		AND (@id_arm IS NULL OR ID_Armazem = @id_arm)
END
GO

DROP PROCEDURE getVendas
GO
CREATE PROCEDURE getVendas
AS
	BEGIN
		SET NOCOUNT ON;
		SELECT * FROM view_vendas
	END
GO


DROP PROCEDURE filterVendas
GO
CREATE PROCEDURE filterVendas
(
    @data_ent DATE = NULL,
	@id_venda INT = NULL,
	@id_produto INT = NULL,
	@nome_produto VARCHAR(64) = NULL,
	@type_prod VARCHAR(64) = NULL,
	@nome_dis VARCHAR(256) = NULL,
	@nome_vend VARCHAR(256) = NULL,
	@nif_client VARCHAR(256) = NULL
)
AS
BEGIN
	SET NOCOUNT ON;
    SELECT DISTINCT * 
    FROM view_vendas
    WHERE (@data_ent IS NULL OR Data_Entrega >= @data_ent)
		AND (@id_venda IS NULL OR ID_Venda = @id_venda)
		AND (@id_produto IS NULL OR ID_Produto = @id_produto)
        AND (@nome_produto IS NULL OR Nome_Produto LIKE ISNULL(@nome_produto, '') + '%')
		AND (@type_prod IS NULL OR Tipo_de_Produto LIKE ISNULL(@type_prod, '') + '%')
		AND (@nome_dis IS NULL OR Nome_Distribuidor LIKE ISNULL(@nome_dis, '') + '%')
		AND (@nome_vend IS NULL OR Nome_Vendedor LIKE ISNULL(@nome_vend, '') + '%')
		AND (@nif_client IS NULL OR NIF_Cliente LIKE ISNULL(@nif_client, '') + '%')
END
GO



DROP PROCEDURE addVenda
GO
CREATE PROCEDURE addVenda
(
	@id_venda INT = NULL,
	@id_prod INT = NULL,
	@Quantidade INT = NULL,
	@data_venda DATE = NULL,
	@nome_vendedor VARCHAR(256) = NULL,
	@nif_cliente  INT = NULL,
	@nome_dist VARCHAR(256) = NULL
)
AS
	BEGIN
		DECLARE @id_arm INT;
		DECLARE @countVenda INT;
		DECLARE @counterProd INT;
		DECLARE @num_dist INT;
		DECLARE @num_vendedor INT;
		DECLARE @num_cliente INT;
		
		DECLARE @erro VARCHAR(100);
		DECLARE @quantity INT;
		DECLARE @IDProduto VARCHAR(5);
		SET @countVenda = Higiliquidos.VerificarIDVendaExistente(@id_venda)
		SET @counterProd = Higiliquidos.checkifProdutoIDExists(@id_prod);
		SET @num_dist = Higiliquidos.getnumDistBYname(@nome_dist);
		SET @num_vendedor = Higiliquidos.getnumVendedorBYname(@nome_vendedor);
		SET @num_cliente = Higiliquidos.getnumClienteByNif(@nif_cliente);
		SET @id_arm = Higiliquidos.GetArmazemID(@id_prod);
		;

		IF (@counterProd = 0)
			RAISERROR('O produto com o ID %d não existe.', 16, 1, @id_prod);			
		ELSE IF (@num_dist < 1)
			 RAISERROR('O distribuidor com o nome %s não existe.', 16, 1, @nome_dist);
		ELSE IF (@num_vendedor < 1)
			RAISERROR('O vendedor com o nome %s não existe.', 16, 1, @nome_vendedor);
		ELSE IF (@num_cliente < 1)
			RAISERROR('O cliente com o NIF %d não existe.', 16, 1, @nif_cliente);
		ELSE IF (@countVenda >= 1)
			RAISERROR('O ID de venda %d já existe.', 16, 1, @id_venda);
		ELSE 
			BEGIN
				DECLARE	productCursor CURSOR FAST_FORWARD
					FOR SELECT ID , Quantidade FROM Higiliquidos.Produto WHERE ID = @id_prod;
				OPEN productCursor;
				FETCH productCursor INTO @IDProduto , @quantity;
					WHILE @@FETCH_STATUS = 0
						BEGIN
							IF @quantity >= @Quantidade
								BEGIN
									UPDATE Higiliquidos.Produto SET Quantidade = Quantidade - @Quantidade WHERE	ID = @id_prod
									INSERT INTO Higiliquidos.Venda(ID, Quantidade, ID_Produto, ID_Armazem, Num_Vendedor, Num_Distribuidor, Num_Cliente)
									VALUES (@id_venda, @Quantidade, @id_prod, @id_arm, @num_vendedor, @num_dist, @num_cliente)
									INSERT INTO Higiliquidos.Entrega (Data_Entrega, ID_Venda, Num_Distribuidor) VALUES (@data_venda, @id_venda, @num_dist)
								END
							ELSE
								BEGIN
									RAISERROR ('Produto nao disponivel', 16,1);
								END
							FETCH productCursor INTO @IDProduto , @quantity
						END
				CLOSE productCursor;
				DEALLOCATE productCursor;
				RETURN ;
			END
	END
GO



DROP PROCEDURE getCompras
GO
CREATE PROCEDURE getCompras
AS
	BEGIN
		SET NOCOUNT ON;
		SELECT * FROM view_compras
	END
GO



DROP PROCEDURE filterCompras
GO
CREATE PROCEDURE filterCompras
(
    @data_comp DATE = NULL,
	@id_compra INT = NULL,
	@id_produto INT = NULL,
	@nome_produto VARCHAR(64) = NULL,
	@type_prod VARCHAR(64) = NULL,
	@nome_forn VARCHAR(256) = NULL

)
AS
BEGIN
	SET NOCOUNT ON;
    SELECT DISTINCT * 
    FROM view_compras
    WHERE (@data_comp IS NULL OR Data_Compra >= @data_comp)
		AND (@id_compra IS NULL OR ID_Compra = @id_compra)
		AND (@id_produto IS NULL OR ID_Produto = @id_produto)
        AND (@nome_produto IS NULL OR Nome_Produto LIKE ISNULL(@nome_produto, '') + '%')
		AND (@type_prod IS NULL OR Tipo_de_Produto LIKE ISNULL(@type_prod, '') + '%')
		AND (@nome_forn IS NULL OR Nome_fornecedor LIKE ISNULL(@nome_forn, '') + '%')
END
GO


DROP PROCEDURE addCompra
GO
CREATE PROCEDURE addCompra
(
	@data_comp DATE = NULL,
	@id_compra INT = NULL,
	@id_produto INT = NULL,
	@Quantidade INT = NULL,
	@nome_forn VARCHAR(256) = NULL
)
AS
	BEGIN
		DECLARE @id_arm INT;
		DECLARE @countCompra INT;
		DECLARE @counterProd INT;
		DECLARE @num_forn INT;
		
		DECLARE @erro VARCHAR(100);
		DECLARE @quantity INT;
		DECLARE @IDProduto VARCHAR(5);
		SET @countCompra = Higiliquidos.VerificarIDCompraExistente(@id_compra)
		SET @counterProd = Higiliquidos.checkifProdutoIDExists(@id_produto);
		SET @num_forn = Higiliquidos.getnumFornecedorBYname(@nome_forn);
		SET @id_arm = Higiliquidos.GetArmazemID(@id_produto);
		;

		IF (@counterProd = 0)
			RAISERROR('O produto com o ID %d não existe.', 16, 1, @id_produto);			
		ELSE IF (@num_forn < 1)
			 RAISERROR('O fornecedor com o nome %s não existe.', 16, 1, @nome_forn);
		ELSE IF (@countCompra >= 1)
			RAISERROR('O ID de venda %d já existe.', 16, 1, @id_compra);
		ELSE 
			BEGIN
				DECLARE	productCursor CURSOR FAST_FORWARD
					FOR SELECT ID , Quantidade FROM Higiliquidos.Produto WHERE ID = @id_produto;
				OPEN productCursor;
				FETCH productCursor INTO @IDProduto , @quantity;
					WHILE @@FETCH_STATUS = 0
						BEGIN
							IF @quantity >= @Quantidade
								BEGIN
									UPDATE Higiliquidos.Produto SET Quantidade = Quantidade + @Quantidade WHERE	ID = @id_produto
									INSERT INTO Higiliquidos.Compra(ID, Data_Compra, Quantidade, ID_Produto, ID_Armazem, Num_Fornecedor)
									VALUES (@id_compra, @data_comp, @Quantidade, @id_produto, @id_arm, @num_forn)
								END
							ELSE
								BEGIN
									RAISERROR ('Produto nao disponivel', 16,1);
								END
							FETCH productCursor INTO @IDProduto , @quantity
						END
				CLOSE productCursor;
				DEALLOCATE productCursor;
				RETURN ;
			END
	END
GO



DROP PROCEDURE getDistribuidores
GO
CREATE PROCEDURE getDistribuidores
AS
	BEGIN
		SET NOCOUNT ON;
		SELECT DISTINCT * FROM view_distribuidores
	END
GO

DROP PROCEDURE filterDistribuidores
GO
CREATE PROCEDURE filterDistribuidores
(
    @nif INT = NULL,
    @nome VARCHAR(256) = NULL,
	@email VARCHAR(64) = NULL,
	@num_func INT = NULL,
	@id_venda INT = NULL,
    @matricula VARCHAR(8) = NULL,
	@num_dist INT = NULL
)
AS
BEGIN
	SET NOCOUNT ON;
    SELECT DISTINCT * 
    FROM view_distribuidores
    WHERE (@nif IS NULL OR NIF = @nif)
        AND (@nome IS NULL OR Nome LIKE ISNULL(@nome, '') + '%')
		AND (@email IS NULL OR Email LIKE ISNULL(@email, '') + '%')
		AND (@num_func IS NULL OR Num_Func = @num_func)
		AND (@id_venda IS NULL OR ID_Venda = @id_venda)
		AND (@matricula IS NULL OR Matricula_Carrinha LIKE ISNULL(@matricula, '') + '%')
		AND (@num_dist IS NULL OR Num_Distribuidor = @num_dist)
		

END
GO



DROP PROCEDURE getVendedores
GO
CREATE PROCEDURE getVendedores
AS
	BEGIN
		SET NOCOUNT ON;
		SELECT DISTINCT * FROM view_vendedores
	END
GO

DROP PROCEDURE getGerente
GO
CREATE PROCEDURE getGerente
AS
	BEGIN
		SET NOCOUNT ON;
		SELECT DISTINCT * FROM view_gerente
	END
GO