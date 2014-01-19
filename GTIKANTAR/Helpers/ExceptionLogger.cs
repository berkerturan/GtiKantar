using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace GTIKANTAR.Helpers
{
    class ExceptionLogger
    {
        string Kaydet(Exception exp, Form form, string MetodName)
        {
            string _path = Application.StartupPath + "\\DB_HATA.TXT";
            // StreamWriter f = new StreamWriter(_path, true, Encoding.UTF8);
            string msg = exp.InnerException == null ? exp.Message : exp.InnerException.Message;
            msg += !String.IsNullOrEmpty(exp.StackTrace) ? exp.StackTrace : String.Empty;
            msg += exp.InnerException != null ? exp.InnerException.StackTrace : String.Empty;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Tarih = " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + " - Formun Adı = " + form.Name + " - Metod Adı = " + MetodName);
            sb.AppendLine();
            sb.AppendLine(msg);
            sb.AppendLine();
            sb.AppendLine("---x---x---x---x---x---x---x---");
            try
            {
                if (!File.Exists(_path))
                {
                    using (StreamWriter sw = File.CreateText(_path))
                    {
                        sw.WriteLine(sb.ToString());
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(_path))
                    {
                        sw.WriteLine(sb.ToString());
                    }
                }
            }
            catch
            {
            }
            return msg;
        }
        public void ThrowExp(Exception exp, Form context, string methodadi)
        {
            string msg = Kaydet(exp, context, methodadi);
            msg = string.IsNullOrEmpty(msg) ? "Hata Alınmıştır ama Hata MEsajı Yazılamamıştır." : msg;

            try
            {
                MailClass mail = new MailClass();
                StringBuilder body = new StringBuilder();
                string path = Application.StartupPath + "\\MailFormat\\ExceptionMail.txt";
                body.AppendFormat(File.ReadAllText(path), context.Name, methodadi, msg);
                if (mail.MailGonder("turanberker@yahoo.com", "TurStok Hata", body.ToString()))
                {
                    MessageBox.Show("Beklenmedik Bir Hata Alınmıştır. Hata Kaydedilmiştir. Hata mesajı Mail Atılmıştır. ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Beklenmedik Bir Hata Alınmıştır. Ancak Mail Atılamamıştır. ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Beklenmedik Bir Hata Alınmıştır. Ancak Mail Atılamamıştır. ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
