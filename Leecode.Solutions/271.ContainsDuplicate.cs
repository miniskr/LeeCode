using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leecode.Solutions
{
    public partial class Solution
    {
        public static bool ContainsDuplicate(int[] nums)
        {
            var hash = new HashSet<int>(nums);
            return nums.Length != hash.Count;
        }
    }
}
