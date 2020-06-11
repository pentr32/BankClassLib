namespace BankClassLib
{
    class CheckingAccount : Account
    {
        public CheckingAccount(int accountNumber, string name)
        {
            this.AccountNumber = accountNumber;
            this.Name = name;
            this.AccountType = AccountType.CheckingAccount;
        }

        public override void CalculateInterest()
        {
            if (Balance > 0)
            {
                Balance *= 1.005;
            }
        }
    }
}
