namespace Foobarspace;

public class Formula : IFoobar
{
    string _result;
    int _foo = 3;
    int _bar = 5;

    public void GetFooBar(int x)
    {
        _result = CheckFooBar(x);
    }
    public string GetFooBarResult()
    {
        return _result;
    }

    private string CheckFooBar(int x)
    {
        if (DivisibleByBoth(x))
        {
            return "Foobar";
        }
        if (DivisibleBy(_foo, x))
        {
            return "Foo";
        }
        if (DivisibleBy(_bar, x))
        {
            return "Bar";
        }
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