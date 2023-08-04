namespace Abstract;

public abstract class Vehicle
{
    protected int _seat;
    protected int _wheel;
    protected int _vehicleId;

    public void HasData(int wheel, int vehicleId)
    {
        _wheel = wheel;
        _vehicleId = vehicleId;
    }
    public void HasData(int seat, int wheel, int vehicleId)
    {
        _seat = seat;
        _wheel = wheel;
        _vehicleId = vehicleId;

    }
    public abstract void GetData();


}
