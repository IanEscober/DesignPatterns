namespace Visitor.Elements
{
    using System;
    using Visitor.Visitors;

    public class BlobBinding<T> : IBinding<T>
    {
        public void Accept(ICollector<T> collector)
        {
            collector.VisitBlob(this);
        }

        public void Bind(T input)
        {
            Console.Write($"Binding Blob of type: {typeof(T)}");
        }
    }
}
