namespace Testing;

public interface IWheel
{
    void HasWheel();
}

public class Bicycle : IWheel
{
    public void HasWheel()
    {
        Console.WriteLine("Bicycle has Wheel");
    }
}

public class SkateBoard : IWheel
{
    public void HasWheel()
    {
        Console.WriteLine("SkateBoard has wheel");
    }

}
    public class Car : IWheel
    {
        public void HasWheel()
        {
            Console.WriteLine("Car has wheel");
        }
    }

public class Vehicle
{
    public IWheel wheel;
    public Vehicle(IWheel wheel)
    {
        this.wheel = wheel;
    }

    public void Start()
    {
        wheel.HasWheel();
    }


}
