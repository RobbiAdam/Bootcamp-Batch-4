namespace ProjectTiga;

public class Tire
{
	public string tireSize;

	public Tire(string tireSize)
	{
		this.tireSize = tireSize;
	}
	
	public void CheckTire() 
	{
		Console.WriteLine("Tires type " + tireSize);
	}
}
