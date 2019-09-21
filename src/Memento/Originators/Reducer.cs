namespace Memento.Originators
{
    using System;
    using System.Collections.Generic;
    using Memento.Mementos;

    public class Reducer<T> : IReducer<T>
    {
        private readonly IStore<T> store;

        public Reducer(IStore<T> store)
        {
            this.store = store;
        }

        public IReadOnlyCollection<T> CurrentState => this.store.States();

        public void Reduce(Func<T, T> action)
        {
            var currentIndex = this.store.StatesLength - 1;
            var current = this.store.StateAt(currentIndex);
            var next = action(current);

            this.store.AddState(next);
        }

        public void Fallback(IEnumerable<T> states)
        {
            this.store.SetStates(states);
        }
    }
}
