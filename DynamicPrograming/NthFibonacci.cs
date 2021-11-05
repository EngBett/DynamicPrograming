using System.Collections.Generic;

namespace DynamicPrograming
{
    public class NthFibonacci
    {
        private static Dictionary<int, long> memo = new();

        public static int NthFib(int n)
        {
            if (n <= 2) return 1;

            return NthFib(n - 1) + NthFib(n - 2);
        }

        public static long NthFibMemo(int n)
        {
            if (memo.ContainsKey(n)) return memo[n];

            if (n <= 2) return 1;

            var res = NthFibMemo(n - 1) + NthFibMemo(n - 2);
            memo.Add(n,res);

            return memo[n];
        }

        public static long NthFibDyn(int n)
        {
            int res=0;
            
            if (n <= 2) return 1;
            int dp1 = 1;
            int dp2 = 1;
            for (int i = 3; i <=n; i++)
            {
                res = dp1 + dp2;
                dp1 = dp2;
                dp2 = res;
            }

            return res;
        }
    }
}