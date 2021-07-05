using System;

namespace Leecode.Solutions
{
    public partial class Solution
    {
        public static int MaxSubArray(int[] nums)
        {
            var pre = 0;
            var maxAns = nums[0];
            foreach (var num in nums)
            {
                pre = Math.Max(pre + num, num);
                maxAns = Math.Max(pre, maxAns);
            }
            return maxAns;
        }

    }

    public class Status
    {
        public int lSum, rSum, mSum, iSum;
        public Status(int lSum, int rSum, int mSum, int iSum)
        {
            this.lSum = lSum;
            this.rSum = rSum;
            this.mSum = mSum;
            this.iSum = iSum;
        }
    }
}
