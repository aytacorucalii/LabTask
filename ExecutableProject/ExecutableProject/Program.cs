using CustomValidatorLibrary;
using System;

namespace ExecutableProject
{
    public class Person
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public DateTime Birthday { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Validator validator = new Validator();
            Person person = new Person();

            while (true)
            {
                Console.WriteLine("1. Yeni şəxs yarat");
                Console.WriteLine("2. Çıxış");
                Console.Write("Seçiminizi daxil edin: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                      
                        Console.Write("Username: ");
                        string username = Console.ReadLine();
                        if (!validator.ValidateUserName(username))
                        {
                            Console.WriteLine("İstifadəçi adı minimum 2 simvol olmalıdır.");
                            continue;
                        }
                        person.UserName = username;

                        Console.Write("Password: ");
                        string password = Console.ReadLine();
                        if (!validator.ValidatePassword(password))
                        {
                            Console.WriteLine("Şifrə minimum 8 simvol olmalı, rəqəm, simvol, böyük və kiçik hərf olmalidir.");
                            continue;
                        }
                        person.Password = password;

                        Console.Write("Name: ");
                        person.Name = Console.ReadLine();
                        if (!validator.ValidateName(person.Name))
                        {
                            Console.WriteLine("Ad minimum 2 simvol olmalıdır.");
                            continue;
                        }

                        Console.Write("Surname: ");
                        person.Surname = Console.ReadLine();
                        if (!validator.ValidateSurname(person.Surname))
                        {
                            Console.WriteLine("Soyad minimum 2 simvol olmalıdır.");
                            continue;
                        }

                        Console.Write("Age: ");
                        if (!int.TryParse(Console.ReadLine(), out int age) || !validator.ValidateAge(age))
                        {
                            Console.WriteLine("Yaş 0-dan böyük olmalıdır.");
                            continue;
                        }
                        person.Age = age;

                        Console.Write("Birthday (yyyy-mm-dd): ");
                        if (!DateTime.TryParse(Console.ReadLine(), out DateTime birthday) || !validator.ValidateBirthday(birthday))
                        {
                            Console.WriteLine("Doğum tarixi 1970-ci ildən kiçik olmamalıdır.");
                            continue;
                        }
                        person.Birthday = birthday;

                        Console.WriteLine("Yeni şəxs yaradıldı!");
                        break;

                    case "2":
                        Console.WriteLine("Proqramdan çıxılır...");
                        return;

                    default:
                        Console.WriteLine("Yanlış seçim! Lütfən, 1 və ya 2 arasında seçim edin.");
                        break;
                }
            }
        }
    }
}
