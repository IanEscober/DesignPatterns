namespace Pipeline
{
    using System;
    using Pipeline.Handlers;
    using Pipeline.Pipelines;

    public class Client
    {
        public static void Main(string[] args)
        {
            var messageHandlerPipeline = PipelineCreator<MessageParserPipeline>
                .Create(
                    new MessageSplitHandler(),
                    new MessageTransformHandler(),
                    new MessageValidateHandler()
                );

            messageHandlerPipeline.Handle("Ultrasonic,100");
            messageHandlerPipeline.Handle("GPS,121.12");

            Console.ReadKey();
        }
    }
}
