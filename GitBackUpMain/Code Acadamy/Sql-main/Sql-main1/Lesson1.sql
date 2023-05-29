-- NOT: Sorgularımızı yazarken küçük-büyük harfe dikkat etmemize gerek yok. (Eğer başlangıçta Server kurulurken bu ayar seçilmiş ise)

-- DML -> Data Manipulation Language

use Northwind
-- Northwind veritabanı üzerinde sorgulamalar yapacağımız için ya bu şekilde ya da sol üst köşedeki ComboBox'ı kullanarak veritabanımızı seçeriz.

-- TABLOLARI SORGULAMAK

-- Select <sütun_adları> From <tablo_adı> -- (sütun adları arasında virgül var)
-- Employees tablosundaki tüm kayıtları listeleyelim
SELECT * FROM Employees

-- Employees tablosundan, çalışanlara ait ad, soyad, görev ve doğum tarihi bilgilerini listeleyelim
SELECT FirstName, LastName, Title, BirthDate FROM Employees
-- Seçmek istediğimiz sütunları aralarına virgül koyarak belirtiyoruz. 

-- Sütun isimlerinin Intellisense menüsü ile gelmesi için Select ifadesinden sonra From <tablo_adı> yazıp, daha sonra Select ile From arasına sütun isimlerini yazarsak, sütun isimleri bize listelenir.

-- Employees tablosunun sütunlarını sürükle bırak yardımı ile de ekleyebiliriz.
SELECT [EmployeeID], [LastName], [FirstName], [Title], [TitleOfCourtesy], [BirthDate], [HireDate], [Address], [City], [Region], [PostalCode], [Country], [HomePhone], [Extension], [Photo], [Notes]
FROM Employees
SELECT [FirstName], [LastName], [HireDate], [HomePhone], [Title]
FROM Employees

-- Employees tablosunun altındaki Columns klasörünü sürükleyip bırakırsak bütün sütunlar listelenir.

-- SÜTUNLARIN ISIMLENDIRILMESI

-- 1. Yol 
SELECT TitleOfCourtesy AS Unvan, FirstName AS Adi, LastName AS Soyadi, Title AS Gorev
FROM Employees

-- 2. Yol 
SELECT TitleOfCourtesy Unvan, FirstName Adi, LastName Soyadi, Title Gorev, BirthDate 'Dogum Tarihi'
FROM Employees

-- 3. Yol
SELECT Unvan=TitleOfCourtesy, Adi=FirstName, Soyadi=LastName, Gorev=Title, 'Doğum Tarihi'=BirthDate, [İşe Giriş Tarihi]=HireDate
FROM Employees

-- TEKIL KAYITLARI LISTELEMEK

SELECT City
FROM Employees; -- Aynı şehirler listelenir.


SELECT DISTINCT
       City
FROM Employees; -- Farklı olan şehirlerin (tekil değerler) listelenmesini sağlar.


SELECT  DISTINCT  City , FirstName FROM Employees
 -- Üstteki ile aynı sonucu getirir, sebebi ise aynı ad ve şehir değerine sahip kayıtların olmamasıdır.Eğer FirstName = Steven, City = London olan başka bir kayıt daha girilirse tabloya, bu kayıtlardan sadece biri listelenecektir.


-- METİNLERİ BİRLEŞTİRMEK
 
SELECT CAST(EmployeeID AS nvarchar(50))+' '+TitleOfCourtesy+' '+FirstName+' '+LastName AS Personel
FROM Employees

SELECT CONCAT(EmployeeID, ' ', TitleOfCourtesy, ' ', FirstName, ' ', LastName) AS Personel
FROM Employees