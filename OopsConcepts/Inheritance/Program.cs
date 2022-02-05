using System;

/*
 * Types of Inheritance 
 * 1.Single
 * 2.hierarchical
 * 3.Multi Level
 * 4.Multiple (Not possible in c#)
 * 5.Hybrid inheritance  (Not possible in c#)
 * 
 *  Single Inheritance 
 *          it is the type of inheritance in which there is one base class and derived class
 *          (ex. = Class A , Class B : A)
 *          
 *  Hierarchical Inheritance
 *          This is type of inheritance in which there are multiple classes derived  from one
 *          base class. 
 *          (ex. = Class A, Class B: A, Class C : A)
 *          
 *  Multilevel Inheritance 
 *           When one class derived from another class then this type of inheritance is called
 *           multilevel inheritance
 *           (ex. = Class A, Class B: A , Class C : B)
 *           
 *   Multiple (Not possible in c#)
 *           there can inherit features from more than one parent object or parent class .
 *           (ex. = Class A, Class B , Class C : A,B)
 */
namespace Inheritance
{
    /*
     * Base class (Parent)
     */
    class Vehicle
    {
        public string brand = "Ford";
        public void honk()
        {
            Console.WriteLine("Tuut, tutt!");

        }
        
    }
    /*
     * Derieved Class (Child)
     */
    class Car : Vehicle
    {
        public string modelName = "Mustag";
    }

    class Ford : Car
    {
        public string city = "Londan";
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car();
            car.honk();
            Console.WriteLine(car.brand);
            Console.WriteLine(car.modelName);

            Ford ford = new Ford();
            
            ford.honk();
            Console.WriteLine(ford.modelName);
            Console.WriteLine(ford.city);
        }
    }

    
}
