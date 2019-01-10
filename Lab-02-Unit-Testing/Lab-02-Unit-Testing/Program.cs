using System;

namespace Lab_02_Unit_Testing
{
    public class Program
    {
        public static decimal Balance = 1000;

        static void Main(string[] args)
        {
            Console.WriteLine("Ryna's International ATM");
            ATM();
        }

        public static void ATM()
        {
            bool isWorking = true;

            while (isWorking)
            {
                Console.WriteLine("What can I help you with today?");
                Console.WriteLine("1. View Balance");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Add Money");
                Console.WriteLine("4. Exit");
                try
                {
                    string selectedOption = Console.ReadLine();
                    int selected = Convert.ToInt32(selectedOption);
                    if (selected == 1 || selected == 2 || selected == 3 || selected == 4)
                    {
                        decimal value;
                        switch (selected)
                        {
                            case 1:
                                Console.WriteLine($"Your current balance is {Balance}");
                                break;
                            case 2:
                                Console.WriteLine($"What is your withdraw amount?");
                                string withDraw = Console.ReadLine();
                                value = Convert.ToInt32(withDraw);
                                Console.WriteLine($"Your current balance is {Balance}");
                                break;
                            case 3:
                                Console.WriteLine("How much money would you like to deposit?");
                                string deposit = Console.ReadLine();
                                value = Convert.ToInt32(deposit);
                                Console.WriteLine($"Your balance is {Balance}");
                                break;
                            default:
                                Environment.Exit(0);
                                break;

                        }
                    }
                    else
                    {
                        Console.WriteLine("Please select a one of the options: 1, 2, 3, 4");
                        ATM();
                    }
                }
                catch
                {
                    Console.WriteLine("That is not one of the options");
                }
            }
        }
    }
}
