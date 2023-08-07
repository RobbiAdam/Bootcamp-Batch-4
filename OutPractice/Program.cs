class Program
{
    public static void Main(string[] args)
    {
        int a = 5;
        int b = 10;
        int c = a;

        AddUp(ref a, ref b, out int x);
        int d = a;
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(d);
    }

    static void AddUp(ref int x, ref int y, out int a)
    {
        a = 3;
        x += a;
        y += x;

    }
}