using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leecode.Solutions
{
    public partial class Solution
    {
        static int[] t = Array.Empty<int>();
        static int[][] ans = Array.Empty<int[]>();
        public static IList<IList<int>> Subsets(int[] nums)
        {
            dfs(0, nums);
            return ans;
        }

        public static void dfs(int cur, int[] nums)
        {
            if (cur == nums.Length)
            {
                ans.Append(t);
                return;
            }

            t.Append(nums[cur]);
            dfs(cur + 1, nums);

            t.Distinct();
            dfs(cur + 1, nums);
        }
    }
}
