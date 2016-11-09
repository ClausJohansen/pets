using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Pet
    {
        public Species species;
        public string name;

        public Pet(Species species, string name)
        {
            this.species = species;
            this.name = name;
        }
    }
}
