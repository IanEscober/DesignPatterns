namespace Command.Receivers
{
    using System;
    using System.Threading.Tasks;
    using Command.Commands.Models;

    public class CartCommandHandler : ICommandHandler<CartCommandModel>
    {
        public Task HandleAsync(CartCommandModel commandModel)
        {
            return Task.Run(() => Console.WriteLine($"Product Id: {commandModel.ProductId}, Quantity: {commandModel.Quantity}"));
        }
    }
}
