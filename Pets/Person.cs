using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Person
    {
        private string name;
        private int birthYear;
        private Pet pet;

        public Person(string name, int birthYear, Pet pet)
        {
            this.name = name;
            this.birthYear = birthYear;
            this.pet = pet;
        }

        public string Name
        {
            get { return name; }
        }

        public int BirthYear
        {
            get { return birthYear; }
        }

        public Pet Pet
        {
            get { return pet; }
        }

        public string GetName()
        {
            return name;
        }

        public int GetAge()
        {
            return DateTime.Now.Year - BirthYear;
        }

        public int GetNumberOfEyesForPet()
        {
            return pet.Species.NumberOfEyes;
        }
    }
}
