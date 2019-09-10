namespace Command.Commands
{
    using System.Threading.Tasks;
    using Command.Commands.Models;

    public interface ICommand<T> where T : ICommandModel
    {
        Task ExecuteAsync(T commandModel);
    }
}
