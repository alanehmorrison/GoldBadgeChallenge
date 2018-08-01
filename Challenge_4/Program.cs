using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Badge badge = new Badge();
            BadgeRepository badgeRepo = new BadgeRepository();
            List<string> _Doors = new List<string>();
            Dictionary<int, List<string>> theDictionary = new Dictionary<int, List<string>>();

            Console.WriteLine("Hello Security what would you like to do?\n" +
                "Select 1 to Add a new badge.\n" +
                "Select 2 to Update a badge.\n" +
                "Select 3 to List all badges.");

            string theAnswer = Console.ReadLine();

            while (true)
            {
                if (theAnswer == "1")
                {
                    Console.WriteLine("What is the number on the badge?");
                    var number = int.Parse(Console.ReadLine());
                    Console.WriteLine("What are the doors it needs to access?");
                    var newdoor = Console.ReadLine();

                    

                }

                if (theAnswer == "2")
                {

                }

                if (theAnswer == "3")
                {
                    foreach(KeyValuePair<$"{badge.Id}, {badge.Doors}">)
                    {
                        Console.WriteLine("")
                    }

                }

            }
        }

    }
}
