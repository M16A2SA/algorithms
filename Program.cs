//using System.Collections;

namespace algorithms {
	class Program {
		public static void Main() {
			int[] test = { 1, 1, 4, 5, 1, 4 };
			int[] res = Solution.PlusOne(test);
			foreach (int num in res) {
				Console.WriteLine(num);
			}
			Console.ReadLine();
		}
	}
}

