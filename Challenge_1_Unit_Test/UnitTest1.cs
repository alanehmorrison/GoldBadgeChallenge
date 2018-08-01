using System;
using Challenge_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge_1_Unit_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Menu_CakeNumber_ShouldReturnInt()
        {
            MenuRepository menuRepo = new MenuRepository();

            Menu Strawberry = new Menu(3, "strawcake", "fresh fruit", "straw cake mix", 5);

            int expected = 3;
            int actual = Strawberry.Number; 

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Menu_CakeName_ShouldReturnString()
        {
            Menu Strawberry = new Menu(3, "strawcake", "fresh fruit", "straw cake mix", 5);

            string expected = "strawcake";
            string actual = Strawberry.Name;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Menu_CakeDescription_ShouldReturnString()
        {
            Menu Strawberry = new Menu(3, "strawcake", "fresh fruit", "straw cake mix", 5);

            string expected = "fresh fruit";
            string actual = Strawberry.Description;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Menu_CakeIngredients_ShouldReturnString()
        {
            Menu Strawberry = new Menu(3, "strawcake", "fresh fruit", "straw cake mix", 5);

            string expected = "straw cake mix";
            string actual = Strawberry.Ingredients;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Menu_CakePrice_ShouldReturnInt()
        {
            Menu Strawberry = new Menu(3, "strawcake", "fresh fruit", "straw cake mix", 5);

            int expected = 5;
            int actual = Strawberry.Price;

            Assert.AreEqual(expected, actual);
        }
    }
}
