using Foobarspace;

interface IFoobar
{
    void GetFooBar(int x);
    string GetFooBarResult();
}
class Program
{
    static void Main()
    {
        Formula formula = new();

        formula.GetFooBar(5);
        Console.WriteLine(formula.GetFooBarResult());
    }
}

        // int _userInput = InputHandler.GetInput();
        // formula.FooBar(_userInput);
// static class InputHandler
// {
//     public static int GetInput()
//     {
//         while (true)
//         {
//             Console.Write("Enter a number: ");
//             string _input = Console.ReadLine();

//             if (int.TryParse(_input, out int number))
//             {
//                 return number;
//             }
//             else
//             {
//                 Console.WriteLine("Invalid input. Please enter a valid number !");
//             }

//         }
//     }
// }