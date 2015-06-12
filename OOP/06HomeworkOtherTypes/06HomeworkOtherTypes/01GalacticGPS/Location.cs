using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01GalacticGPS
{
    struct Location
    {
        private double latitude;
        private double longtitude;

        public Location(double latitude, double longtitude, Planet planet) : this()
        {
            this.Latitude = latitude;
            this.Longtitude = longtitude;
            this.PlanetName = planet;
        }

        public double Latitude
        {
            get
            {
                return this.latitude;
            }
            set
            {
                if (value < -180 || value > 180)
                {
                    throw new ArgumentOutOfRangeException("value", "Latitude must be between -90 and 90 degrees.");
                }
                this.latitude = value;
            }
        }
        public double Longtitude
        {
            get
            {
                return this.longtitude;
            }
            set
            {
                if (value < -180 || value > 180)
                {
                    throw new ArgumentOutOfRangeException("value","Longtitude must be between -180 and 180 degrees.");
                }
                this.longtitude = value;
            }
        }
        public Planet PlanetName { get; set; }

        public override string ToString()
        {
            return String.Format("{0}, {1} - {2}",this.Latitude,this.Longtitude,this.PlanetName);
        }
    }
}
