using System;



namespace ATM.ConsoleApplication
{
    internal class AtmScreen
    {
        internal static void WelcomeATM()
        {
            Console.Clear();
            Console.Title = "MyBank ATM System.";
            Console.WriteLine("Welcome to Mybank ATM.\n");
            Console.WriteLine("Please insert your ATM card.");
            Console.WriteLine("\nPress enter to continue.");
            Console.ReadKey();
        }

        internal UserBankAccount LoginForm()
        {
            var vmUserBankAccount = new UserBankAccount();
            vmUserBankAccount.CardNumber = Validator.Convert<long>("card number");
            Console.WriteLine("Enter card pin");
            vmUserBankAccount.CardPin = Convert.ToInt32(Console.ReadLine());

            return vmUserBankAccount;
        }
    }
}
