using System;

namespace Robotterne_kommer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //school assignment about constructors
            //makes 3 objects whit the constructors
            Robots r = new Robots("white", "chip", "wifi", "battery", "soap", 0, ModelName.Romba);

            Robots r2 = new Robots("white", "chip", "wifi", "battery", "soap", 0, ModelName.WindowCleaner );

            Robots r3 = new Robots("white", "chip", "wifi", "battery", "soap", 0, ModelName.Tire);

            //write out the result to the console
            Console.WriteLine(r);
            Console.WriteLine(r2);
            Console.WriteLine(r3);
        }
    }
}
