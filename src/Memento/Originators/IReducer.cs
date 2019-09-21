namespace Memento.Originators
{
    using System;
    using System.Collections.Generic;

    public interface IReducer<T>
    {
        IReadOnlyCollection<T> CurrentState { get; }
        void Fallback(IEnumerable<T> states);
        void Reduce(Func<T, T> action);
    }
}