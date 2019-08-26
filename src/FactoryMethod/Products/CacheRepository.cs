using System;

namespace FactoryMethod.Products
{
    // Cache Persistence Logic
    public class CacheRepository<T> : IRepository<T>
    {
        private readonly object serializer;

        public CacheRepository(object serializer)
        {
            this.serializer = serializer;
        }

        public void Delete(int id)
        {
            if (id > 0)
            {
                return;
            }
            throw new ArgumentOutOfRangeException();
        }

        public T Get(int id)
        {
            if (id > 0)
            {
                return default(T);
            }
            throw new ArgumentOutOfRangeException();
        }

        public T Set(T item)
        {
            return item;
        }

        public T Update(T item)
        {
            return item;
        }
    }
}
