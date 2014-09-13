CREATE PROCEDURE [dbo].[CreatePerson] 
	@FirstName VARCHAR(255), 
	@LastName VARCHAR(255)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO People (FirstName, LastName)
	VALUES (@FirstName, @LastName)
END