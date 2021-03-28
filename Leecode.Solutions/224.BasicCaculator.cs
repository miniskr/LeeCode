using System.Collections.Generic;

namespace Leecode.Solutions
{
    public partial class Solution
    {
        public static int BasicCaculator(string s)
        {
            var res = 0;
            var len = s.Length;
            var ops = new Stack<int>();
            ops.Push(1);

            var sign = 1;
            var i = 0;
            while (i < len)
            {
                if (s[i] == ' ')
                    i++;
                else if (s[i] == '+')
                {
                    sign = ops.Peek();
                    i++;
                }
                else if (s[i] == '-')
                {
                    sign = -ops.Peek();
                    i++;
                }
                else if (s[i] == '(')
                {
                    ops.Push(sign);
                    i++;
                }
                else if (s[i] == ')')
                {
                    ops.Pop();
                    i++;
                }
                else
                {
                    var num = 0;
                    while (i < len && s[i] >= '0' && s[i] <= '9')
                    {
                        num = num * 10 + s[i] - '0';
                        i++;
                    }
                    res += sign * num;
                }
            }

            return res;
        }

        public static int Caculator(string s)
        {
            var res = 0;
            var ops = new Stack<int>();
            ops.Push(1);
            var sign = 1;
            var i = 0;
            var len = s.Length;

            while (i < len)
            {
                switch (s[i])
                {
                    case ' ':
                        i++;
                        break;
                    case '+':
                        sign = ops.Peek();
                        i++;
                        break;
                    case '-':
                        sign = -ops.Peek();
                        i++;
                        break;
                    case '(':
                        ops.Push(sign);
                        i++;
                        break;
                    case ')':
                        ops.Pop();
                        i++;
                        break;
                    default:
                        {
                            var num = 0;
                            while (i < len && s[i] >= '0' && s[i] <= '9')
                            {
                                num = num * 10 + s[i] - '0';
                                i++;
                            }

                            res += sign * num;
                            break;
                        }
                }
            }
            return res;
        }
    }
}
