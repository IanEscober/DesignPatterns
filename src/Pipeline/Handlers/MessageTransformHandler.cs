namespace Pipeline.Handlers
{
    using System;
    using Pipeline.Pipelines;

    public class MessageTransformHandler : MessageParserPipeline
    {
        public override void Handle(object message)
        {
            if (message.GetType() == typeof(string[]))
            {
                var parsedMessage = (string[])message;

                switch (parsedMessage[0])
                {
                    case "Ultrasonic":
                        this.Next((typeof(int), parsedMessage[1]));
                        break;
                    case "GPS":
                        this.Next((typeof(double), parsedMessage[1]));
                        break;
                    default:
                        throw new Exception("Type not supported");
                }
            }

            this.Next((message.GetType(), message));
        }
    }
}
