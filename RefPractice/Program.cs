
class Program
{
    public static void Main()
    {
        string _condition = "i can fix her";

        bool status = AddExclamationRef(ref _condition);
        Console.WriteLine(_condition);
    }

    static bool AddExclamationRef(ref string x)
    {
        if(x != null)
        {
            x = x + " !";
            return true;
        }
        return false;
    }
    
}