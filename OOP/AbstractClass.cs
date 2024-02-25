/*
Abstract Class
    a class defined with the abstract reserved keyword
    cannot be instantiated
    used as a base class for other classes that inherit from it
    contains abstract methods, abstract properties, and abstract events
    Abstract methods 
        methods declared but not implemennted
        must be set as public or protected
        meant to be implemented by derived classes
        all derived classes must implement all abstract methods
    Abstract classes can also contain non-abstract methods, properties, fields, and properties
    Abstract classes can contain access modifiers
    Abstract classes can contain constructors 
        however they can only be called by derived classes constructor
        the dervied constructor calls the base class constructor using the base keyword
*/


abstract class Restaurant
{   

    public abstract List<string> Menu { get; set; }

    public abstract void GetMenu();

    public void HoursOpen()
    { Console.WriteLine("We are open from 10am to 10pm"); }

    public abstract void getDirections();
}


class RussBurgers : Restaurant
{ 
    override public List<string> Menu { get; set; }

    public RussBurgers()
    {   
        Menu = new List<string>();
        Menu.Add("Russ Burger's Menu");
        Menu.Add("Cheeseburger $5");
        Menu.Add("Fries $2");
        Menu.Add("Soda $1");
    }   

    override public void GetMenu()
    {
        foreach (string item in Menu)
        {Console.WriteLine(item);}
    }

    override public void getDirections()
    {Console.WriteLine("We are located at 123 Main St.\n\n");}    
}


class BrentPizza : Restaurant
{ 
    override public List<string> Menu { get; set; }

    public BrentPizza()
    {
        Menu = new List<string>();
        Menu.Add("Brent's Pizza Menu");
        Menu.Add("CheesePizza $12");
        Menu.Add("Sausage Pizza $15");
        Menu.Add("Deluxe Pizza $20");
    }

    override public void GetMenu()
    {
        foreach (string item in Menu)
        { Console.WriteLine(item); }
    }

    /// <summary>
    /// /overrides the HoursOpen method in the base class 
    /// /and provides a new implementation
    /// </summary>
    public new void HoursOpen()
    { Console.WriteLine("We are open from 12pm to 11pm"); }


    override public void getDirections()
    { Console.WriteLine("We are located at 788 Elm St."); }
}

class Program
{
    static void Main(string[] args)
    {
        RussBurgers burgerplace = new RussBurgers();
        burgerplace.GetMenu();
        burgerplace.HoursOpen();
        burgerplace.getDirections();

        BrentPizza pizzaplace = new BrentPizza();
        pizzaplace.GetMenu();
        pizzaplace.HoursOpen();
        pizzaplace.getDirections();
    }
}
