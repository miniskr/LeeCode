using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leecode.Solutions;
using Xunit;

namespace Leecode.Test
{
    public class PalindromeNumberTest
    {
        [Fact]
        public void Test()
        {
            var input1 = 121;
            var input2= -121;
            var input3 = 10;
            var input4 = -101;

            Assert.True(Solution.IsPalindrome(input1));
            Assert.False(Solution.IsPalindrome(input2));
            Assert.False(Solution.IsPalindrome(input3));
            Assert.False(Solution.IsPalindrome(input4));
            
        }
    }
}
