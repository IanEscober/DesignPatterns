namespace Iterator
{
    using System;
    using Iterator.Aggregates;

    public class Client
    {
        public static void Main(string[] args)
        {
            var id = 1;
            var balances = new[] { 1.5, 1.23, 2.12, 1.09, 2.1 };
            var bankAccount = new BankRecords(id, balances, 1.0, 2.0);

            var iterator = bankAccount.CreateIterator();
            iterator.Traverse();

            Console.ReadKey();
        }
    }
}
