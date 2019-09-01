namespace Adapter.Adaptees
{
    using System;

    public class ReferenceTypeSerializer<T> : ISerializer<T> where T : class
    {
        public T Deserialize()
        {
            return default(T);
        }

        public void Serialize(T item)
        {
            Console.WriteLine($"Serialized: {item.GetType()}");
        }
    }
}
