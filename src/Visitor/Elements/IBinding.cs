namespace Visitor.Elements
{
    using Visitor.Visitors;

    public interface IBinding<T>
    {
        void Bind(T input);
        void Accept(ICollector<T> collector);
    }
}
