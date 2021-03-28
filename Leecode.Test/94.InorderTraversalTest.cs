using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leecode.Solutions;
using Xunit;

namespace Leecode.Test
{
    public class InorderTraversalTest
    {
        [Fact]
        public void Test()
        {
            var root1 = new TreeNode(1, null, new TreeNode(2, new TreeNode(3, null, null), null));
            var res1 = new List<int>() { 1, 3, 2 };
            var ret1 = Solution.InorderTraversal(root1);
            Assert.Equal(res1, ret1);
        }
    }
}
