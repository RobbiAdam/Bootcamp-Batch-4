class Program
{
    static void Main(string[] args)
    {
        // int a = 9;
        // object obj = a;

        // string b = (string)obj;
        // Console.WriteLine(b);

        int c = (int)ObjectMaker.MyWrapper(10);
        
        Console.WriteLine(c);
        Console.WriteLine(ObjectMaker.MyWrapper(5));
    }

    static class ObjectMaker
    {
        public static object MyWrapper(int x)
        {
            object y = x;
            return y;
        }

    }

        //  class ObjectMaker{
        // public  int MyWrapper(int x)
        // {
        //     int y = x;
        //     return y;
        // }
}