using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDIntro.Kata.Canonicalizer;
using Xunit;

namespace TDDIntro.Kata.Tests
{
    public class CanonicalizerTests
    {
       /* 
        * A search string can be in different formats but have the same canonical value.
        * For example, a search for:
        * "best song Radiohead" or "radiohead best song" or "best RADIOHEAD song" have the same meaning
        * and can be transformed to a canonical form by applying some rules.
        *
        * - characters should be all uppercase
        * - words should be ordered alphabeticaly
        * - extra whitespaces should be removed
        * 
        * so the canonical form of "best song Radiohead" and "radiohead best song" is
        * "BEST RADIOHEAD SONG"
        */

        [Theory]
        [InlineData("radiohead best SONG", "BEST RADIOHEAD SONG")]
        [InlineData("best song radiohead", "BEST RADIOHEAD SONG")]
        [InlineData("radiohead song best", "BEST RADIOHEAD SONG")]
        [InlineData("   radiohead    song    best", "BEST RADIOHEAD SONG")]
        [InlineData(null, "")]
        [InlineData("", "")]
        [InlineData("Word", "WORD")]
        public void Words_Should_Be_Ordered_Alphabeticaly(string input, string expectedValue)
        {            
            var output = TDDCanonicalizer.Canonicalize(input);

            output.Should().Be(expectedValue);
        }
    }
}
