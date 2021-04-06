using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leecode.Solutions
{
    public partial class Solution
    {
        public static int RemoveDuplicatesII(int[] nums)
        {
            var len = nums.Length;
            if (len <= 2) return len;

            var slow = 2;
            var fast = 2;

            while (fast < len)
            {
                if (nums[slow - 2] != nums[fast])
                {
                    nums[slow] = nums[fast];
                    ++slow;
                }
                ++fast;
            }

            return slow;
        }
    }
}
