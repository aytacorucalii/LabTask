using System;
using CustomValidatorLibrary;

namespace ExecutableProject
{
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

                if (choice == "1")
                {
                    
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
                       Console.WriteLine("Şifrə minimum 8 simvol olmalı, rəqəm, simvol, böyük və kiçik hərf r.");
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
                    person.Age = int.Parse(Console.ReadLine());
                    if (!validator.ValidateAge(person.Age))
                    {
                        Console.WriteLine("Yaş 0-dan böyük, 55d olmalıdır.");
                        continue; 
                    }

                    Console.Write("Birthday (yyyy-mm-dd): ");
                    person.Birthday = DateTime.Parse(Console.ReadLine());
                    if (!validator.ValidateBirthday(person.Birthday))
                    {
                        Console.WriteLine("Doğum tarixi 1970-ci ildən kiçik olmamalıdır.");
                        continue; 
                    }

                    Console.WriteLine("Yeni şəxs yaradıldı!");
                }
                else if (choice == "2")
                {
                    Console.WriteLine("Proqramdan çıxılır...");
                    break; 
                }
                else
                {
                    Console.WriteLine("Yanlış seçim! Lütfən, 1 və ya 2 arasında seçim edin.");
                }
            }
        }
    }
}
