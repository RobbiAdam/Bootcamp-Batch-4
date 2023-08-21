enum DaysOfWeek
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}

class Program
{
    static void Main(string[] args)
    {
        DaysOfWeek today = DaysOfWeek.Wednesday;

        Console.WriteLine("Today is: " + today); // Outputs "Today is: Wednesday"

        if (today == DaysOfWeek.Wednesday)
        {
            Console.WriteLine("It's the middle of the week!");
        }
    }
}
