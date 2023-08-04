namespace Abstract;

public class Skateboard : Vehicle
{
    public override void GetData()
    {

        Console.WriteLine("Skateboard has " + GetWheel(_wheel) + " WHeel");
        Console.WriteLine("Skateboard ID is " + GetId(_vehicleId));

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
