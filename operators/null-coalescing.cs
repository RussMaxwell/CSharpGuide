class Program
{
    static void Main(string[] args)
    {
        //null coalescing example 1
        string name = null;
        var result = name ?? "No Name";
        Console.WriteLine(result);

        //null coalescing example 2
        string name2 = "John";
        var result2 = name2 ?? "No Name";
        Console.WriteLine(result2);
    }
}
