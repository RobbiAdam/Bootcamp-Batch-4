namespace Abstract;

public class Skateboard : Vehicle
{
    public override void GetData()
    {
        Console.WriteLine("Skateboard has " + _wheel + " Wheel");
        Console.WriteLine("Skateboard ID is " + _vehicleId);
    }


    public int GetWheel(int wheel)
    {
        _wheel = wheel;
        return _wheel;
    }

    public int GetId(int vehicleId)
    {
        _vehicleId = vehicleId;
        return _vehicleId;
    }

}
