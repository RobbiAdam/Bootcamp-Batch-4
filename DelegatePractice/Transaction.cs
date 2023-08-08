namespace DelegatePractice;
public delegate void Transaction();
static class ItemTransaction 
{
    public static void Buy()
    {
        Console.WriteLine("Buy an item");
    }

    public static void Sell()
    {
        Console.WriteLine("Sell an item");
    }

    public static void Barter()
    {
        Console.WriteLine("Barter an item");
    }

}
