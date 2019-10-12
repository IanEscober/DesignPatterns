namespace Mediator.Mediators
{
    using System.Threading.Tasks;
    using Mediator.Models;

    public interface IMediator
    {
        Task SendAsync(IPayload payload);
        Task BroadcastAsync(IPayload payload);
    }
}
