﻿CREATE PROCEDURE [dbo].[GetPersonById] 
	@Id BIGINT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT FirstName, LastName
	FROM People
	WHERE Id = @Id
END