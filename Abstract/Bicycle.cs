namespace Abstract;

public class Bicycle : Vehicle
{
    public override void GetData()
    {
        
        Console.WriteLine("Bicycle has "  + GetSeat(_seat) + " Seat");
        Console.WriteLine("Bicycle has "  + GetWheel(_wheel) + " WHeel");
        Console.WriteLine("Bicycle ID is "  + GetId(_vehicleId));
       
    }

    public int GetSeat(int Seat)
    {
        _seat = Seat;
        return _seat;
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