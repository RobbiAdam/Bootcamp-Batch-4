class Program
{
    public static void Main(string[] args)
    {
        Cat cat= new Cat();
        Cat cat1= new Cat();
        Dog dog  = new Dog();

        
        Console.WriteLine(cat1.equals(cat1));
        // Console.WriteLine(cat1.equals(dog)); //Cannot convert dog to cat
    }
}

class Cat
{
    int _legs;

    public int GetLegs()
    {
        return _legs;
    }

    public bool equals(Cat x)
    {
        if(x == null || this.GetType() != x.GetType())
        {
            return false;
        }
        
        Cat other = (Cat)x;
        return _legs == other._legs;
    }
}

class Dog
{
    int _legs;

    public int GetLegs()
    {
        return _legs;
    }

    public bool equals(Dog x)
    {
        if(x == null || this.GetType() != x.GetType())
        {
            return false;
        }
        
        Dog other = (Dog)x;
        return _legs == ((Dog)x)._legs;
    }
}
