namespace Proxy.Subjects
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class FilterOperation<T> : IOperation<IEnumerable<T>>
    {
        private readonly ICollection<T> target;

        public FilterOperation(ICollection<T> target)
        {
            this.target = target;
        }

        public IEnumerable<T> Perfrom(params object[] args)
        {
            return this.target.Where(t => args.Contains(t));
        }
    }
}
