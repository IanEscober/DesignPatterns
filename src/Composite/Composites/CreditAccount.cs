namespace Composite.Composites
{
    using System;
    using System.Collections.Generic;

    public class CreditAccount : CompositeAccount
    {
        private readonly List<CashAccount> cashAccounts;

        public CreditAccount()
        {
            this.cashAccounts = new List<CashAccount>();
        }

        public override void Add(CashAccount cashAccount)
        {
            this.cashAccounts.Add(cashAccount);
        }

        public override Type GetAccountType()
        {
            return typeof(CompositeAccount);
        }

        public override void Remove(CashAccount cashAccount)
        {
            this.cashAccounts.Remove(cashAccount);
        }

        public override void Visit()
        {
            Console.WriteLine($"This account have {this.cashAccounts.Count} credit accounts");
            foreach (var item in this.cashAccounts)
            {
                item.Visit();
            }
        }
    }
}
