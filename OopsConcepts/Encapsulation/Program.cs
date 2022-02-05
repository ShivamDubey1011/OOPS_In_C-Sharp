using System;
/*
 * 1) A mechanism of binding the object state (fields) and behavior(methods) together into a 
 *     single unit.
 * 2) The encapsulation is mainly achieved by creating classes.
 * 3) The class is a kind of a container or capsule, which encapsulate the set of fields and methods
 * How to Achieve Encapsulation
 *  Step 1: Declare the variable of class as private.
 *  Step 2: Provide public setter and getter methods to modify and view the variables values 
 */
//Note properties are combination of Field and Methods 
namespace Encapsulation
{
    class Account
    {
        //step 1 
        private int accountBalance = 1000;
        public int AccountBalance
        {
            get { return accountBalance; }
            set {
                if (value < 0)
                {
                    Console.WriteLine("entered amount is less than 0");
                }
                else
                    accountBalance = value;
            }
        }
        public string name = "Shivam";
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            account.AccountBalance = 1000;
            account.name= "happy";

        }
    }
}
