using System;

public class Weapon
{
    public int MagazineCapacity;  
    public int BulletCount;       
    public bool IsAutomatic;      

   
    public Weapon(int magazineCapacity, int bulletCount, bool isAutomatic)
    {
        MagazineCapacity = magazineCapacity;
        BulletCount = bulletCount;
        IsAutomatic = isAutomatic;
    }

    


    public void Shoot()
    {
        if (BulletCount > 0)
        {
            BulletCount--;
            Console.WriteLine("1 güllə atıldı. Qalan güllə sayı: " + BulletCount);
        }
        else
        {
            Console.WriteLine("Daraqda güllə yoxdur!");
        }
    }

    public void Fire()
    {
        if (BulletCount > 0)
        {
            int bulletsFired = BulletCount;
            BulletCount = 0;
            Console.WriteLine($"Hamısı {bulletsFired} güllə atıldı.");
        }
        else
        {
            Console.WriteLine("Daraqda güllə yoxdur!");
        }
    }

 
    public int GetRemainBulletCount()
    {
        return MagazineCapacity - BulletCount;
    }

   
    public void Reload()
    {
        if (MagazineCapacity - BulletCount <= BulletCount )
        {
            Console.WriteLine("Daraq doludurr");
        }
        else
        {
            BulletCount = MagazineCapacity;
            Console.WriteLine("Daraq yenidən dolduruldu.");
        }
    }

  
    public void ChangeFireMode()
    {
        IsAutomatic = !IsAutomatic;
        if (IsAutomatic)
        {
            Console.WriteLine("Atış modu: Avtomatik");
        }
        else
        {
            Console.WriteLine("Atış modu: Təkli");
        }
    }
}
