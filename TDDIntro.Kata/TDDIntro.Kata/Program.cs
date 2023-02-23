// See https://aka.ms/new-console-template for more information
using TDDIntro.Kata.Canonicalizer;

//happy flow
Console.WriteLine(FailingCanonicalizer.Canonicalize("best song radiohead"));
Console.WriteLine(FailingCanonicalizer.Canonicalize("best radiohead song"));
Console.WriteLine(FailingCanonicalizer.Canonicalize("radiohead best song"));


//first error
//extra white spaces

Console.Read();
