
//The static keyword in C# means that the member is shared across all instances of the class.
//Static classes can only have static members (fields, properties, methods must be static)
//Static classes can't be used to instantiate objects
//Static classes are sealed and therefore cannot be inherited
//Static classes cannot contain a constructor
//Static classes and their members are stored in special memory called loader heap.  It's separate from regular heap and stack memory
public static class Animals
{

    //C# will warn you if you attempt to use a reference type that's not initialized and not marked as nullable. 
    //fix this by initializing the property to string.Empty below
    public static string Name { get; set; } = string.Empty;
       
    public static string Sound = string.Empty;

    public static string MakeSound()
    {
        if (Name == string.Empty || Sound == String.Empty)
        {
            return "An animal has no name or sound";
        }

        else
        {
            return String.Format("{0} says {1}", Name, Sound);
        }
    }
}   

class Program
{
    static void Main(string[] args)
    {
       Animals.Name = "Lion";
       Animals.Sound = "Roar";
       Console.WriteLine(Animals.MakeSound());
    }
}