using System.Collections;
using Leecode.Solutions;
using Xunit;

namespace Leecode.Test
{
    public class DeleteDuplicatesTest
    {
        [Fact]
        public void Test()
        {
            var v1 = new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(3)))));
            var v2 = new ListNode(1, new ListNode(1, new ListNode(2)));

            var r1 = new ListNode(1, new ListNode(2, new ListNode(3)));
            var r2 = new ListNode(1, new ListNode(2));

            var res1 = Solution.DeleteDuplicates(v1);
            var res2 = Solution.DeleteDuplicates(v2);
            
            Assert.Equal(r1, res1);
            Assert.Equal(r2, res2);
        }

       
    }
}