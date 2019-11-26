using System;

namespace ClothesRental.Data_Layer
{
    public class Outfit
    {
        //assigning unique value of outfit
        private static int iterator = 0;
        private readonly int outfitID = 100 + iterator;
        
        private string outfitType;
        private char outfitSize;
        
        public Outfit()
        {
            iterator++;
            outfitType = "Wonder Woman";
            outfitSize = 'S';
        }

        public Outfit(char size, string type)
        {
            if (size == 'S' || size == 'M' || size == 'L')
            {
                iterator++;
                outfitSize = size;
                outfitType = type;
            }
        }

        public char getOutfitSize()
        {
            return outfitSize;
        }

        public int getOutfitID()
        {
            return outfitID;
        }
        
        public string getOutfitType()
        {
            return outfitType;
        }
    }
}    //generatory danych ?