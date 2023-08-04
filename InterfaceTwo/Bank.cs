namespace InterfaceTwo;


public class Bank : ISaveData, ILoadData
{
    protected string _data;
    // public ISaveData saveData;
    public string HasData(string data)
    {
        _data = data;
        return _data;
    }

    public void Save()
    {
        Console.WriteLine("saving " + _data);
    }

    public void Load()
    {
        Console.WriteLine("loading " + _data);
    }



}
