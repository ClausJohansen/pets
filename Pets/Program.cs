using System;
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

            Console.WriteLine("{0} is {1}'s pet.", claus.pet.name, claus.name);
            Console.WriteLine("{0} is a {1}.", claus.pet.name, claus.pet.species.name);
            Console.WriteLine("{0} has {1} eyes and {2} legs.", claus.pet.name, claus.pet.species.numberOfEyes, claus.pet.species.numberOfLegs);


            Console.WriteLine("{0} is a {1}. He \"kravler op af muren\".", notMyPet.name, notMyPet.species.name);
            Console.WriteLine("{0} has {1} eyes and {2} legs.", notMyPet.name, notMyPet.species.numberOfEyes, notMyPet.species.numberOfLegs);

            Console.ReadKey();
        }
    }
}
