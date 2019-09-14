namespace Iterator.Aggregates
{
    using System;
    using Iterator.Iterators;

    public class BankRecords : IIteratableAggregate<double>
    {
        private readonly int id;
        private readonly double[] balances;
        private readonly double minTaxableAmount;
        private readonly double maxTaxableAmount;

        public BankRecords(int id, double[] balances, double minTaxAmt, double maxTaxAmt)
        {
            this.id = id;
            this.balances = balances;
            this.minTaxableAmount = minTaxAmt;
            this.maxTaxableAmount = maxTaxAmt;
        }

        public BaseIterator<double> CreateIterator()
        {
            return new BoundIterator<double>(this.balances, this.FilterBalances, this.Print);
        }

        private bool FilterBalances(double balance)
        {
            return balance >= this.minTaxableAmount && balance <= this.maxTaxableAmount;
        }

        private void Print(double allowedBalance)
        {
            Console.WriteLine(allowedBalance);
        }

    }
}
