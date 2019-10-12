namespace Mediator.Mediators
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Mediator.Colleagues.Internal;
    using Mediator.Models;

    public class CqrsMediator : IMediator
    {
        private readonly IEnumerable<HandlerWrapper> handlers;

        public CqrsMediator(IEnumerable<HandlerWrapper> handlers)
        {
            this.handlers = handlers;
        }

        public Task BroadcastAsync(IPayload payload)
        {
            var tasks = new List<Task>();

            foreach (var handler in this.handlers)
            {
                if (this.MatchHandlerWithPayload(handler, payload))
                {
                    tasks.Add(handler.HandleAsync(payload));
                }
            }

            if (tasks.Any())
            {
                return Task.WhenAll(tasks);
            }

            return Task.CompletedTask;
        }

        public Task SendAsync(IPayload payload)
        {
            var handler = this.handlers.Single(h => this.MatchHandlerWithPayload(h, payload));
            return handler.HandleAsync(payload);
        }

        private bool MatchHandlerWithPayload(HandlerWrapper handler, IPayload payload)
        {
            return this.GetPayloadType(handler) == payload.GetType();
        }

        private Type GetPayloadType(HandlerWrapper handler)
        {
            return handler.GetType()
                .GenericTypeArguments[0];
        }
    }
}
