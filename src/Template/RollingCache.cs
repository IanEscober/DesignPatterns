namespace Template
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RollingCache<T> : BaseCache<T>
    {
        public RollingCache(ICollection<T> cache) : base(cache) { }

        protected override void DoStore(ref ICollection<T> cache, T item)
        {
            var rolledCache = cache
                .Reverse()
                .Take(cache.Count - 1)
                .Reverse();

            cache = rolledCache.ToList();
            cache.Add(item);
        }
    }
}
