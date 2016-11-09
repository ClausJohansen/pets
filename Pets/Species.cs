using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    public class Species
    {
        public string name;
        public int numberOfEyes;
        public int numberOfLegs;

        public Species(string name, int numberOfEyes, int numberOfLegs)
        {
            this.name = name;
            this.numberOfEyes = numberOfEyes;
            this.numberOfLegs = numberOfLegs;
        }
    }
}
