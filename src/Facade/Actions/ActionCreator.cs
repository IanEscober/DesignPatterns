namespace Facade.Actions
{
    public class ActionCreator : IActionCreator
    {
        public ActionModel CreateAction(string type, params object[] props)
        {
            return new ActionModel()
            {
                Type = type,
                Props = props
            };
        }
    }
}
