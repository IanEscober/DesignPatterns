namespace Mediator
{
    using System;
    using System.Threading.Tasks;
    using Mediator.Colleagues;
    using Mediator.Colleagues.Internal;
    using Mediator.Mediators;
    using Mediator.Models;

    public class Client
    {
        public static async Task Main(string[] args)
        {
            var commandHandler = new HandlerWrapperImp<CommandPayload>(new CommandHandler());
            var queryHandler = new HandlerWrapperImp<QueryPayload>(new QueryHandler());
            var handlers = new HandlerWrapper[] { commandHandler, queryHandler, queryHandler };
            var cqrsMediator = new CqrsMediator(handlers);

            await cqrsMediator.SendAsync(new QueryPayload { Query = "Filter" });

            Console.ReadKey();
        }
    }
}
