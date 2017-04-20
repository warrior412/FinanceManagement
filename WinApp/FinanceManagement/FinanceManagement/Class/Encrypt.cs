using System;

namespace Class
{

    public class Encrypt
    {
        /// <summary>
        /// 会社コードの暗号化？
        /// </summary>
        /// <param name="companyID"></param>
        /// <returns></returns>
        public static string CompanyIDEncryption(string companyID)
        {
            if (companyID.Length != 47 || !companyID.Substring(0, 3).Equals("C20"))
            {
                return string.Empty;
            }
            else
            {

                string ymd = companyID.Substring(3, 6);
                string num = companyID.Substring(9);

                string ret = Convert.ToString(Int32.Parse(ymd), 16).PadLeft(6, '0') + Convert.ToString(Int64.Parse(num), 16);

                return ret;
            }
        }

        /// <summary>
        /// 会社コードの暗号化？
        /// </summary>
        /// <param name="companyID"></param>
        /// <returns></returns>
        public static string CompanyIDDecryption(string companyIDEnc)
        {
            if (companyIDEnc.Length < 7)
            {
                return string.Empty;
            }
            else
            {
                string strymd = companyIDEnc.Substring(0, 6);
                string strnum = companyIDEnc.Substring(6);

                int ymd = Convert.ToInt32(strymd, 16);
                long num = Convert.ToInt64(strnum, 16);

                string companyID = "C20" + ymd.ToString() + num.ToString().PadLeft(38, '0');

                return companyID;
            }
        }

    }

}
