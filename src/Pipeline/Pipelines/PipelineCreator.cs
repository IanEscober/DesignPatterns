namespace Pipeline.Pipelines
{
    public static class PipelineCreator<T> where T : MessageParserPipeline
    {
        public static T Create(params T[] steps)
        {
            for (int i = 0; i < steps.Length - 1; i++)
            {
                steps[i].Successor = steps[i + 1];
            }

            return steps[0];
        }
    }
}
