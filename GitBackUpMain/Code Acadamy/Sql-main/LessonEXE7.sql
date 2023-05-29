


SELECT FirstName,dbo.YasHesabla(BirthDate) AS [Employee Age] FROM Employees



CREATE FUNCTION YasHesabla (@birthDate DATE)
RETURNS INT
BEGIN
RETURN YEAR(GETDATE()) - YEAR(@birthDate)

END



CREATE FUNCTION Dizi (@char nvarchar)
RETURNS TABLE
RETURN SELECT FirstName,LastName FROM Employees WHERE LEFT(FirstName , 1) = @char


SELECT * FROM Dizi('A')


CREATE PROCEDURE sp_TumKateqoriler
AS
BEGIN
SELECT Categories.CategoryName,ProductName FROM Categories JOIN Products ON Categories.CategoryID = Products.CategoryID
END

EXECUTE sp_TumKateqoriler


CREATE PROCEDURE sp_Listele
@CateId INT
AS
BEGIN
SELECT Categories.CategoryName,ProductName FROM Categories JOIN Products ON Categories.CategoryID = Products.CategoryID WHERE Categories.CategoryID = @CateId
END

EXECUTE sp_Listele 1

SELECT * FROM Employees

CREATE PROCEDURE sp_PersonelListe
@AD NVARCHAR(100),
@SOYAD NVARCHAR(100)
AS
BEGIN
SELECT * FROM Employees WHERE FirstName = @AD AND LastName = @SOYAD
END 

EXECUTE sp_PersonelListe 'Nancy','Davolio'



ALTER PROCEDURE sp_Guncelle
@CategoryName NVARCHAR(100) = NULL,
@Description NVARCHAR(100)
AS
BEGIN

	IF EXISTS( Select * FROM Categories WHERE @CategoryName = CategoryName )
	BEGIN
		UPDATE Categories SET [Description] = @Description WHERE CategoryName = @CategoryName 
		
	END

	ELSE
	BEGIN
		INSERT INTO Categories(CategoryName,[Description]) VALUES(@CategoryName,@Description)
	END
END 

SELECT * FROM Categories
EXECUTE sp_Guncelle 'Beverages2','icki'


SElECT * FROM Categories JOIN Products ON Categories.CategoryID = Products.CategoryID





CREATE PROCEDURE sp_CategoryUpdate
@CategoryName NVARCHAR(100),
@ProductName NVARCHAR(100),
@UnitsInStock MONEY,
@UnitPrice SMALLINT
AS
BEGIN
	DECLARE @cID INT
	IF EXISTS( Select * FROM Categories WHERE @CategoryName = CategoryName )
	BEGIN
		 SELECT @cID = CategoryID	FROM Categories	WHERE @CategoryName = CategoryName
	END
	ELSE
	BEGIN
		INSERT INTO Categories(CategoryName) VALUES(@CategoryName)
		SET @cID = SCOPE_IDENTITY()
	END
		 INSERT INTO Products(ProductName,UnitPrice,UnitsInStock,CategoryID) VALUES (@ProductName,@UnitPrice,@UnitsInStock,@cID)
END 

SELECT * FROM Categories
EXECUTE sp_CategoryUpdate 'KOLA 1' , 'Beverages' , 10 , 20

SELECT * FROM Products