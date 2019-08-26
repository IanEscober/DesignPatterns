using System;
using FactoryMethod.Products;

namespace FactoryMethod.Creators
{
    public class BasketAggregate : IAggregate<BasketAggregate>
    {
        public Guid BasketId { get; private set; }
        public int Count { get; private set; }

        public BasketAggregate(Guid basketId, int count)
        {
            this.BasketId = basketId;
            this.Count = count;
        }

        public IRepository<BasketAggregate> CreateRepository()
        {
            return new CacheRepository<BasketAggregate>(null);
        }
    }
}
