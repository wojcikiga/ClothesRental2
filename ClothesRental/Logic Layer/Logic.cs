using System;
using System.Globalization;
using System.Net.Mime;
using ClothesRental.Data_Layer;

namespace ClothesRental.Logic_Layer
{
    public class Logic
    {
        public void app()
        {
            
            
            UsersList usersList = new UsersList();
            
            startScreen(usersList);
        }

        public void startScreen(UsersList usersList)
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
            else if (read == "1") showCustomers(usersList);
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
            //user.addUser(name, surname, nickname, pswd);
            
            
            userScreen(customer);
        }

        public void userScreen(Customer customer)
        {
            Console.Clear();
            if (customer.getOutfitList().Count == 0)
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
                displayCustomerList(customer);
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
            //rentOutfit(customer, int.Parse(read));
            successScreen(customer);
        }
        
            public void rentOutfit(Customer customer, int outfitID)
            {
                //customer.addToOutfitList();
                
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
            
            
        }
        
        public void showCustomers(UsersList usersList)
        {
            for (int i = 0; i < usersList.getUsersList().Count; i++)
            {
                Console.WriteLine(usersList.getUsersList().IndexOf(i));
            }
        }

        public void displayCustomerList(Customer customer)
        {
            for (int i = 0; i < customer.getOutfitList().Count; i++)
            {
                Console.WriteLine(customer.getOutfitList().IndexOf(i).ToString());
            }
        }

        public void showAvailableOutfits()
        {
            
        }
        
        public void showAllAssortment()
        {
            
        }
    }
}