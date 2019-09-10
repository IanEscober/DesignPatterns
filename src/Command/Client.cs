namespace Command
{
    using System;
    using System.Threading.Tasks;
    using Command.Commands;
    using Command.Invokers;
    using Command.Receivers;

    public class Client
    {
        public async static Task Main(string[] args)
        {
            var cartCommand = new CartCommand(new CartCommandHandler());
            var orderCommand = new OrderCommand(new OrderCommandHandler());
            var store = new Store(cartCommand, orderCommand);

            await store.AddToCart(1, 2);
            await store.PlaceOrder(3, 4);

            Console.ReadKey();
        }
    }
}
