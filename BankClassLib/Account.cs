namespace BankClassLib
{
    public abstract class Account
    {
        public int AccountNumber { get; set; }
        public string Name { get; set; }
        double balance;
        public AccountType AccountType { get; set; }

        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
                if (balance < 0)
                {
                    throw new OverdraftException(string.Format("Overdraft: {0}", balance));
                }
            }
        }

        public abstract void CalculateInterest();
    }
}
