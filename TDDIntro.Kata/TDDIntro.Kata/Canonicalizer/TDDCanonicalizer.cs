namespace TDDIntro.Kata.Canonicalizer
{
    public class TDDCanonicalizer
    {
        public static object Canonicalize(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return string.Empty;

            var result = input.ToUpper()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .OrderBy(s => s);

            return string.Join(' ', result);
        }
    }
}