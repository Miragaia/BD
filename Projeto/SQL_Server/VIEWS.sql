DROP VIEW view_clients
GO
CREATE VIEW view_clients AS
SELECT Pessoa.NIF, Nome, Num_Cliente, Data_de_Nascimento, Email, Morada,
ContactoTelefonico
FROM Higiliquidos.Pessoa JOIN Higiliquidos.Cliente on Pessoa.NIF = Cliente.NIF_Cliente;
GO

DROP VIEW view_fornecedores
GO
CREATE VIEW view_fornecedores AS
SELECT Num_Fornecedor, Nome, Pessoa.NIF, Data_de_Nascimento, Email, Morada,
ContactoTelefonico
FROM Higiliquidos.Pessoa JOIN Higiliquidos.Fornecedor on Pessoa.NIF = Fornecedor.NIF_Fornecedor;
GO



DROP VIEW view_distribuidores
GO
CREATE VIEW view_distribuidores AS
SELECT Pessoa.NIF, Nome, Num_Cliente, Data_de_Nascimento, Email, Morada,
ContactoTelefonico
FROM Higiliquidos.Distribuidor d JOIN Higiliquidos.Funcionarios f on d.Num_Distribuidor = f.Num_;
FROM Higiliquidos.Pessoa p JOIN Higiliquidos.Funcionarios f on p.NIF = f.NIF_Funcionario;
GO















DROP VIEW view_vendas
GO

CREATE VIEW view_vendas AS
SELECT DISTINCT
	ent.Data_Entrega,
    v.ID AS ID_Venda,
    v.ID_Produto,
    p.Nome AS Nome_Produto,
    p.Tipo_de_Produto,
    p.Preco,
    p.IVA,
    v.Quantidade,
    v.ID_Armazem,
    pc.Nome AS Nome_Cliente,
	c.NIF_Cliente,
    pv.Nome AS Nome_Vendedor,
    pd.Nome AS Nome_Distribuidor
	
FROM
    Higiliquidos.Venda v
    JOIN Higiliquidos.Produto p ON v.ID_Produto = p.ID
    JOIN Higiliquidos.Armazem a ON v.ID_Armazem = a.ID
    JOIN Higiliquidos.Cliente c ON v.Num_Cliente = c.Num_Cliente
    JOIN Higiliquidos.Vendedor ve ON v.Num_Vendedor = ve.Num_Vendedor
    JOIN Higiliquidos.Distribuidor d ON v.Num_Distribuidor = d.Num_Distribuidor
    JOIN Higiliquidos.Funcionario fv ON fv.Num_Func = ve.Num_Func
    JOIN Higiliquidos.Funcionario fd ON fd.Num_Func = d.Num_Func
    JOIN Higiliquidos.Pessoa pv ON fv.NIF_Funcionario = pv.NIF
    JOIN Higiliquidos.Pessoa pd ON fd.NIF_Funcionario = pd.NIF
	JOIN Higiliquidos.Pessoa pc ON c.NIF_Cliente = pc.NIF
	JOIN Higiliquidos.Entrega ent ON v.ID = ent.ID_Venda;
GO


DROP VIEW view_produtos
GO

CREATE VIEW view_produtos AS
SELECT DISTINCT
    p.ID,
	p.Nome,
	p.Marca,
	p.Tipo_de_Produto,
	p.IVA,
	p.Preco,
	p.Quantidade,
	v.ID_Armazem
    
FROM
    Higiliquidos.Venda v
    JOIN Higiliquidos.Produto p ON v.ID_Produto = p.ID
    JOIN Higiliquidos.Armazem a ON v.ID_Armazem = a.ID
GO



DROP VIEW view_compras
GO

CREATE VIEW view_compras AS
SELECT DISTINCT
	c.Data_Compra,
    c.ID AS ID_Compra,
    c.ID_Produto,
    p.Nome AS Nome_Produto,
    p.Tipo_de_Produto,
    p.Preco,
    p.IVA,
    c.Quantidade,
    c.ID_Armazem,
	pe.nome AS Nome_fornecedor

	
FROM
    Higiliquidos.Compra c
    JOIN Higiliquidos.Produto p ON c.ID_Produto = p.ID
    JOIN Higiliquidos.Armazem a ON c.ID_Armazem = a.ID
	JOIN Higiliquidos.Fornecedor f ON c.Num_Fornecedor = f.Num_Fornecedor
    JOIN Higiliquidos.Pessoa pe ON f.NIF_Fornecedor = pe.NIF

GO