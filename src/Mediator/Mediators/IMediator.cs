namespace Mediator.Mediators
{
    using System.Threading.Tasks;
    using Mediator.Colleagues;

    public interface IMediator
    {
        Task<T> SendAsync<T>(IPayload<T> payload);
        Task BroadcastAsync<T>(IPayload<T> payload);
    }
}
