namespace Singleton.Singletons
{
    using System;
    using System.Collections.Generic;

    public class CollectionSeeder<T> : ISingleton
    {
        private static readonly Lazy<CollectionSeeder<T>> lazy =
               new Lazy<CollectionSeeder<T>>(() => new CollectionSeeder<T>());

        public static ISingleton Instance => lazy.Value;

        public string Key => nameof(CollectionSeeder<T>);

        private static readonly Dictionary<Type, ICollection<T>> Collections = new Dictionary<Type, ICollection<T>>
        {
            { typeof(List<T>), new List<T>() },
            { typeof(HashSet<T>), new HashSet<T>() }
        };

        public ICollection<T> SeedCollection(Type t, int seedCount)
        {
            if (Collections.ContainsKey(t))
            {
                Collections[t].Clear();
                for (int i = 0; i < seedCount; i++)
                {
                    Collections[t].Add(default);
                }

                return Collections[t];
            }

            throw new Exception("Collection is not supported");
        }
    }
}
