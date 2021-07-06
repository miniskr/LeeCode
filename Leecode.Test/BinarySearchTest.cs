using Leecode.Solutions;
using Xunit;

namespace Leecode.Test
{
    public class BinarySearchTest
    {
        [Fact]
        public void Test()
        {
            var arr1 = new int[] { -1, 0, 3, 5, 9, 12 };
            Assert.Equal(4, Solution.BinarySearch(arr1, 9));
            var arr2 = new int[] { -1, 0, 3, 5, 9, 12 };
            Assert.Equal(-1, Solution.BinarySearch(arr2, 2));
        }
    }
}
