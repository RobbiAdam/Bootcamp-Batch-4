using ProjectTiga;

class Program
{
    static void Main()
    {
        Engine combustionEngine = new Engine("Combustion");
        Engine electricEngine = new Engine("Electric");
        Engine dieselEngine = new Engine("Diesel");
        Engine kayuhEngine = new Engine("Kayuh");

        Lamp philips = new Lamp("phillips");
        Lamp petromak = new Lamp("petromak");
        Lamp sanyo = new Lamp("sanyo");

        Tire woodenTire = new Tire("wooden");
        Tire rubberTire = new Tire("rubber");
        Tire offRoad = new Tire("offroad");

        Car teslaCar = new Car();
        teslaCar.engine = kayuhEngine;
        teslaCar.lamp = petromak;
        teslaCar.tire = offRoad;

        Car toyotaCar = new Car();
        toyotaCar.engine = combustionEngine;
        toyotaCar.lamp = philips;
        toyotaCar.tire = rubberTire;

        teslaCar.EngineStart();
        teslaCar.LampCheck();
        teslaCar.TiresType();

        toyotaCar.EngineStart();
        toyotaCar.LampCheck();
        toyotaCar.TiresType();
    }
}