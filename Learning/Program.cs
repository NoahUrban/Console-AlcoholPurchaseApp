using System;
namespace CS_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable Declarations

            string beer = "Beer";
            string whiskey = "Whiskey";
            string wine = "Wine";
            string firstName;
            string lastName;
            int age;
            bool verified = true;
            bool notVerified = false;
            double beerPrice = 3.14;
            double whiskeyPrice = 3.24;
            decimal winePrice = 5.98m;


            // Alchohol Age Checker

            Log("Please enter your first name below then press enter...");
            firstName = Console.ReadLine();

            Clear();

            Log("Please enter your last name below then press enter...");
            lastName = Console.ReadLine();

            Clear();

            Log("Please enter your Age below then press enter...");
            age = Convert.ToInt32(Console.ReadLine());

            Clear();

            Log($"First Name: {firstName}");
            Log($"Last Name: {lastName}");
            Log($"Age: {age}");

            if (age >= 21)
            {
                Log($"Age Verfied: {verified}");
                Console.WriteLine();
                Log("Press any key to shop\n");
                Console.ReadKey();
            }
            else
            {
                Log($"Age Verified: {notVerified}");
                Console.WriteLine();
                Log("You are not old enough to purchase alcohol");
            }

            // Alcohol Order

            if (age >= 21)
            {
                Clear();

                Log("Please select what type of alcohol you would like to purchase...");

                Console.WriteLine();

                Log($"\t{beer}");
                Log($"\t{whiskey}");
                Log($"\t{wine}");

                Console.WriteLine();

                string select;
                select = Console.ReadLine();

                // Order Selection

                if (select == beer)
                {
                    Clear();

                    Log($"You selected {beer}\n");
                    Log($"Your total will be ${beerPrice}\n");
                    Log("Press any key to pay\n");

                    Console.ReadKey();

                    Clear();
                    Log("Thank you for your Purchase and have a great day!");
                }
                else if (select == whiskey)
                {
                    Clear();

                    Log($"You selected {whiskey}\n");
                    Log($"Your total will be ${whiskeyPrice}\n");
                    Log("Press any key to pay");

                    Console.ReadKey();

                    Clear();
                    Log("Thank you for your Purchase and have a great day!");
                }
                else if (select == wine)
                {
                    Clear();
                    Log($"You selected {wine}\n");
                    Log($"Your total will be ${winePrice}\n");
                    Log("Press any key to pay");

                    Console.ReadKey();

                    Clear();
                    Log("Thank you for your Purchase and have a great day!");
                }
                else
                {
                    Log("Sorry, we don't have that kind of beverage");
                }
            }
        }
        // Console.WriteLine Shortcut
        static void Log(string str)
        {
            Console.WriteLine(str);
        }

        // Console.Clear Shortcut
        static void Clear()
        {
            Console.Clear();
        }

    }
}
