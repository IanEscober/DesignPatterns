namespace Adapter
{
    using System;
    using Adapter.Adaptees;
    using Adapter.Adapters.Object;

    public class Client
    {
        public static void Main(string[] args)
        {
            var target = new MessageManager<string>(new ReferenceTypeSerializer<string>());
            target.Broadcast("Message");

            Console.ReadKey();
        }
    }
}
