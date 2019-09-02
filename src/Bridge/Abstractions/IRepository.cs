namespace Bridge.Abstractions
{
    public interface IRepository<T>
    {
        T Get();
        void Set(T item);
    }
}
