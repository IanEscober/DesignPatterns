namespace Facade.Store
{
    using Facade.Actions;
    using Facade.Reducers;
    using Facade.Selectors;

    public interface IStore<T>
    {
        void Dispatch(ActionModel action);
        T Select(IReducer<T> reducer, IQuery<T> query, ActionModel action);
    }
}
