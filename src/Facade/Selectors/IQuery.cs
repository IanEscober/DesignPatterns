namespace Facade.Selectors
{
    using Facade.Actions;
    using Facade.Reducers;

    public interface IQuery<T>
    {
        T CreateFeatureSelector(IReducer<T> reducer, ActionModel action);
        T CreateSelector(IReducer<T> reducer, IQuery<T> query, ActionModel action);
    }
}
