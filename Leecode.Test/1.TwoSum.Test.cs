using System;
using Xunit;
using System.Collections;
using System.Collections.Generic;
using Leecode.Solutions;
using System.Linq;

namespace Leecode.Test
{
    public class TwoSumTest
    {
        [Fact]
        public void Test1()
        {
            var nums = new int[] { 2, 7, 11, 15 };
            var target = 9;
            var result = new int[] { 0, 1 };

            var solution = Solution.TwoSum(nums, target);

            
        }
    }
}
