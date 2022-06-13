using System;


namespace GitFlowTraining
{
    public class Credit : IComparable<Credit>
    {
        private readonly decimal amount;

        public Credit(decimal amount)
        {
            this.amount = amount;
        }

        public decimal Amount { get { return amount; } }

        public int CompareTo(Credit c)
        {
            if (Amount < c.Amount) return -1;
            if (Amount > c.Amount) return 1;
            return 0;
        }

        public override bool Equals(object obj)
        {
            return obj is Credit credit &&
                   Amount == credit.Amount;
        }

        public override int GetHashCode()
        {
            return 31 + Amount.GetHashCode();
        }

    }
}
