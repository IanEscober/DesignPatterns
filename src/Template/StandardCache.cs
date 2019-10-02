namespace Template
{
    using System.Collections.Generic;

    public class StandardCache<T> : BaseCache<T>
    {
        public StandardCache(ICollection<T> cache) : base(cache) { }

        protected override void DoStore(ref ICollection<T> cache, T item)
        {
            cache.Add(item);
        }
    }
}
