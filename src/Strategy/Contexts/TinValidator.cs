namespace Strategy.Contexts
{
    using Strategy.Strategies;

    public class TinValidator : ITinValidator
    {
        private readonly ITinSanitizer<string> tinSanitizer;

        public TinValidator(ITinSanitizer<string> tinSanitizer)
        {
            this.tinSanitizer = tinSanitizer;
        }

        public string ValidateTin(string tin)
        {
            var result = string.Empty;

            if (!string.IsNullOrEmpty(tin))
            {
                result = this.tinSanitizer.Santize(tin);
            }

            return result;
        }
    }
}
