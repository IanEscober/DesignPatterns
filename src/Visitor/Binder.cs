namespace Visitor
{
    using System.Collections.Generic;
    using Visitor.Elements;
    using Visitor.Visitors;

    public class Binder<T>
    {
        private readonly IEnumerable<IBinding<T>> bindings;

        public Binder(IEnumerable<IBinding<T>> bindings)
        {
            this.bindings = bindings;
        }

        public void Accept(ICollector<T> direction)
        {
            foreach (var binding in this.bindings)
            {
                binding.Accept(direction);
            }
        }
    }
}
