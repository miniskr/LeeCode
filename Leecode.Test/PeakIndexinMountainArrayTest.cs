using Xunit;

namespace Leecode.Test
{
    public class PeakIndexinMountainArrayTest
    {
        [Fact]
        public void Test()
        {
            var arr1 = new int[] { 0, 1, 0 };
            var ass1 = 1;
            var arr2 = new int[] { 0, 2, 1, 0 };
            var ass2 = 1;
            var arr3 = new int[] { 0, 10, 5, 2 };
            var ass3 = 1;
            var arr4 = new int[] { 3, 4, 5, 1 };
            var ass4 = 2;
            var arr5 = new int[] { 24, 69, 100, 99, 79, 78, 67, 36, 26, 19 };
            var ass5 = 2;

            var res1 = Solutions.Solution.PeakIndexinMountainArray(arr1);
            var res5 = Solutions.Solution.PeakIndexinMountainArray(arr5);
            Assert.Equal(ass1, res1);
            var res2 = Solutions.Solution.PeakIndexinMountainArray(arr2);
            Assert.Equal(ass2, res2);
            var res3 = Solutions.Solution.PeakIndexinMountainArray(arr3);
            Assert.Equal(ass3, res3);
            var res4 = Solutions.Solution.PeakIndexinMountainArray(arr4);
            Assert.Equal(ass4, res4);
            Assert.Equal(ass5, res5);
        }
    }
}
