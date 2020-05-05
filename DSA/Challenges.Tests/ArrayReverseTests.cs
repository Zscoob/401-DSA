using System;
using Xunit;

namespace Challenges.Tests
{
    public class ArrayReverseTests

    {
        [Theory]
        [InlineData(new[] { 2, 3, 4, 5 }, new[] { 5, 4, 3, 2 })]
        [InlineData(new[] { 4, 2, 1, 3 }, new[] { 3, 1, 2, 4 })]
        
        public void ReverseNums(int[] input, int[] expected)
        {
            //arrange
            //act
            int[] output = ArrayChallenges.EsreverYarra(input);
            //assert
            Assert.Equal(expected, output);

            Assert.NotSame(input, output);
        }
    }
}
