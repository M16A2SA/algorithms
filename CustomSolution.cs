using System;
using System.Collections;


namespace algorithms {
	public class CustomSolution {
		public static ArrayList NonDuplicate(int[] nums) {
			ArrayList res = new ArrayList();
			foreach (int i in nums) {
				foreach (int j in nums) {
					foreach (int m in nums) {
						if (i != j && j != m && m != i) {
							res.Add(i * 100 + j * 10 + m);
						}
					}
				}
			}
			return res;
		}


	}
}