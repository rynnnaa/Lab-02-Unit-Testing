using System;

namespace Lab_02_Unit_Testing
{
    public class Program
    {
        public static decimal Balance = 1000;

        static void Main(string[] args)
        {
            Console.WriteLine("Ryna's International ATM");
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
                    decimal value;
                    switch (number)
                    {
                        case 1:
                            Console.WriteLine($"Your current balance is {Balance}");
                            break;
                        case 2:
                            Console.WriteLine($"How much would you like to withdraw?");
                            Double.TryParse(Console.ReadLine(), out value);
                            Withdraw(value);
                            break;
                        case 3:
                            Console.WriteLine("How much money would you like to deposit?");
                            Decimal.TryParse(Console.ReadLine(), out value);
                            Console.WriteLine(AddMoney(value) ? "Your money has been deposited" : "You cannot Deposit");
                            break;
                        default:
                            Environment.Exit(0);
                            break;
                    }
                }
            }
        }
    }
}
