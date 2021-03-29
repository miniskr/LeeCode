using Leecode.Solutions;
using Xunit;

namespace Leecode.Test
{
    public class SearchMatrixTest
    {
        [Fact]
        public void Test()
        {
            var matrix1 = new int[][] {
                new int[] { 1, 3, 5, 7 },
                new int[] { 10, 11, 16, 20 },
                new int[] { 23, 30, 34, 60 }
            };
            var search1 = Solution.SearchMatrix(matrix1, 3);
            Assert.True(search1);
            var search2 = Solution.SearchMatrix(matrix1, 13);
            Assert.False(search2);
        }
    }
}
