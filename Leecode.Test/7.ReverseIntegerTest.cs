using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leecode.Solutions;
using Xunit;

namespace Leecode.Test
{
    public class ReverseIntegerTest
    {
        [Fact]
        public void Test()
        {
            var reverse = Solution.ReverseInteger(123);
            Assert.Equal(321, reverse);

            var reverse1 = Solution.ReverseInteger(0);
            Assert.Equal(0, reverse1);

            var reverse2 = Solution.ReverseInteger(-123);
            Assert.Equal(-321, reverse2);

            var reverse3 = Solution.ReverseInteger(1534236469);
            Assert.Equal(0, reverse3);

            var reverse4 = Solution.ReverseInteger(-2147483648);
            Assert.Equal(0, reverse4);
        }
    }
}