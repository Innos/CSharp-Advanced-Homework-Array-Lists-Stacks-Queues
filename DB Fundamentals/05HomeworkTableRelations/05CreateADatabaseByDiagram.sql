CREATE TABLE ItemTypes
(
ItemTypeID INT NOT NULL PRIMARY KEY,
Name varchar(50)
)

CREATE TABLE Items
(
ItemID INT NOT NULL PRIMARY KEY,
Name varchar(50),
ItemTypeID INT NOT NULL,
Constraint FK_Items_ItemTypes Foreign Key (ItemTypeID) References ItemTypes(ItemTypeID)
)

CREATE TABLE Cities
(
CityID INT NOT NULL PRIMARY KEY,
Name varchar(50),
)

CREATE TABLE Customers
(
CustomerID INT NOT NULL PRIMARY KEY,
Name varchar(50),
Birthday DATE,
CityID INT NOT NULL,
Constraint FK_Customers_Cities Foreign Key (CityID) References Cities(CityID)
)

CREATE TABLE Orders
(
OrderID INT NOT NULL PRIMARY KEY,
CustomerID INT NOT NULL,
Constraint FK_Orders_Customers Foreign Key (CustomerID) References Customers(CustomerID)
)

CREATE TABLE OrderItems
(
OrderID INT NOT NULL,
ItemID INT NOT NULL,
Constraint PK_OrderItems PRIMARY KEY(OrderID,ItemID),
Constraint FK_OrderItems_Items Foreign Key (ItemID) References Items(ItemID),
Constraint FK_OrderItems_Orders Foreign Key (OrderID) References Orders(OrderID),
)