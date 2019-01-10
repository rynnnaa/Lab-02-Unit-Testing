using System;

namespace Lab_02_Unit_Testing
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What can I help you with today?");
            Console.WriteLine("1. View Balance");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Add Money");
            Console.WriteLine("4. Exit");

            int.TryParse(Console.ReadLine(), out int number);

            decimal value;
            switch(number);
        }

        public static string ATM(string atmMachine);
    }
}
