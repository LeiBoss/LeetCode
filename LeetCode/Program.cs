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
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
