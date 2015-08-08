using System;
using System.Text.RegularExpressions;

namespace MyTrunk.Common
{
    public class DataValidate
    {
        private static readonly Regex RegPhone = new Regex("^[0-9]+[-]?[0-9]+[-]?[0-9]$");
        private static readonly Regex RegCellPhone = new Regex("^1[3-9]{10}$");
        private static readonly Regex RegNumber = new Regex("^[+-]?[0-9]+$");
        private static readonly Regex RegEmail = new Regex("^[\\w-]+@[\\w-]+\\.(com|net|org|edu|mil|tv|biz|info)$");
        private static readonly Regex RegChzn = new Regex("[\u4e00-\u9fa5]");

        /// <summary>
        /// 是否是电话号码
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsPhone(string s)
        {
            return RegPhone.Match(s).Success;
        }

        /// <summary>
        /// 是否是手机号码
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsCellPhone(string s)
        {
            return RegCellPhone.Match(s).Success;
        }

        /// <summary>
        /// 是否是整数
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsNumber(string s)
        {
            return RegNumber.Match(s).Success;
        }

        /// <summary>
        /// 是否是Int
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsInt(string s)
        {
            int value;
            return int.TryParse(s, out value);
        }

        /// <summary>
        /// 是否Int>=minValue
        /// </summary>
        /// <param name="s"></param>
        /// <param name="minValue"></param>
        /// <returns></returns>
        public static bool IsInt(string s, int minValue)
        {
            int value;
            if (int.TryParse(s, out value))
            {
                return value >= minValue;
            }

            return false;
        }

        /// <summary>
        /// 是否Int>=minValue and Int<=maxValue
        /// </summary>
        /// <param name="s"></param>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <returns></returns>
        public static bool IsInt(string s, int minValue, int maxValue)
        {
            int value;
            if (int.TryParse(s, out value))
            {
                return value >= minValue && value <= maxValue;
            }

            return false;
        }

        /// <summary>
        /// 是否Int>0
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsIntGreaterThanZero(string s)
        {
            int value;
            if (int.TryParse(s, out value))
            {
                return value > 0;
            }

            return false;
        }

        /// <summary>
        /// 是否Int>=0
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsIntNoLessThanZero(string s)
        {
            int value;
            if (int.TryParse(s, out value))
            {
                return value >= 0;
            }

            return false;
        }

        /// <summary>
        /// 是否decimal
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsDecimal(string s)
        {
            decimal value;
            return decimal.TryParse(s, out value);
        }

        /// <summary>
        /// 是否decimal>=minValue
        /// </summary>
        /// <param name="s"></param>
        /// <param name="minValue"></param>
        /// <returns></returns>
        public static bool IsDecimal(string s, int minValue)
        {
            decimal value;
            if (decimal.TryParse(s, out value))
            {
                return value >= minValue;
            }

            return false;
        }

        /// <summary>
        ///  是否decimal>=minValue and decimal<=maxValue
        /// </summary>
        /// <param name="s"></param>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <returns></returns>
        public static bool IsDecimal(string s, int minValue, int maxValue)
        {
            decimal value;
            if (decimal.TryParse(s, out value))
            {
                return value >= minValue && value <= maxValue;
            }

            return false;
        }

        /// <summary>
        /// 是否decimal>0
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsDecimalGreaterThanZero(string s)
        {
            decimal value;
            if (decimal.TryParse(s, out value))
            {
                return value > 0;
            }

            return false;
        }

        /// <summary>
        /// 是否decimal>=0
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsDecimalNoLessThanZero(string s)
        {
            decimal value;
            if (decimal.TryParse(s, out value))
            {
                return value >= 0;
            }

            return false;
        }

        /// <summary>
        /// 是否是日期类型
        /// </summary>
        /// <param name="source"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsDateTime(string s)
        {
            DateTime dt;
            return DateTime.TryParse(s, out dt);
        }

        /// <summary>
        /// 是否是邮箱
        /// </summary>
        /// <param name="source"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsEmail(string s)
        {
            return RegEmail.Match(s).Success;
        }

        /// <summary>
        /// 是否有中文字符
        /// </summary>
        /// <param name="inputData"></param>
        /// <returns></returns>
        public static bool IsHasCHZN(string s)
        {
            return RegChzn.Match(s).Success;
        }
    }
}