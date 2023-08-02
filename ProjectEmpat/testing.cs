namespace ProjectEmpat;

public class Testing
{
    private int _number;
    public string _text = "uooooooo";

    private int Multiply(int a, int b)
    {
        return a * b;
    }

    public int MultiplyNumber(int a, int b)
    {
        int _result = Multiply(a, b);

        Console.WriteLine("value is " + _result);
        return _result;

    }
}
