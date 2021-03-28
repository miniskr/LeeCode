using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Leecode.Solutions
{
    public partial class Solution
    {
        public static int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            var str = SplitString(s);

            return str.Length;
        }

        private static string SplitString(string s)
        {
            if (string.IsNullOrEmpty(s))
                return "";

            char[] ch = s.ToCharArray();
            var str = string.Empty;
            var res = string.Empty;
            for (int i = 0; i < ch.Length; i++)
            {
                if (str.Contains(ch[i]))
                {
                    var ind = s.IndexOf(ch[i]) + 1;
                    str = SplitString(s[ind..]);
                    res = res.Length > str.Length ? res : str;
                }
                else
                    str += ch[i];
            }

            return res.Length > str.Length ? res : str; ;
        }
    }
}
