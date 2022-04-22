using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurrencesInArray
{
	public class Solution
	{
		public int solution(int[] A)
		{
			int value = 0;

			for(int i=0; i < A.Count(); i++)
				if(!canBePaired(A[i], i, A)){
					value = A[i];
					break;
				}

			return value;
		}

		private bool canBePaired(int element, int index, int[] A)
		{
			bool canBePaired = false;

			for (int i = 0; i < A.Count(); i++)
				if(index != i && element == A[i]) {
					canBePaired = true;
					break;
				}

			return canBePaired;
		}
	}
}
