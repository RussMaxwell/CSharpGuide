////////////
//For Loop//
////////////
Console.WriteLine("Printing Numbers");
for(int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}


Console.WriteLine();
int mynum = 0;


/////////////////
//For Each Loop//
/////////////////
Console.WriteLine("Printing Names");
string[] names = { "John", "Rachel", "Brent" , "Scott"};

foreach (string nam in names)
{
    Console.WriteLine(nam);
}



//////////////
//While Loop//
//////////////
while (mynum != 5)
{
    Console.WriteLine("Enter any number other than 5:");
    var input = Console.ReadLine();
    bool anum = int.TryParse(input, out mynum);

    if (anum && mynum != 5)
    {
        Console.WriteLine($"You entered {mynum}");
    }

    else if (anum && mynum == 5)
    {
        Console.WriteLine("You entered 5, exiting out of while loop");
    }
    else
    {
        Console.WriteLine("Invalid number, try again");
    }
 }




/////////////////
//Do While Loop//
/////////////////

string input2;

do
{ 
    Console.WriteLine("Enter anything to keep do while loop alive:");
    input2 = Console.ReadLine(); 
} while (!string.IsNullOrEmpty(input2));

















