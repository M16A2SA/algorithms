//using System.Collections;

namespace algorithms {
	class Program {
		public static void Main() {
			int[] numbers = { 1, 2, 3, 4 };
			foreach (int i in CustomSolution.NonDuplicate(numbers)) {
				Console.WriteLine(i);
			}
		}
	}
}

