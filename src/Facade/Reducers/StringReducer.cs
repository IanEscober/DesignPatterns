namespace Facade.Reducers
{
    using Facade.Actions;

    public class StringReducer : IReducer<string>
    {
        private readonly string State;

        public StringReducer(string initialState)
        {
            this.State = initialState;
        }

        public string CreateReducer(string state, ActionModel action)
        {
            switch (action.Type)
            {
                case "Populate":
                    return "ABC";
                default:
                    return state;
            }
        }
    }
}
