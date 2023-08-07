static class Program
{
    static void Main(string[] args)
    {
        int x = 10;
        object object1 = x; //boxing
        int y = (int)object1; //unboxing
        string _str = y.ToString(); //convert to string
        object object2 = _str; //boxing
        int _int = object2 as int? ?? 0;// as int only convert data inside object

        Console.WriteLine(_int);

        object object3 = "i can fix her";
        if (object3 is string str1) // pattern matching
        {
            Console.WriteLine(str1);
        }
        else
        {
            Console.WriteLine("is not string");
        }
    }
}