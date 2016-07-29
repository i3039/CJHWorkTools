using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CJH.Common
{
    /// <summary>
    /// 字符串辅助类
    /// </summary>
    public static class StringHelper
    {
        /// <summary>
        /// 给字符串添加“0”字符
        /// </summary>
        /// <param name="str">原字符串</param>
        /// <param name="strLength">要求的字符串长度</param>
        /// <param name="isLeft">是否添加到字符串左方</param>
        /// <returns></returns>
        public static string AddZeroString(string str, int strLength, bool isLeft)
        {
            string result = str;
            if (str.Length < strLength)
            {
                string zero = "";
                int len = strLength - str.Length;
                for (int i = 0; i < len; i++)
                {
                    zero += "0";
                }

                if (isLeft)
                {
                    result = zero + "" + str;
                }
                else
                {
                    result = str + "" + zero;
                }
            }

            return result;
        }

        /// <summary>
        /// 给字符串添加“0”字符
        /// </summary>
        /// <param name="str">原字符串</param>
        /// <param name="strLength">要求的字符串长度</param>
        /// <returns></returns>
        public static string AddZeroString(string str, int strLength)
        {
            return AddZeroString(str, strLength, true);
        }

        /// <summary>
        /// 去除末尾字符
        /// </summary>
        /// <param name="str">字符</param>
        /// <returns></returns>
        public static string EndStringClear(string str, string endStr)
        {
            if (!str.Equals("") && str.Substring(str.Length - 1, 1).Equals(endStr))
            {
                return str.Substring(0, str.Length - 1);
            }

            return str;
        }

        /// <summary>
        /// 去除地区编号末尾0
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static string GetAreaDelZero(string code)
        {
            if (code.Equals(""))
            {
                return "";
            }
            else
            {
                if (code.Substring(2, 4).Equals("0000"))
                {
                    return code.Substring(0, 2);
                }

                if (code.Substring(4, 2).Equals("00"))
                {
                    return code.Substring(0, 4);
                }

                return code;
            }
        }

        /// <summary>
        /// 判断字符串是否为数字
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool isNumberic(string str)
        {
            try
            {
                Int64 a = Convert.ToInt64(str);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 转换日期格式：YYYY-MM-DD
        /// </summary>
        /// <param name="dtStr"></param>
        /// <returns></returns>
        public static string GetDateTimeShortString(string dtStr)
        {
            DateTime dt = DateTime.Parse(dtStr);
            return string.Format("{0:yyyy-MM-dd}", dt); //string.Format("{0:yyyyMMddHHmmssffff}",dt)
        }

        /// <summary>
        /// 转换日期格式：YYYY年MM月DD日
        /// </summary>
        /// <param name="dtStr"></param>
        /// <returns></returns>
        public static string GetDateTimeLongString(string dtStr)
        {
            DateTime dt = DateTime.Parse(dtStr);
            return string.Format("{0:yyyy年MM月dd日}", dt); //string.Format("{0:yyyyMMddHHmmssffff}",dt)
        }
    }
}
