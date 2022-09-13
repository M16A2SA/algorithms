using System.Collections;
using System.Numerics;

namespace algorithms
{
    public class numpy
    {
        public static bool isEven(int a)
        {
            if (a % 2 == 0) return true;
            else return false;
        }
        public static bool isPrime(int a)
        {
            if (numpy.findFactor(a).Count == 2) return true;
            else return false;
        }
        public static ArrayList everyDigit(int num)
        {
            ArrayList res = new ArrayList();
            for (int i = 0; num != 0; i++)
            {
                res.Add(num % 10);
                num /= 10;
            }
            res.Reverse();
            return res;
        }
        public static int everyDigitSum(int num)
        {
            ArrayList arr = everyDigit(num);
            int res = 0;
            foreach (int i in arr)
            {
                res += i;
            }
            return res;
        }
        public static bool containsDigit(int num, int target)
        {
            string str = num.ToString();
            if (str.Contains(target.ToString()))
            {
                return true;
            }
            else return false;
        }
        public static BigInteger factorial(long num)
        {
            BigInteger res = 1;
            if (num == 0 || num == 1) return 1;
            for (int i = 1; i <= num; i++)
            {
                res *= i;
            }

            return res;
        }
        public static bool isTrumpet(int num)
        {
            ArrayList arr = everyDigit(num);
            arr.TrimToSize();
            int[] arr2 = new int[arr.Capacity];
            int res = 0;
            arr.CopyTo(arr2);
            for (int i = 0; i < arr2.Length; i++)
            {
                res += (int)factorial(arr2[i]);
            }
            if (res == num) return true;
            else return false;
        }

        public static int arrSum(int[] arr)
        {
            int res = 0;
            foreach (int i in arr)
            {
                res += i;
            }
            return res;
        }
        public static decimal arrAvg(int[] arr)
        {
            return (decimal)arrSum(arr) / arr.Length;
        }

        public static ArrayList findFactor(int a)
        {
            ArrayList res = new ArrayList();
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    res.Add(i);
                }
            }
            return res;
        }
        public static int factorSum(int a)
        {
            int res = 0;
            foreach (int i in findFactor(a))
            {
                res += i;
            }
            return res;
        }
    }

}