using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using CIS.Utils.Security;

namespace CIS.Utils.Config
{
    public class DBConfig
    {
        /// <summary>
        /// 数据库连接串
        /// </summary>
        public static string connString
        {
            get
            {
                //加密字符串
                //string str1 = Secure.EncryptAES("cisda",
                //                                   "Cis20151018",
                //                                   "Cis20151018");
                //string str = ConfigurationManager.ConnectionStrings["DataAppServices"].ConnectionString;
                string str = string.Format(ConfigurationManager.ConnectionStrings["DataAppServices"].ConnectionString, Security.Secure.DecryptAES(ConfigurationManager.AppSettings["OracleDBPWD"].ToString(), "Cis20151018", "Cis21151018"));

                return str;
            }
        }
    }
}
