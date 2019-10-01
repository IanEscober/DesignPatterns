namespace Strategy.Strategies
{
    using System.Text.RegularExpressions;

    public class NumericTinSanitizer : ITinSanitizer<string>
    {
        private static readonly Regex expression = new Regex("[^.0-9]");

        public string Santize(string input)
        {
            var result = expression.Replace(input, string.Empty);

            return result;
        }
    }
}
