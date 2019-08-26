using System;
using FactoryMethod.Products;

namespace FactoryMethod.Creators
{
    public class ProductAggregate : IAggregate<ProductAggregate>
    {
        public Guid ProductId { get; private set; }
        public string ProductName { get; private set; }

        public ProductAggregate(Guid productId, string productName)
        {
            this.ProductId = productId;
            this.ProductName = productName;
        }

        public IRepository<ProductAggregate> CreateRepository()
        {
            return new DbRepository<ProductAggregate>(null);
        }
    }
}
