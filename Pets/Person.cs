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

        public Person(string name)
        {
            this.name = name;
        }

        public Person(string name, Pet pet)
        {
            this.name = name;
            this.pet = pet;
        }

        public Person(string name, string petName, Species petSpecies)
        {
            this.name = name;
            this.pet = new Pet(petSpecies, petName);
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
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
