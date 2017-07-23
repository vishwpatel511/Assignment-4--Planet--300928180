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
       Date modified: July 22, 2017
       Description: Assignment 4 
       version: 0.2 Final - Created  TerrestrialPlanet Class

  */
    public class TerrestrialPlanet : Planet
    {
        private bool _oxygen;

        // Constructor
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen) : base(name, diameter, mass)
        {
            this._oxygen = oxygen;
        }
        // Impliment the interface
        public bool HasMoons()
        {
            return this.MoonCount > 0 ? true : false;
        }

        public bool Habitable()
        {
            if (_oxygen == true)
            {
                return true;
            }
            else
            { return false; }
        }
    }
}
