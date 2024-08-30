using System.Linq;

namespace LeetCode
{
    // Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.
    public class MedianOfTwoSortedArrays {
        public double CalculateMedian(int[] array1, int[] array2)
        {
            var totalLength = array1.Length + array2.Length;
            var isEven = totalLength % 2 == 0;

            if (totalLength == 0)
            {
                return 0.0;
            }

            var totalArray = array1
                .Concat(array2)
                .OrderBy(x => x)
                .Skip(isEven ? (totalLength / 2) - 1 : totalLength / 2)
                .Take(isEven ? 2 : 1)
                .Average();

            return totalArray;
        }
    }
}