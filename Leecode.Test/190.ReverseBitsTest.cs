using Leecode.Solutions;
using Xunit;

namespace Leecode.Test
{
    public class ReverseBitsTest
    {
        [Fact]
        public void Test()
        {
            uint input1 = 0b0000_0010_1001_0100_0001_1110_1001_1100;
            uint res = 0b0011_1001_0111_1000_0010_1001_0100_0000;
            uint ret = Solution.ReverseBits(input1);
            Assert.Equal(res, ret);
        }
    }
}
