CREATE DATABASE Demo_08162021batch;

--create an insert statement for one product
CREATE TABLE Products(
ProductId INT PRIMARY KEY IDENTITY,
ProductName varchar(50) NOT NULL,
ProductDescription varchar(100) NOT NULL,
ProductPrice decimal(19,4) NOT NULL);

--create an insert statement for one customer
CREATE TABLE Customers(
CustomerId INT PRIMARY KEY IDENTITY,
FirstName varchar(50) NOT NULL,
LastName varchar(50) NOT NULL);

-- be ready to create an order with at least
CREATE TABLE ItemizedOrders(
ItemizedId uniqueidentifier NOT NULL DEFAULT newid() PRIMARY KEY,
OrderId uniqueidentifier NOT NULL,
CustomerId INT NOT NULL FOREIGN KEY REFERENCES Customers(CustomerId) ON DELETE CASCADE,
ProductId INT NOT NULL FOREIGN KEY REFERENCES Products(ProductId) ON DELETE CASCADE,
OrderDate date NOT NULL);

DROP Table ItemizedOrders;


-- I will create a view to display any particular order and it's details.

INSERT INTO dbo.Products (ProductName, ProductDescription, ProductPrice)
VALUES ('SANGARIA Royal Milk Tea', 'Sangaria royal milk tea made with premium leaf and real milk (Pack of 24)', 42.90);

INSERT INTO dbo.Customers (FirstName, LastName)
VALUES ('Yami', 'Sukehiro');

INSERT INTO Customers
 (LastName,FirstName)
VALUES ('Bond','JamesBond');

INSERT INTO Products
 (ProductName,ProductDescription,ProductPrice)
VALUES ('Golden Gun','one-hit kill fun', 2.50);

INSERT INTO Customers ( FirstName, LastName) VALUES ('Courtney', 'Walker');

INSERT INTO Products (ProductName, ProductDescription, ProductPrice) VALUES ('ObscureBox', 'Travel Sized and Locked', 39.95);
INSERT INTO Products (ProductName,ProductDescription,ProductPrice)
VALUES('La Croix', 'A bubbly delicious zero calorie drink', 4.50);

INSERT INTO Customers
VALUES('Winnie','Wynn');
INSERT INTO Products(ProductName, ProductDescription, ProductPrice)
VALUES ('Dog Food', 'Literally food for dogs', 19.95);

INSERT INTO Customers(FirstName, LastName)
Values('Austin', 'Towler');
INSERT INTO Products
VALUES ('Lays Chips (3oz)', 'Potato chips in a bag', 1.99);

INSERT INTO Products (ProductName, ProductDescription, ProductPrice)
VALUES ('Shea Moisture Conditioner', 'Deep Conditioner', 11.99);
INSERT INTO Products (ProductName, ProductDescription, ProductPrice)
VALUES ('Cheese Pizza', 'A plain old pizza with only cheese as its topping', 5.99);
INSERT INTO Products (ProductName, ProductDescription, ProductPrice)
VALUES('Standing Desk', 'Rising desk that fits two monitors', 200);

INSERT INTO Customers (FirstName, LastName)
VALUES ('Gulomjon', 'Saidov');
INSERT INTO Customers (FirstName, LastName)
VALUES ('Hank', 'Hill');

INSERT INTO Products(ProductName, ProductDescription, ProductPrice)
VALUES ('Backpack', 'Can hold stuff for you.', 65.99);
INSERT INTO Customers
VALUES ('Jeffrey', 'Wright');
INSERT INTO Customers(FirstName, LastName) 
VALUES ('Tika', 'Brown');
INSERT INTO Products (ProductName, ProductDescription, ProductPrice)
VALUES ('Pillow', 'Satin Pillow', 24.99);
INSERT INTO Products (ProductName, ProductDescription, ProductPrice)
VALUES ('Shea Moisture Conditioner', 'Deep Conditioner', 11.99);
INSERT INTO Customers(FirstName, LastName) 
VALUES ('Tika', 'Brown');
INSERT INTO Customers (FirstName, LastName)
VALUES ( 'John', 'Doe');
INSERT INTO Customers (FirstName, LastName)
VALUES ('Blake', 'Drost');
INSERT INTO Products(ProductName, ProductDescription, ProductPrice)
VALUES ('nendoroid', 'anime figurine', 50.00);

INSERT INTO Customers(FirstName, LastName)
VALUES ('Kai', 'Ichinose');
INSERT INTO Customers (FirstName, LastName)
VALUES ('Biker', 'Joe');

INSERT INTO Products (ProductName, ProductDescription, ProductPrice)
VALUES ('Water Filter', 'A water filter with a pitcher.', 25.00);

INSERT INTO Products (ProductName, ProductDescription, ProductPrice)
VALUES ('Hydroflask', 'An insulated water bottle perfect for keeping your water cold, even during a hot day.', 25.00);

INSERT INTO Products (ProductName, ProductDescription, ProductPrice)
VALUES ('Bicycle Cage', 'A small cage that can be attached to your bicycle to hold a water bottle.', 10.00);
insert into Products
values ('HPOmen', 'Laptop', 1499.99);

insert into Products
values ('Razor', 'Desktop', 899.99);

insert into Products
values ('HP450','Notebook', 499.99);

insert into Products 
values ('CloudX', 'Gaming PC', 1999.99);

insert into Customers
values ('Chris', 'Moore');
insert into Customers
values ('Joseph', 'Mertz');
insert into Customers
values ('Jake', 'Moon');
INSERT INTO Products
VALUES ('Iphone','Mobile Phone',20.5);
INSERT INTO Customers
VALUES ('Davian','Ramsay');

insert into Products (ProductName, ProductDescription, ProductPrice) values ('cereal', '12 oz box', 12.99);

insert into Products (ProductName, ProductDescription, ProductPrice) values ('big cereal', '28 oz box', 19.99);

insert into Products (ProductName, ProductDescription, ProductPrice) values ('little cereal', '6 oz box', 6.99);

insert into Customers (FirstName, LastName) values ('Tim', 'Jack');
INSERT INTO Products(ProductName, ProductDescription, ProductPrice) VALUES 
('Gucci booksack', 'Overpriced book carrying device', 399.99);

INSERT INTO Customers(FirstName, LastName) VALUES ('Karen', 'Bigmoney');
insert into Products values ('Crack cocaine','helluva drug',100);
INSERT INTO Customers VALUES ('Simran', 'Manandhar');

INSERT INTO Products VALUES ('Juice','contains aloe vera',3.99);
insert into Customers values ('Ivana','Dance');

--0dbccbc5-2460-4259-94bc-5f8e0c711bd8
--INSERT INTO ItemizedOrders VALUES();

Insert into ItemizedOrders (OrderId, CustomerId, ProductId, OrderDate)
VALUES ('d6ff6edb-e010-4a42-8a3b-bbbb07838a7f', 1, 25, GETDATE());

Insert into ItemizedOrders (OrderId, CustomerId, ProductId, OrderDate)
VALUES ('cc6e2b75-5f48-43fb-92f4-4f9842985bf6', 1, 26, GETDATE());

Insert into ItemizedOrders (OrderId, CustomerId, ProductId, OrderDate)
VALUES ('2f473542-41c7-4f87-a5b3-717afe821305', 1, 11, GETDATE());

INSERT INTO ItemizedOrders(OrderId,CustomerId,ProductId,OrderDate)
VALUES('EE17E695-0A23-4ED7-9249-F75E9197F012',4,10,getdate());

INSERT INTO ItemizedOrders(OrderId,CustomerId,ProductId,OrderDate)
VALUES('EE17E695-0A23-4ED7-9249-F75E9197F012',4,12,getdate());

INSERT INTO ItemizedOrders(OrderId,CustomerId,ProductId,OrderDate)
VALUES('EE17E695-0A23-4ED7-9249-F75E9197F012',4,22,getdate());

--
INSERT INTO ItemizedOrders (orderid, customerid, productid, orderdate)
VALUES ('74063857-e94e-4f3f-b365-f49c1b2121a6', 8, 20, GETDATE());
INSERT INTO ItemizedOrders (orderid, customerid, productid, orderdate)
VALUES ('74063857-e94e-4f3f-b365-f49c1b2121a6', 8, 6, GETDATE());
INSERT INTO ItemizedOrders (orderid, customerid, productid, orderdate)
VALUES ('74063857-e94e-4f3f-b365-f49c1b2121a6', 8, 21, GETDATE());

insert into ItemizedOrders (OrderId, CustomerID, ProductId, OrderDate)
values('e5401eb2-0e6c-4e61-87b7-6b48be10e90b', 20, 20, '2021-09-03');

insert into ItemizedOrders (OrderId, CustomerID, ProductId, OrderDate)
values('5e842f56-fe1b-40eb-8539-f9e0559b7a99', 21, 3, '2021-09-03' );

insert into ItemizedOrders (OrderId, CustomerID, ProductId, OrderDate)
values('7685876b-bff8-4ce3-b90d-d4514256c4a7', 11, 21, '2021-09-03');

--
INSERT INTO ItemizedOrders (OrderID, CustomerId, ProductId, OrderDate) VALUES ('474a212b-36dd-4821-9700-8fdbc28fd307', 22, 3, GETDATE());
INSERT INTO ItemizedOrders (OrderID, CustomerId, ProductId, OrderDate) VALUES ('474a212b-36dd-4821-9700-8fdbc28fd307', 22, 8, GETDATE());
INSERT INTO ItemizedOrders (OrderID, CustomerId, ProductId, OrderDate) VALUES ('474a212b-36dd-4821-9700-8fdbc28fd307', 22, 26, GETDATE());

INSERT INTO ItemizedOrders (OrderID, CustomerID, ProductId, OrderDate)
VALUES('68a5d21f-f87a-4417-a4af-8f19e2ae0711', 2,2,GETDATE());

INSERT INTO ItemizedOrders (OrderID, CustomerID, ProductId, OrderDate)
VALUES('68a5d21f-f87a-4417-a4af-8f19e2ae0711', 2,1,GETDATE());

INSERT INTO ItemizedOrders (OrderID, CustomerID, ProductId, OrderDate)
VALUES('68a5d21f-f87a-4417-a4af-8f19e2ae0711', 2,3,GETDATE());

insert into ItemizedOrders (OrderID, CustomerID, ProductId, OrderDate)values ('a3af85c7-62ef-4f26-a94f-efe4c7c513e0',20,8,getDate())
insert into ItemizedOrders (OrderID, CustomerID, ProductId, OrderDate)values ('a3af85c7-62ef-4f26-a94f-efe4c7c513e0',20,22,getDate())
insert into ItemizedOrders(OrderID, CustomerID, ProductId, OrderDate) values ('a3af85c7-62ef-4f26-a94f-efe4c7c513e0',20,6,getDate())

INSERT INTO ItemizedOrders(OrderId, CustomerId, ProductId, OrderDate)
VALUES ('99e27569-dbb1-448a-abce-8e84688eac50', 12, 11, GETDATE()),
('99e27569-dbb1-448a-abce-8e84688eac50', 12, 25, GETDATE()),
('99e27569-dbb1-448a-abce-8e84688eac50', 12, 27, GETDATE());

INSERT INTO ItemizedOrders (OrderID, CustomerID, ProductId, OrderDate)
VALUES ('d6721536-175c-470a-83b0-43e02529649f', 14, 17, GETDATE())

INSERT INTO ItemizedOrders (OrderID, CustomerID, ProductId, OrderDate)
VALUES ('d6721536-175c-470a-83b0-43e02529649f', 14, 20, GETDATE())

INSERT INTO ItemizedOrders (OrderID, CustomerID, ProductId, OrderDate)
VALUES ('d6721536-175c-470a-83b0-43e02529649f', 14, 14, GETDATE())

INSERT INTO ItemizedOrders(OrderId, CustomerId, ProductId, OrderDate)
VALUES ('2403fbf5-2d84-4160-a96b-17227797456f', 5, 4, GETDATE());

INSERT INTO ItemizedOrders(OrderId, CustomerId, ProductId, OrderDate)
VALUES ('2403fbf5-2d84-4160-a96b-17227797456f', 5, 9, GETDATE());

INSERT INTO ItemizedOrders(OrderId, CustomerId, ProductId, OrderDate)
VALUES ('2403fbf5-2d84-4160-a96b-17227797456f', 5, 11, GETDATE());

--
INSERT INTO ItemizedOrders (OrderID, CustomerId, ProductId, OrderDate) VALUES ('fa54cf2b-8c7e-4e44-86b0-8234b4702c66', 7, 8, GETDATE());
INSERT INTO ItemizedOrders (OrderID, CustomerId, ProductId, OrderDate) VALUES ('fa54cf2b-8c7e-4e44-86b0-8234b4702c66', 7, 9, GETDATE());
INSERT INTO ItemizedOrders (OrderID, CustomerId, ProductId, OrderDate) VALUES ('fa54cf2b-8c7e-4e44-86b0-8234b4702c66', 7, 6, GETDATE());

Insert into ItemizedOrders(OrderId, CustomerId, ProductId, OrderDate)
values ('53266e78-7dee-42c9-b9b8-e40422c959bf', 15, 18, GetDate());
Insert into ItemizedOrders(OrderId, CustomerId, ProductId, OrderDate)
values ('53266e78-7dee-42c9-b9b8-e40422c959bf', 15, 19, GetDate());
Insert into ItemizedOrders(OrderId, CustomerId, ProductId, OrderDate)
values ('53266e78-7dee-42c9-b9b8-e40422c959bf', 15, 20, GetDate());

INSERT INTO dbo.ItemizedOrders (OrderID, CustomerID, ProductId, OrderDate)
SELECT
    N'f9b889d7-5912-4b38-8c6a-a46db40d1c14' AS OrderID,
    8 AS CustomerID,
    ProductID,
    DATEFROMPARTS(2020, 11, 29) AS OrderDate
FROM Products
WHERE ProductID IN (7,25,20);

INSERT INTO ItemizedOrders (OrderID, CustomerID, ProductId, OrderDate)
VALUES ('0cda9147-fe03-47a3-9442-5abaee2d87f1' , 20, 6,GetDate());

INSERT INTO ItemizedOrders (OrderID, CustomerID, ProductId, OrderDate)
VALUES ('0cda9147-fe03-47a3-9442-5abaee2d87f1' , 21, 19, GetDate());

INSERT INTO ItemizedOrders (OrderID, CustomerID, ProductId, OrderDate)
VALUES ('0cda9147-fe03-47a3-9442-5abaee2d87f1' , 19, 21, GetDate());

INSERT INTO ItemizedOrders (OrderID, CustomerID, ProductId, OrderDate)
VALUES ('cb4e7098-be8a-453f-828c-cbacaf74e65e', 2, 13,GETDATE());

INSERT INTO ItemizedOrders (OrderID, CustomerID, ProductId, OrderDate)
VALUES ('2926b274-635e-47a4-8240-9bb5b5195398', 2, 15,GETDATE());

INSERT INTO ItemizedOrders (OrderID, CustomerID, ProductId, OrderDate)
VALUES ('70f18b35-01a8-46c5-9859-c93d7eed401b', 2, 17,GETDATE());

INSERT INTO ItemizedOrders(OrderId, CustomerId, ProductId, OrderDate)
VALUES ('e48be35b-c515-4066-943e-ba2aab8f14ca', 1, 2, GETDATE());

INSERT INTO ItemizedOrders(OrderId, CustomerId, ProductId, OrderDate)
VALUES ('e48be35b-c515-4066-943e-ba2aab8f14ca', 1, 7, GETDATE());

INSERT INTO ItemizedOrders(OrderId, CustomerId, ProductId, OrderDate)
VALUES ('e48be35b-c515-4066-943e-ba2aab8f14ca', 1, 10, GETDATE());

insert into ItemizedOrders (OrderId, CustomerId, ProductId, OrderDate) values ('02308b04-3b64-46a9-a0da-2ba5ebf5eea6', 1, 11, getdate());

insert into ItemizedOrders (OrderId, CustomerId, ProductId, OrderDate) values ('435f8063-5503-476a-b962-3899e653a4ed', 1, 5, getdate());

insert into ItemizedOrders (OrderId, CustomerId, ProductId, OrderDate) values ('339101e4-4af7-4d72-b2d2-ca2014592705', 1, 18, getdate());

INSERT INTO ItemizedOrders(OrderId, CustomerId, ProductId, OrderDate)
VALUES ('EA0EF870-5D07-42A7-B5E6-1F6BF8706415', 13, 15, GETDATE()), ('EA0EF870-5D07-42A7-B5E6-1F6BF8706415', 13, 8, GETDATE()), ('EA0EF870-5D07-42A7-B5E6-1F6BF8706415', 13, 10, GETDATE());

INSERT INTO ItemizedOrders(OrderId,CustomerId,ProductId,OrderDate)
VALUES('E6B34D13-FCB9-4780-A897-DFE8FA4B4E66', 10, 8, GETDATE());

INSERT INTO ItemizedOrders(OrderId,CustomerId,ProductId,OrderDate)
VALUES('E6B34D13-FCB9-4780-A897-DFE8FA4B4E66', 12, 10,GETDATE());

INSERT INTO ItemizedOrders(OrderId,CustomerId,ProductId,OrderDate)
VALUES('E6B34D13-FCB9-4780-A897-DFE8FA4B4E66',5, 1,GETDATE());