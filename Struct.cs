struct Dog
{
    public string Name { get; set; }
    public string Breed { get; set; }

    public void Bark()
    {
        Console.WriteLine($"{this.Name} says Woof!");
    }
}

class Program
{
    static void Main(string[] args)
    {

        Dog mydog = new();

        mydog.Name = "Fido";
        mydog.Breed = "Beagle";

        mydog.Bark();
    }
}