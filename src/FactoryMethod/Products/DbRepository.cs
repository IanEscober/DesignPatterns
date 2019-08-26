using System;

namespace FactoryMethod.Products
{
    // Db Persistence Logic
    public class DbRepository<T> : IRepository<T>
    {
        private readonly object context;

        public DbRepository(object context)
        {
            this.context = context;
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
