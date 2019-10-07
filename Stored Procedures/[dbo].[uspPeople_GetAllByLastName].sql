SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[uspPeople_GetAllByLastName]
	@LastName nvarchar(50)
as
begin
	select Id, FirstName, LastName 	from dbo.People 
	where LastName = @LastName
end
GO

