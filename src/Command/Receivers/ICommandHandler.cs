namespace Command.Receivers
{
    using System.Threading.Tasks;
    using Command.Commands.Models;

    public interface ICommandHandler<T> where T : ICommandModel
    {
        Task HandleAsync(T commandModel);
    }
}
