using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Menu Strawberry = new Menu(1, "StrawberryCake", "real fruit goodness", "cake mix, strawberry", 5);
            Menu Chocolate = new Menu(2, "ChocolateCake", "lava cake", "cake mix, chocolate", 2);
            Menu Birthday = new Menu(3, "BirthdayCake", "celebrate your day", "sprinkles, cake mix", 4);

            MenuRepository menuRepo = new MenuRepository();

            while (true)
            {
                Console.WriteLine("What do you want to do? Pick a number.\n" +
                     "1) Add to List.\n" +
                     "2) View List.\n" +
                     "3). Remove from List.");
                string userAnswer = Console.ReadLine();

                if (userAnswer == "1")
                {
                    Console.WriteLine("Enter the number of cake:");
                    int cakenumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter name of cake");
                    string cakename = Console.ReadLine();
                    Console.WriteLine("Enter the description of the cake:");
                    string cakescription = Console.ReadLine();
                    Console.WriteLine("Enter the ingredients used to make this cake:");
                    string cakegredients = Console.ReadLine();
                    Console.WriteLine("Enter the cost of this cake");
                    int cakecost = int.Parse(Console.ReadLine());

                    Menu usercake = new Menu(cakenumber, cakename, cakescription, cakegredients, cakecost);

                    menuRepo.AddItemToList(usercake);
                }

                if (userAnswer == "2")
                {
                    menuRepo.AddItemToList(Strawberry);
                    menuRepo.AddItemToList(Chocolate);
                    menuRepo.AddItemToList(Birthday);

                    List<Menu> cakes = menuRepo.GetList();

                    Console.WriteLine("Press enter to view the menu list:");

                    Console.ReadLine();

                    foreach (Menu cake in cakes)
                    {
                        Console.WriteLine($"Meal Number: {cake.Number}\n" +
                            $"Name: {cake.Name}\n" +
                            $"Description: {cake.Description}\n" +
                            $"Ingredients: {cake.Ingredients}\n" +
                            $"Price: {cake.Price}\n");
                    }
                }

                if (userAnswer == "3")
                {
                    while (true)
                    {
                        Console.WriteLine("Would you like to delete a cake off the menu?");
                        string theAnswer = Console.ReadLine();
                        if (theAnswer == "y")
                        {
                            Console.WriteLine("What cake you want to remove?");
                            string Name = Console.ReadLine();

                            menuRepo.RemoveItemFromList(Name);
                        }
                        if (theAnswer == "n")
                        {
                            break;
                        }
                    }
                }
                Console.ReadLine();


            }
        }
    }
}
    
