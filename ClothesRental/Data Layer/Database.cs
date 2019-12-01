using System.Collections;

namespace ClothesRental.Data_Layer
{
    public interface Database
    {
        void addUser(string name, string surname, string nickname, string pswd);    //adds user to database directly
        ArrayList listOfUsers();           //return users from database.users into ArrayList
        ArrayList availableOutfitsList();  //return outfits from database.outfits into ArrayList
        ArrayList allAssortmentList();     //return the ArrayList from availableOutfitsList() and showRented()
        ArrayList showRented();            //return all outfit_id s from database.customers_list into ArrayList
        ArrayList customersList(int customer_id);         //return list of outfits rented by user into ArrayList
        void rentOutfit(int customer_id, int outfit_id);    //add new rental to database.customers_list and remove the outfit_id from database.outfits
        void giveBackOutfit(int cus_id, int outfit_id);     //removes record form database.customers_list and add outfit_id to database.outfits
    }
}