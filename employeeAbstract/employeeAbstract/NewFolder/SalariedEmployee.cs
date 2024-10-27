using System;

namespace ConsoleApp9.NewFolder
{
    internal class SalariedEmployee : EmployeAbstract
    {
        public double MonthlySalary { get; set; }

        public override double CalculateSalary() => MonthlySalary;

        public override void DisplayDetails()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Ad: {Name}");
            Console.WriteLine($"Soyad: {Surname}");
            Console.WriteLine($"Yaş: {Age}");
            Console.WriteLine($"Aylıq Maaş: {MonthlySalary}");
        }
    }
}
