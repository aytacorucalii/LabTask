using System.Text.RegularExpressions;

namespace GroupStudentClassTask;

internal class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student();
        student1.Name = "Aytac";
        student1.Surname = "Orucaliyeva";
        student1.Gender = "Female";
        student1.age = 20;
        student1.PhoneNumber = "0551234567";
        student1.Limit = 0;
        student1.Group = "Group2";

        Group group1 = new Group();
        group1.Name = "Group1";
        group1.Shift = "Morning";

       


        Group group2 = null;

        if (group2 != null)
        {
            group2.AddStudent(student1);
        }
        else
        {
            Console.WriteLine("Bele bir qrup yoxdur.");
        }
        group1.AddStudent(student1);

    }
    internal class Student
    {
      public string Name { get; set; }
      public string Surname { get; set; }
      public string Gender { get; set; }    
      public int age { get; set; }
      public string PhoneNumber { get; set; }
      public int Limit { get; set; }
      public string Group { get; set; }
        public void Absent()
        {
            if (Limit > 0)
            {
                Limit--;
                Console.WriteLine("Telebe bu gun derse gelmeyib.");
            }
            else
            {
                Console.WriteLine("Kesildiniz.");
            }
        }
    }
}