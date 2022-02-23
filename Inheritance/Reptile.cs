using System;
namespace Inheritance
{
    public class Reptile : Animal
    {
        // Create a class Reptile
        // give this class 4 members that are specific to Reptile
        // Set this class to inherit from your Animal Class

        public Reptile()
        {

        }

        public bool hasScales { get; set; }
        public bool isCold_Blooded { get; set; }
        public string environment { get; set; }
        public bool hasLegs { get; set; }

        public void PrintReptile()
        {
            Console.Write("This animal has scales: ");
            Console.WriteLine(hasScales);
            Console.Write("This animal is cold-blooded: ");
            Console.WriteLine(isCold_Blooded);
            Console.Write("Does this animal live mainly on land or in water?: ");
            Console.WriteLine(environment);
            Console.Write("Does this animal have legs?: ");
            Console.WriteLine(hasLegs);
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
