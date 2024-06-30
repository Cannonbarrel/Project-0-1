using System;
namespace GreenvilleIdol
{
class GreenvilleRevenue {
  public static void Main (string[] args) {
    var app = new GreenvilleIdolApp();
            app.Run();
        }
    }

    public class GreenvilleIdolApp
    {
        private string motto = "************************************\n*  The stars shine in Greenville.  *\n************************************";
        private int lastYearContestants = 0;
        private int thisYearContestants = 0;
        private int revenuePerContestant = 25;  

        public string DisplayMotto()
        {
            return motto;
        }

        public string DisplayMenu()
        {
            return "Please Enter the following number below from the following menu:\n" +
                   "1. CALCULATE Greenville Revenue Year-Over-Year\n" +
                   "2. Exit";
        }

        public string CalculateRevenue()
        {
            int expectedRevenue = thisYearContestants * revenuePerContestant;
            return $"Expected Revenue this year is ${expectedRevenue}";
        }

        public string CheckContestantNumbers()
        {
            if (thisYearContestants > lastYearContestants)
            {
                return $"Last year's competition had {lastYearContestants} contestants, and this year's has {thisYearContestants} contestants\n" +
                "It is true that this year's competition is bigger than last year's";
              
            }
            else
            {
                return $"Last year's competition had {lastYearContestants} contestants, and this year's has {thisYearContestants} contestants\n" +
              "This year's competition does not have more contestants than last year.";
            }
        }

        public void Run()
        {
            Console.WriteLine(DisplayMotto());
            while (true)
            {
                Console.WriteLine(DisplayMenu());
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    Console.WriteLine("Enter the number of contestants from last year: ");
                      lastYearContestants = int.Parse(Console.ReadLine());

                      Console.Write("Enter the number of contestants from this year: ");
                      thisYearContestants = int.Parse(Console.ReadLine());

                      Console.WriteLine(CalculateRevenue());
                      Console.WriteLine(CheckContestantNumbers());
                }
                else if (choice == "2")
                {
                    Console.WriteLine("Thank you for using the Greenville Revenue App, good bye!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option, please try again.");
                }
            }
        }
  }
}