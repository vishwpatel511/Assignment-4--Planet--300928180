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
  version: 0.2 Final - Created Abstract Planet Class

  */
    /// <summary>
    /// That's the abstarct Planet class
    /// </summary>
    public abstract class Planet
    {
        // PRIVATE INSTANCE VARIABLES
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;

        // PUBLIC PROPERTIES

        public double Diameter
        {
            get
            {
                return this._diameter;

            }


        }
        public double Mass
        {
            get
            {
                return this._mass;
            }
        }
        public int MoonCount
        {
            get
            {
                return this._moonCount;
            }
            set
            {
                this._moonCount = value;
            }
        }
        public string Name
        {
            get

            {
                return this._name;
            }
        }
        public double OrbitalPeriod
        {
            get
            {
                return this._orbitalPeriod;
            }
            set
            {
                this._orbitalPeriod = value;
            }
        }

        public int RingCount
        {
            get
            {
                return this._ringCount;
            }
            set
            {
                this._ringCount = value;
            }
        }
        public double RotationPeriod
        {
            get
            {
                return this._rotationPeriod;
            }
            set
            {
                this._rotationPeriod = value;
            }
        }
        // CONSTRUCTOR
        // which takes three parameteres name, diameter, mass --------------------------------
        public Planet(string name, double diameter, double mass)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;


        }
        // Override ToString() Method.
        // It returns name, diameter and mass
        public override string ToString()
        {
            return "Name of the planet: " + Name + " diameter(in kms): " + Diameter + " mass(in pound): " + Mass;

        }
    }

}
// Final version
// End of Abstract Planet class
