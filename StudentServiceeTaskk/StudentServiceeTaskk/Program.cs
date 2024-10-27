using StudentServiceeTaskk.Models;

internal class Program
{
    static void Main(string[] args)
    {
     
        StudentService studentService = new StudentService();

     
        Student aytac = new Student();
        aytac.FirstName = "Aytac";
        aytac.LastName = "Oruc";
        aytac.GPA = 3.5; 
        aytac.Status = "Active"; 
        aytac.Major = "Computer Science"; 
        studentService.AddStudent(aytac);


        Student elvin = new Student();
        elvin.FirstName = "Elvin";
        elvin.LastName = "Huseynov";
        elvin.GPA = 3.8;
        elvin.Status = "Graduate"; 
        elvin.Major = "Math";
        studentService.AddStudent(elvin);

        Student nigar = new Student();
        nigar.FirstName = "Nigar";
        nigar.LastName = "Aliyeva";
        nigar.GPA = 3.6;
        nigar.Status = "Pending"; 
        nigar.Major = "Physics";
        studentService.AddStudent(nigar);

        Student kamran = new Student();
        kamran.FirstName = "Kamran";
        kamran.LastName = "Mehdiyev";
        kamran.GPA = 3.7;
        kamran.Status = "Active";
        kamran.Major = "Chemistry";
        studentService.AddStudent(kamran);

       
        Student[] allStudents = studentService.GetAllStudents();

       
        foreach (Student student in allStudents)
        {
            if (student != null) // Əgər tələbə mövcuddursa (array-da boş yerlər də ola bilər)
            {
               
                Console.WriteLine($"Id: {student.Id}, Ad: {student.FirstName}, Soyad: {student.LastName}, Ixtisas: {student.Major}, GPA: {student.GPA}, Status: {student.Status}");
            }
        }
    }
}
