using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leecode.Solutions
{
    public partial class Solution
    {
        // 这里应该使用二分查找
        public static bool SearchMatrix(int[][] matrix, int target)
        {
            if (target < matrix[0][0] || target > matrix[^1][^1])
                return false;

            var rows = matrix[0..^0];

            foreach (var row in rows)
            {
                var columns = row[0..^0];
                foreach (var cell in columns)
                {
                    if (cell == target)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
