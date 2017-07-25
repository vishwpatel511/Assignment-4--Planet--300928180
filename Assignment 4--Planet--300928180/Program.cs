using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4__Planet__300928180
{
    /*
 Name: Vishw Patel
 Student ID: 300928180
 Date Modified: July 25, 2017
 Description: Assignment 4 
 version: 0.2 Final - Created and edited Program class to display the more accurate result..
 */
    /// <summary>
    /// That's the driver class
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // creating giantPlanet object
            GiantPlanet giantPlanet = new GiantPlanet("Saturn", 116464, 5.683E16, "Gaseous");
            //67, 11.86, 4, 0.41,
            Console.WriteLine(giantPlanet.ToString());
            // Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Does the Planet has moons? " + giantPlanet.HasMoons());
            Console.WriteLine("Does the Planet has rings? " + giantPlanet.HasRings());
            Console.WriteLine("--------------------------------------------------------");


            // creating terrestrialPlanet object

            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Venus", 12104, 4.867E24, true);
            Console.WriteLine(terrestrialPlanet.ToString());
           // Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Does the Planet has moons? " + terrestrialPlanet.HasMoons());
            Console.WriteLine("Does the Planet has oxygen and is Habitable? " + terrestrialPlanet.Habitable());


            // Method calling
            WaitForAnyKey();
        }

        /// <summary>
        /// WaitForAnyKey() method to hold the console screen 
        /// </summary>
        static void WaitForAnyKey()
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Press any key to close the console...");
            Console.ReadKey();
        }
    }
}
