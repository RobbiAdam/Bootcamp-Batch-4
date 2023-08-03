using AnimalLibrary;

class Program
{
    static void Main(string[] args)
    {
        Animal animal = new Animal();
        Cat cat = new Cat();
        Bird bird = new Bird();
        Kangaroo kangaroo = new Kangaroo();

        cat.MakeSound();
        bird.MakeSound();
        kangaroo.MakeSound();

        cat.Eat();
        cat.Eat("fish", 5, "cooked");
        bird.Eat("Meat");

        kangaroo.Eat("apple", 2);
        animal.Eat();
    }
}