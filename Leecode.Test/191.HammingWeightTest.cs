using Leecode.Solutions;
using Xunit;

namespace Leecode.Test
{
    public class HammingWeightTest
    {
        [Fact]
        public void Test()
        {
            const uint b1 = 0b00000000000000000000000000001011;
            var res = Solution.HammingWeight(b1);
            Assert.Equal(3, res);

            const uint b2 = 0b00000000000000000000000010000000;
            res = Solution.HammingWeight(b2);
            Assert.Equal(1,res);

            const uint b3 = 0b11111111111111111111111111111101;
            res = Solution.HammingWeight(b3);
            Assert.Equal(31, res);
        }
    }
}