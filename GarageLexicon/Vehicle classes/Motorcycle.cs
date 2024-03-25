using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLexicon
{
    internal class Motorcycle : Vehicle
    {
        public string modelType;
        public Motorcycle(string registrationNr, string color, int modelYear, int horsePower, string modelType) : base(registrationNr, color, modelYear, horsePower)
        {
            this.modelType = modelType;
        }
    }
}
