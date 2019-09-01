namespace Adapter.Adapters.Object
{
    using System;
    using Adapter.Adaptees;

    public class MessageManager<T> : IBroadcaster<T>
    {
        private readonly ISerializer<T> serializer;

        public MessageManager(ISerializer<T> serializer)
        {
            this.serializer = serializer;
        }

        public void Broadcast(T item)
        {
            this.serializer.Serialize(item);
            Console.WriteLine($"Broadcasted: {item.GetType()}");
        }
    }
}
