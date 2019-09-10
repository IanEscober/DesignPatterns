namespace Command.Invokers
{
    using System.Threading.Tasks;
    using Command.Commands;
    using Command.Commands.Models;

    public class Store
    {
        private readonly ICommand<CartCommandModel> cartCommand;
        private readonly ICommand<OrderCommandModel> orderCommand;

        public Store(ICommand<CartCommandModel> cartCommand, ICommand<OrderCommandModel> orderCommand)
        {
            this.cartCommand = cartCommand;
            this.orderCommand = orderCommand;
        }

        public Task AddToCart(int productId, int quantity)
        {
            return this.cartCommand.ExecuteAsync(new CartCommandModel() { ProductId = productId, Quantity = quantity });
        }

        public Task PlaceOrder(int orderId, int Price)
        {
            return this.orderCommand.ExecuteAsync(new OrderCommandModel() { OrderId = orderId, Price = Price });
        }
    }
}
