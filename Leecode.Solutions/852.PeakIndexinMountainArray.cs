namespace Leecode.Solutions
{
    public partial class Solution
    {
        public static int PeakIndexinMountainArray(int[] arr)
        {
            var arr1 = arr;
            var index = 0;
            while (arr1.Length > 1)
            {
                arr1 = BinaryCompare(arr1, out index);
            }

            return index;
        }

        private static int[] BinaryCompare(int[] arr, out int index)
        {
            var len = arr.Length;
            var binLen = len / 2;
            var left = arr[..binLen];
            var right = arr[binLen..];

            if (left[binLen - 1] > right[0])
            {
                index = binLen - 1;
                return left;
            }
            else
            {
                index = binLen;
                return right;
            }
        }
    }
}
