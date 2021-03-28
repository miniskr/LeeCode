using System;
using System.Collections.Generic;

namespace Leecode.Solutions
{
    public partial class Solution
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            var dic = new Dictionary<int, int>();

            for(var i = 0; i < nums.Length; i++)
            {
                var key = target - nums[i];
                if(dic.ContainsKey(key))
                {
                    return new int[] { dic[key], i };
                }
                dic.Add(nums[i], i);
            }

            throw new ArgumentException("no solution");
        }
    }
}
