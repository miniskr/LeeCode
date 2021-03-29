using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leecode.Solutions
{
    public partial class Solution
    {
        /*
         *  颠倒给定的 32 位无符号整数的二进制位。
         *  eg1:输入: 00000010100101000001111010011100
         *      输出: 00111001011110000010100101000000
         *      解释: 输入的二进制串 00000010100101000001111010011100 表示无符号整数 43261596，
         *      因此返回 964176192，其二进制表示形式为 00111001011110000010100101000000。
         */
        public static uint ReverseBits(uint n)
        {
            /*
             * 思路：取二进制位的最后一位，放入rev的二进制位的第一位，以此类推
             * (n & 1)得到二进制位最后一位， n >>= 1，将n二进制向右位移1位
             */
            uint rev = 0;
            for (int i = 0; i < 32 && n > 0; ++i)
            {
                rev |= (n & 1) << (31 - i);
                n >>= 1;
            }

            return rev;
        }

        public static uint ReverseBitsOperation(uint n)
        {
            /*
             * 思路：反转二进制串，可以将其均分为左右两部分，对每部分递归执行反转操作，然后将左半部分拼在右半部分的后面，即完成反转
             * 由于左右两部分计算相似，利用位掩码和位移运算，我们可以自低向上完成这一部分分治流程
             * 对于递归的最底层，我们需要交换所有奇偶位：
             * 1.取出所有奇数位和偶数位；
             * 2.将奇数位移到偶数位上，偶数位移到奇数位上。
             */
            const uint M1 = 0x55555555; // 01010101010101010101010101010101
            const uint M2 = 0x33333333; // 00110011001100110011001100110011
            const uint M3 = 0x0f0f0f0f; // 00001111000011110000111100001111
            const uint M4 = 0x00ff00ff; // 00000000111111110000000011111111

            n = n >> 1 & M1 | (n & M1) << 1;
            n = n >> 2 & M2 | (n & M2) << 2;
            n = n >> 4 & M3 | (n & M3) << 4;
            n = n >> 8 & M4 | (n & M4) << 8;

            return n >> 16 | n << 16;
        }
    }
}
