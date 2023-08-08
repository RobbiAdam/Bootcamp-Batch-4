using DelegatePractice;

class Program
{
    static void Main(string[] args)
    {
        Transaction BuyAction = ItemTransaction.Buy;
        Transaction SellAction = ItemTransaction.Sell;
        Transaction BarterAction = ItemTransaction.Barter;
        BuyAction();
        // Console.WriteLine(BuyAction);
    }
}