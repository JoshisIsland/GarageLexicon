using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLexicon
{
    internal class Airplane : Vehicle
    {
        public int nrOfSeats;

        public Airplane(string registrationNr, string color, int modelYear, int horsePower, int nrOfSeats) : base(registrationNr, color, modelYear, horsePower)
        {
            this.nrOfSeats = nrOfSeats;
        }
    }
}
