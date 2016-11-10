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
            Pet myPet = new Pet(dog, "Sinus");
            Person claus = new Person("Claus", 1980, myPet);

            Console.WriteLine("{0} is {1}'s pet.", claus.Pet.Name, claus.Name);
            Console.WriteLine("{0} is a {1}.", claus.Pet.Name, claus.Pet.Species.Name);
            Console.WriteLine("{0} has {1} eyes and {2} legs.", claus.Pet.Name, claus.Pet.Species.NumberOfEyes, claus.Pet.Species.NumberOfLegs);

            Species spider = new Species("Spider", 8, 8);
            Pet notMyPet = new Pet(spider, "Peter");

            Console.WriteLine("{0} is a {1}. He \"kravler op af muren\".", notMyPet.Name, notMyPet.Species.Name);
            Console.WriteLine("{0} has {1} eyes and {2} legs.", notMyPet.Name, notMyPet.Species.NumberOfEyes, notMyPet.Species.NumberOfLegs);

            Console.WriteLine("{0} is {1} years old.", claus.GetName(), claus.GetAge());
            Console.WriteLine("His pet {0} has {1} eyes.", claus.Pet.Name, claus.GetNumberOfEyesForPet());

            Person ole = new Person("Ole", "Peter", spider);

            Console.WriteLine("{0} has a pet {1}. The {1}'s name is {2}", ole.Name, ole.Pet.Species.Name, ole.Pet.Name);

            Console.ReadKey();
        }
    }
}
