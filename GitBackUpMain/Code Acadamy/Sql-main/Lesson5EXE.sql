SELECT COUNT(*) FROM Categories
SELECT COUNT(*) FROM Products


SELECT C.CategoryName,P.ProductName FROM Categories C INNER JOIN Products P ON C.CategoryID = P.CategoryID
SELECT C.CategoryName,P.ProductName FROM Categories C LEFT JOIN Products P ON C.CategoryID = P.CategoryID

SELECT * FROM Employees P RIGHT JOIN Employees M ON P.EmployeeID = M.ReportsTo 


SELECT C.CategoryName,P.ProductName FROM Categories C RIGHT JOIN Products P ON C.CategoryID = P.CategoryID


SELECT * FROM Categories C  FULL JOIN Products P ON C.CategoryID = P.CategoryID

SELECT CategoryName,ProductName FROM Categories CROSS JOIN Products

SELECT ProductID,ProductName,UnitPrice FROM Products WHERE UnitPrice > (SELECT AVG(UnitPrice) AS Price FROM Products) ORDER BY 3

SELECT * FROM Products WHERE UnitsOnOrder > 0



SELECT * FROM Products WHERE ProductID NOT IN (SELECT distinct ProductID FROM [Order Details])



SELECT DISTINCT ShipVia, (SELECT CompanyName FROM Shippers WHERE ShipperID = Orders.ShipVia) AS CompanyName , COUNT(*) AS Adet FROM Orders GROUP BY ShipVia
SELECT * FROM Employees
SELECT * FROM ORDERS

SELECT FirstName,LastName FROM Employees E WHERE EXISTS (SELECT EmployeeID FROM Orders O WHERE O.EmployeeID = E.EmployeeID)



SELECT NEWID() AS ProductId ,ProductName,UnitPrice,UnitsInStock into Urunler FROM Products

SELECT * FROM Urunler

SELECT ROW_NUMBER() OVER (ORDER BY ProductName) AS [Index],ProductId ,ProductName,UnitPrice,UnitsInStock FROM Urunler


SELECT ROW_NUMBER() OVER (PARTITION BY ContactTitle ORDER BY ContactTitle) AS [Index],ContactTitle FROM Customers


SELECT RANK() OVER (ORDER BY ContactTitle) AS [Index],ContactTitle FROM Customers
SELECT DISTINCT RANK() OVER (ORDER BY ContactTitle) AS [Index],ContactTitle FROM Customers

SELECT DENSE_RANK() OVER (ORDER BY ContactTitle) AS [Index],ContactTitle FROM Customers
SELECT DISTINCT DENSE_RANK() OVER (ORDER BY ContactTitle) AS [Index],ContactTitle FROM Customers



SELECT DISTINCT ShipVia, (SELECT CompanyName FROM Shippers WHERE ShipperID = Orders.ShipVia) AS CompanyName , COUNT(*) AS Adet FROM Orders GROUP BY ShipVia


SELECT * FROM (SELECT DISTINCT ShipVia, (SELECT CompanyName FROM Shippers WHERE ShipperID = Orders.ShipVia) AS CompanyName , COUNT(*) AS Adet FROM Orders GROUP BY ShipVia) AS tbl PIVOT(
	SUM(Adet)
	FOR ShipVia in ([1],[2],[3]) 
) AS pvt


SELECT CategoryName , SUM(Quantity * [Order Details].UnitPrice) AS [Total Price] , COUNT(Quantity) AS Quantity FROM Products JOIN Categories ON Products.CategoryID = Categories.CategoryID JOIN [Order Details] ON Products.ProductID = [Order Details].ProductID GROUP BY CategoryName


