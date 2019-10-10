namespace Mediator.Colleagues
{
    using System.Threading.Tasks;
    using Mediator.Mediators;

    public class QueryPayload<T> : IPayload<T>
    {
        private readonly IMediator mediator;

        public QueryPayload(IMediator mediator, T query)
        {
            this.mediator = mediator;
            this.Message = query;
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
