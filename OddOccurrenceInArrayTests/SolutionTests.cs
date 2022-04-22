using NUnit.Framework;
using OddOccurrencesInArray;

namespace OddOccurrenceInArrayTests
{
	public class SolutionTests
	{
		private Solution _solution { get; set; } = null!;

		[SetUp]
		public void Setup()
		{
			_solution = new Solution();
		}

		[Test]
		public void OddOccurrencesInArray_Test1()
		{
			int result = _solution.solution(new int[] { 9, 3, 9, 3, 9, 7, 9 });
			Assert.AreEqual(7, result);
		}

		[Test]
		public void OddOccurrencesInArray_Test2()
		{
			int result = _solution.solution(new int[] { 9, 3, 9, 3, 9, 7, 9, 7, 5, 9, 3, 9, 3 });
			Assert.AreEqual(5, result);
		}

		[Test]
		public void OddOccurrencesInArray_Test3()
		{
			int result = _solution.solution(new int[] { 1, 1, 1, 0, 1 });
			Assert.AreEqual(0, result);
		}

		[Test]
		public void OddOccurrencesInArray_Test4()
		{
			int result = _solution.solution(new int[] { 7, 3, 7, 3, 7, 7, 8 });
			Assert.AreEqual(8, result);
		}

		[Test]
		public void OddOccurrencesInArray_Test5()
		{
			int result = _solution.solution(new int[] { 2, 2, 2, 2, 3, 3, 4, 3, 3 });
			Assert.AreEqual(4, result);
		}

		[Test]
		public void OddOccurrencesInArray_Test6()
		{
			int result = _solution.solution(new int[] { 1, 2, 2, 2, 3, 3, 2, 3, 3 });
			Assert.AreEqual(1, result);
		}
	}
}