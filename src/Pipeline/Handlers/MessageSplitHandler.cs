namespace Pipeline.Handlers
{
    using Pipeline.Pipelines;

    public class MessageSplitHandler : MessageParserPipeline
    {
        public override void Handle(object message)
        {
            var result = message;

            if (message.GetType() == typeof(string))
            {
                result = ((string)message).Split(',');
            }

            this.Next(result);
        }
    }
}
