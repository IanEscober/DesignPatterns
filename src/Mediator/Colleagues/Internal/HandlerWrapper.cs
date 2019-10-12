namespace Mediator.Colleagues.Internal
{
    using System.Threading.Tasks;
    using Mediator.Models;

    public abstract class HandlerWrapper
    {
        public abstract Task HandleAsync(IPayload payload);
    }

    public class HandlerWrapperImp<T> : HandlerWrapper where T : IPayload
    { 
        private readonly IHandler<T> handler;

        public HandlerWrapperImp(IHandler<T> handler)
        {
            this.handler = handler;
        }

        public override Task HandleAsync(IPayload payload)
        {
            return this.handler.HandleAsync((T)payload);
        }
    }
}
