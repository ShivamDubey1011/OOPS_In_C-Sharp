using System;

/*
 * - A speial type of function/method which has the same name as its class.
 * - Invoked automatically whenever an object of a class is created .
 * - Resposible for object initialization and memory alloccation of its class members.
 * - Doesn't have a return a type, not even void type
 * - Supports overloading.
 * 
 * Types of Constructor : 1) Default
 *                        2) Parameterized
 *                        3) Static 
 *                        4) Private
 *                        
 *  1) Default Constructor : - The default constructor has no parameters
 *                             When a class has no constructor , default constructor is served by
 *                             the Compiler to the class.
 *                             Used to assign default values to instance variables of class.
 *                             
 *  2) Parameterized : - The parameterized constructor has one or more parameters .
 *                       Used to assign value to instance variable in class.
 *                       
 *  3) Static Constructor : - A special type of constructor that gets called before the first object
 *                            of the class is created.
 *                            Used to initilize any static fields, or to perform a particular action
 *                            that need to perform only once.
 *                            A clas can have only one static constructor and it must be a default
 *                            constructor, having no access modifier.
 */
namespace Cunstructor
{
    internal class Program
    {
        //declare a string 
        public string model;
        public string carName;

        //Constructor with parameter
        public Program(string value )
        {
            Console.WriteLine("hello Man");
            model = value ;
        }


        /*
         * For copy constructor
         *   we created a paramete constructor 
         *   then after that we created a constructor which will going to have object of class 
         *   and then we pass create a object of the class and pass another object inside as 
         *   its parameter 
         *   so in this way we are going to copy one custructor to another 
         */
        public Program(string para1, string para2)
        {
            model = para1;
            carName = para2;
        }

        public Program(Program program)
        {
            model = program.model;
            carName = program.carName;
        }
        
        /*
         * 
         */
        //Constructor without parameter 
        public Program()
        {
            model = "null";
        }
        
        static void Main(string[] args)
        {
            //created a object of Program Class 
            //since we are not passing any parametere so it will going to execute costructor 
            //which is not with parameter
            Program program = new Program();
            Console.WriteLine(program.model);

            //we created object of Program and passing parameter in so it will going to 
            // invoke the constructor which is with parameter 
            Program hell = new Program("happy");
            Console.WriteLine(hell.model);

            
            Program pro = new Program("2018", "BMW");
            Program obj = new Program(pro);
            Console.WriteLine(obj.model);
            Console.WriteLine(obj.carName);
        }
    }
}
