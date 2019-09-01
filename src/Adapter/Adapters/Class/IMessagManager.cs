namespace Adapter.Adapters.Class
{
    using Adapter.Adaptees;

    public interface IMessagManager<T> : IBroadcaster<T>, ISerializer<T>
    {
        // Inherits from the needed adaptees 
        // Essentially a wrapper
    }
}
