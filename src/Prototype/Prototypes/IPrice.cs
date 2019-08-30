namespace Prototype.Prototypes
{
    using System.Collections.Generic;

    public interface IPrice
    {
        IEnumerable<IPrice> Prices { get; }
        IPrice Clone();
        IPrice Concat(params IPrice[] otherPrices);
    }
}
