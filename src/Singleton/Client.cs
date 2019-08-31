namespace Singleton
{
    using System;
    using System.Collections.Generic;
    using Singleton.Singletons;

    public class Client
    {
        public static void Main(string[] args)
        {
            SingletonRegistry.Register(AlgorithmOptions.Instance);
            SingletonRegistry.Register(CollectionSeeder<int>.Instance);

            var algorithmOptions = SingletonRegistry.Retrieve(nameof(AlgorithmOptions)) as AlgorithmOptions;
            Console.WriteLine(algorithmOptions.GetAlgorithmOption("BFS_Multiplier"));
            Console.WriteLine(algorithmOptions.GetAlgorithmOption("NeuralNetwork_Depth"));

            var collectionSeeder = SingletonRegistry.Retrieve(nameof(CollectionSeeder<int>)) as CollectionSeeder<int>;
            Console.WriteLine(collectionSeeder.SeedCollection(typeof(List<int>), 3).Count);
            Console.WriteLine(collectionSeeder.SeedCollection(typeof(HashSet<int>), 5).Count);

            Console.ReadKey();
        }
    }
}
