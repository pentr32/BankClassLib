namespace BankClassLib
{
    class MoneyMarketAccount : Account
    {
        public MoneyMarketAccount(int accountNumber, string name)
        {
            this.AccountNumber = accountNumber;
            this.Name = name;
            this.AccountType = AccountType.MoneyMarketAccount;
        }

        public override void CalculateInterest()
        {
            if (Balance > 0)
                Balance *= 1.005;
            else
                Balance *= 0.95;
        }
    }
}
