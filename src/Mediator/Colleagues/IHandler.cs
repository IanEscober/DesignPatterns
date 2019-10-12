namespace Mediator.Colleagues
{
    using System.Threading.Tasks;
    using Mediator.Models;

    public interface IHandler<in T> where T : IPayload
    {
        Task HandleAsync(T payload);
    }
}
