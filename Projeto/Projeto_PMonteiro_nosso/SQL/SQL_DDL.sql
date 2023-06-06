CREATE TABLE supermarket.person(
	NIF INT,
	[name] VARCHAR(50) NOT NULL,
	[address] VARCHAR(100),
	phone VARCHAR(15),
	email VARCHAR(30),
	PRIMARY KEY(NIF)
);

CREATE TABLE supermarket.client(
	clientID INT,
	website VARCHAR(30),
	clientSince DATE,
	NIF INT,
	PRIMARY KEY (clientID),
  	FOREIGN KEY (NIF) REFERENCES supermarket.person(NIF)
);

CREATE TABLE supermarket.employee(
	employeeID INT,
	employeeSince DATE,
	salary FLOAT(2),
	jobTitle VARCHAR(20),
	NIF INT,
	PRIMARY KEY (employeeID),
	FOREIGN KEY (NIF) REFERENCES supermarket.person(NIF)
);

CREATE TABLE supermarket.supplier(
	supplierID INT,
	organizationName VARCHAR(30),
	[address] VARCHAR(100),
	email VARCHAR(30),
	phone VARCHAR(15),
	supplierSince DATE,
	NIF INT,
	website VARCHAR(30),
	[description] VARCHAR(255),
	PRIMARY KEY (supplierID)
);

CREATE TABLE supermarket.type(
	[name] VARCHAR(20),
	IVA FLOAT,
	PRIMARY KEY ([name])
);

CREATE TABLE supermarket.wareHouse(
	number INT,
	PRIMARY KEY (number)
);

CREATE TABLE supermarket.product(
	barcode INT,
	[name] VARCHAR(30) NOT NULL,
	brand VARCHAR(30),
	stock INT NOT NULL,
	buyPrice FLOAT NOT NULL,
	retailUnitPrice FLOAT NOT NULL,
	profit FLOAT,
	[description] VARCHAR(255),
	baseUnit VARCHAR(30),
	supplierID INT,
	productType VARCHAR(20),
	wareHouseNumber INT,
	PRIMARY KEY (barCode),
	FOREIGN KEY (supplierID) REFERENCES supermarket.supplier(supplierID),
	FOREIGN KEY (productType) REFERENCES supermarket.type([name]),
	FOREIGN KEY (wareHouseNumber) REFERENCES supermarket.wareHouse(number)
);

CREATE TABLE supermarket.shoppingList(
	orderNumber INT,
	productBarCode INT,
	amount INT,

	PRIMARY KEY (orderNumber, productBarCode),
	FOREIGN KEY (orderNumber) REFERENCES supermarket.invoice(referenceNumber),
	FOREIGN KEY (productBarCode) REFERENCES supermarket.product(barCode)
);

CREATE TABLE supermarket.invoice(
	referenceNumber INT,
	[date] DATE,
	[paymentValue] FLOAT,
	paid BIT,
	[counter] INT,
	employeeID INT,
	clientID INT,

	PRIMARY KEY (referenceNumber),
	FOREIGN KEY (clientID) REFERENCES supermarket.client(clientID),
	FOREIGN KEY (employeeID) REFERENCES supermarket.employee(employeeID)
);	

CREATE TABLE supermarket.login(
	username INT NOT NULL,
	password VARCHAR(128) NOT NULL,
	PRIMARY KEY (username)
);