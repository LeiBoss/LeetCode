using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.My
{
    public class LeetCode20190106
    {
        /// <summary>
        /// 给定一个排序数组和一个目标值，在数组中找到目标值，并返回其索引。如果目标值不存在于数组中，返回它将会被按顺序插入的位置。
        ///你可以假设数组中无重复元素。
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int SearchInsert(int[] nums, int target)
        {
            int index = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0 && nums[i] > target)
                {
                    index = 0;
                    break;
                }
                else if (i == nums.Length - 1 && nums[nums.Length - 1] < target)
                {
                    index = nums.Length;
                    break;
                }
                else if (target <= nums[i])
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
    }
}
