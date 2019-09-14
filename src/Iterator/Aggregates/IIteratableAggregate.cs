namespace Iterator.Aggregates
{
    using Iterator.Iterators;

    public interface IIteratableAggregate<T>
    {
        BaseIterator<T> CreateIterator();
    }
}
