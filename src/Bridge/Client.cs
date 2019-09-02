namespace Bridge
{
    using System;
    using Bridge.Abstractions;
    using Bridge.Implementors;

    public class Client
    {
        public static void Main(string[] args)
        {
            var cache = new CacheRepositoryImp<string>();
            var db = new DbRepositoryImp<string>();

            var userCacheRepository = new UserRepository(cache);
            var userDbRepository = new UserRepository(db);

            userCacheRepository.Set("User to Cache");
            userDbRepository.Set("User to Db");

            Console.ReadKey();
        }
    }
}
