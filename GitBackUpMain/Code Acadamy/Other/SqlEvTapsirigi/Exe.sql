SELECT * FROM Employees
SELECT * FROM Employees  WHERE FirstName LIKE 'LA%' OR FirstName LIKE 'LN%' OR FirstName LIKE 'AA%' OR FirstName LIKE 'AN%' 



SELECT * FROM Employees  WHERE FirstName LIKE '%[_]%'


SELECT TOP (10) PERCENT * FROM Customers  WHERE CustomerID LIKE '_A_T%'


SELECT * FROM Employees WHERE FirstName NOT LIKE '_A%' AND FirstName NOT LIKE '_T%'


SELECT * FROM Employees  WHERE FirstName NOT LIKE '[A-I]%'

SELECT * FROM Employees  WHERE FirstName LIKE '%[^T]'


SELECT dbo.ufnCalculateAge('10/04/1995',22) AS [Calculate Age]