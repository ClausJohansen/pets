﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            Species dog = new Species("Dog", 2, 4);
            Species spider = new Species("Spider", 8, 8);

            Pet myPet = new Pet(dog, "Sinus");
            Pet notMyPet = new Pet(spider, "Peter");

            Person claus = new Person("Claus", 1980, myPet);

            Console.WriteLine("{0} is {1}'s pet.", claus.Pet.Name, claus.Name);
            Console.WriteLine("{0} is a {1}.", claus.Pet.Name, claus.Pet.Species.Name);
            Console.WriteLine("{0} has {1} eyes and {2} legs.", claus.Pet.Name, claus.Pet.Species.NumberOfEyes, claus.Pet.Species.NumberOfLegs);

            Console.WriteLine("{0} is a {1}. He \"kravler op af muren\".", notMyPet.Name, notMyPet.Species.Name);
            Console.WriteLine("{0} has {1} eyes and {2} legs.", notMyPet.Name, notMyPet.Species.NumberOfEyes, notMyPet.Species.NumberOfLegs);

            Console.WriteLine("{0} is {1} years old.", claus.getName(), claus.getAge());
            Console.WriteLine("His pet {0} has {1} eyes.", claus.Pet.Name, claus.getNumberOfEyesForPet());

            Console.ReadKey();
        }
    }
}
