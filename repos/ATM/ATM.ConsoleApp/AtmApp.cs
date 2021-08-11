using System;
namespace ATM.ConsoleApplication
{
    public class AtmApp : IATMApp, ITransaction, IUserBankAccount
    {
        private List<UserBankAccount> _accountList;
        private List<Transaction> _listOfTransactions;
        public AtmApp()
        {
            screen = new AtmScreen();
        }

        public void Initialization()
        {
            _accountList = new List<UserBankAccount>
            {
                new UserBankAccount() { Id=1, FullName = "Peter Parker", AccountNumber=333111, CardNumber = 123123, CardPin = 111111, AccountBalance = 2000.00m, IsLocked = false },
                new UserBankAccount() { Id=2, FullName = "Bruce Bane", AccountNumber=111222, CardNumber = 456456, CardPin = 222222, AccountBalance = 1500.30m, IsLocked = true },
                new UserBankAccount() { Id=3, FullName = "Clark Kent", AccountNumber=888555, CardNumber = 789789, CardPin = 333333, AccountBalance = 2900.12m, IsLocked = false }
            };

            _listOfTransactions = new List<Transaction>();
        }

        public void Execute()
        {
            AtmScreen.WelcomeATM();
            CheckCardNoPassword();
        }

        public void CheckCardNoPassword()
        {
            bool isLoginPassed = false;

            while (isLoginPassed == false)
            {
                var inputAccount = screen.LoginForm();

                AtmScreen.LoginProgress();

                foreach (UserBankAccount account in _accountList)
                {
                    selectedAccount = account;
                    if (inputAccount.CardNumber.Equals(account.CardNumber))
                    {
                        selectedAccount.TotalLogin++;

                        if (inputAccount.CardPin.Equals(account.CardPin))
                        {
                            selectedAccount = account;
                            if (selectedAccount.IsLocked)
                            {
                                // This is when database is used and when the app is restarted.
                                // Even user login with the correct card number and pin,
                                // If IsLocked status is locked, user still will be still blocked.
                                AtmScreen.PrintLockAccount();
                            }
                            else
                            {
                                selectedAccount.TotalLogin = 0;
                                isLoginPassed = true;
                                break;
                            }
                        }
                    }
                }

                if (isLoginPassed == false)
                {
                    Utility.PrintMessage("Invalid card number or PIN.", false);

                    // Lock the account if user fail to login more than 3 times.
                    selectedAccount.IsLocked = selectedAccount.TotalLogin == 3;
                    if (selectedAccount.IsLocked)
                        AtmScreen.PrintLockAccount();
                }

                Console.Clear();
            }
        }
    }
