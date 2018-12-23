using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.My
{
    public class LeetCode20181223
    {
        /// <summary>
        /// 给定一个只包括 '('，')'，'{'，'}'，'['，']' 的字符串，判断字符串是否有效。
        ///有效字符串需满足：
        ///左括号必须用相同类型的右括号闭合。
        ///左括号必须以正确的顺序闭合。
        ///注意空字符串可被认为是有效字符串。
        ///todo - 修改
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsValid(string s)
        {
            bool isValid = true;
            if (!string.IsNullOrEmpty(s))
            {
                Dictionary<char, char> sDic = new Dictionary<char, char>
                {
                    { '(', ')' },
                    { '{', '}' },
                    { '[', ']' }
                };

                Stack<char> stChar = new Stack<char>();

                char[] sChar = s.ToCharArray();
                foreach (var c in sChar)
                {
                    if (sDic.ContainsKey(c))
                    {
                        stChar.Push(c);
                    }
                    else if (sDic.ContainsValue(c))
                    {
                        if (stChar.Count == 0)
                        {
                            return false;
                        }
                        if (sDic[stChar.Pop()] != c)
                        {
                            if (stChar.Count == 0)
                            {
                                return false;
                            }
                            break;
                        }
                    }
                }
                isValid = stChar.Count == 0;
            }
            return isValid;
        }
    }
}
