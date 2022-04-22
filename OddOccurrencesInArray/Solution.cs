using System;
using System.Linq;

namespace OddOccurrencesInArray
{
	public class Solution {
		public int solution(int[] A) {
			return A.Aggregate((x,y) => x ^ y);
		}
	}
}
