-- GROUP BY Kullanımı

-- Çalışanların ülkelerine göre gruplanması
-- https://cdn.create.vista.com/api/media/medium/184353266/stock-photo-white-brown-eggs-laying-egg?token=

SELECT Country, COUNT(Region)FROM Employees GROUP BY Country -- Aggregate fonksiyonlarda, boş geçilebilen (null) olan alanlar sorguya dahil edilmez.
SELECT Country, COUNT(*)FROM Employees GROUP BY Country

-- Çalışanların yapmış olduğu sipariş adeti
SELECT EmployeeID, COUNT(*) AS Adet
FROM Orders
GROUP BY EmployeeID
ORDER BY 2

-- Employees Tablosundan; FirstName alanına göre, isimleri Asc olarak sıraladıktan sonra, sonuç kümesinin ilk beş kaydını ülkelerine göre gruplayın
SELECT Country, COUNT(*) AS Adet
FROM(SELECT TOP 5 * FROM Employees ORDER BY FirstName) AS Personeller
GROUP BY Country

-- Ürün bedeli 35$'dan az olan ürünlerin kategorilerine göre gruplanması
SELECT CategoryID, COUNT(*) AS Adet
FROM Products
WHERE UnitPrice<=35
GROUP BY CategoryID
ORDER BY 2

-- Baş harfi A-K aralığında olan ve stok miktarı 5 ile 50 arasında olan ürünleri kategorilerine göre gruplayınız.
SELECT CategoryID, COUNT(*) AS Adet
FROM Products
WHERE ProductName LIKE '[A-K]%' AND UnitsInStock BETWEEN 5 AND 50
GROUP BY CategoryID

-- Her bir siparişteki toplam ürün sayısını bulunuz. 
SELECT OrderID, SUM(Quantity) AS [Toplam Ürün Sayısı]
FROM [Order Details]
GROUP BY OrderID
ORDER BY 2

-- Her bir siparişin tutarına göre listelenmesi
SELECT OrderID, CAST(SUM((Quantity * UnitPrice)*(1-Discount)) AS decimal(12, 2)) AS DecimalX, SUM((Quantity * UnitPrice)*(1-Discount)) AS Summary, CONCAT(CAST(SUM((Quantity * UnitPrice)*(1-Discount)) AS NVARCHAR(100)), ' AZN') AS Tutar
FROM [Order Details]
GROUP BY OrderID
ORDER BY 2


SELECT CONCAT(CAST(SUM(Summary) AS NVARCHAR(100)), ' $') AS [Nusret'ten Yemek Yersen, Gelecek olan fatura]
FROM(SELECT OrderID, CAST(SUM((Quantity * UnitPrice)*(1-Discount)) AS DECIMAL(12, 2)) AS DecimalX, SUM((Quantity * UnitPrice)*(1-Discount)) AS Summary, CONCAT(CAST(SUM((Quantity * UnitPrice)*(1-Discount)) AS NVARCHAR(100)), ' AZN') AS Tutar
     FROM [Order Details]
     GROUP BY OrderID) AS Deneme


SELECT OrderID, SUM((Quantity * UnitPrice)*(1-Discount)) AS Tutar
FROM [Order Details]
GROUP BY OrderID
ORDER BY 2
-- Toplam tutari 2500 ile 3500 arasinda olan siparişlerin gruplanması

SELECT OrderID, SUM((Quantity * UnitPrice)*(1-Discount)) AS Tutar
FROM [Order Details]
GROUP BY OrderID
HAVING SUM((Quantity * UnitPrice)*(1-Discount)) between 2500 and 3500
ORDER BY 2


-- Her bir siparişteki toplam ürün sayisi 200'den az olanlar

SELECT OrderID, SUM(Quantity)  [Toplam Ürün Sayısı] FROM [Order Details]
GROUP BY OrderID
HAVING SUM(Quantity) < 200
ORDER BY 2



/*
	1) Inner Join
	2) Left Outer Join
	3) Right Outer Join
	4) Full Join
	5) Cross Join
	6) Self Join
	7) Where Join
	8) Union
	9) Union All 
*/

-- JOIN IŞLEMLERI
-- 1) Inner Join: Bir tablodaki her bir kaydın diğer tabloda bir karşılığı olan kayıtlar listelenir. Inner Join ifadesini yazarken Inner cümlesini yazmazsak da (sadece Join yazarsak) bu yine Inner Join olarak işleme alınır.




insert into Categories (CategoryName) values
('Fashion'),
('Technology'),
('Health and Fitness'),
('Food and Cooking'),
('Travel and Adventure'),
('Sports and Recreation'),
('Home and Decor'),
('Beauty and Skincare'),
('Art and Design'),
('Music and Entertainment'),
('Books and Literature'),
('Education and Learning'),
('Automotive'),
('Finance and Investment'),
('Business and Entrepreneurship'),
('Photography'),
('Gaming'),
('Outdoor and Nature'),
('Parenting and Family'),
('Science and Technology'),
('Wellness and Self-care'),
('DIY and Crafts'),
('Pets and Animals'),
('Movies and TV Shows'),
('Gardening and Landscaping'),
('Mental Health and Wellbeing'),
('Social Media and Influencers'),
('Fitness and Exercise'),
('Fashion Accessories'),
('Home Improvement'),
('Cooking Recipes'),
('Health and Nutrition'),
('Adventure Travel'),
('Water Sports'),
('Sustainable Living'),
('Makeup and Cosmetics'),
('Fine Art'),
('Classical Music'),
('Fiction Books'),
('Language Learning'),
('Luxury Cars'),
('Personal Finance'),
('Small Business Tips'),
('Portrait Photography'),
('Console Gaming'),
('Hiking and Trekking'),
('Pregnancy and Childbirth'),
('Space and Astronomy'),
('Meditation and Mindfulness'),
('Handmade Crafts'),
('Dog Care and Training'),
('Film Reviews'),
('Organic Gardening'),
('Yoga and Pilates'),
('Fashion Trends'),
('Smart Home Technology'),
('Healthy Recipes'),
('Adventure Sports'),
('Green Living'),
('Skincare Products'),
('Contemporary Art'),
('Pop Music'),
('Non-fiction Books'),
('Online Learning Platforms'),
('Electric Cars'),
('Stock Market Analysis'),
('Startup Advice'),
('Landscape Photography'),
('PC Gaming'),
('Camping and Survival Skills'),
('Parenting Advice'),
('Psychology and Behavior'),
('Influencer Marketing'),
('Bodybuilding and Weightlifting'),
('Sustainable Fashion'),
('Interior Design Inspiration'),
('Culinary Arts'),
('Holistic Health'),
('Wildlife Photography'),
('Cat Care and Training'),
('Movie Recommendations'),
('Home Gardening'),
('Dance and Choreography'),
('Personal Development'),
('Eco-friendly Living'),
('Fashion Styling'),
('Virtual Reality Technology'),
('Healthy Dessert Recipes'),
('Extreme Sports'),
('Green Energy Solutions'),
('Anti-aging Skincare'),
('Street Art'),
('Jazz Music'),
('Travel Guides'),
('Sustainable Architecture'),
('Meditation Retreats'),
('Vintage Fashion'),
('Smart Gadgets'),
('Art History'),
('Historical Fiction Books')



INSERT INTO Products (ProductName, UnitPrice, UnitsInStock) VALUES ('Product 1', 10.99, 50);
INSERT INTO Products (ProductName, UnitPrice, UnitsInStock) VALUES ('Product 2', 19.99, 100);
INSERT INTO Products (ProductName, UnitPrice, UnitsInStock) VALUES ('Product 3', 5.99, 75);
INSERT INTO Products (ProductName, UnitPrice, UnitsInStock) VALUES ('Product 4', 8.49, 30);
INSERT INTO Products (ProductName, UnitPrice, UnitsInStock) VALUES ('Product 5', 14.99, 20);
INSERT INTO Products (ProductName, UnitPrice, UnitsInStock) VALUES ('Product 6', 12.99, 90);
INSERT INTO Products (ProductName, UnitPrice, UnitsInStock) VALUES ('Product 7', 7.99, 60);
INSERT INTO Products (ProductName, UnitPrice, UnitsInStock) VALUES ('Product 8', 9.99, 10);
INSERT INTO Products (ProductName, UnitPrice, UnitsInStock) VALUES ('Product 9', 6.99, 25);
INSERT INTO Products (ProductName, UnitPrice, UnitsInStock) VALUES ('Product 10', 17.99, 15);
INSERT INTO Products (ProductName, UnitPrice, UnitsInStock) VALUES ('Product 11', 11.99, 80);
INSERT INTO Products (ProductName, UnitPrice, UnitsInStock) VALUES ('Product 12', 13.49, 40);
INSERT INTO Products (ProductName, UnitPrice, UnitsInStock) VALUES ('Product 13', 9.99, 70);
INSERT INTO Products (ProductName, UnitPrice, UnitsInStock) VALUES ('Product 14', 8.99, 55);
INSERT INTO Products (ProductName, UnitPrice, UnitsInStock) VALUES ('Product 15', 6.49, 95);
INSERT INTO Products (ProductName, UnitPrice, UnitsInStock) VALUES ('Product 16', 14.99, 85);
INSERT INTO Products (ProductName, UnitPrice, UnitsInStock) VALUES ('Product 17', 5.99, 120);
INSERT INTO Products (ProductName, UnitPrice, UnitsInStock) VALUES ('Product 18', 10.49, 25);
INSERT INTO Products (ProductName, UnitPrice, UnitsInStock) VALUES ('Product 19', 7.99, 35);
INSERT INTO Products (ProductName, UnitPrice, UnitsInStock) VALUES ('Product 20', 16.99, 65);
INSERT INTO Products (ProductName, UnitPrice, UnitsInStock) VALUES ('Product 21', 11.99, 75);
INSERT INTO Products (ProductName, UnitPrice, UnitsInStock) VALUES ('Product 22', 9.49, 50);
INSERT INTO Products (ProductName, UnitPrice, UnitsInStock) VALUES ('Product 23', 7.99, 30);
INSERT INTO Products (ProductName, UnitPrice, UnitsInStock) VALUES ('Product 24', 14.99, 80);
INSERT INTO Products (ProductName, UnitPrice, UnitsInStock) VALUES ('Product 25', 8.99, 100); 
INSERT INTO Products (ProductName, UnitPrice, UnitsInStock) VALUES ('Product 26', 12.49, 60);
INSERT INTO Products (ProductName, UnitPrice, UnitsInStock) VALUES ('Product 27', 6.99, 45);
INSERT INTO Products (ProductName, UnitPrice, UnitsInStock) VALUES ('Product 28', 9.99, 20);
INSERT INTO Products (ProductName, UnitPrice, UnitsInStock) VALUES ('Product 29', 11.99, 90);
INSERT INTO Products (ProductName, UnitPrice, UnitsInStock) VALUES ('Product 30', 13.49, 70);
INSERT INTO Products (ProductName, UnitPrice, UnitsInStock) VALUES ('Product 31', 7.99, 30);
INSERT INTO Products (ProductName, UnitPrice, UnitsInStock) VALUES ('Product 32', 15.99, 50);
INSERT INTO Products (ProductName, UnitPrice, UnitsInStock) VALUES ('Product 33', 9.99, 40);
INSERT INTO Products (ProductName, UnitPrice, UnitsInStock) VALUES ('Product 34', 6.49, 80);
INSERT INTO Products (ProductName, UnitPrice, UnitsInStock) VALUES ('Product 35', 11.99, 60);
INSERT INTO Products (ProductName, UnitPrice, UnitsInStock) VALUES ('Product 36', 8.49, 35);
INSERT INTO Products (ProductName, UnitPrice, UnitsInStock) VALUES ('Product 37', 13.99, 25);
INSERT INTO Products (ProductName, UnitPrice, UnitsInStock) VALUES ('Product 38', 6.99, 15);
INSERT INTO Products (ProductName, UnitPrice, UnitsInStock) VALUES ('Product 39', 12.99, 55);
INSERT INTO Products (ProductName, UnitPrice, UnitsInStock) VALUES ('Product 40', 9.99, 95);
INSERT INTO Products (ProductName, UnitPrice, UnitsInStock) VALUES ('Product 41', 5.99, 50);
INSERT INTO Products (ProductName, UnitPrice, UnitsInStock) VALUES ('Product 42', 10.49, 70);
INSERT INTO Products (ProductName, UnitPrice, UnitsInStock) VALUES ('Product 43', 8.99, 40);
INSERT INTO Products (ProductName, UnitPrice, UnitsInStock) VALUES ('Product 44', 6.99, 80);
INSERT INTO Products (ProductName, UnitPrice, UnitsInStock) VALUES ('Product 45', 14.99, 60);
INSERT INTO Products (ProductName, UnitPrice, UnitsInStock) VALUES ('Product 46', 11.49, 30);
INSERT INTO Products (ProductName, UnitPrice, UnitsInStock) VALUES ('Product 47', 7.99, 100);
INSERT INTO Products (ProductName, UnitPrice, UnitsInStock) VALUES ('Product 48', 13.99, 50);
INSERT INTO Products (ProductName, UnitPrice, UnitsInStock) VALUES ('Product 49', 9.99, 75);
INSERT INTO Products (ProductName, UnitPrice, UnitsInStock) VALUES ('Product 50', 12.99, 25);
INSERT INTO Products (ProductName, UnitPrice, UnitsInStock) VALUES ('Product 51', 5.99, 45);



select Count(*) from Categories  -- 108
select Count(*) from Products    -- 128


SELECT CategoryID, COUNT(CategoryID) AS Adet
FROM Products
WHERE CategoryID IS NOT NULL
GROUP BY CategoryID


SELECT * FROM Products INNER JOIN Categories 
ON Categories.CategoryID = Products.CategoryID


-- Products tablosundan ProductID, ProductName, CategoryID
-- Categories tablosundan CategoryName, Description

SELECT ProductID, ProductName, Products.CategoryID,CategoryName, [Description] FROM Products INNER JOIN Categories 
ON Categories.CategoryID = Products.CategoryID

-- NOT: Eğer seçtiğimiz sütunlar her iki tabloda da bulunuyorsa, o sütunu hangi tablodan seçtiğimizi açıkça belirtmemiz gerekir. (Products.CategoryID gibi)

-- Hangi sipariş, hangi çalışan tarafından, hangi müşteriye yapılmış
-- Employees
-- Orders
-- Customers

SELECT E.TitleOfCourtesy, FirstName, E.LastName, C.CompanyName, C.ContactTitle, C.ContactName, O.OrderID AS [Sipariş No], O.OrderDate AS [Sipariş Tarihi]
FROM Employees E
     INNER JOIN Orders O ON E.EmployeeID=O.EmployeeID
     INNER JOIN Customers C ON C.CustomerID=O.CustomerID

-- Sorguyu kısaltmak amacıyla tablo isimlerine de takma isim verilebilir, ancak dikkat edilmesi gereken nokta bir tabloya takma isim verildikten sonra artık her yerde o ismin kullanılması gerektiğidir.




-- Suppliers tablosundan CompanyName, ContactName
-- Products tablosundan ProductName, UnitPrice
-- Categories tablosundan CategoryName
-- CompanyName sütununa göre artan sırada sıralayınız.


-- Tüm bilgilerini ekleyin, ünvan adı soyadı 
-- Her bir çalışan toplam ne kadarlık (PUL) :) satış yapmıştır.