namespace Adapter.Adaptees
{
    using System;

    public class MessageBroadcaster<T> : IBroadcaster<T>
    {
        public void Broadcast(T item)
        {
            Console.WriteLine($"Broadcasted: {item.GetType()}");
        }
    }
}
