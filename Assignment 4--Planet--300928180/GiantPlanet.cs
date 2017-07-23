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
 Date Modified: July 22, 2017
 Description: Assignment 4 
 version: 0.2 Final - Created GiantPlanet Class

 */
 /// <summary>
 /// That's the GiantPlanet class with HasMoons() , HasRings() methods..
 /// </summary>
    public class GiantPlanet : Planet, IHasMoons, IHasRings
    {

        private string _type; // either Gaseous or fire

        // CONSTRUCTOR

        public GiantPlanet(string name, double diameter, double mass, string type) : base(name, diameter, mass)
        {
            this._type = type;
        }

        public bool HasMoons()
        {
            return this.MoonCount > 0 ? true : false;
        }

        public bool HasRings()
        {
            return this.RingCount > 0 ? true : false;
        }

    }
}



