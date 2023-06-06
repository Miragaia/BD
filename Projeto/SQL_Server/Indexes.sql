-- produtos index
DROP INDEX idx_product_name ON Higiliquidos.Produto;
GO
CREATE INDEX idx_product_name ON Higiliquidos.Produto(ID, Nome);

-- clientes index
DROP INDEX idx_client ON Higiliquidos.Cliente;
GO
CREATE INDEX idx_client ON Higiliquidos.Cliente(Num_Cliente);

-- vendas index
DROP INDEX idx_vendas ON Higiliquidos.Venda;
GO
CREATE INDEX idx_vendas ON Higiliquidos.Venda(ID);