namespace Pipeline.Pipelines
{
    public abstract class MessageParserPipeline
    {
        public abstract void Handle(object message);

        public MessageParserPipeline Successor { get; set; }

        public void Next(object message)
        {
            if (this.Successor != null)
            {
                this.Successor.Handle(message);
            }
        }
    }
}
