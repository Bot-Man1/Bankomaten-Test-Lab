using System;

class Program
{
    static void Main()
    {
        Console.Title = "Syntax Bank";

        // =========================
        // VÄLKOMST
        // =========================

        Console.Clear();

        Console.WriteLine("=================================");
        Console.WriteLine("       WELCOME TO SYNTAX BANK");
        Console.WriteLine("=================================");
        Console.WriteLine();

        // =========================
        // INLOGGNING
        // =========================

        Console.Write("Username: ");
        string username = Console.ReadLine();

        Console.Write("PIN-code: ");
        string pin = Console.ReadLine();

        Console.Clear();

        Console.WriteLine("=================================");
        Console.WriteLine("           IN LOGGED");
        Console.WriteLine("=================================");
        Console.WriteLine();

        // =========================
        // MENU
        // =========================

        Console.WriteLine("What would you like to do?");
        Console.WriteLine();
        Console.WriteLine("[1] View balance");
        Console.WriteLine("[2] Transfer money");
        Console.WriteLine("[3] Withdraw money");
        Console.WriteLine("[4] Log out");
        Console.WriteLine();

        Console.Write("Choose an option: ");

        string choice = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("---------------------------------");

        switch (choice)
        {
            case "1":
                Console.WriteLine("Your balance is: 5000 kr");
                break;

            case "2":
                Console.WriteLine("Transfer");
                Console.WriteLine("Enter amount:");
                break;

            case "3":
                Console.WriteLine("Withdrawal");
                Console.WriteLine("Enter amount:");
                break;

            case "4":
                Console.WriteLine("You have been logged out.");
                break;

            default:
                Console.WriteLine("Invalid choice!");
                break;
        }

        Console.WriteLine("---------------------------------");
        Console.WriteLine();
        Console.WriteLine("Press ENTER to continue.");
        Console.ReadLine();
    }
}
