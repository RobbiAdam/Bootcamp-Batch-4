class Program
{
    public static void Main(string[] args)
    {
        DressCode.Intern();
        DressCode.Junior();
        DressCode.Senior();
        DressCode.Manager();
    }
}

static public class DressCode
{
    static public void Intern()
    {
        Console.WriteLine("Seragam Kemeja Putih");
    }

    static public void Junior()
    {
        Console.WriteLine("Kemeja seragam");
    }

    static public void Senior()
    {
        Console.WriteLine("Kemeja bebas");
    }

    static public void Manager()
    {
        Console.WriteLine("Baju bebas");
    }
}