//Tuples are used when you want to group together a small, fixed number of items, possibly of different types, into a single unit.

//Object Tuple
    //are reference types and stored on the heap
    //immutable - can't add elements to a tuple after it's created
        //you can't change tuple elements/values post creation
    //cannot name your elements like you can with value tuples
    //recommneded to use over value tuples when working with Large tuples (Heap) or as keys in a dictionary

using System;

class Program
{
    //making this static or would need to create instance of program class to call the method
    //that's unnecessary
    static Tuple <string, string, int> getmyDog()
    {
        Tuple<string, string, int> myDog = new("Rex", "Bulldog", 5);
        return myDog;
    }
        

    //example uses named tuple that takes accepts arguments
    //can think of this of creating a tuple object from passed in arguments
    static Tuple<string, string, int> getmyFish(string tmpname, string tmpbreed, int tmpage)
    {
        Tuple<string, string, int> myFish = new(tmpname, tmpbreed, tmpage);        
        return myFish;
    }
     

    static void Main(string[] args)
    {
        //receiving a tuple and printing it out
        var hmmm = getmyDog();
        Console.WriteLine($"My name is {hmmm.Item1} and I'm a {hmmm.Item2}.");

        
        //returns an object tuple and prints it out
        var myFish = getmyFish("Goldie", "Goldfish", 1);
        Console.WriteLine($"Hello, my name is {myFish.Item1} and I'm a {myFish.Item2}!");
    }
}
