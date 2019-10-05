
create procedure dbo.uspPeople_GetAll
as
begin
	select id, firstname, lastname 
	from dbo.people
end