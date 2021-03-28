using System.Collections.Generic;

namespace Leecode.Solutions
{
    public partial class Solution
    {
        /*
         * 给定一个二叉树的根节点 root ，返回它的 中序 遍历。
         */
        public static IList<int> InorderTraversal(TreeNode root)
        {
            var list = new List<int>();
            Inorder(root, list);
            return list;
        }

        private static void Inorder(TreeNode root, IList<int> res)
        {
            if (root is null)
                return;

            Inorder(root.left, res);
            res.Add(root.val);
            Inorder(root.right, res);
        }
    }
}
