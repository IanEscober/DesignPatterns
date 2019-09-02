namespace Builder.Directors
{
    using System.Collections.Generic;
    using Builder.Builders;

    public class BrokerConfigurationDirector
    {
        private readonly IBrokenConfigurationBuilder brokenConfigurationBuilder;

        public BrokerConfigurationDirector(IBrokenConfigurationBuilder brokenConfigurationBuilder)
        {
            this.brokenConfigurationBuilder = brokenConfigurationBuilder;
        }

        public BrokerConfigurationDirector Initialize(string clientId, bool cleanSession, string server)
        {
            this.brokenConfigurationBuilder
                .WithClientId(clientId)
                .WithCleanSession(cleanSession)
                .WithServer(server);

            return this;
        }

        public BrokerConfigurationDirector AddTopic(string topic)
        {
            this.brokenConfigurationBuilder.WithTopic(topic);

            return this;
        }

        public BrokerConfigurationDirector AddTopics(IEnumerable<string> topics)
        {
            this.brokenConfigurationBuilder.WithTopic(topics);

            return this;
        }

        public BrokerConfiguration Generate()
        {
            return this.brokenConfigurationBuilder.Build();
        }
    }
}
