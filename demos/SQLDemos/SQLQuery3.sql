CREATE VIEW CustomersFirstNamesAndRemarks
AS
SELECT FirstName, Remarks
FROM Customers
WHERE FirstName Like 'L%';


--alter the view
CREATE OR ALTER VIEW CustomersFirstNamesAndRemarks
AS
SELECT LastName, Remarks
FROM Customers
WHERE FirstName Like 'L%';

Select * from CustomersFirstNamesAndRemarks;

select * from customers;
select * from Addresses;

--View with a left join
CREATE VIEW CustomersAndAddresses
AS
SELECT FirstName, LastName, AddressLine1, City, CountryCode
FROM Customers
LEFT JOIN Addresses ON Customers.AddressID = Addresses.AddressID;

SELECT * FROM CustomersAndAddresses
Select FirstName, City FROM CustomersAndAddresses
WHERE AddressLine1 Like '1%' OR AddressLine1 LIKE '4%';