
using Challenges;
using Xunit;

namespace ChallengesTest
{
    public class BinarySearchTests
    {
        [Fact]
        public static void CenterOfTheEarth()
        {
            //arrange
            int[] arr = { 5, 10, 15, 20, 56, 420 };
            int key = 15;
            //act
            int result = ArrayChallenges.BinSearch(arr, key);
            //assert
            Assert.Equal(3, result);
        }
        [Fact]
        public static void dunGoof()
        {
            //arrange
            int[] arr = { 7, 14, 21, 28, 35, 42 };
            int key = 77;
            //act
            int result = ArrayChallenges.BinSearch(arr, key);
            //assert
            Assert.Equal(-1, result);
        }
    }
}