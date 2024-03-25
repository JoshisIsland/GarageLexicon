using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLexicon
{
    internal class Car : Vehicle
    {
        public string brand;
        public string fuelType;
        public Car(string registrationNr, string color, int modelYear, int horsePower, string brand, string fuelType) : base(registrationNr, color, modelYear, horsePower)
        {
            this.brand = brand;
            this.fuelType = fuelType;
        }
    }
}
