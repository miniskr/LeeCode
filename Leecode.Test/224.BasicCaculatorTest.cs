using Leecode.Solutions;
using Xunit;

namespace Leecode.Test
{
    public class BasicCaculatorTest
    {
        [Fact]
        public void Test()
        {
            const string s1 = "1 + 1";
            var s2 = "2-1 +2";
            var s3 = "(1+(4+5+2)-3)+(6+8)";

            var res1 = Solution.BasicCaculator(s1);
            Assert.Equal(2, res1);

            var res2 = Solution.BasicCaculator(s2);
            Assert.Equal(3, res2);

            var res3 = Solution.Caculator(s3);
            Assert.Equal(23, res3);
        }
    }
}