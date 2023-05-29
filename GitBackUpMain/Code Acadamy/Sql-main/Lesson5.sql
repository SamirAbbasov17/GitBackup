-- 2.) OUTER JOIN  
-- 2.1) LEFT OUTER JOIN : Sorguda katılan tablolardan soldakinin tüm kayıtları getirilirken, sağdaki tablodaki sadece ilişkili olan kayıtlar getirilir.

SELECT COUNT(*)
FROM Categories -- 108
SELECT COUNT(*)
FROM Products
--128

-- Satış yapan personeller
select C.CategoryName
     , P.ProductName
from Categories         C
    inner join Products P
        on C.CategoryID = P.CategoryID
-- sadece ilişkisel kayıtları getirir ( inner join )

-- Tüm Personeller ve satış değerleri
select C.CategoryName
     , P.ProductName
from Categories        C
    left join Products P
        on C.CategoryID = P.CategoryID

-- Her bir çalışanı rapor verdiği kişiyle birlikte listeleyelim
select P.FirstName + ' ' + p.LastName AS [Personel]
     , M.FirstName + ' ' + M.LastName AS [Yönetici]
from Employees          P
    left join Employees M
        ON P.ReportsTo = M.EmployeeID
order by 2



-- 2.2) RIGHT OUTER JOIN: Sorguda katılan tablolardan sağdakinin tüm kayıtları getirilirken, soldaki tablodaki sadece ilişkili olan kayıtlar getirilir.


select C.CategoryName
     , P.ProductName
from Categories        C
    right join Products P
        on C.CategoryID = P.CategoryID



select M.FirstName + ' ' + M.LastName AS [Personel]
     , P.FirstName + ' ' + P.LastName AS [Yönetici]
from Employees          P
    right join Employees M
        ON P.EmployeeID = M.ReportsTo
order by 2



-- 3.) FULL JOIN: Her iki tablodaki tüm kayıtlar getirilir. Left ve Right Outer Join'in birleşimidir



select  C.CategoryName, P.ProductName from Categories C  /*inner*/full join Products P 
ON C.CategoryID = P.CategoryID

-- 4.) CROSS JOIN: Bir tablodaki bir kaydın diğer tablodaki tüm kayıtlarla eşleştirilmesini sağlar.


select CategoryName, ProductName from Categories cross join Products



-- SUB QUERY
select ProductID
     , ProductName
     , UnitPrice
     , UnitsInStock
     , CategoryName
	 , C.Description
     , S.CompanyName
	 , S.ContactTitle
	 , S.ContactName
from Products       P
    Join Categories C
        on P.CategoryID = C.CategoryID
    join Suppliers  S
        on P.SupplierID = S.SupplierID

SELECT ProductID
     , ProductName
     , UnitPrice
     , UnitsInStock
     , (
           SELECT CONCAT(CategoryName, ' - ', [Description])
           FROM Categories C
           Where C.CategoryID = P.CategoryID
       )           AS Category
     , (
           SELECT CONCAT(S.CompanyName, ' - ',S.ContactTitle, ' - ',  S.ContactName) 
           FROM Suppliers S WHERE S.SupplierID = P.SupplierID 
       ) AS Supplier
--, C.Description
--, S.CompanyName
--, S.ContactTitle
--, S.ContactName
FROM Products       P
    --JOIN Categories C
    --    ON P.CategoryID = C.CategoryID
    --JOIN Suppliers  S
    --    ON P.SupplierID = S.SupplierID





-- Fiyatı ortalama fiyatın üstünde olan ürünler

SELECT ProductID
     , ProductName
     , UnitPrice
FROM Products
WHERE UnitPrice >
(
    SELECT AVG(UnitPrice) AS Price FROM Products
)
ORDER BY 3


-- Ürünler tablosudaki satılan ürünlerin listesi


SELECT *
FROM  Products
WHERE ProductID not in (
                           SELECT DISTINCT ProductID FROM [Order Details]
					   )

-- kargo şirketlerinin taşıdıkları sipariş sayıları
SELECT DISTINCT ShipVia, (SELECT CompanyName FROM Shippers WHERE ShipperID = Orders.ShipVia) AS CompanyName , COUNT(*) AS Adet FROM Orders 
GROUP BY ShipVia



SELECT ShipperID
     , CompanyName
     , COUNT(*) AS Adet
FROM Shippers
    JOIN Orders
        ON Shippers.ShipperID = Orders.ShipVia
GROUP BY ShipperID
       , CompanyName



-- Sipariş Alan Çalışanları Listeleyiniz

SELECT FirstName, LastName FROM Employees E  
WHERE Exists (select EmployeeID from Orders O where O.EmployeeID = E.EmployeeID)

insert into Employees (FirstName, LastName) values('Test','Deneme')

select NEWID() as ProductId, ProductName, UnitPrice, UnitsInStock  into Uruns from Products 

select * from Uruns


-- Row_Number() -> satırlar için sanal sıra no oluşturur

SELECT ROW_NUMBER() OVER (ORDER BY ProductName) AS [Index]
     , ProductId
     , ProductName
     , UnitPrice
     , UnitsInStock
FROM Uruns


-- Aynı değerlere, sıralı index değerinin verilmesi
 
SELECT ROW_NUMBER() OVER (PARTITION BY ContactTitle ORDER BY ContactTitle) AS [Index],
      ContactTitle
FROM Customers


SELECT DISTINCT RANK() OVER (ORDER BY ContactTitle) AS [Index],
      ContactTitle
FROM Customers


SELECT DENSE_RANK() OVER (ORDER BY ContactTitle) AS [Index],
      ContactTitle
FROM Customers

SELECT DISTINCT DENSE_RANK() OVER (ORDER BY ContactTitle) AS [Index],
      ContactTitle
FROM Customers


-- RowNumber ile Derived bir tablo oluşturup sayfalama yapma

SELECT * FROM (SELECT ROW_NUMBER() OVER (ORDER BY CustomerID ) AS SatirNo, CompanyName, ContactTitle, ContactName ,City FROM Customers) AS tbl
WHERE tbl.SatirNo BETWEEN 20 AND 50



-- Hangi kargo firması, kaç adet kargo taşımıştır


-- pivot sorgu
SELECT ShipVia, COUNT(*) AS [Adet] FROM Orders
GROUP BY ShipVia


SELECT * FROM (SELECT ShipVia, COUNT(*) AS [Adet] FROM Orders
GROUP BY ShipVia) AS tbl
PIVOT (
    SUM(Adet) 
	FOR ShipVia in ([1], [2], [3]) 
) AS pvt

-- Ürünleri kategori adına göre gruplayıp sonrasındai pivot sorguya çeviriniz :)



-- sonra :) bu sorguyu kategori adına göre dinamik yazın , yani yeni bir kategori eklediğimde :) sorgu değişmeyecek :)sorgu dinamik olacak :) dinamik :)
