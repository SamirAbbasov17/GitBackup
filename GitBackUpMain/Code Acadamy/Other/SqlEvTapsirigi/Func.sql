-- =============================================
-- Author:		Samir
-- Create date: 19/05/2023
-- Description:	Age Tester
-- =============================================
ALTER FUNCTION dbo.ufnCalculateAge
(
  @birthdate DATE,
  @isage INT
)
RETURNS VARCHAR(50)
AS
BEGIN
  DECLARE @currentDate DATE = GETDATE();
  DECLARE @isbirthdate DATE = DATEADD(YEAR, @isage, @birthdate);
  
  
  IF (YEAR(@currentDate) <= YEAR(@isbirthdate) )
  BEGIN
    IF (DATEDIFF(DAY ,@currentDate ,@isbirthdate) <= 31)
      RETURN 'Yil ve Ay oduyor';
    ELSE IF (DATEDIFF(YEAR, @currentDate,@isbirthdate) = 0)
      RETURN 'Yil oduyor';
    ELSE
      RETURN 'Ay gun ve yil odemiyor';
  END
 
  RETURN 'Ay, gun ve yil oduyor';
END;
