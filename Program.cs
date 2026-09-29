using System;

class Program
{
    static void Main()
    {
        Console.Title = "Mitt Bankprogram";

        // =========================
        // VÄLKOMST
        // =========================

        Console.Clear();

        Console.WriteLine("=================================");
        Console.WriteLine("       VÄLKOMMEN TILL BANKEN");
        Console.WriteLine("=================================");
        Console.WriteLine();

        // =========================
        // INLOGGNING
        // =========================

        Console.Write("Användarnamn: ");
        string username = Console.ReadLine();

        Console.Write("PIN-kod: ");
        string pin = Console.ReadLine();

        Console.Clear();

        Console.WriteLine("=================================");
        Console.WriteLine("           INLOGGAD");
        Console.WriteLine("=================================");
        Console.WriteLine();

        // =========================
        // MENY
        // =========================

        Console.WriteLine("Vad vill du göra?");
        Console.WriteLine();
        Console.WriteLine("[1] Visa saldo");
        Console.WriteLine("[2] Överföra pengar");
        Console.WriteLine("[3] Ta ut pengar");
        Console.WriteLine("[4] Logga ut");
        Console.WriteLine();

        Console.Write("Välj ett alternativ: ");

        string choice = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("---------------------------------");

        switch (choice)
        {
            case "1":
                Console.WriteLine("Ditt saldo är: 5000 kr");
                break;

            case "2":
                Console.WriteLine("Överföring");
                Console.WriteLine("Ange belopp:");
                break;

            case "3":
                Console.WriteLine("Uttag");
                Console.WriteLine("Ange belopp:");
                break;

            case "4":
                Console.WriteLine("Du har loggats ut.");
                break;

            default:
                Console.WriteLine("Felaktigt val!");
                break;
        }

        Console.WriteLine("---------------------------------");
        Console.WriteLine();
        Console.WriteLine("Tryck ENTER för att avsluta.");
        Console.ReadLine();


        // Source - https://stackoverflow.com/a/21917650
        // Center text in console window
        string s = "Hello|World";
        Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
        Console.WriteLine(s);

    }
}