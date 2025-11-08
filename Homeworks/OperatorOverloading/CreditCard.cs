using System.Globalization;

namespace OperatorOverloading
{
    internal class CreditCard
    {
        private int cvc;
        private decimal balance;
        public string CardNumber { get; init; }
        public int CVC
        {
            get => cvc;
            set
            {
                if (value < 0 || value > 999) throw new ArgumentException("CVC must be 0–999.");
                cvc = value;
            }
        }

        public decimal Balance
        {
            get => balance;
            set
            {
                if (value < 0) throw new InvalidOperationException("Balance cannot be negative.");
                balance = value;
            }
        }

        public CreditCard(string cardNumber, int cvc, decimal balance)
        {
            CardNumber = cardNumber;
            CVC = cvc;
            Balance = balance;
        }

        public static CreditCard operator +(CreditCard c, decimal amount)
        {
            return new CreditCard(c.CardNumber, c.CVC, c.Balance + amount);
        }

        public static CreditCard operator -(CreditCard c, decimal amount)
        {
            if (c.Balance - amount < 0)
                throw new InvalidOperationException("Insufficient funds.");
            return new CreditCard(c.CardNumber, c.CVC, c.Balance - amount);
        }

        public static bool operator ==(CreditCard c1, CreditCard c2)
        {
            return c1.CVC == c2.CVC;
        }

        public static bool operator !=(CreditCard c1, CreditCard c2)
        {
            return c1.CVC != c2.CVC;
        }

        public static bool operator <(CreditCard c1, CreditCard c2)
        {
            return c1.Balance < c2.Balance;
        }
        public static bool operator >(CreditCard c1, CreditCard c2)
        {
            return c1.Balance > c2.Balance;
        }

        public override bool Equals(object obj)
        {
            return obj is CreditCard c && CVC == c.CVC; 
        }

        public override int GetHashCode()
        {
            return CVC.GetHashCode();
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Card: {CardNumber}, CVC: {CVC}, Balance: {Balance.ToString("C", new CultureInfo("uk-UA"))}");
        }
    }
}
