-- TARiH FONKSiYONLARI
-- DATEPART() Kullanımı: Bir tarih bilgisinden istediğimiz kısmı elde etmemizi sağlar.

SELECT FirstName, LastName, DATEPART(YYYY,BirthDate) AS [Year] FROM Employees
SELECT FirstName, LastName, DATEPART(ww,BirthDate) AS [Week] FROM Employees
SELECT FirstName, LastName, DATEPART(dw,BirthDate) AS [Day of Week] FROM Employees
SELECT FirstName, LastName, DATEPART(isowk,BirthDate) AS [Day of Week] FROM Employees
/*

year,        yyyy,    yy     = Year
quarter,     qq,      q      = Quarter
month,       mm,      m      = month
dayofyear,   dy,      y      = Day of the year
day,         dd,      d      = Day of the month
week,        ww,      wk     = Week
weekday,     dw,      w      = Weekday
hour,        hh              = hour
minute,      mi,      n      = Minute
second,      ss,      s      = Second
millisecond, ms              = Millisecond
microsecond, mcs             = Microsecond
nanosecond,  ns              = Nanosecond
tzoffset,    tz              = Timezone offset
iso_week,    isowk,   isoww  = ISO week

*/


-- C# iki tarih arasındaki farkı veren metot hansı -> TimeSpan
-- Sql                                             -> DateIff


SELECT 
	FirstName + ' '+ LastName AS Personel,
	DATEDIFF(YEAR, BirthDate, GETDATE()) AS [Yaş],
	DATEDIFF(DAY, HireDate, GETDATE()) AS [Ödenen Pirim Sayısı] 
FROM Employees


-- Kaç yıl, ay, gün, saat, dakika  yaşıyorsunuz bulun :)


DECLARE @MyBirthDate nvarchar(100) = '1982-09-25 00:00:00.000'

SELECT DATEDIFF(YY, @MyBirthDate,  GETDATE()) AS [Yıl],
       DATEDIFF(MM, @MyBirthDate,  GETDATE()) AS [Ay],
       DATEDIFF(D,  @MyBirthDate , GETDATE()) AS [Gün],
       DATEDIFF(HH, @MyBirthDate , GETDATE()) AS [Saat],
       DATEDIFF(MI, @MyBirthDate,  GETDATE()) AS [Dakika]



SELECT 10 + 90 + 50 + 500 + 5000

SELECT 'Bu alan içerisinde mesaj görünecek'
PRINT('Console.WriteLine niyetine PRINT metodunu kullanınız :) ')

-- STRING Fonksiyonlar
SELECT ASCII ('A') AS [ASCII Kodu]
SELECT CHAR(65) AS [Karakter]

SELECT CHARINDEX('@', 'murat.vuranok@hotmail.com') AS [Index No]


SELECT LEFT('murat',1) AS [Soldan, sağa 1 karakter]
SELECT RIGHT('murat', 1)  [Sağdan, sola 1 karakter]


SELECT LEN('                    code academy                    ') AS [Toplam Karakter Sayısı] -- 32 -- NOT: Len sağdaki boşluk değerini sorguya dahil etmiyor (bil'e mail at)

SELECT LTRIM('                    code academy                    ') AS[Soldaki Boşlukları Siler]
SELECT RTRIM('                    code academy                    ') AS[Sağdaki Boşlukları Siler]

SELECT RTRIM(LTRIM('                    code academy                    ')) AS[Sağdaki ve Soldaki Boşlukları Siler]
SELECT TRIM('                    code academy                    ')         AS[Sağdaki ve Soldaki Boşlukları Siler]


SELECT REPLACE('murat.vuranok@code.edu.az','az','com')       AS [Metinsel Değişiklik]
SELECT SUBSTRING('Code Academy Baku Yazılım Dersleri', 6, 7) AS [Alt Metinler Oluşturur]  -- -> Academy

SELECT REVERSE('murat') AS [Tersine Çevir]
SELECT 'Murat'+SPACE(50)+'Vuranok' AS[Boşluk Ekle]
SELECT REPLICATE('Seni Çok Seviyorum' , 1000) AS [Seni 2. Parametrede Gönderdiğim Kadar Seviyorum]

SELECT UPPER('murat') AS [Büyük Harf]
SELECT LOWER('murat') AS [Küçük Harf]

DECLARE 
@data      NVARCHAR(100) = 'ali.vuranok@code.edu.az',
@mail      NVARCHAR(100),
@firstName NVARCHAR(100),
@lastName  NVARCHAR(100),
@company   NVARCHAR(100),
@extention NVARCHAR(100)

SELECT @mail = @data,
@firstName   = LEFT(@data, CHARINDEX('.', @data) -1),
@data        = SUBSTRING(@data, CHARINDEX('.', @data)  + 1, LEN(@data)),
@lastName    = LEFT(@data ,CHARINDEX('@', @data) -1),
@data        = SUBSTRING(@data, CHARINDEX('@', @data)  + 1, LEN(@data)),
@company     = LEFT(@data, CHARINDEX('.', @data)),
@data        = SUBSTRING(@data, CHARINDEX('.', @data)  + 1, LEN(@data)),
@company     += LEFT(@data, CHARINDEX('.', @data) -1) ,
@extention   = SUBSTRING(@data , CHARINDEX('.', @data), LEN(@data))
 

PRINT('
	Adı       : '+ UPPER(LEFT(@firstName,1)) + LOWER(SUBSTRING(@firstName, 2, LEN(@firstName))) +'
	Soyadı    : '+ UPPER(LEFT(@lastName,1)) + LOWER(SUBSTRING(@lastName, 2, LEN(@lastName))) +'
	Şirket    : '+ @company +'
    Mail      : '+ @mail +'
    Extention : '+ TRIM('.' FROM @extention))


/*

	Adı       : Murat
	Soyadı    : Vuranok
	Mail      : murat.vuranok@code.edu.az
	Company   : code.edu
	Extention : az

*/


-- split function
SELECT VALUE AS ResultSonucu FROM STRING_SPLIT('ali.vuranok@code.edu.az','.')
 


-- Aggregate Fonksiyonlar (Toplam Fonksiyonlari, Gruplamali Fonksiyonlar)
-- COUNT(Sütun adi | *): Bir tablodaki kayit sayisini öğrenmek için kullanilir.

-- NOT : NULL alanlar, sorguya dahil edilmez!!!!!

SELECT COUNT(EmployeeID) AS [Toplam Personel Sayısı] FROM Employees  -- 9
SELECT COUNT(Region) AS [Bölgesi Belirtilen Toplam Personel Sayısı] FROM Employees  -- 5
-- Region sütunundaki kayit sayisi (Region sütunu null geçilebileceği için bir tablodaki kayit sayisini bu sütundan yola çikarak öğrenmek yanliş sonuçlar oluşturabilir. Çünkü aggregate fonksiyonlari NULL değer içeren kayitlari dikkate almaz. Bu nedenle kayit sayisini öğrenebilmek için ya * karakterini ya da NULL değer geçilemeyen sütunlardan birinin adini kullanmamiz gerekir.



-- SUM(Sütun adi): Bir sütundaki değerlerin toplamini verir.

SELECT SUM(EmployeeID) FROM Employees

-- Çalişanlarin yaşlarinin toplamini bulunuz.
SELECT SUM(YEAR(GETDATE())- YEAR(BirthDate)) Toplam from Employees
SELECT SUM(DATEDIFF(YY, BirthDate, GETDATE())) Toplam from Employees
SELECT SUM(FirstName) FROM Employees  -- Sadece sayısal değerler :)

-- AVG(Sütun adi): Bir sütundaki değerlerin ortalamasini verir.
SELECT AVG(EmployeeID) FROM Employees

-- Çalişanlarin yaşlarinin ortalamasi

SELECT AVG(YEAR(GETDATE())- YEAR(BirthDate)) Toplam from Employees
SELECT AVG(DATEDIFF(YY, BirthDate, GETDATE())) Toplam from Employees
SELECT AVG(FirstName) FROM Employees -- Sadece sayısal değerler :)



-- MAX(Sütun adi): Bir sütundaki en büyük değeri verir. ( NOT: Dondurma değildir )
-- MIN(Sütun adi): Bir sütundaki en küçük değeri verir.

SELECT MAX(EmployeeID)[Maximum Değer], MIN(EmployeeID) [Minimum Değer] FROM Employees
SELECT MAX(FirstName)[Maximum Değer], MIN(FirstName) [Minimum Değer] FROM Employees

-- Sütunun sayisal sütun olmasina gerek yok, alfabetik olarak en küçük değeri de verir.

SELECT 
	EmployeeID, 
	FirstName, 
	LastName , 
	Country,
	IIF(Country = 'USA' , 'Amerike Birleşik Devletleri', IIF(Country = 'UK', 'İngiltere Birleşik Kırallığı', Country)) AS Ulke
FROM Employees





SELECT 
	EmployeeID, 
	FirstName, 
	LastName , 
	Country,
	CASE (Country)
	WHEN 'UK'  THEN 'İngiltere Birleşik Kırallığı'
	WHEN 'USA' THEN 'Amerike Birleşik Devletleri'
	END AS 'Ülke'
FROM Employees


-- EmployeeID değeri 5'ten büyükse -> 5'ten büyüktür
-- EmployeeID değeri 5'ten küçükse -> 5'ten küçük
-- EmployeeID değeri 5'e eşitse    -> 5'e eşittir


SELECT 
	EmployeeID, 
	FirstName, 
	LastName, 
	CASE 
	WHEN EmployeeID > 5 THEN '5''ten büyüktür'
	WHEN EmployeeID < 5 THEN '5''ten küçük'
	ELSE '5''e eşittir'
	END AS Result
FROM Employees
 