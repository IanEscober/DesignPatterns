namespace Command.Commands
{
    using System.Threading.Tasks;
    using Command.Commands.Models;
    using Command.Receivers;

    public class CartCommand : ICommand<CartCommandModel>
    {
        private readonly ICommandHandler<CartCommandModel> cartCommandHandler;

        public CartCommand(ICommandHandler<CartCommandModel> cartCommandHandler)
        {
            this.cartCommandHandler = cartCommandHandler;
        }

        public Task ExecuteAsync(CartCommandModel commandModel)
        {
            return this.cartCommandHandler.HandleAsync(commandModel);
        }
    }
}
