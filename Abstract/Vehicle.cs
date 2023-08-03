namespace Abstract;

public abstract class Vehicle
{
    private int _seat;
    private int _wheel;
    private int _vehicleId;

    public void HasSeat(int Seat, int wheel, int vehicleId)
    {
        _seat = Seat;
        _wheel = wheel;
        _vehicleId = vehicleId;
                
    }
    public abstract int GetData();


}

