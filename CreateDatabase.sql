USE [People]
GO
/****** Object:  Table [dbo].[People]    Script Date: 22.07.2014 22:28:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[People](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](255) NOT NULL,
	[LastName] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[CreatePerson]    Script Date: 22.07.2014 22:28:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CreatePerson] 
	@FirstName VARCHAR(255), 
	@LastName VARCHAR(255)
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO People (FirstName, LastName)
	VALUES (@FirstName, @LastName)
END

GO
/****** Object:  StoredProcedure [dbo].[DeletePerson]    Script Date: 22.07.2014 22:28:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeletePerson]
	@Id BIGINT
AS
BEGIN
	SET NOCOUNT ON;

    DELETE FROM Person
	WHERE Id = @Id
END

GO
/****** Object:  StoredProcedure [dbo].[GetPersonById]    Script Date: 22.07.2014 22:28:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetPersonById] 
	@Id BIGINT
AS
BEGIN
	SET NOCOUNT ON;

	SELECT FirstName, LastName
	FROM People
	WHERE Id = @Id
END

GO
/****** Object:  StoredProcedure [dbo].[UpdatePerson]    Script Date: 22.07.2014 22:28:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

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

GO
