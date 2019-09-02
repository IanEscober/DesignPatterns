namespace Composite.Leafs
{
    using System;

    public class CarLoanAccount : BaseAccount
    {
        public override Type GetAccountType()
        {
            return typeof(BaseAccount);
        }

        public override decimal GetBalance()
        {
            return new Random().Next(50);
        }

        public override void Visit()
        {
            Console.WriteLine("Checking balance on Car Loan Account...");
            var balance = this.GetBalance();
            Console.WriteLine($"Balance: {balance}");
        }
    }
}
