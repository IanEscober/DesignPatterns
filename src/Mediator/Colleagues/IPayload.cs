namespace Mediator.Colleagues
{
    using System.Threading.Tasks;

    public interface IPayload<T>
    {
        T Message { get; }
        Task ConnectAsync();
        Task PublishAsync();
    }
}
