namespace Proxy.Subjects
{
    using System.Collections.Generic;

    public class ConcatOperation<T> : IOperation<IEnumerable<T>>
    {
        private readonly ICollection<T> target;

        public ConcatOperation(ICollection<T> target)
        {
            this.target = target;
        }

        public IEnumerable<T> Perfrom(params object[] args)
        {
            foreach (var item in args)
            {
                this.target.Add((T)item);
            }
            return this.target;
        }
    }
}
