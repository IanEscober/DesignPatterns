namespace Singleton
{
    using System.Linq;
    using System.Collections.Generic;
    using Singleton.Singletons;

    public static class SingletonRegistry
    {
        private static List<ISingleton> Instances = new List<ISingleton>();

        public static void Register(ISingleton singleton) =>
            Instances.Add(singleton);

        public static ISingleton Retrieve(string key) =>
            Instances.SingleOrDefault(singleton => singleton.Key == key);
    }
}
