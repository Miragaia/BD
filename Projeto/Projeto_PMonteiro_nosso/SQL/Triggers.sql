CREATE TRIGGER confirmPurchase ON supermarket.shoppingList
AFTER INSERT, UPDATE
AS
	SET NOCOUNT ON;
	DECLARE @barcode INT
	DECLARE @referenceNumber INT
	DECLARE @amount INT
	DECLARE @value FLOAT
	SELECT @barcode = productBarCode, @referenceNumber = orderNumber, @amount = amount FROM inserted;
	SELECT @value = retailUnitPrice FROM supermarket.product WHERE @barcode = barcode
	UPDATE supermarket.invoice SET paymentValue += @amount * @value WHERE @referenceNumber = referenceNumber
GO

INSERT supermarket.shoppinglist VALUES (11, 1, 5)