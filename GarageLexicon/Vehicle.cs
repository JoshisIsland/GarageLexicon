using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLexicon
{
    internal class Vehicle
    {
        public string registrationNr;
        public string color;
        public int modelYear;
        public int horsePower;

    public Vehicle(string registrationNr, string color, int modelYear, int horsePower) 
        {
            this.registrationNr = registrationNr;
            this.color = color;
            this.modelYear = modelYear;
            this.horsePower = horsePower;
        }




    }
}
