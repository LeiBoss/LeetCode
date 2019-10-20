using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.My
{
    public class LeetCode20190107
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int k = j;
                    while (k < m + n && nums1[j] > nums2[i])
                    {
                        nums1[k] = nums2[i];
                        k = k + 1;
                    } 
                }
            }
        }
    }
}
