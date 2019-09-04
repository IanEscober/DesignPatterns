namespace Facade.Store
{
    using Facade.Actions;
    using Facade.Effects;
    using Facade.Reducers;
    using Facade.Selectors;

    public class StringStore : IStore<string>
    {
        private readonly IReducer<string> reducer;
        private readonly IEffect effect;

        public StringStore(IReducer<string> reducer, IEffect effect)
        {
            this.reducer = reducer;
            this.effect = effect;
        }

        public void Dispatch(ActionModel action)
        {

            var result = this.reducer.CreateReducer("", action);
            this.effect.CreateEffect(action);

        }

        public string Select(IReducer<string> reducer, IQuery<string> query, ActionModel action)
        {
            var selectedFeature = query.CreateSelector(reducer, query, action);

            return selectedFeature;
        }
    }
}
