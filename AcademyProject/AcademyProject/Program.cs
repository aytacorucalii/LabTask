
using AcademyProject.Models;
using System.Data.SqlClient;
//SQLqueries.GetInsertData("INSERT INTO Students (FirstName, LastName, DataOfBirth, Username, Password, EnrollmentDate)  \r\nVALUES  \r\n('Aytac', 'Orucali', '2000-05-15', 'aytacorucalii', 'password123', '2023-09-01'),  \r\n('Elvin', 'Mehdiyev', '1999-07-20', 'elvin.mehdiyev', 'elvinpass', '2022-08-25'),  \r\n('Leyla', 'Hüseynova', '2001-11-10', 'leyla.huseyn', 'leylapass', '2021-02-15'),  \r\n('Kamran', 'Məmmədov', '1998-03-05', 'kamran.mammadov', 'kammam123', '2020-01-10'),  \r\n('Nigar', 'Əliyeva', '2002-09-30', 'nigar.aliyeva', 'nigarpass2023', '2024-09-10');\r\n");

//SQLqueries.GetSelectData("select * from Students");


string deleteCommand = "DELETE FROM Students WHERE Id= '1'";
SQLqueries.GetDeleteData(deleteCommand);