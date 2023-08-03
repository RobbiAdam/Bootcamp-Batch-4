using Testing;
class program
{
    static void Main(string[] args)
    {
        Bicycle bicycle= new Bicycle();
        SkateBoard skateBoard= new SkateBoard();
        Car car= new Car(); 

        Vehicle vehicle = new Vehicle(bicycle);
        vehicle.Start();
    }
}