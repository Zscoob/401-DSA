using System;
using Xunit;

namespace Challenges.Test
{

    public class ArrayShiftTests
    {
        [Theory]
        [InlineData(new[] { 0, 1, 2, 3 }, new[] { 0, 1, 5, 2, 3 })]
        public void shift(int[] input, int[] expected)
        {
            //arrange
            int numInput = 5;
            //act
            int[] result = ArrayChallenges.shiftedArr(input, numInput);
            //assert
            Assert.Equal(expected, result);

        }
        [Fact]
        public void ShiftTests()
        {
            //arrange
            int[] arrInp = new int[4] { 1, 2, 3, 4 };
            int num = 5;
            int[] expected = new int[5] { 1, 2, 5, 3, 4 };

            //act
            int[] result = ArrayChallenges.shiftedArr(arrInp, num);

            //assert
            Assert.Equal(expected, result);

        }

    }
}
