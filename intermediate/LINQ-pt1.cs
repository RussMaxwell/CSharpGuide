/*
    LINQ is a powerful feature of C# that allows for querying collections of objects.
    It is a great way to filter, sort, and manipulate data in a collection.
    The following code demonstrates how to use LINQ to query a collection of Hobby objects.
*/

using System.Linq;

class Hobby
{
    public int? Id { get; set; }
    public string? Name { get; set; }

    public Hobby(int tmpid, string tmpname)
    {
        Id = tmpid;
        Name = tmpname;
    }
 }


class Program
{
    static void Main(string[] args)
    {

        Hobby[] hobbies = [new(1, "baseball"),new(2, "football"),new(3, "soccer")];

        //lambda syntax and returns a list of elementsback
        var hobby1 = hobbies.Where(h => $"{h}".Equals("baseball"));

        //lambda syntax and returns a list of elements back
        var hobby2 = hobbies.Where(h => h.Id > 1);

        //can also skip elements and return a list of elements back
        var skiphobby = hobbies.Skip(1);

        //lambda syntax and returns a desired element property back as list 
        var hobby3 = hobbies.Where(h => $"{h}".Equals("baseball")).Select(h => h.Name);

        //query syntax and returns a list back with a specific element/s
        var hobby4 = from h in hobbies where h.Name.Equals("football") select h;

        //query syntax using lambda to retrieve specific element property
        var hobby5 = from h in hobbies where h.Name.Equals("soccer") select h.Name;

        //skipping the first hobby and taking the second one
        var hobby6 = hobbies.Skip(1).Take(1);

        //print out hobby2 results
        foreach (var h in hobby2)
        {
            Console.WriteLine(h.Name);
        }
    }
}