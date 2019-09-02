namespace Builder.Builders
{
    using System.Collections.Generic;

    public interface IBrokenConfigurationBuilder
    {
        BrokerConfiguration Build();
        IBrokenConfigurationBuilder WithClientId(string clientId);
        IBrokenConfigurationBuilder WithCleanSession(bool cleanSession);
        IBrokenConfigurationBuilder WithServer(string server);
        IBrokenConfigurationBuilder WithTopic(string topic);
        IBrokenConfigurationBuilder WithTopic(IEnumerable<string> topics);
    }
}
