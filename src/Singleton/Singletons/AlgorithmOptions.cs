namespace Singleton.Singletons
{
    using System;
    using System.Collections.Generic;

    public class AlgorithmOptions : ISingleton
    {
        private static readonly Lazy<AlgorithmOptions> lazy =
               new Lazy<AlgorithmOptions>(() => new AlgorithmOptions());

        public static ISingleton Instance => lazy.Value;

        public string Key => nameof(AlgorithmOptions);

        private static readonly Dictionary<string, double> Options = new Dictionary<string, double>
        {
            {"BFS_Multiplier", 2.0},
            {"DFS_Multiplier", 2.3},
            {"NeuralNetwork_Depth", 432.93}
        };

        public double GetAlgorithmOption(string algorithm) =>
            Options.GetValueOrDefault(algorithm);
    }
}
