﻿CREATE PROCEDURE [dbo].[DeletePerson]
	@Id BIGINT
AS
BEGIN
	SET NOCOUNT ON;
    DELETE FROM dbo.People
	WHERE Id = @Id
END