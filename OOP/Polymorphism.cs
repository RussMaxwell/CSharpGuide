/*
Polymorphism
    A concept that allows you to use a single interface to represent different types of objects  

    In this example,
    Restaurant is an abstract base class that defines a contract for all restaurants. 
    RussBurgers and BrentPizza are concrete classes that inherit from Restaurant and provide their own implementations for the abstract members.
    
    The HungryPerson class takes a Restaurant object in its constructor and uses it to call the GetMenu, HoursOpen, and getDirections methods.The HungryPerson class 
    has a method MenuHoursLocation that calls GetMenu, HoursOpen, and getDirections on a Restaurant object. This is where polymorphism comes into play. 
    The actual type of the Restaurant object could be RussBurgers, BrentPizza, or any other class that inherits from Restaurant. 
    The MenuHoursLocation method doesn't need to know the actual type of the object; it just needs to know that it can call GetMenu, HoursOpen, and getDirections on it.

    In the Main method, I'm creating a HungryPerson with a RussBurgers object. When I call MenuHoursLocation on this HungryPerson, 
    it will use the RussBurgers versions of the GetMenu, HoursOpen, and getDirections methods. This is decided at runtime, hence the term "runtime polymorphism".
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


class HungryPerson
{
    private Restaurant desiredeatery;

    public HungryPerson(Restaurant placetoeat)
    {
        desiredeatery = placetoeat;
    }

    public void MenuHoursLocation()
    {
        desiredeatery.GetMenu();
        desiredeatery.HoursOpen();
        desiredeatery.getDirections();
    }
}


class Program
{
    static void Main(string[] args)
    {
        Restaurant burgerplace = new RussBurgers();
        Restaurant pizzaplace = new BrentPizza();

        HungryPerson bob = new(burgerplace);
        bob.MenuHoursLocation(); 
    }
}
