namespace Composite
{
    using System;
    using Composite.Composites;
    using Composite.Leafs;

    public class Client
    {
        public static void Main(string[] args)
        {
            var creditAccount = new CreditAccount();
            var loanAccount = new LoanAccount();

            var visaAccount = new VisaAccount();
            var masterAccount = new MasterAccount();
            var carLoanAccount = new CarLoanAccount();

            if (creditAccount.GetAccountType() == typeof(CompositeAccount) && loanAccount.GetAccountType() == typeof(CompositeAccount))
            {
                creditAccount.Add(visaAccount);
                creditAccount.Add(masterAccount);
                loanAccount.Add(carLoanAccount);
            }
           
            creditAccount.Visit();
            loanAccount.Visit();

            Console.ReadKey();
        }
    }
}
