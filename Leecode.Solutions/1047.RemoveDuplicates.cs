using System.Collections.Generic;
using System.Text;

namespace Leecode.Solutions
{
    public partial class Solution
    {
        public static string RemoveDuplicates(string s)
        {
            var stack = new Stack<char>();
            for (var i = 0; i < s.Length; ++i)
            {
                if (stack.Count == 0)
                {
                    stack.Push(s[i]);
                }
                else
                {
                    var stackChar = stack.Peek();
                    var c = s[i];
                    if (c == stackChar)
                    {
                        stack.Pop();
                    }
                    else
                    {
                        stack.Push(c);
                    }
                }
            }

            var sb = new StringBuilder();
            var str = stack.ToArray();
            for (var j = str.Length - 1; j >= 0; --j)
            {
                sb.Append(str[j]);
            }

            return sb.ToString();
        }
    }
}
