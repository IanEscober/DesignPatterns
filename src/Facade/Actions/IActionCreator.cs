namespace Facade.Actions
{
    public interface IActionCreator
    {
        ActionModel CreateAction(string type, params object[] props);
    }
}
