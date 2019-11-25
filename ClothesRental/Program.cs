using System;
using ClothesRental.Logic_Layer;

namespace ClothesRental
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iguśka");
            
//            Outfit ou = new Outfit();
//            Console.WriteLine(ou.getOutfitID());
//            Console.WriteLine(ou.getOutfitSize());
//
//            Outfit ofeu = new Outfit();
//            //ofeu.setOutfitName();
//            Console.WriteLine(ofeu.getOutfitID());
//            Console.WriteLine(ofeu.getOutfitSize());
            
            //Customer c = new Customer("Igo", "Napoli", "igi", "1234");
            Logic logic = new Logic();
            logic.app();
        }
    }
}