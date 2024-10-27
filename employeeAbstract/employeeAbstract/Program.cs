using ConsoleApp9.NewFolder;
using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Saatlıq İşçi Girişi");
                Console.WriteLine("2. Aylıq İşçi Girişi");
                Console.WriteLine("3. Çıxış");
                Console.Write("Seçim edin (1/2/3): ");
                var choice = Console.ReadLine();

                if (choice == "1")
                {
                    var hourlyEmployee = new HourlyEmployee();
                    Console.Write("Ad: ");
                    hourlyEmployee.Name = Console.ReadLine();
                    Console.Write("Soyad: ");
                    hourlyEmployee.Surname = Console.ReadLine();
                    Console.Write("Yaş: ");
                    hourlyEmployee.Age = int.Parse(Console.ReadLine());
                    Console.Write("Saatlıq Ücret: ");
                    hourlyEmployee.HourlyRate = double.Parse(Console.ReadLine());
                    Console.Write("İşlənən Saat: ");
                    hourlyEmployee.HourlyWorked = double.Parse(Console.ReadLine());

                    hourlyEmployee.DisplayDetails();
                    Console.WriteLine($"Maaş: {hourlyEmployee.CalculateSalary()}");
                }
                else if (choice == "2")
                {
                    var salariedEmployee = new SalariedEmployee();
                    Console.Write("Ad: ");
                    salariedEmployee.Name = Console.ReadLine();
                    Console.Write("Soyad: ");
                    salariedEmployee.Surname = Console.ReadLine();
                    Console.Write("Yaş: ");
                    salariedEmployee.Age = int.Parse(Console.ReadLine());
                    Console.Write("Aylıq Maaş: ");
                    salariedEmployee.MonthlySalary = double.Parse(Console.ReadLine());

                    salariedEmployee.DisplayDetails();
                    Console.WriteLine($"Maaş: {salariedEmployee.CalculateSalary()}");
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Proqramdan çıxılır...");
                    break;
                }
                else
                {
                    Console.WriteLine("Yanlış seçim. Lütfən, doğru seçim edin.");
                }

                Console.WriteLine();
            }
        }
    }
}
