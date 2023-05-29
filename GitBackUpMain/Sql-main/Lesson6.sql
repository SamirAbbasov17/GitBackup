-- Bir siparişin hangi çalışan tarafından hangi müşteriye hangi kategorideki üründen hangi fiyattan kaç adet satıldığını listeleyiniz.
-- Çalışanın adı, soyadı, ünvanı, görevi, işe başlama tarihi
-- Müşterinin firma adını, temsilcisini ve telefonunu
-- Ürünün adını, stok miktarını, birim fiyatını
-- Siparişin adetini ve satış fiyatını
-- Kategori adını


CREATE VIEW SatisRaporlari
AS

SELECT dbo.Employees.FirstName, dbo.Employees.LastName, dbo.Employees.Title, dbo.Employees.HireDate, dbo.Customers.ContactTitle, dbo.Customers.ContactName, dbo.Customers.CompanyName, dbo.Customers.Phone, dbo.Products.ProductName, dbo.Products.UnitPrice, dbo.Products.UnitsInStock, dbo.[Order Details].Quantity, dbo.[Order Details].UnitPrice AS Expr1, dbo.Categories.CategoryName
FROM dbo.Categories
     INNER JOIN dbo.Products ON dbo.Categories.CategoryID=dbo.Products.CategoryID
     INNER JOIN dbo.[Order Details] ON dbo.Products.ProductID=dbo.[Order Details].ProductID
     INNER JOIN dbo.Employees
                INNER JOIN dbo.Orders ON dbo.Employees.EmployeeID=dbo.Orders.EmployeeID
                INNER JOIN dbo.Shippers ON dbo.Orders.ShipVia=dbo.Shippers.ShipperID
                INNER JOIN dbo.Customers ON dbo.Orders.CustomerID=dbo.Customers.CustomerID ON dbo.[Order Details].OrderID=dbo.Orders.OrderID
 
 /* 
	View'ler genel olarak 2 amaç için kullanılır.

	1) Karmaşık sorguları basitleştirmek için.
	2) Tablo erişimlerini kullanıcı bazında kısıtlayarak bu kullanıcların belirtilen tabloların belirtilen sütunlarına erişmesini sağlamak 
	amacıyla kullanılır. Yani, kullanıcı tablo üzerinde istediği gibi hareket edemeyecektir.
	
*/
SELECT * FROM SatisRaporlari

-- View Oluşturma
CREATE VIEW Kategoriler AS
SELECT * FROM Categories



-- View Güncelleme
ALTER VIEW   Kategoriler AS
SELECT CategoryID, CategoryName FROM Categories
 
ALTER VIEW   Kategoriler AS
SELECT CategoryID,CategoryName, [Description] FROM Categories
WHERE  [Description] is not null
 
-- View üzerinden güncelleme işlemi
Update Kategoriler Set Description = 'View açıklaması' Where CategoryID = 1

-- View  üzerinden kayıt ekleme işlemi
Insert into Kategoriler (CategoryName,Description) values ('Kategori Adı','Yeni Kategori Açıklaması')

-- View üzerinden kayıt ekleme işlemi
Delete from Kategoriler where CategoryID = 1012

SELECT * FROM Kategoriler 



-- VIEW ile With Check Option Kullanımı
ALTER VIEW OgrenciListesi 
WITH ENCRYPTION
AS 
SELECT EmployeeID AS StudentId, FirstName, LastName, City AS Branch   FROM Employees
WHERE City = 'London' 
WITH CHECK OPTION


SELECT * FROM OgrenciListesi

-- London 
INSERT INTO OgrenciListesi VALUES ('Ahmet', 'Şahin','London' )


ALTER VIEW OgrenciListesi 
WITH ENCRYPTION
AS 
SELECT EmployeeID AS StudentId, FirstName, LastName, City AS Branch   FROM Employees
WHERE City = 'London' 
WITH CHECK OPTION



 -- View ile With Schemabinding Kullanımı
-- Bir tablo üzerinde bir View tanımladıktan sonra, tablo üzerinde yapısal bir değişiklik yaparsak (örneğin, FirstName sütununun tipini 
--nvarchar(10)'dan nvarchar(15)'e çekersek, SQL Server bize bir uyarı verir. Bu uyarıda bu tablo üzerinde bir View olduğu ve eğer yaptığımız
-- değişikliği onaylarsak View'in tanımından With SchemaBindind ibaresini kaldıracağını bildirir. Eğer onaylarsak View'den bu ibare kaldırılır
-- ve tablo üzerinde yapacağımız daha sonraki değişiklikler için herhangi bir uyarı almayız.

ALTER VIEW Kategoris
WITH SCHEMABINDING
AS
SELECT CategoryID, CategoryName,Description FROM dbo.Categories

SELECT * FROM Kategoris






execute as Login = 'test'

 select FirstName,  BirthDate as 'Sallary' from Employees

-- update Employees set FirstName = 'Deneme' where LastName = 'Sahin'
revert