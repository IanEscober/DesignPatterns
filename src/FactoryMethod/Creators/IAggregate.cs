using FactoryMethod.Products;

namespace FactoryMethod.Creators
{
    public interface IAggregate<T>
    {
        IRepository<T> CreateRepository();
    }
}
