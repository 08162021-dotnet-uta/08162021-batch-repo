CREATE TABLE Customer_audits
(
ChangeId INT IDENTITY PRIMARY KEY,--record a unique id of the change
CustomerId INT NOT NULL,
FirstName VARCHAR(255),
LastName VARCHAR(255),
AddressID INT,
LastOrderDate DATE,
Remarks VARCHAR(255),
UpdatedAt DATETIME NOT NULL,--record when the operation happened
Operation CHAR(3) NOT NULL,--Record what type of operation it is.
CHECK(operation ='INS' or operation='DEL')
);

CREATE TRIGGER WhenCustomerAdded 
ON Customers
AFTER INSERT, DELETE
AS
BEGIN
	INSERT INTO Customer_audits
	(CustomerId, FirstName,LastName, AddressID, LastOrderDate, Remarks, UpdatedAt, Operation)
	SELECT CustomerId, FirstName,LastName, AddressID, LastOrderDate, Remarks, GETDATE(),'INS'
	FROM inserted
UNION ALL
	SELECT CustomerId, FirstName,LastName, AddressID, LastOrderDate, Remarks, GETDATE(),'DEL'
	FROM deleted
END

INSERT INTO Customers (LastName, FirstName, AddressId, LastOrderDate) VALUES ('Maya','Moore', 1, GETDATE());


SELECT * FROM Customers;
SELECT * FROM Customer_audits;
---------------------------------------------
CREATE TABLE Customer_audits2
(
ChangeId INT IDENTITY PRIMARY KEY,--record a unique id of the change
FirstName VARCHAR(255),
LastName VARCHAR(255),
AddressID INT,
LastOrderDate DATE
);


CREATE OR ALTER TRIGGER InsteadOfCustomerInsert 
ON Customers --this trigger will execute when inserts are done on the customers table
-- so... instead of inserting unto the customers table, this trigger will intercept that data and do something with it.
INSTEAD OF INSERT
AS
BEGIN
	INSERT INTO Customer_audits2
	(FirstName,LastName, AddressID, LastOrderDate)
	SELECT FirstName,LastName, AddressID, LastOrderDate
	FROM inserted
END

SELECT * FROM Customer_audits2;