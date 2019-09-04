namespace Facade.Reducers
{
    using Facade.Actions;

    public interface IReducer<T>
    {
        T CreateReducer(T state, ActionModel action);
    }
}
