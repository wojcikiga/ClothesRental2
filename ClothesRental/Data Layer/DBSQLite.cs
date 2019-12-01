using System.Collections;

namespace ClothesRental.Data_Layer
{
    public class DBSQLite : Database
    {
        public void addUser(string name, string surname, string nickname, string pswd)
        {
            //adds user to database directly
        }

        public ArrayList listOfUsers()
        {
            
            //return users from database.users into ArrayList
            
            
            ArrayList ar = new ArrayList();
            //for (int i = 0; i = (SELECT MAX(customers_id) FROM customers) -1; i++) 
            //{ar.Add(SELECT customer_id FROM customers WHERE customer_id = ((SELECT MIN(customer_id) FROM customers)+i))}
            return ar;
        }

        public ArrayList availableOutfitsList()
        {
            //return outfits from database.outfits into ArrayList
            
            ArrayList ar = new ArrayList();
            return ar;
        }

        public ArrayList allAssortmentList()
        {
            //return the ArrayList from availableOutfitsList() and showRented()
            
            ArrayList ar = new ArrayList();
            return ar;
        }

        public ArrayList showRented()
        {
            //return all outfit_id s from database.customers_list into ArrayList
            
            ArrayList ar = new ArrayList();
            return ar;
        }

        public ArrayList customersList(int customer_id)
        {
            //return list of outfits rented by user into ArrayList        

            ArrayList ar = new ArrayList();
            return ar;
        }

        public void rentOutfit(int customer_id, int outfit_id)
        {
            //add new rental to database.customers_list and remove the outfit_id from database.outfits
        }
    }
}