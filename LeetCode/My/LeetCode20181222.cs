using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.My
{
    public class LeetCode20181222
    {
        /// <summary>
        /// 给定一个整数数组 nums 和一个目标值 target，请你在该数组中找出和为目标值的那 两个 整数，并返回他们的数组下标。
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] twoSum = new int[2];
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        twoSum[0] = nums[i];
                        twoSum[1] = nums[j];
                        break;
                    }
                }
            }
            return twoSum;
        }

        /// <summary>
        /// 给出一个 32 位的有符号整数，你需要将这个整数中每位上的数字进行反转。
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int Reverse(int x)
        {
            int sum = 0;
            int j = 0;
            int m = 1;
            char[] numChar = x.ToString().ToCharArray();
            if (numChar[0] == '-')
            {
                j = 1;
                m = -1;
            }
            int n = 1;

            for (int i = j; i < numChar.Length; i++)
            {
                try
                {
                    checked
                    {
                        sum = sum + Convert.ToInt32(numChar[i].ToString()) * n;
                    }
                }
                catch
                {
                    return 0;
                }
                n = n * 10;
            }

            return sum * m;
        }

        /// <summary>
        /// 判断一个整数是否是回文数。回文数是指正序（从左向右）和倒序（从右向左）读都是一样的整数。
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }

            int sum = 0;
            int j = 0;
            char[] numChar = x.ToString().ToCharArray();

            int n = 1;

            for (int i = j; i < numChar.Length; i++)
            {
                try
                {
                    checked
                    {
                        sum = sum + Convert.ToInt32(numChar[i].ToString()) * n;
                    }
                }
                catch
                {
                    return false;
                }
                n = n * 10;
            }
            return sum == x;
        }

        /// <summary>
        /// 编写一个函数来查找字符串数组中的最长公共前缀。
        /// 如果不存在公共前缀，返回空字符串 ""。
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public static string LongestCommonPrefix(string[] strs)
        {
            string existsStr = "";
            if (strs.Length > 0)
            {
                char[] strsChar = strs[0].ToCharArray();


                for (int i = 0; i < strsChar.Length; i++)
                {
                    foreach (var str in strs)
                    {
                        if (i >= str.Length)
                        {
                            goto breakFor;
                        }
                        if ((str[i]) == strsChar[i])
                        {
                            continue;
                        }
                        else
                        {
                            goto breakFor;
                        }
                    }
                    existsStr = existsStr + strsChar[i];
                }

                breakFor:;
            }

            return existsStr;

        }
    }
}
