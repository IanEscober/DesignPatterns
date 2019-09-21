namespace Memento
{
    using System;
    using System.Collections.Generic;
    using Memento.Mementos;
    using Memento.Originators;

    public class Caretaker
    {
        public static void Main(string[] args)
        {
            var defaultState = new[] { 1, 2, 3 };
            var store = new Store<int>(defaultState);
            var reducer = new Reducer<int>(store);

            PrintState(reducer.CurrentState);

            reducer.Reduce(act => ++act);
            PrintState(reducer.CurrentState);
            var storedState = reducer.CurrentState;

            reducer.Reduce(act => --act);
            PrintState(reducer.CurrentState);

            reducer.Fallback(storedState);
            reducer.Reduce(act => ++act);
            PrintState(reducer.CurrentState);

            Console.ReadKey();
        }

        private static void PrintState(IReadOnlyCollection<int> states)
        {
            foreach (var state in states)
            {
                Console.Write($"{state}");
            }
            Console.WriteLine();
        }
    }
}
