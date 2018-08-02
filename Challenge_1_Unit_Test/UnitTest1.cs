using System;
using Challenge_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge_1_Unit_Test
{
    [TestClass]
    public class UnitTest1
    {
        //I unit tested my properties for practice.

        MenuRepository menuRepo = new MenuRepository();

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
        [TestMethod]
        public void Challenge1_menuRepo_ShouldReturnCountWith1()
        {
            Menu one = new Menu(1, "Cake", "yummy", "cakemix", 5);
            menuRepo.AddItemToList(one);

            var actual = menuRepo.GetList().Count;
            var expected = 1;

            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void Challenge1_menuRepo_GetList()
        {
            var actual = menuRepo.GetList().Count;
            var expected = 0;

            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void Challenge2_menuRepo_ShouldReturnWithMinusOneCount()
        {
            
            Menu one = new Menu(1, "Cake", "yummy", "cakemix", 5);
            Menu two = new Menu(2, "TriCake", "yummy", "cakemix", 4);
            menuRepo.AddItemToList(one);
            menuRepo.AddItemToList(two);
            menuRepo.RemoveItemFromList("Cake");

            var actual = menuRepo.GetList().Count;
            var expected = 1;

            Assert.AreEqual(actual, expected);
        }
    }
}
