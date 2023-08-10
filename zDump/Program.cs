interface IFoobar
{
    void FooBar(int x);
}
class Program
{
    static void Main()
    {
        Formula formula = new();
        int _userInput = InputHandler.GetInput();
        formula.FooBar(_userInput);
    }
}
static class InputHandler
{
    public static int GetInput()
    {
        while (true)
        {
            Console.Write("Enter a number: ");
            string _input = Console.ReadLine();

            if (int.TryParse(_input, out int number))
            {
                return number;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number !");
            }

        }
    }
}
public class Formula : IFoobar
{
    public void FooBar(int x)
    {
        for (int i = 0; i <= x; i++)
        {
            string _result = FindFooBar(i);
            Console.WriteLine(_result);
        }
    }
    // private int FindFoobar(int x)
    private string FindFooBar(int x)
    {
        int _foo = 3;
        int _bar = 5;

        if (DivisibleByBoth(x))
        {
            // Console.WriteLine("Foobar");
            return "Foobar";
        }
        if (DivisibleBy(_foo, x))
        {
            // Console.WriteLine("Foo");
            return "Foo";
        }
        if (DivisibleBy(_bar, x))
        {
            // Console.WriteLine("Bar");
            return "Bar";
        }
        // return x
        return x.ToString();
    }

    private bool DivisibleBy(int x, int number)
    {
        return number % x == 0;
    }

    private bool DivisibleByBoth(int number)
    {
        return DivisibleBy(3, number) && DivisibleBy(5, number);
    }
}
