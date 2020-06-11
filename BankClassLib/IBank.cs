using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankClassLib
{
    public interface IBank
    {
        string BankName { get; }
        double Inventory { get; }

        /// <summary>
        /// Used to create a new account.
        /// </summary>
        /// <param name="name">Name of the person.</param>
        /// <param name="type">Account type.</param>
        /// <returns>int</returns>
        int CreateAccount(string name, AccountType type);

        /// <summary>
        /// Used to insert money to a specific account.
        /// </summary>
        /// <param name="accountNumber">The account number.</param>
        /// <param name="amount">The amount.</param>
        /// <returns>double</returns>
        double InsertAmount(int accountNumber, double amount);

        /// <summary>
        /// Used to withdraw money from a specific account.
        /// </summary>
        /// <param name="accountNumber">The account number.</param>
        /// <param name="amount">The amount.</param>
        /// <returns>double</returns>
        double WithdrawAmount(int accountNumber, double amount);

        /// <summary>
        /// Used to check the balance to a specific account.
        /// </summary>
        /// <param name="accountNumber">The account number.</param>
        /// <returns>Account</returns>
        Account Balance(int accountNumber);

        /// <summary>
        /// Used to calculate the interest for all existing accounts.
        /// </summary>
        void InterestCalculating();

        /// <summary>
        /// Used to provide a list for the select control for selecting the pull and insert account
        /// </summary>
        /// <returns>List<AccountListItem></returns>
        List<AccountListItem> AccountLookUpList();

        /// <summary>
        /// Used to provide a list to show all accounts.
        /// </summary>
        /// <returns>List<AccountListItem></returns>
        List<AccountListItem> GetAccountList();
    }
}
