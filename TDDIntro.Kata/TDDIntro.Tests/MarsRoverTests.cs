using FluentAssertions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDIntro.Kata.MarsRover;

namespace TDDIntro.Tests
{
    public class MarsRoverTests
    {
        /*
         * Tests:
         *                  
         * 
         * Todos
         *          
         */     
        [Theory]
        [InlineData("fflff", Directions.East, 2,2)]
        [InlineData("bbrff", Directions.West, 8, 8)]
        [InlineData("lff", Directions.East, 2, 0)]
        public void Verify_Position_And_Direction_After_Command(string command, Directions expectedDirection, int expectedX, int expectedY)
        {
            MarsRover rover = new MarsRover(0, 0, new Direction(Directions.South), 10, 10);

            rover.ExecuteCommand(command);

            rover.Direction.Current.Should().Be(expectedDirection);
            rover.Position.Should().Be(new Position(expectedX, expectedY));            
        }
    }
}
