/*
Lists store multiple values of different types.  
They can be dynamically sized (means you can create a lists and add elements to it as you go).
Lists are reference types and stored on the heap.
*/

/////////////////
//Create Lists //
/////////////////

//empty list containing integers
List<int> numbers1 = new List<int>();

//create list with values of different types
List<object> numbers2 = new List<object> {1, "one", 2, "two", 3, "three"};


//extend list by adding three values
numbers1.Add(10);
numbers1.Add(20);
numbers1.Add(30);

//add an int to numbers2 list
numbers2.Add(4);

//remove last element from list
numbers2.RemoveAt(numbers2.Count - 1);

//remove first element from list
numbers2.RemoveAt(0);


///////////////////////////
//List Properties/Methods//
///////////////////////////

//Length property
int listLen = numbers1.Count;

//IndexOf() method
int index = numbers1.IndexOf(20);

//sort method (ascending)
numbers1.Sort();

//sort method (descending)
numbers1.Reverse();


//////////////////
//Looping  Lists//
//////////////////

//loop through list and write values to console
foreach (int number in numbers1)
{Console.WriteLine(number);}

//add 1 to each element in the list
for (int i = 0; i < numbers1.Count; i++)
{numbers1[i] += 1;}


//////////////////////////////////
//Writing list values to console//
//////////////////////////////////

Console.WriteLine(numbers1[0]);

//write values using string.Join()
Console.WriteLine(string.Join(", ", numbers1));