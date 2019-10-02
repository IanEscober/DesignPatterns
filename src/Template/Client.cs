namespace Template
{
    using System;
    using System.Collections.Generic;

    public class Client
    {
        public static void Main(string[] args)
        {
            var standardCache = new StandardCache<int>(new List<int> { 1, 2 });
            var rollingCache = new RollingCache<int>(new List<int> { 1, 2, 3, 4, 5, 6 });

            Console.WriteLine(nameof(standardCache));
            foreach (var item in standardCache.Cache(3))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(nameof(rollingCache));
            foreach (var item in rollingCache.Cache(7))
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
