CREATE VIEW view_employees AS
SELECT employeeID, [name], person.NIF, [address], phone, email,
jobTitle, salary, employeeSince
FROM supermarket.person JOIN supermarket.employee on person.NIF = employee.NIF;

CREATE VIEW view_clients AS
SELECT clientID, [name], person.NIF, [address], phone, email,
website, clientSince
FROM supermarket.person JOIN supermarket.client on person.NIF = client.NIF;

CREATE VIEW product_list AS
SELECT DISTINCT barcode, [name], brand, retailUnitPrice, amount
FROM supermarket.product JOIN supermarket.shoppingList on product.barcode = shoppingList.productBarCode;

CREATE VIEW view_suppliers AS
SELECT supplierID, organizationName, [address], email, phone, 
supplierSince, NIF, website, [description]
FROM supermarket.supplier

CREATE VIEW view_shoppingList AS
SELECT orderNumber, productBarCode, amount
FROM supermarket.shoppingList JOIN supermarket.invoice on shoppingList.orderNumber = invoice.referenceNumber

CREATE VIEW view_invoices AS
SELECT referenceNumber, [date], [paymentValue], paid, [counter], employee
FROM supermarket.invoice

CREATE VIEW view_products AS
SELECT barcode, [name], brand, stock, buyPrice, retailUnitPrice, productType, wareHouseNumber
FROM supermarket.product
