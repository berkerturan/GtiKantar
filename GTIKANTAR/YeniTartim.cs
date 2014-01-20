using Petaframe.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
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
           
                this.Invoke(new MethodInvoker(delegate
                {
                    txtTartim.Text = port.ReadLine();
                }));
            
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
    }
}
