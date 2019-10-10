namespace Mediator.Colleagues
{
    using System.Threading.Tasks;
    using Mediator.Mediators;

    public class CommandPayload<T> : IPayload<T>
    {
        private readonly IMediator mediator;

        public CommandPayload(IMediator mediator, T command)
        {
            this.mediator = mediator;
            this.Message = command;
        }

        public T Message { get; }

        public Task ConnectAsync()
        {
            return this.mediator.SendAsync(this);
        }

        public Task PublishAsync()
        {
            return this.mediator.BroadcastAsync(this);
        }
    }
}
