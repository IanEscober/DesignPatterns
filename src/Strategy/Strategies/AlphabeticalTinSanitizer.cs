namespace Strategy.Strategies
{
    using System.Text.RegularExpressions;

    public class AlphabeticalTinSanitizer : ITinSanitizer<string>
    {
        private static readonly Regex expression = new Regex("[^a-zA-Z]+");

        public string Santize(string input)
        {
            var result = expression.Replace(input, string.Empty);

            return result;
        }
    }
}
