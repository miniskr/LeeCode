﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leecode.Solutions
{
    public partial class Solution
    {
        /*
         * 子集 II
         * 给你一个整数数组 nums ，其中可能包含重复元素，请你返回该数组所有可能的子集（幂集）。
         * 解集 不能 包含重复的子集。返回的解集中，子集可以按 任意顺序 排列。
         * 示例 1：
         * 输入：nums = [1,2,2]
         * 输出：[[],[1],[1,2],[1,2,2],[2],[2,2]]
         */
        public static IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            var arr = Array.Empty<int>();

            Array.Sort(nums);

            var len = nums.Length;

            throw new NotImplementedException();
        }

        private static IList<int> GetArr(int[] nums)
        {
            throw new NotImplementedException();
        }
    }
}
