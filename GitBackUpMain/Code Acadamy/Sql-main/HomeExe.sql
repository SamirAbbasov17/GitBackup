 SELECT CompanyName,ContactName,ProductName,UnitPrice,CategoryName FROM Suppliers INNER JOIN Products ON Suppliers.SupplierID = Products.ProductID  INNER JOIN Categories ON Products.CategoryID = Categories.CategoryID ORDER BY CompanyName ASC

 SELECT FirstName + ' ' + LastName AS Calisan , SUM(UnitPrice * Quantity) AS [Toplam Satis]  FROM Employees INNER JOIN Orders ON Employees.EmployeeID = Orders.EmployeeID  INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID GROUP BY (FirstName + ' ' + LastName)

 
-- SELECT * FROM (SELECT (SELECT CategoryName FROM Categories WHERE Categories.CategoryID = Products.CategoryID) AS Category , ProductName  FROM Products GROUP BY Products.CategoryID , ProductName) AS tbl 
-- PIVOT (
--	SUM(ProductName) 
--	FOR Category in ([1], [2], [3]) 
--) AS pvt

 --SELECT * FROM (SELECT CategoryName , ProductName  FROM Products join Categories ON Products.CategoryID = Categories.CategoryID GROUP BY CategoryName,ProductName) AS tbl 



DECLARE 
    @columns NVARCHAR(MAX) = '', 
    @sql     NVARCHAR(MAX) = '';

SELECT 
    @columns+=QUOTENAME(CategoryName) + ','
FROM 
    Categories
ORDER BY 
    CategoryName;


SET @columns = LEFT(@columns, LEN(@columns) - 1);

SET @sql ='
SELECT * FROM   
(
    SELECT CategoryName , ProductName , Products.CategoryID   FROM Products join Categories ON Products.CategoryID = Categories.CategoryID GROUP BY CategoryName,ProductName , Products.CategoryId
) t 
PIVOT(
    COUNT(CategoryID) 
    FOR CategoryName IN ('+ @columns +')
) AS pivot_table;';


EXECUTE sp_executesql @sql;
