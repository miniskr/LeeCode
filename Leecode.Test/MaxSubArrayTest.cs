using Leecode.Solutions;
using Xunit;

namespace Leecode.Test
{
    public class MaxSubArrayTest
    {
        [Fact]
        public void Test()
        {
            var arr1 = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            Assert.Equal(6, Solution.MaxSubArray(arr1));
            var arr2 = new int[] { 1 };
            Assert.Equal(1, Solution.MaxSubArray(arr2));
            var arr3 = new int[] { 5, 4, -1, 7, 8 };
            Assert.Equal(23, Solution.MaxSubArray(arr3));
        }
    }
}
