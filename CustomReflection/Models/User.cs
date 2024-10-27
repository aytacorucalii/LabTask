using System;

namespace CustomReflection.Models
{
    public class User
    {
        private static string Id { get; set; }
        private string Name { get; set; }
        private string SurName { get; set; }
        private static int Age { get; set; }

        public User(string name, string surname, int age)
        {
            Name = name;
            SurName = surname;
            Age = age;
        }

        public void GetFullName()
        {
            Console.WriteLine($"Name: {Name}, Surname: {SurName}");
        }

        
        public static void ChangeAge(int NewAge)
        {
            Age = NewAge;
        }

       
        public static int GetAge()
        {
            return Age;
        }

       
      
    }
}
