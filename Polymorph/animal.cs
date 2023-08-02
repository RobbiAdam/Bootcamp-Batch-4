namespace AnimalLibrary;

public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Sounding");
    }

    public void Eat()
    {
        Console.WriteLine("le eating");
    }

    public void Eat(string food)
    {
        Console.WriteLine("is eating " + food);
    }
    public void Eat(string food, int x)
    {
        Console.WriteLine("is eating " + x + " " + food);
    }

    public void Eat(string food, int x, string condition)
    {
        Console.WriteLine("is eating " + x + " " + condition + " " + food);
    }


    
}

