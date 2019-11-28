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
        
    }
}