using System;

namespace ConsoleApp9
{
    internal abstract class EmployeAbstract
    {
        public static int IdCounter { get; set; } 
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public EmployeAbstract()
        {
            Id = IdCounter++;
        }

        public abstract double CalculateSalary();
        public abstract void DisplayDetails();
    }
}
