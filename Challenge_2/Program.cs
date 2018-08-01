using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ClaimRepository claimsRepo = new ClaimRepository();

            Claim car = new Claim(1, "car", "car accident", 400, DateTime.Parse("04/25/2018"), DateTime.Parse("04/27/2018"));
            Claim house = new Claim(2, "home", "house fire", 4000, DateTime.Parse("04/26/2018"), DateTime.Parse("04/28/2018"));
            Claim theft = new Claim(3, "theft", "stolen pancakes", 4, DateTime.Parse("04/27/2018"), DateTime.Parse("06/01/2018"));


            claimsRepo.Add(car);
            claimsRepo.Add(house);
            claimsRepo.Add(theft);

            while (true)
            {
                Console.WriteLine("Welcome to your claims queue! What would you like to do?\n" +
                    "Press 1: See all Claims.\n" +
                    "Press 2: Take Care of next claim.\n" +
                    "Press 3: Enter a new Claim.\n");
                string theAnswer = Console.ReadLine();

                if (theAnswer == "1")
                {


                    foreach (Claim claim in claimsRepo.GetClaimList()) 
                    {
                        Console.WriteLine("Here are the details for the next claim:\n" +
                            $"ID Number: {claim.Id}\n" +
                            $"Claim Dept: {claim.Type}\n" +
                            $"Description: {claim.Description}\n" +
                            $"Cost of Claim: {claim.Amount}\n" +
                            $"Incident Date:: {claim.Incident}\n" +
                            $"Date of Reports: {claim.Report}\n" +
                            $"Validity: {claim.isValid}");
                    }
                }
                if (theAnswer == "2")
                {
                    Queue<Claim> claims = claimsRepo.GetClaimList();

                    
                    Console.WriteLine("Would you like to deal with this claim now?");
                    string Answer = Console.ReadLine();

                    while (true)
                    {
                        if (Answer == "y")
                        {
                            claimsRepo.CurrentClaimFinished();
                            Console.Clear();
                            claimsRepo.PrintList(claimsRepo.GetClaimList());
                            break;
                        }
                        if (Answer == "n")
                        {
                            break;
                        }
                    }
                }
                if(theAnswer == "3")
                    {
                        Console.WriteLine("Enter the number of the claim:");
                        int claimnumber = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the type of claim");
                        string claimtype = Console.ReadLine();
                        Console.WriteLine("Enter the description of the claim:");
                        string claimscription = Console.ReadLine();
                        Console.WriteLine("Enter the amount of the claim:");
                        int claimamount = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the date of the incident:");
                        DateTime claimincident = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the date the claim was filed:");
                        DateTime claimreport = DateTime.Parse(Console.ReadLine());
                        
                        Claim userclaim = new Claim(claimnumber, claimtype, claimscription, claimamount, claimincident, claimreport);

                        claimsRepo.Add(userclaim);
                }
            }
        }
    }
}
