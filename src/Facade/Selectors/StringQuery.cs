namespace Facade.Selectors
{
    using Facade.Actions;
    using Facade.Reducers;

    public class StringQuery : IQuery<string>
    {
        public string CreateFeatureSelector(IReducer<string> reducer, ActionModel action)
        {
            return reducer.CreateReducer("", action);
        }

        public string CreateSelector(IReducer<string> reducer, IQuery<string> query, ActionModel action)
        {
            return query.CreateFeatureSelector(reducer, action);
        }
    }
}
