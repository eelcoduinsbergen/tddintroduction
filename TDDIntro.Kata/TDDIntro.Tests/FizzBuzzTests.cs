using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDIntro.Tests
{
    /*
     * if divisible by 3: return "Fizz"
     * if divisible by 5: return "Buzz"
     * if divisible by 3 and 5: return "FizzBuzz"
     * otherwise: return ""
     */
    public class FizzBuzzTests
    {
        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        public void Divisible_By_3_Should_Return_Fizz(int input)
        {
            //Arrange            
            var expectedResult = "Fizz";

            //Act
            var result = FizzBuzz(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Divisible_By_5_Should_Return_Buzz(int input)
        {
            //Arrange            
            var expectedResult = "Buzz";

            //Act
            var result = FizzBuzz(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(45)]
        public void Divisible_By_3_and_5_Should_Return_FizzBuzz(int input)
        {
            //Arrange            
            var expectedResult = "FizzBuzz";

            //Act
            var result = FizzBuzz(input);

            //Assert
            result.Should().Be(expectedResult);
        }    


        [Theory]
        [InlineData(4)]
        [InlineData(7)]        
        public void Not_Divisible_By_3_Or_5_Should_Return_Empty_String(int input)
        {
            var expectedResult = "";

            //Act
            var result = FizzBuzz(input);

            //Assert
            result.Should().Be(expectedResult);
        }

        private string FizzBuzz(int input)
        {
            string result = string.Empty;
                        
            if(input % 3 == 0)
            {
                result = "Fizz";
            }
            
            if (input % 5 == 0)
            {
                result += "Buzz";
            }

            return result;
        }
    }
}
