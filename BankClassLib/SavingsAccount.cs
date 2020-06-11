namespace BankClassLib
{
    class SavingsAccount : Account
    {
        public SavingsAccount(int accountNumber, string name)
        {
            this.Name = name;
            this.AccountNumber = accountNumber;
            this.AccountType = AccountType.SavingsAccount;
        }

        public override void CalculateInterest()
        {
            if (Balance > 100000)
                Balance *= 1.03;
            else
            {
                if (Balance > 50000)
                    Balance *= 1.02;
                else
                {
                    if (Balance > 0)
                        Balance *= 1.01;
                }
            }
        }
    }
}
