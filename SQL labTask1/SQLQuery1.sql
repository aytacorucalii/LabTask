USE AcademyDB
CREATE PROCEDURE StudentData
@FirstName nvarchar(25),
@LastName nvarchar (25),
@DataOfBirth date,
@Username nvarchar(25),
@Password nvarchar(25),
@EnrollmentDate date
as
Begin
INSERT INTO Students (FirstName, LastName, DataOfBirth, Username, Password, EnrollmentDate)
        VALUES (@FirstName, @LastName, @DataOfBirth, @Username, @Password, @EnrollmentDate);
end;
EXEC StudentData
    @FirstName = 'Aytac',
    @LastName = 'Orucaliyeva',
    @DataOfBirth = '2005-08-11',
    @Username = 'aytac.orucaliyeva',
    @Password = 'password123',
    @EnrollmentDate = '2023-09-12';


insert into Groups( GroupName)
values('Ag205')
insert into Classes(Schedule,RoomName)
values('Monday','Room101')

CREATE FUNCTION GetScheduleById (@id INT)
RETURNS TABLE
AS
RETURN (
select 
s.Id AS StudentId, 
s.FirstName AS StudentName, 
s.LastName AS StudentSurname, 
g.Id AS GroupId, 
g.GroupName AS GroupName,
cl.RoomName as RoomName,
cl.Schedule As Schedule

FROM Students s
INNER join Groups g
ON g.Id = s.Id
inner join Classes cl
on cl.id = s.Id

    WHERE s.Id = @id
);
SELECT * FROM GetScheduleById(1);
drop function GetScheduleById

