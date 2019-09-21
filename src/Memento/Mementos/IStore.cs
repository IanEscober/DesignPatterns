namespace Memento.Mementos
{
    using System.Collections.Generic;

    public interface IStore<T>
    {
        int StatesLength { get; }

        void AddState(T state);
        void SetStates(IEnumerable<T> states);
        T StateAt(int index);
        IReadOnlyCollection<T> States();
    }
}