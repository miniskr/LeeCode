using System;
using System.Collections.Generic;
using System.Text;
using Leecode.Solutions;
using Xunit;

namespace Leecode.Test
{
    public class CountBitsTest
    {
		[Fact]
		public void Test()
		{
			var num = 5;
			var tartget = new int[] { 0, 1, 1, 2, 1, 2 };

			Assert.Equal(tartget, Solution.CountBits(num));
		}
	}
}
