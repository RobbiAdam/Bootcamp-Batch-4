using ProjectEmpat;

class Program
{
    static void Main(string[] args)
    {
        Testing _testing = new Testing();
        _testing.MultiplyNumber(5, 10);

        _testing._text = "tyduck uoooooo";
        Console.WriteLine(_testing._text);
             
        
    }
}