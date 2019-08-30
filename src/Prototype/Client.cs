namespace Prototype
{
    using System;
    using Prototype.Prototypes;

    public class Client
    {
        public static void Main(string[] args)
        {
            var bronzeMemberDiscount = new MemberPrice(1, 1, 1);
            var silverMemberDiscount = new MemberPrice(2, 2, 2);
            var goldMemberDiscount = new MemberPrice(3, 3, 3);
            var goodPrice = bronzeMemberDiscount.Clone();

            var regularWholeSellerDiscount = new WholeSellerPrice(2, false);
            var partneredWholeSellerDiscount = new WholeSellerPrice(2, true); 
            var betterPrice = regularWholeSellerDiscount.Clone();

            var regularBronze = regularWholeSellerDiscount.Concat(bronzeMemberDiscount);
            var bestPrice = regularBronze.Clone();

            Console.ReadKey();
        }
    }
}
