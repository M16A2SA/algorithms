using System;
using System.Collections;

namespace algorithms {
	public class LeetCodeSolution {
		public static bool IsPalindrome(int x) {
			if (x < 0 || (x % 10 == 0 && x != 0)) {
				return false;
			}
			int revertedNumber = 0;
			while (x > revertedNumber) {
				revertedNumber = revertedNumber * 10 + x % 10;
				x /= 10;
			}
			return x == revertedNumber || x == revertedNumber / 10;
		}
		public static string LongestCommonPrefix(string[] strs) {
			if (strs == null || strs.Length == 0) {
				return "";
			}
			string prefix = strs[0];
			int count = strs.Length;
			for (int i = 1; i < count; i++) {
				prefix = LongestCommonPrefix(prefix, strs[i]);
				if (prefix.Length == 0) {
					break;
				}
			}
			return prefix;

		}
		public static string LongestCommonPrefix(string str1, string str2) {
			int length = Math.Min(str1.Length, str2.Length);
			int index = 0;
			while (index < length && str1[index] == str2[index]) {
				index++;
			}
			return str1.Substring(0, index);
		}
		public static bool IsValidBrackets(string s) {
			if (s.Length % 2 == 1) return false;

			Dictionary<char, char> Map = new Dictionary<char, char>();
			Map.Add(']', '[');
			Map.Add(')', '(');
			Map.Add('}', '{');

			Stack stk = new Stack();
			for (int i = 0; i < s.Length; i++) {
				if (Map.ContainsKey(s[i])) {
					if (stk.Count == 0 || !stk.Peek().Equals(Map[s[i]])) return false;
					stk.Pop();
				} else {
					stk.Push(s[i]);
				}

			}
			return stk.Count == 0;
		}

		public static int RemoveElement(int[] nums, int val) {
			int removed = 0;
			for (int i = 0; i < nums.Length; i++) {
				if (nums[i] == val) {
					nums[i] = 101;
					removed++;
				}
			}
			Array.Sort(nums);
			return nums.Length - removed;
		}

		public static int RemoveDuplicates(int[] nums) {
			int length = nums.Length;
			int freq = 0;
			int[] freqArr = new int[length];

			for (int i = 0; i < length; i++) {
				for (int j = i + 1; j < length; j++) {
					if (nums[i] == nums[j]) {
						freqArr[i]++;
					}
				}
			}
			for (int i = 0; i < length; i++) {
				if (freqArr[i] >= 1) {
					nums[i] = 2147483647;
				} else { freq++; }
			}
			Array.Sort(nums);
			return freq;
		}

		public static int LengthOfLastWord(string s) {
			int index = s.Length - 1;
			int wordLength = 0;
			while (s[index] == ' ') {
				index--;
			}
			while (index >= 0 && s[index] != ' ') {
				wordLength++;
				index--;
			}
			return wordLength;
		}

		public static int[] PlusOne(int[] digits) {
			int n = digits.Length;
			for (int i = n - 1; i >= 0; --i) {
				if (digits[i] != 9) {
					++digits[i];
					for (int j = i + 1; j < n; ++j) {
						digits[j] = 0;
					}
					return digits;
				}
			}
			int[] ans = new int[n + 1];
			ans[0] = 1;
			return ans;
		}// TODO: UNDERSTAND IT!
	}
}