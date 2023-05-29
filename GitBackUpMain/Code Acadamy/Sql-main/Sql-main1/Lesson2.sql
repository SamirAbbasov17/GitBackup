-- SORGULARI FiLTRELEMEK
-- Yazdiğimiz sorgulari belirli koşullara göre filtreleyebilmek için WHERE cümleciğini kullaniriz. 
-- Ünvani Mr. olanlarin listelenmesi

SELECT TitleOfCourtesy, FirstName, LastName
FROM Employees
WHERE TitleOfCourtesy='Mr.'

-- EmployeeID değeri 5'ten büyük olanların listelenmesi
SELECT EmployeeID, TitleOfCourtesy, FirstName, LastName
FROM Employees
WHERE EmployeeID>5

-- 1960 yilinda doğanlarin listelenmesi
SELECT FirstName, LastName, BirthDate, YEAR(BirthDate) AS [Year]
FROM Employees
WHERE YEAR(BirthDate)=1960

-- 1950 ile 1961 yillari arasinda doğanlar ( between ) kullanmayınız :) görmedik henüz!!!
SELECT FirstName, LastName, BirthDate, YEAR(BirthDate) AS [Year]
FROM Employees
WHERE YEAR(BirthDate)>1950 AND YEAR(BirthDate)<1961
SELECT FirstName, LastName, BirthDate, YEAR(BirthDate) AS [Year]
FROM Employees
WHERE YEAR(BirthDate) BETWEEN 1950 AND 1961

-- ingiltere'de oturan bayanlarin adi, soyadi, mesleği, ünvani, ülkesi ve doğum tarihini listeleyiniz (Employees)
SELECT Country, TitleOfCourtesy
FROM Employees
WHERE(TitleOfCourtesy='Ms.' OR TitleOfCourtesy='Mrs.')AND Country='UK'

-- Ünvani Mr. olanlar veya yaşi 60'tan büyük olanlarin listelenmesi
SELECT TitleOfCourtesy, FirstName, LastName, BirthDate, (YEAR(GETDATE())-YEAR(BirthDate)) Age
FROM Employees
WHERE TitleOfCourtesy='Mr.' or YEAR(GETDATE())-YEAR(BirthDate)>=60

-- GETDATE() fonksiyonu güncel tarih bilgisini verir, YEAR() fonksiyonu ile birlikte o tarihe ait olan yil bilgisini öğreniyoruz. Where ifadesi ile  birlikte kendi isimlendirdiğimiz sütunlari kullanamayiz. Örneğin yukarida Yaş olarak isimlendirdiğimiz sütun ismini Where ifadesi ile birlikte kullanamayiz.

-- NULL VERiLERi SORGULAMAK

-- Bölgesi belirtilmemiş çalışanların listelenmesi
SELECT Region, * FROM Employees WHERE Region IS NULL

-- Bölgesi belirtilen personllerin listelenmesi
SELECT Region, * FROM Employees WHERE Region IS NOT NULL

-- NOT: NULL değerler sorgulanirken = veya <> gibi operatörler kullanilmaz. Bunun yerine IS NULL veya IS NOT NULL ifadeleri kullanilir.

-- SIRALAMA İŞLEMLERİ
SELECT * FROM Employees ORDER BY LastName ASC
-- Ascending -> A'dan Z'ye - 0'dan 9'a sıralama yapar ( fakirden -> Zengine )
SELECT * FROM Employees ORDER BY BirthDate DESC
-- Descending Z'den A'ya - 9'dan 0'a ( zenginden fakire ) sıralama yapar
-- Descending (azalan sirada)
-- ASC ifadesi sayisal sütunlarda küçükten büyüğe, metinsel sütunlarda A'dan Z'ye doğru siralama işlemi yaparken, DESC ifadesi tam tersi şekilde siralama yapar.


SELECT EmployeeID, FirstName, LastName INTO Calisanlar FROM Employees

UPDATE Calisanlar SET FirstName='Michael' WHERE EmployeeID>6

SELECT EmployeeID, FirstName, LastName
FROM Calisanlar
ORDER BY FirstName, LastName DESC

SELECT FirstName, LastName INTO EmployeesTest FROM Employees

SELECT EmployeeID, TitleOfCourtesy,FirstName,LastName, BirthDate, HireDate FROM Employees
ORDER BY 2, 6 DESC


-- Çalişanlari ünvanlarina göre , ünvanlari ayniysa yaşlarina göre büyükten küçüğe siralayiniz.
-- NOT -> Personel kore doğumlu ise, yaşına -1 olarak hesaplayınız :)

SELECT TitleOfCourtesy, FirstName, LastName, YEAR(GETDATE()) - YEAR(BirthDate) AS Age from Employees
ORDER BY TitleOfCourtesy, Age DESC



-- BETWEEN - AND KULLANIMI
-- Aralık bildirmek için kullanılır

SELECT FirstName, LastName, BirthDate, YEAR(BirthDate) AS [Year]
FROM Employees
WHERE YEAR(BirthDate)>1950 AND YEAR(BirthDate)<1961



SELECT FirstName, LastName, BirthDate, YEAR(BirthDate) AS [Year]
FROM Employees
WHERE YEAR(BirthDate) BETWEEN 1950 AND 1961


-- Between kullanımda, verilen değerler sorguya dahil'dir


-- between ve  kullanmadan 2 örnek olarak sorguyu yazınız :)

-- Alfabetik olarak Janet ile Robert arasinda olanlarin listelenmesi
SELECT FirstName, LastName FROM Employees
--WHERE FirstName >= 'Janet' AND FirstName <= 'Robert'
WHERE FirstName BETWEEN 'Janet' AND 'Robert'
ORDER BY FirstName

-- IN KULLANIMI
-- Ünvani Mr. veya Dr. olanlarin listelenmesi

SELECT * FROM Employees
-- WHERE TitleOfCourtesy = 'MR.' OR TitleOfCourtesy = 'Dr.'
WHERE TitleOfCourtesy IN ('MR.' ,'Dr.')

-- 1950, 1955 ve 1960 yillarinda doğanlarin listelenmesi
SELECT FirstName, LastName, BirthDate, YEAR(BirthDate) AS [Year]
FROM Employees
WHERE YEAR(BirthDate) in (1950,1955,1960)


-- TOP Kullanimi
SELECT TOP 3 * FROM Employees --  ilk 3 kayıt

select TOP 5 EmployeeID, FirstName,LastName, TitleOfCourtesy from Employees
order by FirstName

-- TOP ifadesi bir sorguda en son çalişan kisimdir. Yani öncelikle sorgumuz çaliştirilir ve oluşacak olan sonuç kümesinin (result set) ilk 5 kaydi alinir.
 

-- Çalişanlari yaşlarina göre azalan sirada siraladiktan sonra, oluşacak sonuç kümesinin %25'lik kismini listeleyelim.

SELECT TOP 25 PERCENT FirstName, LastName, YEAR(GETDATE()) - YEAR(BirthDate) AS Age FROM Employees
ORDER BY Age


-- LIKE KULLANIMI
-- Adı Michael olan personelin listelenmesi

-- 1. Yol (equal)
SELECT FirstName, LastName FROM Employees WHERE FirstName = 'Michael'

-- 2. Yol

SELECT FirstName, LastName FROM Employees WHERE FirstName LIKE 'Michael'


-- Adının ilk harfi A ile başlayanlar

-- 1. Yol
SELECT FirstName, LastName FROM Employees  WHERE LEFT(FirstName,1) = 'A'

-- 2. Yol
SELECT FirstName, LastName FROM Employees  WHERE  FirstName  LIKE 'A%'



-- Soyadının son harfi N olanlar

-- 1. Yol
SELECT FirstName, LastName FROM Employees  WHERE RIGHT(LastName,1) = 'N'

-- 2. Yol
SELECT FirstName, LastName FROM Employees  WHERE  LastName  LIKE '%N'


-- Adının içerisinde E harfi geçenler
SELECT FirstName, LastName FROM Employees  WHERE FirstName  LIKE '%E%'

-- Adının ilk harfi A veya L olanlar

SELECT FirstName, LastName FROM Employees  WHERE LEFT(FirstName, 1) = 'A' OR LEFT(FirstName, 1) = 'L'
ORDER BY 1

SELECT FirstName, LastName FROM Employees  WHERE FIRSTNAME LIKE 'A%' OR FIRSTNAME LIKE  'L%'
ORDER BY 1

SELECT FirstName, LastName FROM Employees  WHERE FIRSTNAME LIKE '[AL]%'
ORDER BY 1


-- Adının içerisinde R veya T harfi bulunanlar
SELECT FirstName, LastName FROM Employees  WHERE FIRSTNAME LIKE '%[RT]%'
ORDER BY 1

-- Adının ilk harfi alfabetik olarak J ile R aralığında olanlar

SELECT FirstName, LastName FROM Employees
--WHERE LEFT(FirstName, 1) >= 'J' AND LEFT(FirstName, 1) <= 'R'
WHERE LEFT(FirstName, 1) BETWEEN 'J' AND 'R'
ORDER BY FirstName

SELECT FirstName, LastName FROM Employees  WHERE FIRSTNAME LIKE '[J-R]%'
ORDER BY 1


-- Adı şu şekilde olanlar: tAmEr, yAsEmin, tAnEr (A ile E arasında tek bir karakter olanlar)
SELECT FirstName, LastName FROM Employees  WHERE FIRSTNAME LIKE '%A_E%'
ORDER BY 1

-- Adının ilk harfi M olmayanlar
SELECT FirstName, LastName FROM Employees  WHERE FirstName NOT LIKE 'M%'
SELECT FirstName, LastName FROM Employees  WHERE FirstName LIKE '[^M]%'


-- 1) Adının ilk iki harfi LA, LN, AA veya AN olanlar
-- 2) Adının içerisinde _ geçen isimleri listeleyiniz ( içeride kayıt yok diye yazmamazlık yapmayınız, bi zahmet 2 satır datayı güncelleyin :))
-- 3) Customers tablosundan CustomerID'sinin 2. harfi A, 4. harfi T olanların %10'luk kısmını getiren sorguyu yazınız.
-- 4) Adının 2. harfi A veya T olmayanlar
-- 5) Adının ilk harfi A ile I aralığında bulunmayanlar
-- 6) Adı T ile bitmeyenler


-- Function Odev :) -> Yaş hesaplama :) verdiğiniz tarihe göre, kişinin parametrede gönderdiğiniz yaşı doldurup doldurmadığı geriye dönünüz

-- 25.09.1988 , 35 -> Yıl ve ay olarak doldurmuştur, gün olarak eksiktir. | Yıl olarak doldurmuştur, ay ve gün olarak eksik, Yıl, ay ve gün olarak eksik

-- https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.select?view=net-7.0