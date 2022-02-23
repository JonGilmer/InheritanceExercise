using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Bird emu = new Bird();
            emu.usesSexualReproduction = true;
            emu.isMulticellular = true;
            emu.isHeterotrophic = true;
            emu.hasSensoryOrgans = true;
            emu.hasBeak = true;
            emu.hasFeathers = true;
            emu.hasWings = true;
            emu.canFly = true;

            Console.WriteLine($"-------- Emu --------");
            emu.PrintAnimal();
            emu.PrintBird();


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            Reptile viper = new Reptile();
            viper.usesSexualReproduction = true;
            viper.isMulticellular = true;
            viper.isHeterotrophic = true;
            viper.hasSensoryOrgans = true;
            viper.isCold_Blooded = true;
            viper.hasScales = true;
            viper.hasLegs = false;
            viper.environment = "Land";

            Console.WriteLine($"-------- Viper --------");
            viper.PrintAnimal();
            viper.PrintReptile();
        }
    }
}
