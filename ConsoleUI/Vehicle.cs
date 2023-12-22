using System;
namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public int Year { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }

        public abstract void DriveAbstract();
        

        public virtual void DriveVirtual()
        {
            Console.WriteLine("stock model");
        }

        public abstract void ListOfProperties();
    }


}

/*
         * Create an abstract class called Vehicle
         * The vehicle class shall have three string properties: Year, Make, and Model
         * Set the defaults of the properties to something generic in the Vehicle class
         * Vehicle class shall have an abstract method called DriveAbstract with no implementation.
         * Vehicle class shall have a virtual method called DriveVirtual with a base implementation.
         */