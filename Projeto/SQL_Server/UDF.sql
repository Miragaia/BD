DROP FUNCTION Higiliquidos.checkIfNIFExists
GO
CREATE FUNCTION Higiliquidos.checkIfNIFExists (@nif INT) RETURNS INT
AS
	BEGIN
		DECLARE @counter INT
		SELECT @counter=COUNT(1) FROM Higiliquidos.Pessoa WHERE NIF = @nif
		RETURN @counter
	END
GO

DROP FUNCTION Higiliquidos.checkifProdutoIDExists
GO
CREATE FUNCTION Higiliquidos.checkifProdutoIDExists (@ID INT) RETURNS INT
AS
	BEGIN
		DECLARE @counter INT;
		SELECT @counter = COUNT(*) FROM Higiliquidos.Produto WHERE ID = @ID;
		RETURN @counter;
	END;
GO


DROP FUNCTION Higiliquidos.checkifArmazemIDExists
GO
CREATE FUNCTION Higiliquidos.checkifArmazemIDExists (@ID INT) RETURNS INT
AS
	BEGIN
		DECLARE @counter INT;
		SELECT @counter = COUNT(*) FROM Higiliquidos.Armazem WHERE ID = @ID;
		RETURN @counter;
	END;
GO


DROP FUNCTION Higiliquidos.getnumDistBYname
GO
CREATE FUNCTION Higiliquidos.getnumDistBYname (@nomeDistribuidor varchar(256))
RETURNS INT
AS
BEGIN
  DECLARE @numDistribuidor INT;
  
  SELECT @numDistribuidor = Num_Distribuidor
  FROM Higiliquidos.Distribuidor d
  INNER JOIN Higiliquidos.Funcionario f ON d.Num_Func = f.Num_Func
  INNER JOIN Higiliquidos.Pessoa p ON f.NIF_Funcionario = p.NIF
  WHERE p.Nome = @nomeDistribuidor;
  
  IF @numDistribuidor IS NULL
    SET @numDistribuidor = 0;
  
  RETURN @numDistribuidor;
END;
GO



DROP FUNCTION Higiliquidos.getnumFornecedorBYname
GO
CREATE FUNCTION Higiliquidos.getnumFornecedorBYname (@nomeFornecedor varchar(256))
RETURNS INT
AS
BEGIN
  DECLARE @numFornecedor INT;
  
  SELECT @numFornecedor = Num_Fornecedor
  FROM Higiliquidos.Fornecedor f
  INNER JOIN Higiliquidos.Pessoa p ON f.NIF_Fornecedor = p.NIF
  WHERE p.Nome = @nomeFornecedor;
  
  IF @numFornecedor IS NULL
    SET @numFornecedor = 0;
  
  RETURN @numFornecedor;
END;
GO




DROP FUNCTION Higiliquidos.getnumVendedorBYname
GO
CREATE FUNCTION Higiliquidos.getnumVendedorBYname (@nomeVendedor varchar(256))
RETURNS INT
AS
BEGIN
  DECLARE @numVendedor INT;
  
  SELECT @numVendedor = Num_Vendedor
  FROM Higiliquidos.Vendedor v
  INNER JOIN Higiliquidos.Funcionario f ON v.Num_Func = f.Num_Func
  INNER JOIN Higiliquidos.Pessoa p ON f.NIF_Funcionario = p.NIF
  WHERE p.Nome = @nomeVendedor;
  
  IF @numVendedor IS NULL
    SET @numVendedor = 0;
  
  RETURN @numVendedor;
END;
GO



DROP FUNCTION Higiliquidos.getnumClienteByNif
GO
CREATE FUNCTION Higiliquidos.getnumClienteByNif (@nifCliente INT)
RETURNS INT
AS
BEGIN
  DECLARE @numCliente INT;

  SELECT @numCliente = Num_Cliente
  FROM Higiliquidos.Cliente
  WHERE NIF_Cliente = @nifCliente;

  IF @numCliente IS NULL
    SET @numCliente = 0;

  RETURN @numCliente;
END;
GO



DROP FUNCTION Higiliquidos.VerificarIDVendaExistente
GO
CREATE FUNCTION Higiliquidos.VerificarIDVendaExistente (@id_venda INT)
RETURNS INT
AS
BEGIN
    DECLARE @count INT;

    SELECT @count = COUNT(*)
    FROM Higiliquidos.Venda
    WHERE ID = @id_venda;

    RETURN @count;
END;
GO


DROP FUNCTION Higiliquidos.GetArmazemID
GO
CREATE FUNCTION Higiliquidos.GetArmazemID(@ProdutoID INT)
RETURNS INT
AS
BEGIN
    DECLARE @ArmazemID INT;

    SELECT @ArmazemID = ID_Armazem
    FROM Higiliquidos.Venda
    WHERE ID_Produto = @ProdutoID;

    RETURN @ArmazemID;
END;
GO

DROP FUNCTION Higiliquidos.VerificarIDCompraExistente
GO
CREATE FUNCTION Higiliquidos.VerificarIDCompraExistente (@id_compra INT)
RETURNS INT
AS
BEGIN
    DECLARE @count INT;

    SELECT @count = COUNT(*)
    FROM Higiliquidos.Compra
    WHERE ID = @id_compra;

    RETURN @count;
END;
GO