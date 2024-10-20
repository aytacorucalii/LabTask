using System;

class Program
{
    static void Main(string[] args)
    {
        Weapon weapon = new Weapon(10, 10, true); // Obyekt yaradır

        while (true)
        {
            Console.WriteLine("0 - İnformasiya almaq üçün");
            Console.WriteLine("1 - Shoot metodu üçün");
            Console.WriteLine("2 - Fire metodu üçün");
            Console.WriteLine("3 - GetRemainBulletCount metodu üçün");
            Console.WriteLine("4 - Reload metodu üçün");
            Console.WriteLine("5 - ChangeFireMode metodu üçün");
            Console.WriteLine("6 - Proqramdan dayandırmaq üçün");
            Console.Write("Seçim edin: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    Console.WriteLine($"Darağın güllə tutumu: {weapon.MagazineCapacity}, Qalan güllə sayı: {weapon.BulletCount}, Atış modu: {(weapon.IsAutomatic ? "Avtomatik" : "Təkli")}");
                    break;
                case 1:
                    weapon.Shoot();
                    break;
                case 2:
                    weapon.Fire();
                    break;
                case 3:
                    Console.WriteLine("Tam dolması üçün lazım olan güllə sayı: " + weapon.GetRemainBulletCount());
                    break;
                case 4:
                    weapon.Reload();
                    break;
                case 5:
                    weapon.ChangeFireMode();
                    break;
                case 6:
                    return; 
                default:
                    Console.WriteLine("Yanlış seçim, yenidən cəhd edin.");
                    break;
            }
        }
    }
}
