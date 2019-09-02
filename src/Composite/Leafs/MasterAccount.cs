namespace Composite.Leafs
{
    using System;

    public class MasterAccount : BaseAccount
    {
        public override Type GetAccountType()
        {
            return typeof(BaseAccount);
        }

        public override decimal GetBalance()
        {
            return new Random().Next(500);
        }

        public override void Visit()
        {
            Console.WriteLine("Checking balance on Master Account...");
            var balance = this.GetBalance();
            Console.WriteLine($"Balance: {balance}");
        }
    }
}
