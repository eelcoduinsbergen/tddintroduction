using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TDDIntro.Kata.Tests
{
    public class CanonicalizerTests
    {
        //A search string can be in different formats but have the same canonical value.
        //For example, a search for:
        //"best song Radiohead" or "radiohead best song" or "best RADIOHEAD song" have the same meaning
        //and can be transformed to a canonical form "BEST RADIOHEAD SONG" by applying some rules.
        //
        //- characters should be all uppercase
        //- words should be ordered alphabeticaly
        //- extra whitespaces should be removed                
    }
}
