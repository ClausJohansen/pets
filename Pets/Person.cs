using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Person
    {
        public string name;
        public int birthYear;
        public Pet pet;

        public Person(string name, int birthYear, Pet pet)
        {
            this.name = name;
            this.birthYear = birthYear;
            this.pet = pet;
        }
    }
}
