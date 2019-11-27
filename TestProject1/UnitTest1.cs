using System;
using ClothesRental.Data_Layer;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }


        [Test]
        public void Test1()
        {

            Assortment assortment = new Assortment();
            Customer cu = new Customer("Ryan", "Gosling", "ryan1000", "gosling");
            Console.WriteLine(cu.getName());
            Assert.Pass();
        }
    }
}