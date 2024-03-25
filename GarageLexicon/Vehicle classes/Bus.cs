using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLexicon
{
    internal class Bus : Vehicle
    {
        public int nrOfSeats;
        public Bus(string registrationNr, string color, int modelYear, int horsePower, int nrOfSeats) : base(registrationNr, color, modelYear, horsePower)
        {
            this.nrOfSeats = nrOfSeats;
        }
    }
}
