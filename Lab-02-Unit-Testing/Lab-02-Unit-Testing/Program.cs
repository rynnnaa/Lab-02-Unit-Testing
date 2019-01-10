using System;

namespace Lab_02_Unit_Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What can I help you with today?");
            Console.WriteLine("1. View Balance");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Add Money");
            Console.WriteLine("4. Exit");

            Int32.TryParse(Console.ReadLine(), out int number);

            decimal value;
            switch (number)
            {
                case 1:
                    Console.WriteLine("How much money would you like to deposit?");
                    Decimal.TryParse(Console.ReadLine(), out value);
                    Console.WriteLine(AddMoney(value) ? "Your money has been deposited" : "You cannot Deposit");

                    break;

                    //public static string ATM(string atmMachine);
            }
        }
    }
}
