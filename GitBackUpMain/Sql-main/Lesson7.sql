-- Kullanıcı Tanımlı Fonksiyonlar (User Defined Function - UDF)
-- Fonksiyonlar değer döndüren yapısal birimlerdir. Parametre alabilirler. Aynı SP'ler gibi önceden derlenmiþlerdir ve bu nedenle daha hızlı çalıþan yapılardır.
-- Fonksiyonlar geriye tek bir değer veya bir tablo döndürebilirler.
-- SP'lerden en büyük farkları sorgu içerisinde kullanılabilmeleridir.
-- View'lerden en büyük farkı parametre alan yapıları sağlayabilmeleridir.
-- Değer döndüren fonksiyonlara Scalar Function, Tablo döndüren fonksiyonlara da Table Value Function denir.

/*
	SKALER Fonksiyonlar
	* Geriye tek bir değer döndürürler. Genellikle matematiksel işlemlerde kullanılırlar.
	* RETURNS <tip> ile geriye hangi tipte değer döndürüleceği bildirilmelidir.
	* RETURN ifadesi ile geriye fonksiyonun döndüreceği değer belirtilir.
	* Fonksiyonu oluşturan kod bloğu BEGIN - END arasında yazılır ve kullanılırken tablonun şeması da belirtilir.
	
*/



SELECT 
CategoryName, 
ProductName,
UnitPrice AS [Birim Fiyat], 
UnitPrice *  1.18 AS [Kdv Dahil] 
FROM .Products P JOIN Categories C 
ON P.CategoryID = C.CategoryID

-- KDV Oranını hesaplayan Function

CREATE FUNCTION code.KdvHesapla(@price MONEY)  --dbo
RETURNS MONEY  -- function'ın geriye dönüş tipi
BEGIN  -- {
	-- bu alan içerisinde kodlamanızı yapabilirsiniz

	DECLARE @result MONEY = @price * 1.18
	-- RETURN @price * 1.18 -- function sonrası geriye değer dönme işlemi
	RETURN  @result 
END    -- }
   
SELECT 
CategoryName, 
ProductName,
UnitPrice AS [Birim Fiyat], 
dbo.KdvHesapla(UnitPrice) AS [Kdv Dahil] 
FROM .Products P JOIN Categories C 
ON P.CategoryID = C.CategoryID

SELECT * FROM code.Employees E join dbo.Orders O on E.EmployeeID = O.EmployeeID

-- Kişilerin yaşlarını hesaplayacak bir UDF yazınız.

CREATE FUNCTION DBO.YASHESAPLA(@date DATETIME)
RETURNS INT
BEGIN
	RETURN DATEDIFF(YEAR,@date, GETDATE())
END


SELECT FirstName, LastName, dbo.YasHesapla(BirthDate) AS Age FROM Employees


/*
    Tablo Döndüren Fonksiyonlar
    * Skaler fonksiyonkar gibi dışarıdan parametre alabilirler.
    * Begin - End kullanılmaz
    * Fonksiyon kullanımında şema ismi kullanmaya gerek yok 
*/

CREATE FUNCTION PersonelBilgisi()
RETURNS TABLE
RETURN SELECT * FROM dbo.Employees


SELECT * FROM PersonelBilgisi()

-- Çalışanları adının baş harfine göre listeleyen fonksiyonu yazınız.


CREATE FUNCTION PersonelGetir(@letter NVARCHAR)
RETURNS TABLE 
RETURN SELECT FirstName, LastName FROM Employees WHERE LEFT(FirstName, 1) = @letter
 
CREATE FUNCTION PersonelGetirByLike(@letter NVARCHAR)
RETURNS TABLE 
RETURN SELECT FirstName, LastName FROM Employees WHERE FirstName like @letter+'%'


SELECT * FROM PersonelGetirByLike('N')


-- STORED PROCEDURE (Saklı Yordamlar)
-- TSQL komutları ile hazırladığımız işlemler bütününün çalıştırılma anında derlenmesi ile size bir sonuç üreten sql server  bileşenidir.
-- Çalışma anı planlama sağlar ve tekrar tekrar kullanılabilir
-- Querylerinize otomatik parametrelendirme getirir
-- Uygulamalar arasında ortak kullanılabilir yapıdadır
-- Güvenli data modifikasyonu sağlar
-- Network bandwidth inden tasarruf sağlar(daha az network bandwith kaynak kullanımı)
-- Job olarak tanımlanabilir ve schedule edilebilir
-- Database objelerine güvenli erişim sağlar.

CREATE PROCEDURE sp_PersonelListesi
AS
BEGIN
	SELECT TitleOfCourtesy, FirstName, LastName, City FROM dbo.Employees
	wHERE City IS NOT NULL
END
 
execute sp_PersonelListesi

-- Tüm kategorilerle bu kategorilere ait ürünleri getiren Stored Procedure

create procedure sp_UrunAndCategories As
select C.CategoryID, C.CategoryName,C.Description, P.ProductID, P.ProductName, P.UnitPrice,P.UnitsInStock from Categories C join Products P on C.CategoryID= P.CategoryID


execute sp_UrunAndCategories

-- Kategorisine göre ürünleri getiren Stored Procedure

alter proc sp_ProductsByCategory
@categoryId int
as

select CategoryID, ProductID, ProductName, UnitPrice, UnitsInStock from Products where CategoryID = @categoryId


exec sp_ProductsByCategory 2


-- Adına ve soyadına göre çalışanları listeleyen SP


/*

alter proc sp_get_employees
 @text nvarchar(100) 
 as
select * from Employees where FirstName like  '%'+@text+'%' or '%'+LastName = @text+'%'

select * from Employees where FirstName = @firstName and LastName = @lastName

sp_get_employees 'Nancy', 'Davolio'
sp_get_employees @lastName = 'Davolio', @firstName = 'Nancy'

execute sp_get_employees 'an'







*/


create proc sp_get_employees
 @firstName nvarchar(100),
 @lastName nvarchar(100)
 as

select * from Employees where FirstName like @firstName and LastName like @lastName

sp_get_employees 'Nancy', 'Davolio'
sp_get_employees @lastName = 'Davolio', @firstName = 'Nancy'


-- Customers Tablosunun tamamına ekleme yapan sp yazmanız.

SELECT 
    CONCAT( c.name  ,',' ),
    CONCAT('@', c.name , ' ', t.Name,'(', c.max_length,'),' ),
    CONCAT('@', c.name  ,',' ),
    c.name 'Column Name',
    t.Name 'Data type',
    c.max_length 'Max Length' 
FROM    
    sys.columns c
INNER JOIN 
    sys.types t ON c.user_type_id = t.user_type_id
LEFT OUTER JOIN 
    sys.index_columns ic ON ic.object_id = c.object_id AND ic.column_id = c.column_id
LEFT OUTER JOIN 
    sys.indexes i ON ic.object_id = i.object_id AND ic.index_id = i.index_id
WHERE
    c.object_id = OBJECT_ID('Products')


ALTER PROC MusteriEkle
    @CustomerID nchar(10)     ,
    @CompanyName nvarchar(80) ,
    @ContactName nvarchar(60) = Null,
    @ContactTitle nvarchar(60)= Null,
    @Address nvarchar(120)    = Null,
    @City nvarchar(30)        = Null,
    @Region nvarchar(30)      = Null,
    @PostalCode nvarchar(20)  = Null,
    @Country nvarchar(30)     = Null,
    @Phone nvarchar(48)       = Null,
    @Fax nvarchar(48)		  = Null
AS
INSERT INTO Customers
(
    CustomerID,
    CompanyName,
    ContactName,
    ContactTitle,
    Address,
    City,
    Region,
    PostalCode,
    Country,
    Phone,
    Fax
)
VALUES
(@CustomerID, @CompanyName, @ContactName, @ContactTitle, @Address, @City, @Region, @PostalCode, @Country, @Phone, @Fax)



exec MusteriEkle @CustomerID = 'CODMY' , @CompanyName = 'Code Academy'

select * from Customers where CustomerID = 'CODMY'


-- Kullanıcının belirttiği kategoriyi eğer kategoriler tablosında yok ise eklesin var ise, o kategorinin açıklamasını güncellesib :) SP yazınız.



CREATE PROC AddCategory @categoryName NVARCHAR(15), @description NVARCHAR(MAX)
AS 
BEGIN
    IF EXISTS (SELECT * FROM Categories WHERE CategoryName=@categoryName)
		BEGIN
			UPDATE Categories
			SET [Description]=@description
			WHERE CategoryName=@categoryName
		END
    ELSE 
		BEGIN
			INSERT INTO Categories(CategoryName, [Description])
			VALUES(@categoryName, @description)
		END
END



EXEC AddCategory @categoryName = 'Beverages1', @description = 'Eski Açıklama'


--Stored Procedure kullanarak Ürün ve Kategori Eklemek (eğer kategori daha önceden eklenmişse yeniden eklemek yerine o kategorinin ID bilgisini kullanalım)

-- prodAdi  @urunAdi = 'Kola', @stokAdet=  10, @fiyat = 20, @kategoriI d = 'Beverages'

-- en son yapılan insert işleminin pk değerini teslim eder.

-- SCOPE_IDENTITY -> var olan (bulunduğunuz) scope (alan ) içerisindeki en son değeri teslim eder
-- @@IDENTITY     -> limitsiz, server'da eklenmiş son değeri teslim eder

alter procedure InsertProductByCategory
    @ProductName nvarchar(80)
  , @CategoryName nvarchar(15)
  , @UnitPrice money
  , @UnitsInStock smallint
as
begin
    Declare @cId int
    if exists (select * from Categories where CategoryName = @CategoryName)
    begin
        print ('Kategori Mevcut')
        select @cId = CategoryId
        from Categories
        where CategoryName = @CategoryName
    --insert into Products(ProductName, UnitPrice, UnitsInStock, CategoryID)
    --values (@ProductName,@UnitPrice,@UnitsInStock, @cId)
    --insert into Products(ProductName, UnitPrice, UnitsInStock, CategoryID)
    --values(@ProductName, @UnitPrice, @UnitsInStock, (select CategoryId from Categories where CategoryName=@CategoryName))
    end
    else
    begin
        print 'Kategori Yok'

        insert into Categories
        (
            CategoryName
        )
        values (@CategoryName)
        set @cId = SCOPE_IDENTITY()
    end

    --insert into Products(ProductName, UnitPrice, UnitsInStock, CategoryID)
    --       values(@ProductName, @UnitPrice, @UnitsInStock, (select CategoryId from Categories where CategoryName=@CategoryName))
    insert into Products
    (
        ProductName
      , UnitPrice
      , UnitsInStock
      , CategoryID
    )
    values
    (@ProductName, @UnitPrice, @UnitsInStock, @cId)
end



exec InsertProductByCategory 'Kola 1','Beveragesxs',10,20
delete from Categories where CategoryID not in (select CategoryID from Products where CategoryID is not null)
select * from Categories
select * from Products where  CategoryID = 111