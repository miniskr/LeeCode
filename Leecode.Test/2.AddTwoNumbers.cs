using System;
using System.Collections.Generic;
using System.Text;
using Leecode.Solutions;
using Xunit;

namespace Leecode.Test
{
    public class AddTwoNumbersTest
    {
        [Fact]
        public void Test()
        {
            var l1 = new ListNode(9, new ListNode(9, new ListNode(9,new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))))));
            var l2 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))));

            var sum = Solution.AddTwoNumbers(l1, l2);

            Assert.NotNull(sum);
        }
    }
}
