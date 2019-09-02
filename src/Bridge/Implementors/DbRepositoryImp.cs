namespace Bridge.Implementors
{
    using System;

    public class DbRepositoryImp<T> : IRepositoryImp<T>
    {
        public T Read()
        {
            return default(T);
        }

        public void Write(T item)
        {
            Console.WriteLine($"{item} is stored to DB");
        }
    }
}
