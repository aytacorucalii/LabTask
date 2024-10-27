using System;

namespace HomeTask2Class.Object.Methods
{
   


    class Animal
    {
        public string Name { get; set; }
        public int Age { get ; set; }

        public void Eat()
        {
            Console.WriteLine("Able to eat");
        }
    }





    class Dog : Animal
    {
        public bool HasTail { get; set; }

        public void Bark()
        {
            Console.WriteLine("Dogs are barking");
        }
    }

   





    class Bear : Animal
    {
        public bool IsWild { get; set; }
    }

   




    class Bird : Animal
    {
        public bool CanSwim { get; set; }

        public void Fly()
        {
            Console.WriteLine("Bird is flying");
        }
    }






   
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir heyvan növü seçin: Dog, Bear, Bird");
            string animalType = Console.ReadLine().ToLower();

           
            if (animalType == "dog")
            {
                Dog dog = new Dog();
                Console.Write("Dog adı daxil edin: ");

                dog.Name = Console.ReadLine();
                Console.Write("Dog yaşı daxil edin: ");

                dog.Age = int.Parse(Console.ReadLine());
                Console.Write("Dog-un quyruğu var (true/false): ");

                dog.HasTail = bool.Parse(Console.ReadLine());
                Console.WriteLine($"Adı: {dog.Name}, Yaşı: {dog.Age}, Quyruğu var: {dog.HasTail}");

                dog.Eat();
                dog.Bark();
            }




            else if (animalType == "bear")
            {
                Bear bear = new Bear();
                Console.Write("Bear adı daxil edin: ");

                bear.Name = Console.ReadLine();
                Console.Write("Bear yaşı daxil edin: ");

                bear.Age = int.Parse(Console.ReadLine());
                Console.Write("Bear vəhşi mi (true/false): ");

                bear.IsWild = bool.Parse(Console.ReadLine());
                Console.WriteLine($"Adı: {bear.Name}, Yaşı: {bear.Age}, Vəhşi: {bear.IsWild}");
                bear.Eat();

            }




            else if (animalType == "bird")
            {
                Bird bird = new Bird();
                Console.Write("Bird adı daxil edin: ");

                bird.Name = Console.ReadLine();
                Console.Write("Bird yaşı daxil edin: ");

                bird.Age = int.Parse(Console.ReadLine());
                Console.Write("Bird üzə bilir mi (true/false): ");

                bird.CanSwim = bool.Parse(Console.ReadLine());
                Console.WriteLine($"Adı: {bird.Name}, Yaşı: {bird.Age}, Üzə bilir: {bird.CanSwim}");
                bird.Eat();
                bird.Fly();
            }





            else
            {
                Console.WriteLine("Səhv seçim etdiniz. Yalnız Dog, Bear və Bird növlərindən birini seçin.");
            }
        }
    }
}
