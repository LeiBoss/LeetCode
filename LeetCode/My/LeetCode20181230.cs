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
        ///
        ///"mississippi"
        ///"issip"
        /// </summary>
        /// <param name="haystack"></param>
        /// <param name="needle"></param>
        /// <returns></returns>
        public static int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle))
            {
                return 0;
            }
            if (string.IsNullOrEmpty(haystack) || (needle.Length > haystack.Length))
            {
                return -1;
            }

            int index = 0;
            char[] haystackChar = haystack.ToCharArray();
            char[] needleChar = needle.ToCharArray();

            List<int> hasIndex = new List<int>();

            for (int i = 0; i < haystackChar.Length; i++)
            {
                if (haystackChar[i] == needleChar[0])
                {
                    hasIndex.Add(i);
                }
            }
            int n = 0;
            int m = -1;
            foreach (var j in hasIndex)
            {
                n = 0;
                index = 0;
                for (int i = j; i < haystack.Length; i++)
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
                        }
                        if (n == needle.Length)
                        {
                            m = j;
                            goto gotoBreak;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            gotoBreak:

            return m;
        }
    }
}
