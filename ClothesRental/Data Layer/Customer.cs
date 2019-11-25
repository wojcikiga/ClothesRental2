using System.Collections;

namespace ClothesRental.Data_Layer
{
    public class Customer
    {
        private static int iterator = 0;
        private readonly int customerID = 3000+iterator;
        private readonly string customerName;
        private readonly string customerSurname;
        private readonly string nick;
        private readonly string password;
        private ArrayList outfitList = new ArrayList();
        
        public Customer(string name, string surname, string nickname, string pswd)
        {
            customerName = name;
            customerSurname = surname;
            nick = nickname;
            password = pswd;
            iterator++;
        }
        
        public Customer(string nickname, string pswd)
        {
            nick = nickname;
            password = pswd;
            iterator++;
        }

        public ArrayList getOutfitList()
        {
            return outfitList;
        }

        public void setOutfitList(ArrayList list)
        {
            outfitList.Clear();
            outfitList = list;
        }
        public void addToOutfitList(Outfit ou)
        {
            outfitList.Add(ou);
        }

        public int removeFromOutfitList(Outfit ou)
        {
            if (!outfitList.Contains(ou)) return 0;
            outfitList.Remove(ou);
            return 1;
        }

        public int getID()
        {
            return customerID;
        }
        
        public string getName()
        {
            return customerName;
        }
        public string getSurname()
        {
            return customerSurname;
        }

        public string getNickname()
        {
            return nick;
        }

        public string getPassword()
        {
            return password;
        }
    }
}