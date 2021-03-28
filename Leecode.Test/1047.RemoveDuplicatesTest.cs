using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leecode.Solutions;
using Xunit;

namespace Leecode.Test
{
    public class RemoveDuplicatesTest
    {
        [Fact]
        public void Test()
        {
            var str1 = "abbaca";


            var remove1 = Solution.RemoveDuplicates(str1);

            Assert.Equal("ca", remove1);
        }
    }
}
