using GTIKANTAR.Business;
using GTIKANTAR.DataType;
using Petaframe.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Transactions;
using System.Windows.Forms;

namespace GTIKANTAR
{
    public partial class YeniTartim : Form
    {
        public YeniTartim()
        {
            InitializeComponent();
        }
        int sayi = 0;
        private void port_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            sayi = 0;


            int bytes = port.BytesToRead;
            byte[] comBuffer = new byte[bytes];
            port.Read(comBuffer, 0, bytes);
            string yazilacak, kyazilacak;
            System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
            yazilacak = enc.GetString(comBuffer);
            kyazilacak = yazilacak.Substring(1).Trim();
            int tartim;

            if (int.TryParse(kyazilacak, out tartim))
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    txtTartim.Text = tartim.ToString();
                }));
            }
        }

        private void YeniTartim_Load(object sender, EventArgs e)
        {
            port.WriteTimeout = 5000;
            port.ReadTimeout = 5000;
            port.PortName = Crytography.Decrypt(ConfigurationManager.AppSettings["Port"].ToString(), Petaframe.Security.Crytography.HashType.AES);
            port.BaudRate = Convert.ToInt32(Crytography.Decrypt(ConfigurationManager.AppSettings["BaudRate"].ToString(), Petaframe.Security.Crytography.HashType.AES));
            port.DataBits = Convert.ToInt32(Crytography.Decrypt(ConfigurationManager.AppSettings["DataBit"].ToString(), Petaframe.Security.Crytography.HashType.AES));
            switch (Crytography.Decrypt(ConfigurationManager.AppSettings["Parity"].ToString(), Petaframe.Security.Crytography.HashType.AES))
            {
                case "Even":
                    port.Parity = Parity.Even;
                    break;
                case "Odd":
                    port.Parity = Parity.Odd;
                    break;
                case "Mark":
                    port.Parity = Parity.Mark;
                    break;
                case "Space":
                    port.Parity = Parity.Space;
                    break;
                default:
                    port.Parity = Parity.None;
                    break;
            }
            switch (Crytography.Decrypt(ConfigurationManager.AppSettings["HandShake"].ToString(), Petaframe.Security.Crytography.HashType.AES))
            {
                case "RequestToSend":
                    port.Handshake = Handshake.RequestToSend;
                    break;
                case "RequestToSendXOnXOdd":
                    port.Handshake = Handshake.RequestToSendXOnXOff;
                    break;
                case "XOnXOff":
                    port.Handshake = Handshake.XOnXOff;
                    break;
                default:
                    port.Handshake = Handshake.None;
                    break;
            }
            switch (Crytography.Decrypt(ConfigurationManager.AppSettings["StopBit"].ToString(), Petaframe.Security.Crytography.HashType.AES))
            {
                case "2":
                    port.StopBits = StopBits.Two;
                    break;
                case "1":
                    port.StopBits = StopBits.One;
                    break;
                case "1,5":
                    port.StopBits = StopBits.OnePointFive;
                    break;
                default:
                    port.StopBits = StopBits.None;
                    break;
            }
            if (!port.IsOpen)
            {
                try
                {
                    port.Open();
                    timer1.Interval = 1000;
                    timer1.Start();
                }
                catch
                {
                    MessageBox.Show("Port Açılamadı. Lütfen Ayarları Kontrol Ediniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void YeniTartim_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (port.IsOpen)
                port.Close();
            if (timer1.Enabled)
                timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayi++;
            if (sayi == 5)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    txtTartim.Text = "0,00";
                }));
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            txtAlinan.Text = txtTartim.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    decimal tartim;
                    if (string.IsNullOrEmpty(txtPlaka.Text))
                    {
                        MessageBox.Show("Plaka Alanının Doldurulması Zorunludur!", "Eksik Veri", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (string.IsNullOrEmpty(txtTartim.Text))
                    {
                        MessageBox.Show("Tartımı Sabitlemeniz Gerekmektedir!", "Eksik Veri", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                        else if (decimal.TryParse(txtTartim.Text, out tartim))
                    {
                        MessageBox.Show("Tartım Alanındaki Veri Yanlıştır!", "Hatalı Veri", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        IEnumerable<KANTAR_KAPI> KapiVerileri;
                        using (KANTAR_KAPIBS kbs = new KANTAR_KAPIBS(ConnectionStrings.KapiConnection))
                        {
                            KapiVerileri = kbs.ListeleSinceYesterday();
                        }
                        KANTAR_LOCAL entity = new KANTAR_LOCAL()
                        {
                            ILKTARTIMTARIHI = DateTime.Now,
                            DORSE = txtDorse.Text,
                            KAPIYAYAZILDIMI = false,
                            KULLANICI = frmLogin.GirişYapan.FNAME + ' ' + frmLogin.GirişYapan.LNAME,
                            PLAKA = txtPlaka.Text,
                            ROWID = Guid.NewGuid(),
                            TARTIM1 = tartim,
                            TIP = "C",
                            ALAN1 = cmbAlan1.SelectedValue.ToString()
                        };
                    }
                }
                catch (Exception exp)
                {
                    StackTrace st = new StackTrace();
                    StackFrame sf = new StackFrame();
                    new Helpers.ExceptionLogger().ThrowExp(exp, this as Form, sf.GetMethod().Name);
                    return;
                }
            }


        }
    }
}
