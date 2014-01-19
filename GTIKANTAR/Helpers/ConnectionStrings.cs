using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTIKANTAR
{
    static class ConnectionStrings
    {

        public static string MerkezErpConnection
        {
            get
            {
                return ConfigurationManager.AppSettings["ERPConnection"].ToString();
            }

        }
        public static string MerkezNexusConnection
        {
            get
            {
                return ConfigurationManager.AppSettings["NEXUSConnection"].ToString();
            }

        }

        public static string KantarConnection
        {
            get
            {
                return ConfigurationManager.AppSettings["KantarConnection"].ToString();
            }

        }

    }
}
