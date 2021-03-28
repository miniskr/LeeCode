using System.Collections;
using System.Collections.Generic;
using Leecode.Solutions;
using Xunit;

namespace Leecode.Test
{
    public class SpiralMatrixTest
    {
        [Fact]
        public void Test()
        {
            var m1 = new int[][]
            {
                new int[] {1, 2, 3}, 
                new int[] {4, 5, 6},
                new int[] {7, 8, 9}
            };

            var s1 = Solution.SpiralOrder(m1);
            IList<int> res1 = new int[] {1, 2, 3, 6, 9, 8, 7, 4, 5};

            Assert.Equal(res1, s1);
        }
    }
}