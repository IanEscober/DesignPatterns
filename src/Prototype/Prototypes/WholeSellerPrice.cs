namespace Prototype.Prototypes
{
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    public class WholeSellerPrice : IPrice
    {
        private readonly decimal quantityDiscountMultiplier;
        private readonly bool withBrandDiscount;
        public IEnumerable<IPrice> Prices { get; private set; }

        public WholeSellerPrice(decimal quantityDiscountMultiplier, bool withBrandDiscount)
        {
            this.quantityDiscountMultiplier = quantityDiscountMultiplier;
            this.withBrandDiscount = withBrandDiscount;
            this.Prices = new List<IPrice>();
        }

        public IPrice Clone()
        {
            foreach (var price in this.Prices)
            {
                price.Clone();
            }
            Debug.WriteLine($"QDM: {this.quantityDiscountMultiplier} WBD: {this.withBrandDiscount}");
            return this.MemberwiseClone() as WholeSellerPrice;
        }

        public IPrice Concat(params IPrice[] otherPrices)
        {
            foreach (var otherPrice in otherPrices)
            {
                this.Prices = this.Prices.Append(otherPrice);
            }

            return this;
        }
    }
}
