namespace ConsoleApp9classTask;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir mashin növü seçin: BMW, Mercd, Audi ");
        string CarType = Console.ReadLine().ToLower();

        Car car = null;

        if (CarType == "bmw")
        {
            car = new BMW();
        }
        else if (CarType == "mercd")
        {
            car = new Mercd();
        }
        else if (CarType == "audi")
        {
            car = new Audi();
        }
        else
        {
            Console.WriteLine("Yanlış seçim.");
            return;
        }
        Console.Write("Car rengi: ");
        car.color = Console.ReadLine();

        Console.Write("car ili : ");
        car.year = int.Parse(Console.ReadLine());

        Console.Write("car markası: ");
        car.brand = CarType.ToUpper();

        Console.Write("car modeli: ");
        car.model = Console.ReadLine();

        Console.Write("FuelCapasity: ");
        car.FuelCapasity = int.Parse(Console.ReadLine());

        Console.Write("FuelFor1Km : ");
        car.FuelFor1Km = int.Parse(Console.ReadLine());

        Console.Write("CurrerFel: ");
        car.CurrerFel = double.Parse(Console.ReadLine());

        Console.Write("  distance : ");
        int distance = int.Parse(Console.ReadLine());

        car.Drive(distance);
        Console.WriteLine($"Gedilen yol: {distance} km. Qalan: {car.CurrerFel} L");

    }

    class Vehicle()
    {
        public string color { get; set; }
        public int year { get; set; }
    }
    class Car : Vehicle
    {
        public string brand { get; set; }
        public string model { get; set; }
        public int FuelCapasity { get; set; }
        public int FuelFor1Km { get; set; }
        public double CurrerFel { get; set; }
        //public string ShowInfo(string info)
        //{
        //    return info;
        //}
        public string ShowInfo()
        {
            return $"Marka: {brand}, Model: {model}, Color: {color}, il: {year}";
        }

        public void Drive(int distance)
        {
            double requiredFuel = distance * FuelFor1Km;
            if (requiredFuel <= CurrerFel)
            {
                CurrerFel -= requiredFuel;
                Console.WriteLine($"car {distance} km getdi.");
            }
            else
            {
                Console.WriteLine("you dont have enough fuell.");
            }
        }
    }



    class BMW : Car { }
    class Mercd : Car { }
    class Audi : Car { }
}