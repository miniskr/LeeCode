using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leecode.Solutions
{
    public partial class Solution
    {
        public static bool IsPalindrome(int x)
        {
            if (x < 0) return false;
            if (x != 0 && x % 10 == 0) return false;


            var tar = 0;
            while(x > tar)
            {
                tar = tar * 10 + x % 10;
                x /= 10;
            }

            return x == tar || x == tar / 10;
        }
    }
}
