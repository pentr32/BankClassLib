using System;
using System.Collections.Generic;

namespace BankClassLib
{
    public class Bank : IBank
    {
        public string BankName { get;  }
        public double Inventory { get; }

        int accountCounter;
        List<Account> Accounts;

        #region Constructor
        public Bank(string bankName, double inventory)
        {
            BankName = bankName;
            Inventory = inventory;
            Accounts = new List<Account>();
        }
        #endregion Constructor

        public int CreateAccount(string name, AccountType type)
        {
            switch (type)
            {
                // Create a new CheckingAccount and add to accounts list.
                case AccountType.CheckingAccount:
                    Accounts.Add(new CheckingAccount(++accountCounter, name));
                    break;

                // Create a new SavingsAccount and add to accounts list.
                case AccountType.SavingsAccount:
                    Accounts.Add(new SavingsAccount(++accountCounter, name));
                    break;

                // Create a new MoneyMarketAccount and add to accounts list.
                case AccountType.MoneyMarketAccount:
                    Accounts.Add(new MoneyMarketAccount(++accountCounter, name));
                    break;

                // In case if user types anything other than any types of account from AccountType.
                default:
                    return 0;
            }
            return accountCounter;
        }

        public double InsertAmount(int accountNumber, double amount)
        {
            // Find the specific account from the list by account number.
            Account foundAccount = Accounts.Find(a => a.AccountNumber == accountNumber);

            // Add the amount to the account that was found from the list.
            foundAccount.Balance += amount;

            // Returns account's balance.
            return foundAccount.Balance;
        }

        public double WithdrawAmount(int accountNumber, double amount)
        {
            // Find the specific account from the list by account number.
            Account foundAccount = Accounts.Find(a => a.AccountNumber == accountNumber);

            // Withdraw the amount from the account that was found from the list.
            foundAccount.Balance -= amount;

            // Returns account's balance.
            return foundAccount.Balance;
        }

        public Account Balance(int accountNumber)
        {
            // Find the specific account from the list by account number.
            Account foundAccount = Accounts.Find(a => a.AccountNumber == accountNumber);

            // Return the account object.
            return foundAccount;
        }

        public void InterestCalculating()
        {
            foreach (Account acc in Accounts)
            {
                acc.CalculateInterest();
            }
        }

        public List<AccountListItem> AccountLookUpList()
        {
            List<AccountListItem> accountList = new List<AccountListItem>();
            foreach (Account acc in Accounts)
            {
                accountList.Add(new AccountListItem
                {
                    AccountNumber = acc.AccountNumber,
                    Name = acc.Name
                });
            }
            return accountList;
        }

        public List<AccountListItem> GetAccountList()
        {
            List<AccountListItem> accountList = new List<AccountListItem>();
            foreach (Account acc in Accounts)
            {
                accountList.Add(new AccountListItem
                {
                    AccountNumber = acc.AccountNumber,
                    Name = acc.Name,
                    Balance = acc.Balance,
                    AccountType = acc.AccountType
                });
            }
            return accountList;
        }
    }
}
