using CatLibrary;
class program
{
    static void Main()
    {
        Cat pedro = new Cat();
        pedro._name = "Pedro";
        pedro._age = 5;
        pedro.Eat("Fish");

        Cat monnie = new Cat();
        string name = monnie._name;
        Console.Write(name);
        monnie._name = "Monnie";
        monnie._age = 4;
        monnie.Sleep();
    }
}


