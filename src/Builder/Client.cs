namespace Builder
{
    using System;
    using Builder.Builders;
    using Builder.Directors;

    public class Client
    {
        public static void Main(string[] args)
        {
            var brokerConfigBuilder = new BrokerConfigurationBuilder();
            var brokerConfigDirector = new BrokerConfigurationDirector(brokerConfigBuilder);

            var brokerConfig = brokerConfigDirector
                .Initialize("You-Source", true, "api.you-source.com")
                .AddTopic("Sensor Topic")
                .AddTopics(new[] { "Queue Topic", "Key Topic" })
                .Generate();

            Console.WriteLine(brokerConfig);

            Console.ReadKey();
        }
    }
}
