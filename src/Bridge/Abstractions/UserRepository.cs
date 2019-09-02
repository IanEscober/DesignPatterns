namespace Bridge.Abstractions
{
    using System;
    using Bridge.Implementors;

    public class UserRepository : IRepository<string>
    {
        private readonly IRepositoryImp<string> repositoryImp;

        public UserRepository(IRepositoryImp<string> repositoryImp)
        {
            this.repositoryImp = repositoryImp;
        }

        public string Get()
        {
            var result = this.repositoryImp.Read();
            return result;
        }

        public void Set(string item)
        {
            Console.WriteLine($"Persisted: {item}");
            this.repositoryImp.Write(item);
        }
    }
}
