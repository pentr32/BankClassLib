namespace BankClassLib
{
    public enum AccountType
    {
        // Used for daily expenses and bills.
        // Account holders can write checks for funds in the account.
        CheckingAccount,

        // Used for saving money for emergencies or a specific goal.
        // Typically earns interest.
        SavingsAccount,

        // Deposit account that earns interest.
        // Limits the number of transactions each month.
        MoneyMarketAccount
    }
}
