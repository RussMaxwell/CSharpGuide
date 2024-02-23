/*
Arrays store multiple values of the same type.  
They are a fixed size and are zero indexed.
Arrays are reference types and stored on the heap.
*/

////////////////////
//Declaring Arrays//
////////////////////

//fixed size with no values
int[] numbers1 = new int[5];

//2 options - declare arrays with values. Both accomplish the same thing
//Option 1
int[] numbers2 = new int[5] {6, 7, 8, 9, 10};

//Option 2
int[] numbers3 = [11, 12, 13, 14, 15];



///////////////////////////////////
//Common Array Properties/Methods//
//////////////////////////////////

//Length property
int arrLen = numbers1.Length;

//IndexOf() method
int index = Array.IndexOf(numbers1, 7);

//sort method (ascending)
Array.Sort(numbers1);

//sort method (descending)
Array.Reverse(numbers1);



//////////////////////////////////////
//Assigning Values to Array Elements//
//////////////////////////////////////

//manually 
numbers1[0] = 1;
numbers1[1] = 2;

//automated via looping
for (int i = 0; i < numbers1.Length; i++)
{numbers1[i] = i + 1;}




////////////////////////////////////
//Writing array values to console//
////////////////////////////////////

//write values manually
Console.WriteLine(numbers1[0]);
Console.WriteLine(numbers1[1]);


//write values via looping
for (int i = 0; i < numbers1.Length; i++)
{Console.WriteLine(numbers1[i]);}


//write values using string.Join()
Console.WriteLine(string.Join(", ", numbers1));