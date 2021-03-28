using System;

namespace Leecode.Solutions
{
    public partial class Solution
    {
        public static ListNode DeleteDuplicates(ListNode head)
        {
            if (head is null)
                return null;

            var cur = head;
            while (cur.next is not null)
            {
                if (cur.val == cur.next.val)
                {
                    cur.next = cur.next.next;
                }
                else
                {
                    cur = cur.next;
                }
            }
            return head;
        }
    }
}