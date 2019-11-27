using System;
using System.Collections;
using ClothesRental.Data_Layer;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        Customer customer = new Customer("Ryan", "Gosling", "ryan1995", "ryanhot");
        Customer customer1 = new Customer("Igo", "Napoli", "igi", "1234");
       
        Outfit wonderWoman = new Outfit();
        
        ArrayList arrayList = new ArrayList();
        Outfit outfit1 = new Outfit();
        Outfit outfit2 = new Outfit();
        
        Assortment assortment = new Assortment();
        
        UsersList usersList = new UsersList();
        
        [Test]
        public void CustomerTest()
        {
            Assert.True(customer.getName()=="Ryan");
            Assert.True(customer.getSurname()=="Gosling");
            Assert.True(customer.getNickname()=="ryan1995");
            Assert.True(customer.getPassword()=="ryanhot");
            Assert.True(customer.getID() == 3000);
            
            Assert.True(customer.getOutfitList().Count == 0);
            customer.addToOutfitList(wonderWoman);
            Assert.True(customer.getOutfitList().Count == 1);
            customer.removeFromOutfitList(wonderWoman);
            Assert.True(customer.getOutfitList().Count == 0);

            Assert.True(customer1.getName() == "Igo");
            Assert.True(customer1.getSurname() == "Napoli");
            Assert.True(customer1.getNickname() == "igi");
            Assert.True(customer1.getPassword() == "1234");
            Assert.True(customer1.getID() == 3001);
            
            Assert.True(customer1.getOutfitList().Count == 0);
            customer1.addToOutfitList(wonderWoman);
            Assert.True(customer1.getOutfitList().Count == 1);
            Assert.True(customer1.removeFromOutfitList(wonderWoman) == 1);
            Assert.True(customer1.getOutfitList().Count == 0);
            
            arrayList.Clear();
            arrayList.Add(outfit1);
            arrayList.Add(outfit2);
            customer.setOutfitList(arrayList);
            Assert.True(customer.getOutfitList().Count == 2);
            Assert.False(customer.removeFromOutfitList(wonderWoman) == 1);
            
            customer.getOutfitList().Clear();
        }

        [Test]
        public void OutfitTest()
        {
            Assert.True(wonderWoman.getOutfitID() == 100);
            
        }
        
        [Test]
        public void AssortmentTest()
        {
            Assert.True(assortment.getAssortment().Count == 0);
            assortment.addOutfit(wonderWoman);
            Assert.True(assortment.getAssortment().Count == 1);
            Assert.True(assortment.removeOutfit(wonderWoman) == 1);
            Assert.True(assortment.removeOutfit(wonderWoman) == 0);
            
            arrayList.Clear();
            arrayList.Add(outfit1);
            arrayList.Add(outfit2);
            assortment.fillAssortment(arrayList);
            Assert.True(assortment.getAssortment().Count == 2);
            
        } 
        
        [Test]
        public void UsersListTest()
        {
            Assert.True(usersList.getUsersList().Count == 0);
            usersList.addUser(customer);
            Assert.True(usersList.getUsersList().Count == 1);
            usersList.removeUser(customer);
            Assert.True(usersList.getUsersList().Count == 0);

            arrayList.Clear();
            arrayList.Add(customer);
            arrayList.Add(customer1);
            usersList.setUsersList(arrayList);
            
            Assert.True(usersList.getUsersList().Count == 2);
            Assert.True(usersList.removeUser(customer1) == 1);
            Assert.False(usersList.removeUser(customer1) == 1);
            usersList.getUsersList().Clear();
        }
    }
}