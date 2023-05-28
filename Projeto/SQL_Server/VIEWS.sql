USE p8g8

GO

CREATE VIEW Higiliquidos.View_Vendedor AS
SELECT v.Num_Vendedor, p.Nome AS NomeVendedor, p.Email AS EmailVendedor, p.ContactoTelefonico AS ContactoVendedor, e.Nome AS NomeEmpresa
FROM Higiliquidos.Vendedor AS v
INNER JOIN Higiliquidos.Funcionario AS f ON v.Num_Func = f.Num_Func
INNER JOIN Higiliquidos.Pessoa AS p ON f.NIF_Funcionario = p.NIF
INNER JOIN Higiliquidos.Empresa AS e ON p.NIF_Empresa = e.NIF_Empresa;
GO


CREATE VIEW Higiliquidos.View_Gerentes AS
SELECT G.Num_Gerente, F.Num_Func, P.Nome AS Nome_Gerente, P.NIF AS NIF_Gerente,  P.Email AS Email_Gerente, P.ContactoTelefonico AS Contacto_Gerente
FROM Higiliquidos.Gerente G
JOIN Higiliquidos.Funcionario F ON G.Num_Func = F.Num_Func
JOIN Higiliquidos.Pessoa P ON F.NIF_Funcionario = P.NIF;
GO


CREATE VIEW Higiliquidos.View_Distribuidor AS
SELECT d.Num_Distribuidor, p.Nome AS NomeDistribuidor, p.Email AS EmailDistribuidor, p.ContactoTelefonico AS ContactoDistribuidor, e.Nome AS NomeEmpresa
FROM Higiliquidos.Distribuidor AS d
INNER JOIN Higiliquidos.Funcionario AS f ON d.Num_Func = f.Num_Func
INNER JOIN Higiliquidos.Pessoa AS p ON f.NIF_Funcionario = p.NIF
INNER JOIN Higiliquidos.Empresa AS e ON p.NIF_Empresa = e.NIF_Empresa;
GO


CREATE VIEW Higiliquidos.View_Funcionario AS
SELECT f.Num_Func, p.Nome AS NomeFuncionario, p.Email AS EmailFuncionario, p.ContactoTelefonico AS ContactoFuncionario, f.IBAN, f.Numero_SS, f.Data_Inicio_Atividade, e.Nome AS NomeEmpresa
FROM Higiliquidos.Funcionario AS f
INNER JOIN Higiliquidos.Pessoa AS p ON f.NIF_Funcionario = p.NIF
INNER JOIN Higiliquidos.Empresa AS e ON p.NIF_Empresa = e.NIF_Empresa;
GO


CREATE VIEW Higiliquidos.View_Clientes AS
SELECT C.Num_Cliente, P.Nome AS Nome_Cliente, C.NIF_Cliente,  P.Email AS Email_Cliente, P.ContactoTelefonico AS Contacto_Cliente
FROM Higiliquidos.Cliente AS C
JOIN Higiliquidos.Pessoa AS P ON C.NIF_Cliente = P.NIF;
GO


CREATE VIEW Higiliquidos.View_Fornecedores AS
SELECT F.Num_Fornecedor, P.Nome AS Nome_Fornecedor, F.NIF_Fornecedor, P.Email AS Email_Fornecedor, P.ContactoTelefonico AS Contacto_Fornecedor
FROM Higiliquidos.Fornecedor AS F
JOIN Higiliquidos.Pessoa AS P ON F.NIF_Fornecedor = P.NIF;
GO


CREATE VIEW Higiliquidos.ViewPessoa AS
SELECT * FROM Higiliquidos.Pessoa
GO


CREATE VIEW Higiliquidos.View_Vendas AS
SELECT v.ID, v.Quantidade, p.Nome AS NomeProduto, a.Endereco AS EnderecoArmazem, v.Num_Vendedor, v.Num_Distribuidor, c.Num_Cliente
FROM Higiliquidos.Venda AS v
INNER JOIN Higiliquidos.Produto AS p ON v.ID_Produto = p.ID
INNER JOIN Higiliquidos.Armazem AS a ON v.ID_Armazem = a.ID
INNER JOIN Higiliquidos.Cliente AS c ON v.Num_Cliente = c.Num_Cliente;
