using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GTIKANTAR.Parametreler
{
    public partial class ConnectionStrings : Form
    {
        public ConnectionStrings()
        {
            InitializeComponent();
        }

        private void btnErpKontrol_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection con = new SqlConnection(txtMerkezErp.Text);
                con.Open();
                con.Close();
                btnErp.Enabled = true;
                txtMerkezErp.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Girdiğiniz Bağlantı Kodu Yanlıştır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNexusKontrol_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection con = new SqlConnection(txtMerkezNexus.Text);
                con.Open();
                con.Close();
                btnNexus.Enabled = true;
                txtMerkezNexus.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Girdiğiniz Bağlantı Kodu Yanlıştır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnLocalKontrol_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(txtLocalKantar.Text);
                con.Open();
                con.Close();
                btnLocal.Enabled = true;
                txtLocalKantar.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Girdiğiniz Bağlantı Kodu Yanlıştır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnErp_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            config.AppSettings.Settings.Remove("ERPConnection");
            config.AppSettings.Settings.Add("ERPConnection", Petaframe.Security.Crytography.Encrypt(txtMerkezErp.Text, Petaframe.Security.Crytography.HashType.AES));
            config.Save(ConfigurationSaveMode.Minimal);
            txtMerkezErp.Enabled = true;
            btnErp.Enabled = false;
            txtMerkezErp.Text = "";

        }

        private void btnNexus_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            config.AppSettings.Settings.Remove("NEXUSConnection");
            config.AppSettings.Settings.Add("NEXUSConnection", Petaframe.Security.Crytography.Encrypt(txtMerkezNexus.Text, Petaframe.Security.Crytography.HashType.AES));
            config.Save(ConfigurationSaveMode.Minimal);
            txtMerkezNexus.Enabled = true;
            btnNexus.Enabled = false;
            txtMerkezNexus.Text = "";
        }

        private void btnLocal_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            config.AppSettings.Settings.Remove("KantarConnection");
            config.AppSettings.Settings.Add("KantarConnection", Petaframe.Security.Crytography.Encrypt(txtLocalKantar.Text, Petaframe.Security.Crytography.HashType.AES));
            config.Save(ConfigurationSaveMode.Minimal);
            txtLocalKantar.Enabled = true;
            btnLocal.Enabled = false;
            txtLocalKantar.Text = "";
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

        private void btnKapıKontrol_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(txtKapiKantar.Text);
                con.Open();
                con.Close();
                btnKapi.Enabled = true;
                txtKapiKantar.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Girdiğiniz Bağlantı Kodu Yanlıştır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKapi_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            config.AppSettings.Settings.Remove("KapiConnection");
            config.AppSettings.Settings.Add("KapiConnection", Petaframe.Security.Crytography.Encrypt(txtLocalKantar.Text, Petaframe.Security.Crytography.HashType.AES));
            config.Save(ConfigurationSaveMode.Minimal);
            txtKapiKantar.Enabled = true;
            btnKapi.Enabled = false;
            txtKapiKantar.Text = "";
        }
    }
}
