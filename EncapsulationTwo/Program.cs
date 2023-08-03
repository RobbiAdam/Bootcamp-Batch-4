using EncapsulationTwo;

class Program
{
    static void Main()

    {
        Data gunData = new Data("Magnum", 6);

        Console.WriteLine(gunData.GetGun());
        // Console.WriteLine(gunData.GetBullet()); //6 bullet
        Console.WriteLine(gunData.SetBullet(15));

        Console.WriteLine(gunData.GetAutomatic());
    }
}