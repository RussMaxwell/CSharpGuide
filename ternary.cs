class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your Age");

        var age = Console.ReadLine();

        if (int.TryParse(age, out int aged))
        {
            var hmm = aged > 40 ? "You are old" : "You are young";
            Console.WriteLine(hmm);

        }

    }
}
