namespace Facade
{
    using Facade.Actions;
    using Facade.Effects;
    using Facade.Reducers;
    using Facade.Selectors;
    using Facade.Store;

    public class StringFacade
    {
        private readonly IStore<string> store;
        private readonly ActionModel PopulateAction;
        private readonly IReducer<string> stringReducer;
        private readonly IEffect stringEffect;
        private readonly IQuery<string> stringSelector;

        public string TheString { get; set; }

        public StringFacade()
        {
            this.TheString = string.Empty;
            this.PopulateAction = new ActionModel() { Type = "Populate" };
            this.stringReducer = new StringReducer("");
            this.stringEffect = new StringEffect();
            this.stringSelector = new StringQuery();
            this.store = new StringStore(this.stringReducer, this.stringEffect);
        }

        public void Populate()
        {
            this.store.Dispatch(this.PopulateAction);
            this.TheString = this.Select();
        }

        private string Select()
        {
            return this.store.Select(this.stringReducer, this.stringSelector, this.PopulateAction);
        }


    }
}
