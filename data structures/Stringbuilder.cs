using System.Text;

class Program
{
    static void Main(string[] args)
    {
        //string builder recommended for working with strings
        StringBuilder sb = new StringBuilder();
        sb.Append("Hello, ");
        sb.Append("how are ");
        sb.Append("you doing?");

        Console.WriteLine(sb.ToString());
    }
}
