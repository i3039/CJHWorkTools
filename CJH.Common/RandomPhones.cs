using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CJH.Common
{
    /// <summary>
    /// 随机电话号码生成类
    /// </summary>
    public class RandomPhones
    {
        static string[] _phoneFirst = new string[] { "130", "131", "133", "135", "136", "137", "138", "139", "150", "151", "152", "155", "158", "159", "177", "180", "181", "182", "183", "184", "185", "186", "187", "189" };

        //Random rd = new Random();
        //int num = rd.Next(100000, 1000000);
        //int num2 = rd.Next(100000, 1000000);
        //double dnum = Convert.ToDouble(num.ToString() + num2.ToString());

        public static string GetPhone()
        {
            Random rd = new Random();
            int num = rd.Next(10000000, 99999999);
            string newPhone = GetFirstNum() + "" + num.ToString();
            return newPhone;
        }

        public static string GetFirstNum()
        {
            Random ra = new Random(unchecked((int)DateTime.Now.Ticks));
            int raNum = ra.Next(1, _phoneFirst.Length);
            //int[] lastNameIndex = getRandomNum(nameCount, 1, _lastName2.Length);
            //name = _firstName[firstNameIndex[i]] + "" + _lastName2[lastNameIndex[i]];
            //int[] arrNum = new int[num];
            //int tmp = 0;
            //for (int i = 0; i <= num - 1; i++)
            //{
            //    tmp = ra.Next(minValue, maxValue); //随机取数
            //    arrNum[i] = getNum(arrNum, tmp, minValue, maxValue, ra); //取出值赋到数组中
            //}
            return _phoneFirst[raNum];//arrNum
        }

        /// <summary>
        /// 随机生成6位数的数字
        /// </summary>
        /// <returns></returns>
        public static string GetSixNumber()
        {
            Random rd = new Random();
            int num = rd.Next(1, 999999);
            string pullZero = "";
            for (int i = num.ToString().Length; i < 6; i++)
            {
                pullZero += "0";
            }
            string newNumber = pullZero + "" + num.ToString();
            return newNumber;
        }


        /// <summary>
        /// 生成随机1个小写字母
        /// </summary>
        /// <returns></returns>
        public static string GetOneLowerChar()
        {
            Random rd = new Random();
            int[] lastIndex = RandomNames.getRandomNum(1, 1, _lowerChar.Length);

            return _lowerChar[lastIndex[0]];
        }

        static string[] _lowerChar = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };


        /// <summary>
        /// 随机生成指定长度的数字
        /// </summary>
        /// <param name="len">长度</param>
        /// <param name="maxNum">最大数</param>
        /// <returns></returns>
        public static string GetNumber(int len, int maxNum)
        {
            Random rd = new Random();
            int num = rd.Next(len, maxNum);

            return num.ToString();
        }
    }
}
