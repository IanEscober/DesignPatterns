namespace Template
{
    using System;
    using System.Collections.Generic;

    public abstract class BaseCache<T>
    {
        private ICollection<T> cache;

        protected BaseCache(ICollection<T> cache)
        {
            this.cache = cache;
        }

        protected abstract void DoStore(ref ICollection<T> cache, T item);

        protected virtual void Connect()
        {
            Console.WriteLine("Connected to cache");
        }

        protected virtual bool IsExist(T item)
        {
            return this.cache.Contains(item);
        }

        public ICollection<T> Cache(T item)
        {
            this.Connect();

            if (!this.IsExist(item))
            {
                try
                {
                    this.DoStore(ref this.cache, item);
                }
                catch (Exception ex)
                {
                    throw new Exception("Cannot store to cache", ex);
                }
            }

            return this.cache;
        }
    }
}
