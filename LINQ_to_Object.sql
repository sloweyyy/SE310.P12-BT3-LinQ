CREATE TABLE Product
(
    ProductID INT PRIMARY KEY,
    ProductName NVARCHAR(50),
    Quantity INT,
    Price MONEY,
    Origin NVARCHAR(50),
    ExpiryDate DATE
)