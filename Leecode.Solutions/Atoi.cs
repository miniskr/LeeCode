using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leecode.Solutions
{
    public partial class Solution
    {
        /// <summary>
        /// 这是一个自动机的问题
        /// |         |  ''  |  +/-     |  number  |  other  |
        /// | start   | start| signed   | in_number|   end   |
        /// |signed   | end  | in_number| in_number|   end   |
        /// |in_number| end  | end      | in_number|   end   |
        /// |end      | end  | end      | end      |   end   |
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int MyAtoi(string s)
        {
            var automaton = new Automaton();
            if (string.IsNullOrWhiteSpace(s)) return 0;
            for (var i = 0; i < s.Length; ++i)
            {
                automaton.Get(s[i]);
            }

            return (int)(automaton.Sign * automaton.Ans);
        }
    }

    public class Automaton
    {
        public int Sign { get; private set; } = 1;
        public long Ans { get; private set; } = 0;

        private string _state = "start";
        private readonly Dictionary<string, string[]> _table = new()
        {
            { "start", new string[] { "start", "signed", "in_number", "end" } },
            { "signed", new string[] { "end", "end", "in_number", "end" } },
            { "in_number", new string[] { "end", "end", "in_number", "end" } },
            { "end", new string[] { "end", "end", "end", "end" } }
        };

        public void Get(char c)
        {
            this._state = this._table[this._state][GetCol(c)];
            if (this._state.Equals("in_number", StringComparison.Ordinal))
            {
                this.Ans = this.Ans * 10 + c - '0';
                this.Ans = this.Sign == 1 ? Math.Min(this.Ans, (long)int.MaxValue) : Math.Min(this.Ans, -(long)int.MinValue);
            }
            else if (this._state.Equals("signed",StringComparison.Ordinal))
            {
                this.Sign = c == '+' ? 1 : -1;
            }
        }

        public int GetCol(char c)
        {
            if (c == ' ') return 0;
            if (c == '-' || c == '+') return 1;
            if (this.IsDigit(c)) return 2;

            return 3;
        }

        private bool IsDigit(char c)
        {
            return c >= '0' && c <= '9';
        }
    }
}
