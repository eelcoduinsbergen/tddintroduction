using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDIntro.Kata
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
