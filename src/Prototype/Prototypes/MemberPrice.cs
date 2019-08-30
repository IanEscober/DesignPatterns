namespace Prototype.Prototypes
{
    using System.Linq;
    using System.Collections.Generic;
    using System.Diagnostics;

    public class MemberPrice : IPrice
    {
        private readonly decimal basePriceMultiplier;
        private readonly decimal couponDiscountMultiplier;
        private readonly decimal saleDiscountMultiplier;
        public IEnumerable<IPrice> Prices { get; private set; }

        public MemberPrice(decimal basePriceMultiplier, decimal couponDiscountMultiplier, decimal saleDiscountMultiplier)
        {
            this.basePriceMultiplier = basePriceMultiplier;
            this.couponDiscountMultiplier = couponDiscountMultiplier;
            this.saleDiscountMultiplier = saleDiscountMultiplier;
            this.Prices = new List<IPrice>();
        }

        public IPrice Clone()
        {
            foreach (var price in this.Prices)
            {
                price.Clone();
            }
            Debug.WriteLine($"PM: {this.basePriceMultiplier} CDP: {this.couponDiscountMultiplier} SDM: {this.saleDiscountMultiplier}");
            return this.MemberwiseClone() as MemberPrice;
        }

        public IPrice Concat(params IPrice[] otherPrices)
        {
            foreach (var otherPrice in otherPrices)
            {
                this.Prices.Append(otherPrice);
            }

            return this;
        }
    }
}
