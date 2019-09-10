namespace Command.Receivers
{
    using System;
    using System.Threading.Tasks;
    using Command.Commands.Models;

    public class OrderCommandHandler : ICommandHandler<OrderCommandModel>
    {
        public Task HandleAsync(OrderCommandModel commandModel)
        {
            return Task.Run(() => Console.WriteLine($"Order Id: {commandModel.OrderId}, Quantity: {commandModel.Price}"));
        }
    }
}
