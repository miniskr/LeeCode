using Leecode.Solutions;
using Xunit;

namespace Leecode.Test
{
    public class ContainsDuplicateTest
    {
        [Fact]
        public void Test()
        {
            var array1 = new[] { 1, 2, 3, 1 };
            Assert.True(Solution.ContainsDuplicate(array1));

            var array2 = new[] { 1, 2, 3, 4 };
            Assert.False(Solution.ContainsDuplicate(array2));

            var array3 = new[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
            Assert.True(Solution.ContainsDuplicate(array3));
        }
    }
}
