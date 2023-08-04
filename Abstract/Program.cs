using Abstract;

class Program
{
    static void Main(string[] args)
    {
        Bicycle bicycle= new Bicycle();
        bicycle.HasData(1, 4, 56);
        bicycle.GetData();
        
        Skateboard skateboard= new Skateboard();
        skateboard.HasData(4, 50);
        skateboard.GetData();

        Cat cat= new Cat();
        // cat.HasData();
        cat.GetData();
    }

}