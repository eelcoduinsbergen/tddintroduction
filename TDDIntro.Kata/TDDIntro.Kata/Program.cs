// See https://aka.ms/new-console-template for more information
using TDDIntro.Kata;

Console.WriteLine(FailingCanonicalizer.Canonicalize("Groenten zijn goed voor iedereen"));
Console.WriteLine(FailingCanonicalizer.Canonicalize("zijn groenten iedereen goed voor"));
Console.WriteLine(FailingCanonicalizer.Canonicalize("voor groenten Zijn IEDEREEN goed"));


//first error: fix it
//Console.WriteLine(FailingCanonicalizer.Canonicalize(null));

//extra wite spaces: fix it
//Console.WriteLine(FailingCanonicalizer.Canonicalize("voor             groenten            Zijn IEDEREEN goed"));

Console.Read();
