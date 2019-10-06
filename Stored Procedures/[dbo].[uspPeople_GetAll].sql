SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[uspPeople_GetAll]
as
begin
	set nocount on;
	select Id, FirstName, LastName 
	from dbo.People;
end
GO

