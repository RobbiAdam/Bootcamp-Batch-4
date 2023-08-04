using Abstract;

class Program
{
    static void Main(string[] args)
    {
        Bicycle bicycle= new Bicycle();
        bicycle.HasData(1, 4, 101);
        bicycle.GetData();
        
    }

}