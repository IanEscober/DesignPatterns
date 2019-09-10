namespace Command.Commands
{
    using System.Threading.Tasks;
    using Command.Commands.Models;
    using Command.Receivers;

    public class OrderCommand : ICommand<OrderCommandModel>
    {
        private readonly ICommandHandler<OrderCommandModel> commandHandler;

        public OrderCommand(ICommandHandler<OrderCommandModel> commandHandler)
        {
            this.commandHandler = commandHandler;
        }

        public Task ExecuteAsync(OrderCommandModel commandModel)
        {
            return this.commandHandler.HandleAsync(commandModel);
        }
    }
}
