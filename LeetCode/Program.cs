using LeetCode.My;
using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 2, 7, 11, 15 };
            //int[] returnNums = LeetCode20181222.TwoSum(nums, 9);
            //LeetCode20181222.TwoSum(nums, 9);
            bool num = My.LeetCode20181222.IsPalindrome(-15651);

            string[] strs = { "aa","aa","a"};
            string str = My.LeetCode20181222.LongestCommonPrefix(strs);

            bool isValid = LeetCode20181223.IsValid("(]");
            int[] nums_Remove = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int count = LeetCode20181225.RemoveDuplicates(nums_Remove);
            int n = LeetCode20181230.StrStr("aaaaa", "bba");
            Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}
