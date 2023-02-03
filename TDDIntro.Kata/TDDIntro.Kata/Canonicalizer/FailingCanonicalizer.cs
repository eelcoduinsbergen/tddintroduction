namespace TDDIntro.Kata.Canonicalizer
{
    internal static class FailingCanonicalizer
    {
        public static string Canonicalize(string input)
        {
            return input.Split(new char[] { ' ' })
                .Select(s => s.ToUpper())
                .OrderBy(s => s)
                .Aggregate((a, b) => a + " " + b);
        }
    }
}
