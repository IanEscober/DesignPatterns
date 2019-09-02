namespace Builder
{
    using System.Collections.Generic;
    using System.Text;

    public class BrokerConfiguration
    {
        public string ClientID { get; set; }
        public bool CleanSession { get; set; }
        public string Server { get; set; }
        public IEnumerable<string> Topics { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Client ID: {this.ClientID}");
            stringBuilder.AppendLine($"Clean Session: {this.CleanSession}");
            stringBuilder.AppendLine($"Server: {this.Server}");

            stringBuilder.AppendLine($"Topics:");
            foreach (var item in this.Topics)
            {
                stringBuilder.AppendLine(item);
            }

            return stringBuilder.ToString();
        }
    }
}
