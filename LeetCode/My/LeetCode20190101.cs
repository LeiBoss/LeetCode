using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.My
{
    public class LeetCode20190101
    {
        /// <summary>
        /// 给定一个数组 nums 和一个值 val，你需要原地移除所有数值等于 val 的元素，返回移除后数组的新长度。
        ///不要使用额外的数组空间，你必须在原地修改输入数组并在使用 O(1) 额外空间的条件下完成。
        ///元素的顺序可以改变。你不需要考虑数组中超出新长度后面的元素。
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public static int RemoveElement(int[] nums, int val)
        {
            int i = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] != val)
                {
                    nums[i] = nums[j];
                    i++;
                }
            }
            return i;
        }

        /// <summary>
        /// 给定一个仅包含大小写字母和空格 ' ' 的字符串，返回其最后一个单词的长度。
        ///如果不存在最后一个单词，请返回 0 。
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int LengthOfLastWord(string s)
        {
            if (string.IsNullOrEmpty(s.Trim()))
            {
                return 0;
            }
            var sArry = s.TrimEnd().Split(" ");

            if (string.IsNullOrEmpty(sArry[sArry.Length - 1]))
            {
                return 1;
            }
            return sArry[sArry.Length - 1].Length;
        }

        /// <summary>
        /// 给定一个由整数组成的非空数组所表示的非负整数，在该数的基础上加一。
        ///最高位数字存放在数组的首位， 数组中每个元素只存储一个数字。
        ///你可以假设除了整数 0 之外，这个整数不会以零开头。
        /// </summary>
        /// <param name="digits"></param>
        /// <returns></returns>
        public static int[] PlusOne(int[] digits)
        {
            int len = digits.Length;
            if (digits[len - 1] < 9)
            {
                digits[len - 1] = digits[len - 1] + 1;
            }
            else
            {
                digits[len - 1] = 0;
                for (int i = len - 2; i >= 0; i--)
                {
                    if (digits[i] + 1 == 10)
                    {
                        digits[i] = 0;
                    }
                    else
                    {
                        digits[i] = digits[i] + 1;
                        break;
                    }
                }
            }
            if (digits[0] == 0)
            {
                int[] newDigits = new int[len + 1];
                newDigits[0] = 1;
                digits.CopyTo(newDigits, 1);
                return newDigits;
            }
            return digits;
        }

        /// <summary>
        /// 实现 int sqrt(int x) 函数。
        ///计算并返回 x 的平方根，其中 x 是非负整数。
        ///由于返回类型是整数，结果只保留整数的部分，小数部分将被舍去。
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int MySqrt(int x)
        {
            if (x <= 1)
            {
                return x;
            }
            long r = x;
            while (r > x / r)
            {
                r = (r + x / r) / 2;
            }
            return (int)r;
        }
    }
}
