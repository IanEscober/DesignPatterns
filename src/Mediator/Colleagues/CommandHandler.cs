namespace Mediator.Colleagues
{
    using System;
    using System.Threading.Tasks;
    using Mediator.Models;

    public class CommandHandler : IHandler<CommandPayload>
    {
        public Task HandleAsync(CommandPayload payload)
        {
            var task = Task.Run(() =>
            {
                Console.WriteLine($"Executing {payload.Command} with arguments:");
                foreach (var arg in payload.Arguments)
                {
                    Console.Write(arg);
                }
            });

            return task;
        }
    }
}
