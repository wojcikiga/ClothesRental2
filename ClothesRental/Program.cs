using System;
using ClothesRental.Logic_Layer;

namespace ClothesRental
{
    internal class Program
    {
        public static void Main(string[] args)
        {
//            Console.WriteLine("Iguśka");
//            
//            string cs = "../main_sqlite_master.sql";
//            
//            using var db = new SQLiteConnection(cs);
            
            Logic logic = new Logic();
            logic.app();
        }
    }
}