using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.My
{
    public class LeetCode20181230
    {
        /// <summary>
        /// 实现 strStr() 函数。
        ///给定一个 haystack 字符串和一个 needle 字符串，在 haystack 字符串中找出 needle 字符串出现的第一个位置(从0开始)。如果不存在，则返回  -1。
        /// </summary>
        /// <param name="haystack"></param>
        /// <param name="needle"></param>
        /// <returns></returns>
        public static int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(haystack) || string.IsNullOrEmpty(needle))
            {
                return 0;
            }
            if (needle.Length > haystack.Length)
            {
                return -1;
            }

            int index = 0;
            char[] haystackChar = haystack.ToCharArray();
            char[] needleChar = needle.ToCharArray();

            int n = 0;
            for (int i = 0; i < haystack.Length; i++)
            {
                if (n < needle.Length && haystack[i] == needle[n])
                {
                    if (index == 0)
                    {
                        index = i;
                        n++;
                    }
                    else
                    {
                        if (index == i - 1)
                        {
                            index = i;
                            n++;
                        }
                        else
                        {
                            index = 0;
                        }
                    }
                }
            }
            if (n == needle.Length)
            {
                return index - n + 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
