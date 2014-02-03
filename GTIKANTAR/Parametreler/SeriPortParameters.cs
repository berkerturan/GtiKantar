using Petaframe.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GTIKANTAR.Parametreler
{
    public partial class SeriPortParameters : Form
    {
        public SeriPortParameters()
        {
            InitializeComponent();
        }

        private void Kaydet_Click(object sender, EventArgs e)
        {
            int sayi;
            if (string.IsNullOrEmpty(cmbHandShake.SelectedItem.ToString()) || string.IsNullOrEmpty(cmbParity.SelectedItem.ToString()) || string.IsNullOrEmpty(cmbPort.SelectedItem.ToString()) || string.IsNullOrEmpty(cmbStopBit.SelectedItem.ToString()) || string.IsNullOrEmpty(txtBaudRate.Text) || string.IsNullOrEmpty(txtDataBits.Text))
            {
                MessageBox.Show("Bütün Alanları Doldurunuz!", "Eksik Veri", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(txtBaudRate.Text, out sayi) || !int.TryParse(txtDataBits.Text, out sayi))
            {
                MessageBox.Show("BaudRate ve BataBits Alanalrına Sadece Sayı Girebilirsiniz!", "Yanlış Veri", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

                config.AppSettings.Settings.Remove("Port");
                config.AppSettings.Settings.Remove("BaudRate");
                config.AppSettings.Settings.Remove("Parity");
                config.AppSettings.Settings.Remove("StopBit");
                config.AppSettings.Settings.Remove("DataBit");
                config.AppSettings.Settings.Remove("HandShake");

                config.AppSettings.Settings.Add("Port", Petaframe.Security.Crytography.Encrypt(cmbPort.SelectedItem.ToString(), Petaframe.Security.Crytography.HashType.AES));
                config.AppSettings.Settings.Add("BaudRate", Petaframe.Security.Crytography.Encrypt(txtBaudRate.Text,
     Petaframe.Security.Crytography.HashType.AES));
                config.AppSettings.Settings.Add("Parity", Petaframe.Security.Crytography.Encrypt(cmbParity.SelectedItem.ToString(), Petaframe.Security.Crytography.HashType.AES));
                config.AppSettings.Settings.Add("StopBit", Petaframe.Security.Crytography.Encrypt(cmbStopBit.SelectedItem.ToString(), Petaframe.Security.Crytography.HashType.AES));
                config.AppSettings.Settings.Add("DataBit", Petaframe.Security.Crytography.Encrypt(txtDataBits.Text, Petaframe.Security.Crytography.HashType.AES));
                config.AppSettings.Settings.Add("HandShake", Petaframe.Security.Crytography.Encrypt(cmbHandShake.SelectedItem.ToString(), Petaframe.Security.Crytography.HashType.AES));
                config.Save(ConfigurationSaveMode.Minimal);
                MessageBox.Show("Kayıt İşlemi Başarıyla Tamamlanmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SeriPortParameters_Load(object sender, EventArgs e)
        {
            try
            {
                txtBaudRate.Text = Crytography.Decrypt(ConfigurationManager.AppSettings["BaudRate"].ToString(), Petaframe.Security.Crytography.HashType.AES);
                txtDataBits.Text = Crytography.Decrypt(ConfigurationManager.AppSettings["DataBit"].ToString(), Petaframe.Security.Crytography.HashType.AES);
                cmbParity.SelectedItem = Crytography.Decrypt(ConfigurationManager.AppSettings["Parity"].ToString(), Petaframe.Security.Crytography.HashType.AES);
                cmbHandShake.SelectedItem = Crytography.Decrypt(ConfigurationManager.AppSettings["HandShake"].ToString(), Petaframe.Security.Crytography.HashType.AES);
                cmbPort.SelectedItem = Crytography.Decrypt(ConfigurationManager.AppSettings["Port"].ToString(), Petaframe.Security.Crytography.HashType.AES);
                cmbStopBit.SelectedItem = Crytography.Decrypt(ConfigurationManager.AppSettings["StopBit"].ToString(), Petaframe.Security.Crytography.HashType.AES);
            }
            catch
            { }
        }

        private void btnSifre_Click(object sender, EventArgs e)
        {
            if (txtSifre.Text == "Kantar2014GTİ")
            {
                panel1.Enabled = true;
                txtSifre.Text = "";
            }
            else
            {
                MessageBox.Show("Şifre Yanlış!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
