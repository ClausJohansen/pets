using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    public class Species
    {
        private string name;
        private int numberOfEyes;
        private int numberOfLegs;

        public Species(string name, int numberOfEyes, int numberOfLegs)
        {
            this.name = name;
            this.numberOfEyes = numberOfEyes;
            this.numberOfLegs = numberOfLegs;
        }

        public string Name
        {
            get { return name; }
        }

        public int NumberOfEyes
        {
            get { return numberOfEyes; }
        }

        public int NumberOfLegs
        {
            get { return numberOfLegs; }
        }
    }
}
