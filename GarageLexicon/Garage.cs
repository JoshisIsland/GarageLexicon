using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLexicon
{
    internal class Garage<T> : IEnumerable
    {
        private Vehicle[] vehicles;
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
