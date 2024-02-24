/*
Interfaces
    a reference type which specifies a set of methods, properties, and events
    But it does not implement them. 
    Any class/struct that inherits an interface must implement all of its members
    All methods and properties in an interface are public by default and cannot be private or internal 
*/


using System.Text;

public interface Irestaurant
{
    public List <string> Menu { get; set; }    

    void GetMenu();
     
    void HoursOpen();

    void getDirections();
}


class RussBurgers : Irestaurant
{ 
    public List<string> Menu { get; set; }

    public RussBurgers()
    {   
        Menu = new List<string>();
        Menu.Add("Russ Burger's Menu");
        Menu.Add("Cheeseburger $5");
        Menu.Add("Fries $2");
        Menu.Add("Soda $1");
    }   

    public void GetMenu()
    {
        foreach (string item in Menu)
        {Console.WriteLine(item);}
    }

    public void HoursOpen()
    {Console.WriteLine("We are open from 10am to 10pm");}

    public void getDirections()
    {Console.WriteLine("We are located at 123 Main St.\n\n");}    
}


class BrentPizza : Irestaurant
{
    public List<string> Menu { get; set; }

    public BrentPizza()
    {
        Menu = new List<string>();
        Menu.Add("Brent's Pizza Menu");
        Menu.Add("CheesePizza $12");
        Menu.Add("Sausage Pizza $15");
        Menu.Add("Deluxe Pizza $20");
    }

    public void GetMenu()
    {
        foreach (string item in Menu)
        { Console.WriteLine(item); }
    }

    public void HoursOpen()
    { Console.WriteLine("We are open from 12pm to 11pm"); }

    public void getDirections()
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
