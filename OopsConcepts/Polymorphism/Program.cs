using System;

/*
 *Method Overloading ->
 *All the method should have Same name
 *All the method should be in Same class
 *But Method Should have Different parameters
 *                      Different Type of Parameters
 *                      Different Numbers of parameters
 *                      Different Sequence of Parameters
 *                      
 *Method Overriding   (Polymorphism)
 *  All the Method Should have Same Name
 *  All the Method Should be in Different Class
 *  But the Method should have same Parameters
 *                        Same Type of parameters 
 *                        Same Numbers of parameters
 *                        Same Sequece of Parametes 
 *  There should be Inheritance Between Classes
 *  
 *  Type of Polymorphims : 
 *  1) Compile Time Polymorphism (Early Binding or Overloading or static binding)[Static Polymorphism].
 *  2) Runtime polymorphism (Late Binding or Overriding or dynamic binding)[Dynamic Polymorphism b].
 *
 */



namespace Polymorphism
{
    /*
     * 1)Compile Time Polymorphism(Overloading) :-Compile time polymorphism means we will declare a method 
     *                               with same name and different parameter/signature because 
     *                               of this we will perform different tasks with same method
     *                               name in the same class is called compile time polymorphism.
     */

    class Arithmetic
    {

        public void Sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Sum(double a, double b)
        {
            Console.WriteLine(a + b);
        }

        public void Sum()
        {
            Console.WriteLine("NO parameter is required");
        }
    }


    /*
     * 2). Runtime polymorphism (Late Binding or Overriding or dynamic binding)
     *              Runtime polymorphism means we will declare a method with same name and same
     *              parameter/signature in the different class is called runtime polymorphism.
     */

    class Program
    {
        static void Main(string[] args)
        {


            /*Compile Time Polymorphism(Overloading)
             */
            Arithmetic arithmetic = new Arithmetic();
            arithmetic.Sum(2, 3); //as we are passing int so this will going to execute int mehtod 
            arithmetic.Sum(2.5, 5.8);//as we are passing double value so method which having this parameter will going to called
            arithmetic.Sum();// as we are not passing parameter so it's will going to call parameter less method .



            /*
             * Runtime polymorphism (overriding)
             */
            Vehicle car = new Car();
            Vehicle bycycle = new Bycycle();
            Vehicle boat = new Boat();

            car.Go();
            //car.Go();
            //bycycle.Go();
            //boat.Go();
            //Vehicle[] vehicles = { car, bycycle, boat };
            //foreach (Vehicle vehicle in vehicles)
            //    vehicle.Go();



        }
    }

    class Vehicle
    {
        public  virtual void Go()
        {
            Console.WriteLine("Vehicles are moving!");
        }
    }

    class Car : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("Car is moving!");
        }
    }

    class Bycycle : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("Bycycle is moving!");
        }
    }
    class Boat : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("Boat is moving!");
        }
    }
}
