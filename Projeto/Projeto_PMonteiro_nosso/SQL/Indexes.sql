-- products index
CREATE INDEX idx_product_name ON supermarket.product(barcode, [name])

-- employees index
CREATE INDEX idx_employee ON supermarket.employee(employeeID)

-- clients index
CREATE INDEX idx_client ON supermarket.client(clientID)

-- suppliers index
CREATE INDEX idx_supplier ON supermarket.supplier(supplierID)