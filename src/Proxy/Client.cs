namespace Proxy
{
    using System;
    using System.Collections.Generic;
    using Proxy.Proxies;
    using Proxy.Subjects;

    public class Client
    {
        public static void Main(string[] args)
        {
            var filterOpt = new FilterOperation<string>(new string[] { "a", "b", "c" });
            var filterOptProxy = new FilterOperationProxy<string>(filterOpt);
            var concatOpt = new ConcatOperation<int>(new List<int> { 1, 2, 3 });
            var concatOptProxy = new ConcatOperationProxy<int>(concatOpt);

            var filterResult = filterOptProxy.Perfrom("a", "b");
            filterResult = filterOptProxy.Perfrom("a", "b");

            var concatResult = concatOptProxy.Perfrom(4);
            concatResult = concatOptProxy.Perfrom(5, 6);

            Console.ReadKey();
        }
    }
}
