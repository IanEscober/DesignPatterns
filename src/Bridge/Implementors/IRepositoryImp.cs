namespace Bridge.Implementors
{
    public interface IRepositoryImp<T>
    {
        T Read();
        void Write(T item);
    }
}
