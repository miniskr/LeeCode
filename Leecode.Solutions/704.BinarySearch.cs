namespace Leecode.Solutions
{
    public partial class Solution
    {
        /// <summary>
        /// 二分查找
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int BinarySearch(int[] nums, int target)
        {
            int pivot;
            var left = 0;
            var right = nums.Length - 1;
            while (left <= right)
            {
                pivot = left + (right - left) / 2;
                if (nums[pivot] == target) return pivot;
                if (target < nums[pivot]) right = pivot - 1;
                else left = pivot + 1;
            }
            return -1;
        }
    }
}
