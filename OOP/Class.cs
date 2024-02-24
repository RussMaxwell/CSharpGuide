
class Animals
{
    public string Name { get; set; }
    public string Sound { get; set; }

    public Animals(string name, string sound)
    {
        Name = name;
        Sound = sound;
    }

    public string MakeSound()
    {
        return String.Format("{0} says {1}", Name, Sound);
    }
}   


class Program
{
    static void Main(string[] args)
    {
        //getting object instance of animal class
        Animals dog = new("Rex", "bark bark");
        Console.WriteLine(dog.MakeSound());
    }
}
