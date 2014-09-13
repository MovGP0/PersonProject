CREATE PROCEDURE [dbo].[UpdatePerson]
    @Id BIGINT,
	@FirstName VARCHAR(255), 
	@LastName VARCHAR(255)
AS
BEGIN
	SET NOCOUNT ON;
    UPDATE People 
	SET FirstName = @FirstName, LastName = @LastName
	WHERE Id = @Id;
END