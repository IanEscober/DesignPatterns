namespace Visitor.Visitors
{
    using Visitor.Elements;

    public interface ICollector<T>
    {
        void VisitBlob(BlobBinding<T> blobBinding);
        void VisitQueue(QueueBinding<T> queueBinding);
    }
}
