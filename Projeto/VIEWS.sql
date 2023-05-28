CREATE VIEW Higiliquidos.View_Clientes AS
SELECT C.Num_Cliente, P.Nome AS Nome_Cliente, C.NIF_Cliente,  P.Email AS Email_Cliente, P.ContactoTelefonico AS Contacto_Cliente
FROM Higiliquidos.Cliente AS C
JOIN Higiliquidos.Pessoa AS P ON C.NIF_Cliente = P.NIF;


CREATE VIEW Higiliquidos.View_Fornecedores AS
SELECT F.Num_Fornecedor, P.Nome AS Nome_Fornecedor, F.NIF_Fornecedor, P.Email AS Email_Fornecedor, P.ContactoTelefonico AS Contacto_Fornecedor
FROM Higiliquidos.Fornecedor AS F
JOIN Higiliquidos.Pessoa AS P ON F.NIF_Fornecedor = P.NIF;


CREATE VIEW Higiliquidos.View_Gerentes AS
SELECT G.Num_Gerente, F.Num_Func, P.Nome AS Nome_Gerente, P.NIF AS NIF_Gerente,  P.Email AS Email_Gerente, P.ContactoTelefonico AS Contacto_Gerente
FROM Higiliquidos.Gerente G
JOIN Higiliquidos.Funcionario F ON G.Num_Func = F.Num_Func
JOIN Higiliquidos.Pessoa P ON F.NIF_Funcionario = P.NIF;


