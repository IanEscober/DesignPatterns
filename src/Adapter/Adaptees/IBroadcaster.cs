namespace Adapter.Adaptees
{
    public interface IBroadcaster<T>
    {
        void Broadcast(T item);
    }
}
