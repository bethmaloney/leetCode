using LeetCode;
using NUnit.Framework;

namespace LeetCodeTest
{
    public class TwoSumTest {

        [TestCaseSource(nameof(_data))]
        public void TwoSum_ShouldReturn_CorrectResult(int[] array, int target, int[] expectedResult)
        {
            var twoSum = new TwoSum();
            var result = twoSum.GetIndices(array, target);
            Assert.That(result, Is.EquivalentTo(expectedResult));
        }

        private static TestCaseData[] _data = {
            new TestCaseData(new[] {2,7,11,15}, 9, new[] {0,1}),
            new TestCaseData(new[] {3,2,4}, 6, new[] {1,2}),
            new TestCaseData(new[] {3,3}, 6, new[] {0,1})
        };
    }
}