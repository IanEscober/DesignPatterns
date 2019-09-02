namespace Builder.Builders
{
    using System.Collections.Generic;
    using System.Linq;

    public class BrokerConfigurationBuilder : IBrokenConfigurationBuilder
    {
        private readonly BrokerConfiguration brokerConfiguration;

        public BrokerConfigurationBuilder()
        {
            this.brokerConfiguration = new BrokerConfiguration
            {
                Topics = new List<string>()
            };
        }

        public BrokerConfiguration Build()
        {
            return this.brokerConfiguration;
        }

        public IBrokenConfigurationBuilder WithCleanSession(bool cleanSession)
        {
            this.brokerConfiguration.CleanSession = cleanSession;
            return this;
        }

        public IBrokenConfigurationBuilder WithClientId(string clientId)
        {
            this.brokerConfiguration.ClientID = clientId;
            return this;
        }

        public IBrokenConfigurationBuilder WithServer(string server)
        {
            this.brokerConfiguration.Server = server;
            return this;
        }

        public IBrokenConfigurationBuilder WithTopic(string topic)
        {
            this.brokerConfiguration.Topics = this.brokerConfiguration.Topics.Append(topic);
            return this;
        }

        public IBrokenConfigurationBuilder WithTopic(IEnumerable<string> topics)
        {
            this.brokerConfiguration.Topics = this.brokerConfiguration.Topics.Concat(topics);
            return this;
        }
    }
}
