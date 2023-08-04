namespace Abstract;

public class Bicycle : Vehicle
{
    public override void GetData()
    {
        
        Console.WriteLine("Bicycle has "  + _seat + " Seat");
        Console.WriteLine("Bicycle has "  + _wheel + " WHeel");
        Console.WriteLine("Bicycle ID is "  + _vehicleId);
       
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