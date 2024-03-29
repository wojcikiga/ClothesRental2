using System;
using System.Collections;
using System.Globalization;
using System.Net.Mime;
using ClothesRental.Data_Layer;

namespace ClothesRental.Logic_Layer
{
    public class Logic
    {
        Database db = new DBSQLite();
        
        public void app()
        {

            //db.open();
            
            startScreen();
        }

        public void startScreen()
        {
            string read = "";
            
            Console.Clear();
            Console.WriteLine("    || CLOTHES RENTAL ||    ");
            Console.WriteLine("\tc - create new account");
            Console.WriteLine("\tl - log in");
            Console.WriteLine("\t1 - show list of customers");
            Console.WriteLine("\t2 - show list of all outfits");
            Console.WriteLine("\t3 - show list of available outfits");
            Console.WriteLine("\t4 - show all rented items");
            Console.WriteLine("\te - exit");

            read = Console.ReadLine();

            if (read == "c") register();
            else if (read == "l") logInScreen();
            else if (read == "1") showCustomers();
            else if (read == "2") showAllAssortment();
            else if (read == "3") showAvailableOutfits();
            else if (read == "4") showRented();
            else if (read == "e") endProgram();
        }
        
        public void logInScreen()
        {
            string nick = "";
            string pswd = "";
            
            Console.Clear();
            Console.Write("Enter your nick: ");
            nick = Console.ReadLine();
            Console.Write("Enter your password: ");
            pswd = Console.ReadLine();
            
            
            logIn(nick, pswd);
            
        }
        
            public void logIn(string nick, string pssswd)
            {
                Customer customer = new Customer(nick, pssswd);
                Console.Clear();
                Console.WriteLine("great!");
                System.Threading.Thread.Sleep(1500);
                userScreen(customer);
            }
        
        public void register()
        {
            string name = "";
            string surname = "";
            string nickname = "";
            string pswd = "";
            
            Console.Clear();
            Console.WriteLine("WELCOME TO CLOTHES RENTAL");
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            
            Console.Write("Enter your surname: ");
            surname = Console.ReadLine();
            
            Console.Write("Enter your nick: ");
            nickname = Console.ReadLine();
            
            Console.Write("Enter your password: ");
            pswd = Console.ReadLine();
            
            Customer customer = new Customer(name, surname, nickname, pswd);
            db.addUser(name, surname, nickname, pswd);
            
            userScreen(customer);
        }

        public void userScreen(Customer customer)
        {
            Console.Clear();
            //if (customer.getOutfitList().Count == 0)
            if (db.customersList(customer.getID()).Count == 0)
            {
                string read = "";
                Console.WriteLine("Your rental list is empty");
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("\tr - rent an outfit");
                Console.WriteLine("\t1 - log out");
                Console.WriteLine("\t2 - exit");

                read = Console.ReadLine();
                if(read == "r") rentScreen(customer);
                else if (read == "1") logOut();
                else if (read == "2") endProgram();
            }
            else
            {
                string read = "";
                Console.WriteLine("Your rental list: ");
                customer.setOutfitList(db.customersList(customer.getID()));
                displayCustomerList(customer);
                
                Console.WriteLine("");
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("\tr - rent an outfit");
                Console.WriteLine("\tg - give back an outfit");
                Console.WriteLine("\t1 - log out");
                Console.WriteLine("\t2 - exit");

                read = Console.ReadLine();
                if(read == "r") rentScreen(customer);
                else if (read == "g") giveBackScreen(customer);
                else if (read == "1") logOut();
                else if (read == "2") endProgram();
            }
        }
        
        public void rentScreen(Customer customer)
        {
            String read = "";
            showAvailableOutfits();
            Console.Write("Enter outfit ID to rent it: ");
            read = Console.ReadLine();
            rentOutfit(customer, int.Parse(read));
            successScreen(customer);
        }
        
        public void rentOutfit(Customer customer, int outfitID) 
        {
            if (db.availableOutfitsList().Contains(outfitID))
            {
                db.rentOutfit(customer.getID(), outfitID);
            }
            else
            {
                Console.Clear();
                Console.Write("Wrong outfit ID!");
                System.Threading.Thread.Sleep(1000);
                rentScreen(customer);
            }
        }

        public void giveBackScreen(Customer customer)
        {
            String read = "";
            displayCustomerList(customer);
            Console.Write("Enter outfit ID to give it back: ");
            read = Console.ReadLine();
            //giveBack(customer, int.Parse(read));
            
            successScreen(customer);
        }
        
        public void giveBack(Customer customer, int outfitID)
        {
            if (db.customersList(customer.getID()).Contains(outfitID))
            {
                db.giveBackOutfit(customer.getID(), outfitID);
            }
            else
            {
                Console.Clear();
                Console.Write("Wrong outfit ID!");
                System.Threading.Thread.Sleep(1000);
                giveBackScreen(customer);
            }
        }

        public void successScreen(Customer customer)
        {
            Console.WriteLine("Success!");
            System.Threading.Thread.Sleep(2000);
            userScreen(customer);
        }
        
        public void logOut()
        {
            Console.WriteLine("Logging out successful");
            System.Threading.Thread.Sleep(3000);
            app();
        }
        
        public void endProgram()
        {
            Console.Clear();
            Console.WriteLine("See you next time!");     
        }
        
        
        public void showRented()
        {
            ArrayList rented = new ArrayList();
            rented = db.showRented();
            for (int i = 0; i < rented.Count; i++)
            {
                Console.WriteLine(rented[i]);
            }

        }
        
        public void showCustomers()
        {
            ArrayList users = new ArrayList();
            users = db.listOfUsers();
            for (int i = 0; i < users.Count; i++)
            {
                Console.WriteLine(users[i]);
            }
        }

        public void displayCustomerList(Customer customer)
        {
//            for (int i = 0; i < customer.getOutfitList().Count; i++)
//            {
//                Console.WriteLine(customer.getOutfitList().IndexOf(i).ToString());
//            }
            ArrayList cusList = new ArrayList();
            cusList = db.customersList(customer.getID());
            for (int i = 0; i < cusList.Count; i++)
            {
                Console.WriteLine(cusList[i]);
            }
        }

        public void showAvailableOutfits()
        {
            ArrayList avOutfits = new ArrayList();
            avOutfits = db.availableOutfitsList();
            Console.Clear();
            Console.WriteLine("AVAILABLE OUTFITS");
            for (int i = 0; i < avOutfits.Count; i++)
            {
                Console.WriteLine(avOutfits[i]);
            }
        }
        
        public void showAllAssortment()
        {
            ArrayList alOutfits = new ArrayList();
            alOutfits = db.allAssortmentList();
            Console.Clear();
            Console.WriteLine("AVAILABLE OUTFITS");
            for (int i = 0; i < alOutfits.Count; i++)
            {
                Console.WriteLine(alOutfits[i]);
            }
        }
    }
}