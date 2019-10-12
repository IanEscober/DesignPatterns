namespace Mediator.Colleagues
{
    using System;
    using System.Threading.Tasks;
    using Mediator.Models;

    public class QueryHandler : IHandler<QueryPayload>
    {
        public Task HandleAsync(QueryPayload payload)
        {
            var task = Task.Run(() => Console.WriteLine($"Querying {payload.Query}"));
            return task;
        }
    }
}
