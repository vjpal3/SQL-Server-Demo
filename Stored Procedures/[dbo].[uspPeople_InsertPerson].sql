SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspPeople_InsertPerson] @FirstName varchar(50), @LastName varchar(50)
AS
SET NOCOUNT ON
Insert into dbo.People
			(FirstName, LastName)
		values
			(@FirstName, @LastName)
GO

