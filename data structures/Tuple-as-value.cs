//Tuples are used when you want to group together a small, fixed number of items, possibly of different types, into a single unit.
//great for returnhing multiple values from a method without using out or ref parameters.
//Each item in a tuple has a position and can optionally have a name, and you can access items by their position or name.

//Value Tuples
//are value types and stoerd on the stack
//mutable - can change their values 
//can name your elements

using System;

class Program
{
    //making this static or would need to create instance of program class to call the method
    //that's unnecessary
    static (string, string, int) getmyDog()
    {
        var myDog = ("Rex", "pitbull", 10);
        return myDog;
    }

    //this examples uses named tuples
    static (string name, string breed, int age) getmyCat()
    {
        var myCat = ("Whiskers", "Siamese", 4);
        return myCat;
    }
        
    //example uses named tuple that takes accepts arguments
    //can think of this of creating a tuple from passed in arguments
    static (string name, string breed, int age) getmyFish(string tmpname, string tmpbreed, int tmpage)
    {
        var myFish = (tmpname, tmpbreed, tmpage);
        return myFish;
    }


    static void Main(string[] args)
    {
        //this is a value tuple
        var hmmm = getmyDog();
        Console.WriteLine(hmmm.Item1);

        //returns a named value tuple that's deconstructed
        var (catName, catBreed, catAge) = getmyCat();
        Console.WriteLine(catName);
        Console.WriteLine($"Breed: {catBreed}");
        Console.WriteLine($"Age: {catAge}");

        
        //returns a named tuple and print it out by accessing the name
        var myFish = getmyFish("Goldie", "Goldfish", 1);
        Console.WriteLine($"Hello, my name is {myFish.name} and I'm a {myFish.breed}!");
    }
}