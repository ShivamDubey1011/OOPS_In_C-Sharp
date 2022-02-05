using System;
/*
 * Type Of AccessModifiers  
 *  1-Private               
 *  2-Protected
 *  3-Internal
 *  4-Internal Protected
 *  5-Public
 */
namespace AccessModifiers
{
    internal class Program
    {
        //created a private string 
        private string name = "Shivam";
        //created a protected string
        protected string name1 = "Dubey";
        //created a public string 
        public string name2 = "Happy";

        internal string Country = "India";

        protected internal string State = "Maharashtra";

        static void Main(string[] args)
        {
            Program program = new Program();

            /*
             * all private , protected and public can called on same class;
             */
            Console.WriteLine(program.name);
            Console.WriteLine(program.name1);
            Console.WriteLine(program.name2);
            Console.WriteLine(program.Country);
            Console.WriteLine(program.State);

            First first = new First();
            first.Main();

            Another another = new Another();
            another.Main();

        }
    }

    class First
    {
        public void Main()
        {
            Program program = new Program();
            /*
             * Private is not accessable in another class
             * Protected is only accessable in class which is inherite from same class
             * Only public can be accessable here 
             */
            //Console.WriteLine(program.name); // Private is not accessable        
            //Console.WriteLine(program.name1); //Protected is not accessable
            Console.WriteLine(program.name2);
            Console.WriteLine(program.Country);
            Console.WriteLine(program.State);

        }

    }

    class Another : Program
    {
        public void Main()
        {


            Another another = new Another();
            Console.WriteLine(another.name1);
            Console.WriteLine(another.name2);
        }
    }


}
