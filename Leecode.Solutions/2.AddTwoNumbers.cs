using System;
using System.Collections.Generic;
using System.Text;

namespace Leecode.Solutions
{
    public partial class Solution
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            return Add(new ListNode(), l1, l2);
        }

        private static ListNode Add(ListNode node, ListNode n1, ListNode n2, bool greater = false)
        {
            var val = greater ? Plus(n1, n2) + 1 : Plus(n1, n2);

            if (val >= 10)
            {
                node.val = val % 10;
                greater = true;
            }
            else
            {
                node.val = val;
                greater = false;
            }

            if (n1?.next == null && n2?.next == null)
            {
                node.next = greater ? new ListNode(1) : null;
            }
            else
            {
                node.next = Add(new ListNode(), n1?.next, n2?.next, greater);
            }
            return node;
        }

        private static int Plus(ListNode n1, ListNode n2)
        {
            int val;
            if (n1 == null)
                val = n2.val;
            else if (n2 == null)
                val = n1.val;
            else
                val = n1.val + n2.val;

            return val;
        }
    }
}
