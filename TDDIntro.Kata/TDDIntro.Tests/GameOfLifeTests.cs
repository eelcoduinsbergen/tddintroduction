using FluentAssertions;
using System.Data.Common;
using TDDIntro.Kata.GOL;

namespace TDDIntro.Tests
{
    public class GameOfLifeTests
    {
        /*
         * 
         * Living cell should die if it has less than 2 neighbours
         * Living cell with 2 or 3 neighbours stays alive
         * Living cell with more than 3 neighbours die
         * Dead cell with exactly 3 neighbours comes to life.
         * 
         * */

        private static bool[,] initialState = new bool[3, 3] { { false, false, false }, { true, true, true }, { false, false, false } };
        private static bool[,] expectedState = new bool[3, 3] { { false, false, false }, { true, true, true }, { false, false, false } };


        [Theory]
        [MemberData(nameof(TestData))]
        public void Test_Next_Gen(bool[,] initialState, bool[,] expectedState, int numberOfGenerations)
        {
            var sut = new GameOfLife(initialState);

            for (int i = 0; i < numberOfGenerations; i++)
            {
                sut.NextGen();
            }

            Assert.Equal(expectedState, sut.Board);
        }

        public static IEnumerable<object[]> TestData => new[]
        {
           new object[] { 
               new bool[3, 3] { { false, false, false }, { true, true, true }, { false, false, false } },
               new bool[3, 3] { { false, true, false }, { false, true, false}, { false, true, false } } ,1},
            new object[] {
               new bool[3, 3] { { false, false, false }, { true, true, true }, { false, false, false } },
               new bool[3, 3] { { false, false, false }, { true, true, true }, { false, false, false } } ,2}

        };
    

    }
}
