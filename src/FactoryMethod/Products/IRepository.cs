namespace FactoryMethod.Products
{
    public interface IRepository<T>
    {
        T Get(int id);
        T Set(T item);
        T Update(T item);
        void Delete(int id);
    }
}
