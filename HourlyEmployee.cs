using System;

namespace ConsoleApp9.NewFolder
{
    internal class HourlyEmployee : EmployeAbstract
    {
        public double HourlyRate { get; set; }
        public double HourlyWorked { get; set; }

        public override double CalculateSalary() => HourlyRate * HourlyWorked;

        public override void DisplayDetails()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Ad: {Name}");
            Console.WriteLine($"Soyad: {Surname}");
            Console.WriteLine($"Yaş: {Age}");
            Console.WriteLine($"Saatlıq Ücret: {HourlyRate}");
            Console.WriteLine($"İşlənən Saat: {HourlyWorked}");
        }
    }
}
