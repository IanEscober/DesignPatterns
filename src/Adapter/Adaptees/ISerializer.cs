namespace Adapter.Adaptees
{
    public interface ISerializer<T>
    {
        void Serialize(T item);
        T Deserialize();
    }
}
