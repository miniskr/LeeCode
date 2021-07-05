using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leecode.Solutions;
using Xunit;

namespace Leecode.Test
{
    public class AtoiTest
    {
        [Fact]
        public void Test()
        {
            var s1 = "42";
            var s2 = "      -42";
            var s3 = "3193 width words";
            var s4 = "words and 987";
            var s5 = "-91283472332";

            Assert.Equal(42, Solution.MyAtoi(s1));
            Assert.Equal(-42, Solution.MyAtoi(s2));
            Assert.Equal(3193, Solution.MyAtoi(s3));
            Assert.Equal(0, Solution.MyAtoi(s4));
            Assert.Equal(int.MinValue, Solution.MyAtoi(s5));
        }
    }
}
