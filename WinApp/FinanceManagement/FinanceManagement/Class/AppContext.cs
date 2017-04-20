using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManagement.Class
{
    public class AppContext
    {
        private static AppContext _instance = null;
        private UserInfo userInfo;

        public UserInfo UserInfo
        {
            get { return userInfo; }
            set { userInfo = value; }
        }
        public static AppContext GetInstance()
        {
            if (_instance == null)
                return _instance = new AppContext();
            return _instance;
        }
        public string getMoneyFormatByDouble(double value)
        {
            if (value == 0)
                return "0.0 VND";
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // try with "en-US"
            string stotal = value.ToString("#,###", cul.NumberFormat) + " VND";
            return stotal;
        }
    }
    public class UserInfo
    {
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        private string fullname;

        public string Fullname
        {
            get { return fullname; }
            set { fullname = value; }
        }
        private int role;

        public int Role
        {
            get { return role; }
            set { role = value; }
        }
    }
}
