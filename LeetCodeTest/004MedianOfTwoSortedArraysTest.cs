using LeetCode;
using NUnit.Framework;

namespace LeetCodeTest
{
    [TestFixture]
    public class MedianOfTwoSortedArraysTest {

        [TestCaseSource(nameof(_data))]
        public double MedianOfTwoArrays_ShouldReturn_MedianValue(int[] array1, int[] array2)
        {
            var medianOfArrays = new MedianOfTwoSortedArrays();

            return medianOfArrays.CalculateMedian(array1, array2);
        }
        
        private static TestCaseData[] _data =
        {
            new TestCaseData(new[] { 1, 3 }, new[] { 2 })
                .Returns(2.0),
            new TestCaseData(new[] { 1, 2 }, new[] { 3, 4 })
                .Returns(2.5),
            new TestCaseData(new[] { 1 }, new[] { 2 })
                .Returns(1.5),
            new TestCaseData(new[] { 1, 3 }, new int[0] )
                .Returns(2),
            new TestCaseData(new int[0], new[] { 1, 3 } )
                .Returns(2),
            new TestCaseData(new[] { 1 }, new int[0] )
                .Returns(1),
            new TestCaseData(new int[0], new int[0] )
                .Returns(0),
        };
    }
}