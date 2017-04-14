using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utils
{
    public static class StringExtension
    {
        /// <summary>
        /// 转换为Ext.define(str)
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string toExtDefineString(this string str, string appName)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return "";
            }

            string newStr = string.Format("Ext.define(" + appName + ",{{{0}}});", str);

            return newStr;
        }

        /// <summary>
        /// 带单引号的字符串
        /// e.g: 'TEST'
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string toSingleString(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return "";
            }

            string newStr = string.Format("'{0}'", str);

            return newStr;
        }

        /// <summary>
        /// 带大括号的字符串
        /// e.g: {TEST}
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string toBraceString(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return "";
            }

            string newStr = string.Format("{{{0}}}", str);

            return newStr;
        }

        /// <summary>
        /// 带中括号的字符串
        /// e.g: [TEST]
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string toBracketString(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return "";
            }

            string newStr = string.Format("[{0}]", str);

            return newStr;
        }

        /// <summary>
        /// 带大括号和双引号的字符串
        /// e.g: '{TEST}'
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string toBraceAndSingleString(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return "";
            }

            string newStr = string.Format("'{{{0}}}'", str);

            return newStr;
        }

        /// <summary>
        /// 前面带"."的字符串
        /// e.g: .TEST
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string toPointString(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return "";
            }

            string newStr = string.Format("'.{0}'", str);

            return newStr;
        }
    }
}
