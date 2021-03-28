namespace Leecode.Solutions
{
    public partial class Solution
    {
        /*
         * 给你一个链表的头节点 head ，旋转链表，将链表每个节点向右移动 k 个位置。
         */
        public static ListNode RotateRight(ListNode head, int k)
        {
            if (k == 0 || head is null || head.next is null)
                return head;

            // 计算长度
            var nodeLen = 1;
            var cur = head;
            while(cur.next != null)
            {
                cur = cur.next;
                nodeLen++;
            }

            // 计算需要位移次数，如果是整数倍则不需要位移
            var add = nodeLen - k % nodeLen;
            if (nodeLen == add)
                return head;

            // 位移
            cur.next = head;
            while(add-- > 0)
            {
                cur = cur.next;
            }

            // 断开链表
            var ret = cur.next;
            cur.next = null;
            return ret;
        }
    }
}
