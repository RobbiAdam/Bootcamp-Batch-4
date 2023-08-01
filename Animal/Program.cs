using Animal;
using System;

class Program
{
    static void Main(string[] args)
    {
        Bird woodpecker = new Bird();
        woodpecker.Sleep();
        
        Cat Pedro = new Cat();
        Pedro._name = "Pedro";
        Pedro.Eat();
        Pedro.Scratch();

        Turtle  elFuerte = new Turtle();
        elFuerte.Sleep();
        elFuerte.Eat();
        elFuerte.Swimming();
        elFuerte.MakeSound();
        
    }
}