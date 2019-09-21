namespace Memento.Mementos
{
    using System.Collections.Generic;
    using System.Linq;

    public class Store<T> : IStore<T>
    {
        private List<T> states;

        public Store(IEnumerable<T> states)
        {
            this.states = states.ToList();
        }

        public int StatesLength => this.states.Count;

        public T StateAt(int index)
        {
            return this.states.ElementAtOrDefault(index);
        }

        public IReadOnlyCollection<T> States()
        {
            return this.states.AsReadOnly();
        }

        public void AddState(T state)
        {
            this.states.Add(state);
        }

        public void SetStates(IEnumerable<T> states)
        {
            this.states = states.ToList();
        }
    }
}
