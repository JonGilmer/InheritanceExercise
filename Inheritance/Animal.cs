using System;
namespace Inheritance
{
    public class Animal
    {
        // Create a class Animal
        // give this class 4 members that all Animals have in common

        public Animal()
        {

        }

        public bool usesSexualReproduction { get; set; }
        public bool isMulticellular { get; set; }
        public bool isHeterotrophic { get; set; }
        public bool hasSensoryOrgans { get; set; }

        public void PrintAnimal()
        {
            Console.Write("This animal utilizes sexual reproduction: ");
            Console.WriteLine(usesSexualReproduction);
            Console.Write("This animal is made up of multiple cells: ");
            Console.WriteLine(isMulticellular);
            Console.Write("This animal is heterotrophic and cannot create its own energy: ");
            Console.WriteLine(isHeterotrophic);
            Console.Write("This animal has sensory organs such as eyes: ");
            Console.WriteLine(hasSensoryOrgans);
        }
    }
}
