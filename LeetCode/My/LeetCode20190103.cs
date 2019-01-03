using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.My
{
    public class LeetCode20190103
    {
        /// <summary>
        /// 给定一个非空整数数组，除了某个元素只出现一次以外，其余每个元素均出现两次。找出那个只出现了一次的元素。
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int SingleNumber(int[] nums)
        {
            Dictionary<int, int> single = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (single.ContainsKey(nums[i]))
                {
                    single[nums[i]] = single[nums[i]] + 1;
                }
                else
                {
                    single.Add(nums[i], 1);
                }
            }
            int n = 0;
            foreach (var s in single)
            {
                if (s.Value == 1)
                {
                    n = s.Key;
                }
            }
            return n;
        }
    }
}
