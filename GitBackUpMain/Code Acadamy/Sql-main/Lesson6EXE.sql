
CREATE VIEW SatisRaporlari AS SELECT Employees.FirstName AS Employee,Employees.LastName,Employees.Address,Employees.Title,Employees.HireDate,Customers.CompanyName,Customers.ContactName AS Customer,Customers.Phone,Categories.CategoryName,Products.ProductName,Products.UnitsInStock,[Order Details].UnitPrice,[Order Details].Quantity FROM Orders JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID JOIN Customers ON Orders.CustomerID = Customers.CustomerID JOIN Employees ON Orders.EmployeeID = Employees.EmployeeID JOIN Products ON [Order Details].ProductID = Products.ProductID JOIN Categories ON Products.CategoryID = Categories.CategoryID

SELECT * FROM SatisRaporlari

create VIEW Kategoriler AS SELECT * FROM Categories


ALTER VIEW Kategoriler AS
SELECT CategoryID,CategoryName FROM Categories

ALTER VIEW Kategoriler AS
SELECT CategoryID,CategoryName , [Description] FROM Categories WHERE [Description] IS NOT NULL

SELECT * FROM Kategoriler

INSERT INTO Kategoriler (CategoryName,Description) values ('Kategory Adi','Yeni Kategori Aciklamasi')


DELETE FROM Kategoriler WHERE CategoryID = 9
SELECT * FROM Kategoriler





ALTER VIEW OgrenciListesi 
WITH ENCRYPTION
AS
SELECT EmployeeID AS StudentId, FirstName , LastName, City AS Branch  FROM Employees
WHERE City = 'London'
WITH CHECK OPTION 


SELECT * FROM OgrenciListesi

INSERT INTO OgrenciListesi VALUES ('Samir','Abbasov','Izmir')




ALTER VIEW Kategoris
WITH SCHEMABINDING
AS
SELECT CategoryID,CategoryName,[Description] FROM dbo.Categories

SELECT * FROM Kategoris