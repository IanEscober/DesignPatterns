namespace Proxy.Proxies
{
    using Proxy.Subjects;
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class FilterOperationProxy<T> : IOperation<IEnumerable<T>>
    {
        private readonly Dictionary<object[], IEnumerable<T>> cache;
        private readonly IOperation<IEnumerable<T>> operation;

        public FilterOperationProxy(IOperation<IEnumerable<T>> operation)
        {
            this.cache = new Dictionary<object[], IEnumerable<T>>();
            this.operation = operation;
        }

        public IEnumerable<T> Perfrom(params object[] args)
        {
            if (this.DeepEqual(args, out var cachedResult))
            {
                Console.WriteLine("Cached Operation");
                return cachedResult;
            }

            Console.WriteLine("New Operation");
            var newResult = this.operation.Perfrom(args);
            this.cache.Add(args, newResult);
            return newResult;
        }

        private bool DeepEqual(object[] compare, out IEnumerable<T> result)
        {
            foreach (var item in this.cache)
            {
                for (int i = 0; i < compare.Length; i++)
                {
                    if (item.Key[i] != compare[i])
                    {
                        result = default;
                        return false;
                    }
                }

                result = item.Value;
                return true;
            }

            result = default;
            return false;
        }
    }
}
