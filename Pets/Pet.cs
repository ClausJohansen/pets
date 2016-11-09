using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Pet
    {
        private Species species;
        private string name;

        public Pet(Species species, string name)
        {
            this.species = species;
            this.name = name;
        }

        public Species Species
        {
            get { return species; }
        }

        public string Name
        {
            get { return name; }
        }
    }
}
