namespace MyApp.Models.D10
{
    public class BankAccount
    {
        private int Balance { get; set; }
        private readonly object _lockObj = new();

        public BankAccount(int balance)
        {
            Balance = balance;
        }

        public void WithDraw(int amount)
        {
            lock (_lockObj)
            {
                if (Balance >= amount)
                {
                    Balance -= 100;
                }
            }
        }

        public int GetBalance()
        {
            return Balance;
        }
    }
}
