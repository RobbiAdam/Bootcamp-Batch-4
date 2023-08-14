using System.Collections;

class Program
{
    public static void Main(string[] args)
    {
        string _text = "Hayolo";
        HashSet<String> myHashSet = new();
        HashSet<String> myHashSet2 = new();

        myHashSet.Add("Jakarta");
        myHashSet.Add("Bandung");
        myHashSet.Add("Palembang");
        myHashSet.Add("Medan");
        myHashSet.Add("Bali");
        myHashSet.Add("Aceh");
        
        foreach(var value in myHashSet)
        {
            // Console.WriteLine(value);   //Print every Hashset list
        }   
        myHashSet2.Add("Medan");
        myHashSet2.Add("Bali");
        myHashSet2.Add("Batam");

        myHashSet.Remove("Aceh"); // remove list

        myHashSet.UnionWith(myHashSet2); // This method is used to modify the current HashSet object to contain all elements that are present in itself, the specified collection, or both.
        foreach(var val in myHashSet)
        {
            Console.WriteLine($"Union with {val}");
        }

        myHashSet.ExceptWith(myHashSet2); //remove all elements in the specified collection from the current HashSet object.
        foreach(var val in myHashSet)
        {
            Console.WriteLine($"Except with {val}");
        }
    }
}