using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Leecode.Solutions
{
    /*
     * 给定一个非负整数 num。对于 0 ≤ i ≤ num 范围中的每个数字 i ，计算其二进制数中的 1 的数目并将它们作为数组返回。
     * 示例 1:
     * 输入: 2
     * 输出: [0,1,1]
     * 示例 2:
     * 输入: 5
     * 输出: [0,1,1,2,1,2]
     */
    public partial class Solution
    {
        public static int[] CountBits(int num)
        {
            var arr = new int[num + 1];

            for(var i = 0; i < arr.Length; ++i)
            {
                var str = Convert.ToString(i, 2);
                var count = str.AsEnumerable().Count(x => x == '1');
                arr[i] = count;
            }

            return arr;
        }
    }
}
