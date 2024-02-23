class Program
{
    static void Main(string[] args)
    {
        //String Compairson
        string name1 = "John";
        string name2 = "Brent";
        bool areEqual = name1.Equals(name2);
        Console.WriteLine($"Are the names the same? Answer: {areEqual}");

        
        //String Formatting
        string part1 = "This is part 1";
        string part2 = "This is part 2";
        string bothparts = string.Format("{0} and {1}", part1, part2);
        Console.WriteLine($"{bothparts}");


        //Adding Strings
        string allparts = part1 + " " + part2 + " " + "This is part 3";
        Console.WriteLine($"{allparts}");

        //String Interpolation
        string part3 = "This is part 3";
        string allParts2 = $"{part1} {part2} {part3}";
        Console.WriteLine($"{allParts2}");
        
        //String Concatenation
        string allParts3 = string.Concat(part1, part2, part3);
        Console.WriteLine($"{allParts3}");


        //String Length
        int stringLength = allparts.Length;
        Console.WriteLine($"The length of the string is: {stringLength}");


        //get index location of a character
        int index = allparts.IndexOf("part 2");
        Console.WriteLine($"Index of part 2: {index}");


        //String Substring
        string subString = allparts.Substring(14, 16);
        Console.WriteLine($"Retrieve substring from string: {subString}");


        //change casing
        string upperCase = allparts.ToUpper();
        string lowerCase = allparts.ToLower();
        Console.WriteLine($"Uppercase: {upperCase}");
        Console.WriteLine($"Lowercase: {lowerCase}");


        //empty string
        string option1 = "";
        string option2 = string.Empty;


        //replace text within a string
        string myName = "Russ is my name";
        string newName = myName.Replace("Russ", "Brent");
        Console.WriteLine(myName);
        Console.WriteLine(newName);


        //convert string to int
        string randomnumber = "492";
        string notreallyanumber = "not going to work";

        if (int.TryParse(randomnumber, out int actualnum1))
        {
            Console.WriteLine($"Converted to int: {actualnum1}");
        }
       else
        {
            Console.WriteLine($"Could not convert {randomnumber} to int");
        }

        if (int.TryParse(notreallyanumber, out int actualnum2))
        {
            Console.WriteLine($"Converted to int: {actualnum2}");
        }

        else
        {
            Console.WriteLine($"Could not convert {notreallyanumber} to int");
        }
    }
}
