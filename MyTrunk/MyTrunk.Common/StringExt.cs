using System;
using System.Security.Cryptography;
using System.Text;

namespace MyTrunk.Common
{
    public static class StringExt
    {
        public static string GetMd5(this string s)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            var t = md5.ComputeHash(Encoding.UTF8.GetBytes(s));
            var sb = new StringBuilder(32);
            foreach (byte t1 in t)
            {
                sb.Append(t1.ToString("x").PadLeft(2, '0'));
            }
            return sb.ToString();
        }

        /// <summary>
        /// 64加密
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string GetBase64Encode(this string s)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(s));
        }

        /// <summary>
        /// 64解密
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string GetBase64Decode(this string s)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(s));
        }
    }
}