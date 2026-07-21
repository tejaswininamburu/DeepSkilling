CREATE NONCLUSTERED INDEX IX_ProductName ON Products(ProductName);
CREATE CLUSTERED INDEX IX_OrderDate ON Orders(OrderDate);
CREATE NONCLUSTERED INDEX IX_Customer_OrderDate ON Orders(CustomerID,OrderDate);
