/*
Properties
    A member of a class or struct
    Encapulates a private field and provides a public way to "get" and "set" its value
    Properties can be any type (class, struct, interface, string, int, etc.)
    Auto-implemented properties are a shortcut to create a property - no need to define a private field
    Regular properties have a private field and a public property
*/

class Animals
{
    //Auto-implemented properties
    string Name { get; set; }    
    public string Sound { get; set; }


    //Regular Property Example
    private int _age;

    public int Age
    {
        get {return _age;
    }
    set
        {
            _age = value;
        }
    }

    //Constructor
    public Animals(string name)
    {
        Name = name;        
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
        Animals dog = new("Rex");
        dog.Sound = "Woof";
        Console.WriteLine(dog.MakeSound());

        dog.Age = 7;
        Console.WriteLine($"The Dog is {dog.Age} years old.");
    }
}
