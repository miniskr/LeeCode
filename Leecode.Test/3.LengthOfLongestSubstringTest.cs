using System;
using System.Collections.Generic;
using System.Text;
using Leecode.Solutions;
using Xunit;

namespace Leecode.Test
{
    public class LengthOfLongestSubstringTest
    {
        [Fact]
        public void Test()
        {
            var s = "abcabca";
            var s1 = "pwwkew";
            var s2 = "abcabcbb";
            var res = Solution.LengthOfLongestSubstring(s);
            var res1 = Solution.LengthOfLongestSubstring(s1);
             var res2 = Solution.LengthOfLongestSubstring(s2);
            Assert.Equal(3, res);
            Assert.Equal(3, res1);
            Assert.Equal(3, res2);
        }
    }
}
