using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLexicon
{
    internal class Boat : Vehicle
    {
        public string name;
        public Boat(string registrationNr, string color, int modelYear, int horsePower, string name) : base(registrationNr, color, modelYear, horsePower)
        {
            this.name = name;
        }
    }
}
