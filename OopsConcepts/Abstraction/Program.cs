using System;
/*
 * Data Abstraction is the process of hiding certain details and showing only essential information
 * to the user. Abstraction can be achieved with either abstract class or interfaces.
 * The abstract keyword is used for classes and methods:
 *          Abstract class: is a restricted class that cannot be used to create 
 *                          objects (to access it, it must be inherited from another class).
 *                          
 *          Abstract method:can only be used in an abstract class, and it does not have a body. 
 *                          The body is provided by the derived class (inherited from).
 *                          
 *  An abstract class can have both abstract and regular methods:
 */
namespace Abstraction
{
    abstract class Vehical
    {
        
    }
    abstract class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
