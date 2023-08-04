namespace InterfaceTwo;

public class HardDrive : Bank, ISaveData
{
    public void Save()
    {
        Console.WriteLine("Data saved to " + _data);
    }

    public void Load()
    {
        Console.WriteLine("Data loaded from " + _data);
    }

    public string GetData(string data)
    {
        _data = data;
        return _data;
    }


}
