using System;
namespace Inheritance
{
    public class Bird : Animal
    {
        // Create a class Bird
        // give this class 4 members that are specific to Bird
        // Set this class to inherit from your Animal Class

        public Bird()
        {

        }

        public bool hasWings { get; set; }
        public bool hasFeathers { get; set; }
        public bool hasBeak { get; set; }
        public bool canFly { get; set; }

        public void PrintBird()
        {
            Console.Write("This animal has wings: ");
            Console.WriteLine(usesSexualReproduction);
            Console.Write("This animal has feathers: ");
            Console.WriteLine(isMulticellular);
            Console.Write("This animal has a beak: ");
            Console.WriteLine(isHeterotrophic);
            Console.Write("Does this animal fly?: ");
            Console.WriteLine(hasSensoryOrgans);
            Console.WriteLine("");
            Console.WriteLine("");
        }

    }
}
