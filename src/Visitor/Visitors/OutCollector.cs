namespace Visitor.Visitors
{
    using System;
    using Visitor.Elements;

    public class OutCollector<T> : ICollector<T>
    {
        private readonly T input;

        public OutCollector(T input)
        {
            this.input = input;
        }

        public void VisitBlob(BlobBinding<T> blobBinding)
        {
            blobBinding.Bind(this.input);
            Console.WriteLine(" to output");
        }

        public void VisitQueue(QueueBinding<T> queueBinding)
        {
            queueBinding.Bind(this.input);
            Console.WriteLine(" to output");
        }
    }
}
