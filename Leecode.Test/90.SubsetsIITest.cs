using Leecode.Solutions;
using Xunit;

namespace Leecode.Test
{
    public class SubsetsIITest
    {
        [Fact]
        public void Test()
        {
            var nums1 = new int[] { 1, 2, 2 };
            var res1 = new int[][] { 
                new int[0], 
                new int[] { 1 }, 
                new int[] { 1, 2 }, 
                new int[] { 1, 2, 2 }, 
                new int[] { 2 }, 
                new int[] { 2, 2 } 
            };

            var ret1 = Solution.SubsetsWithDup(nums1);
            Assert.Equal(res1, ret1);

        }
    }
}
