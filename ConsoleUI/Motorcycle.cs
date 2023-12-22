using System;
namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {



        /* 
                     * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
                     * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
                     * Provide the implementations for the abstract methods
                     * Only in the Motorcycle class will you override the virtual drive method
                    */
        public override void DriveAbstract()
        {
            Console.WriteLine("Motorcycle has 2 tires");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Motorcyle has turbo");
        }

        public override void ListOfProperties()
        {
            Console.WriteLine($"This motorcycle is a {Year} {Make} {Model}.");
        }
    }
}

