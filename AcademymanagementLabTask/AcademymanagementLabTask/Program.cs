using AcademymanagementLabTask.Contexts;
using AcademymanagementLabTask.Models;
using AcademymanagementLabTask.Services.Concretes;

Student student = new Student()
{
    FistName = "Mahir3",
    LastName = "Xalilov3",
    DOB = new(2005, 06, 03),
    EnrollmentDate = new(2024, 09, 23),
    Username = "Makirovich2",
    Password = "Mahir2005",
    CreatedDate = DateTime.Now,
};
  AcademyManagementDbContexts Contexts = new ();
Contexts.Add(student);
int rows=Contexts.SaveChanges();
if (rows == 0)
{
    throw new Exception("something went wrong");
}
Console.WriteLine("succesfully added");
Console.WriteLine(rows);

Student student1 = new Student()
{
    FistName = "Aytac",
    EnrollmentDate = DateTime.Now,
    IsDeleted = true
};
