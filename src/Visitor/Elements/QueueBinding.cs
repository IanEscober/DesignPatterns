namespace Visitor.Elements
{
    using System;
    using Visitor.Visitors;

    public class QueueBinding<T> : IBinding<T>
    {
        public void Accept(ICollector<T> collector)
        {
            collector.VisitQueue(this);
        }

        public void Bind(T input)
        {
            Console.Write($"Binding Queue of type: {typeof(T)}");
        }
    }
}
