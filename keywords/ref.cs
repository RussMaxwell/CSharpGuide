class Program
{
    static void Main(string[] args)
    {

        //by default, int is value type and passed as such
        Console.WriteLine("Example of passing int by value");
        int number = 20;
        Console.WriteLine($"Number before calling ChangeNumber() is {number}");

        ChangeNumber(number);
        //number is still 20 because it was passed by value
        Console.WriteLine($"Number after returning from ChangeNumber() is {number} because it was passed by value");
        Console.WriteLine();


        //force an int type to be passed by reference
        Console.WriteLine("Example of passing int by reference");
        int number2 = 33;
        Console.WriteLine($"Number before calling ChangeNumber2() is {number2}");
        ChangeNumber2(ref number2);
        //number2 is now 50 because it was passed by reference
        Console.WriteLine("Number after returning from ChangeNumber2() is {0} because it was passed by reference", number2);                             
    }


    //pass by value
    static void ChangeNumber(int tmpnum)
    {
        tmpnum = 50;
        Console.WriteLine($"Number within ChangeNumber() is {tmpnum}");       
    }

    //pass by reference
    static void ChangeNumber2(ref int tmpnum)
    {
        tmpnum = 50;
        Console.WriteLine($"Number within ChangeNumber() is {tmpnum}");
    }
  }
