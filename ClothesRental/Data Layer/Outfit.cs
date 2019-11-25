

//generatory danych ?


using System;

namespace ClothesRental.Data_Layer
{
    public class Outfit
    {
        private static int iterator = 0;
        private readonly int outfitID = 100 + iterator;
//        private enum outfitType
//        {
//            Cowboi, SadGirl, Emosy, BuzzAstral 
//        }
        private string outfitType;
        private enum outfitSize
        {
            XS = 34, S = 36, M = 38 
        }

        public Outfit()
        {
            iterator++;
            outfitType = "jojo";
        }

        public Outfit(String size)
        {
            setOutfitSize(size);
        }

        public int getOutfitID()
        {
            return outfitID;
        }
        
        public string getOutfitType()
        {
            return outfitType;
        }

        public int getOutfitSize()
        {
            return 0;
        }

        public int setOutfitSize(string size)
        {
            if (size == "S")
            {
                outfitSize value = outfitSize.S;
                return 1;
            }     
            else if (size == "M")
            {
                outfitSize value = outfitSize.M;
                return 1;
            } 
            else if (size == "XS")
            {
                outfitSize value = outfitSize.XS;
                return 1;
            }
            else return 0;
        }
    }
}