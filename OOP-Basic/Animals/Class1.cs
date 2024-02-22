namespace Animals
{
    //Dog must be set as public to be used in other projects
    public class Dog
    {
        string Name { get; set; }
        string Breed { get; set; }
        string Age { get; set; }

        public Dog(string tmpname, string tmpbreed, string tmpage)
        {
            this.Name = tmpname;
            this.Breed = tmpbreed;
            this.Age = tmpage;
        }

        //public so it can be called outside of project 
        public void Bark()
        {
            Console.WriteLine($"{Name} goes roof roof!");
            Details();
        }

        //only want this class to execute this function
        internal void Details()
        {
            Console.WriteLine($"{Name} is a {Breed} and {Age} years old!");
        }

    }
}
