using InterfaceTwo;
class Program
{
    public static void Main(string[] args)
    {
        Bank bank = new Bank();
        bank.HasData("Tunai");
        bank.Save();

        Safe safe = new Safe();
        safe.GetData("File");
        safe.Load();
    }
}