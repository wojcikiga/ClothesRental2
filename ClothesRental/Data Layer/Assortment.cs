using System.Collections;

namespace ClothesRental.Data_Layer
{
    public class Assortment
    {
        private ArrayList assortmentList = new ArrayList();
        
        public void addOutfit(Outfit ou)
        {
            assortmentList.Add(ou);
        }
        
        public int removeOutfit(Outfit ou)
        {
            if (!assortmentList.Contains(ou)) return 0;
            assortmentList.Remove(ou);
            return 1;
        }
        
        public void fillAssortment(ArrayList list)
        {
            assortmentList.Clear();
            assortmentList = list;
        }

        public ArrayList getAssortment()
        {
            return assortmentList;
        }





    }
}