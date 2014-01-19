using Petaframe.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTIKANTAR.Helpers
{
    class Tools
    {
        private static string GetIpfromConnectionString(string ConnectionString)//Connection stringden ilgili IP'yi çeker
        {
            string _connectionString = Crytography.Decrypt(ConnectionString, Petaframe.Security.Crytography.HashType.AES);
            int ilkindex = _connectionString.IndexOf('=');
            int sonindex = _connectionString.IndexOf('\\');
            return _connectionString.Substring(ilkindex + 1, sonindex - ilkindex - 1);

        }
        private static string ConstStr(string s, int adet)
        {
            string temp = s;
            for (int i = 1; i < adet; i++) temp += s;
            return temp;
        }
        public static bool PingAtilabiliyor(string ConnectionString)
        {
            Ping p = new Ping();
            PingOptions o = new PingOptions();
            o.DontFragment = true;
            string data = ConstStr("a", 32);
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            int timeout = 5000;
            bool ok;
            try
            {
                string ip = GetIpfromConnectionString(ConnectionString);
                if (ip == ".")
                {
                    return true;
                }
                PingReply reply = p.Send(ip, timeout, buffer, o);
                ok = (reply.Status == IPStatus.Success);
            }
            catch { ok = false; }
            p.Dispose();
            return ok;
        }
        public static Form Varmi(string formname, frmMain Anaform)
        {
            Form frm = null;
            foreach (Form item in Anaform.MdiChildren)
            {
                if (item.Name == formname)
                {
                    frm = item;
                    break;
                }
            }
            return frm;
        }
    }
}
