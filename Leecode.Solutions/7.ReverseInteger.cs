using System.Collections.Generic;

namespace Leecode.Solutions
{
    partial class Solution
    {
        public static int ReverseInteger(int x)
        {
            var chars = x.ToString().ToCharArray();

            return Reverse1(x);
        }

        private static int Reverse(char[] chars)
        {
            var stack = new Stack<char>();

            if (chars[0] == '-')
            {
                return -Reverse(chars[1..^0]);
            }

            for (var i = 0; i < chars.Length; ++i)
            {
                stack.Push(chars[i]);
            }

            var arr = stack.ToArray();
            var str = string.Empty;
            foreach (var c in arr)
            {
                str += c;
            }

            if (int.TryParse(str, out var res))
                return res;

            return 0;
        }

        private static int Reverse1(int x)
        {
            var res = 0;

            while (x != 0)
            {
                var pop = x % 10;

                if (res > int.MaxValue / 10 || res == int.MaxValue / 10 && pop > 7) return 0;

                if (res < int.MinValue / 10 || res == int.MinValue / 10 && pop < -8) return 0;

                res = res * 10 + pop;
                x /= 10;
            }

            return res;
        }
    }
}
