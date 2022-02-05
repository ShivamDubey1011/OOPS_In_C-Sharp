using System;

namespace Properties
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Test test = new Test();
            test.Name = "happy";
            Console.WriteLine(test.Name);
            
        }
    }

    class Test
    {
        //we created a private field name with name
        private string name;

        //we are creating property of Name 
        public string Name
        {
            //get is use for returning value ;
            get { return name; }

            //set is  use for Setting value ;
            set { name = value; }
        }
    }
}
