using GTIKANTAR.Business;
using GTIKANTAR.DataType;
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

namespace GTIKANTAR
{
    public partial class KantarGenelBilgileri : Form
    {
        public KantarGenelBilgileri()
        {
            InitializeComponent();
        }

        private void KantarGenelBilgileri_Load(object sender, EventArgs e)
        {
            string KAPIID = Crytography.Decrypt(ConfigurationManager.AppSettings["KAPI"].ToString(), Petaframe.Security.Crytography.HashType.AES);
            string KANTARID = Crytography.Decrypt(ConfigurationManager.AppSettings["KANTAR"].ToString(), Petaframe.Security.Crytography.HashType.AES);
            using (KAPIBS bs = new KAPIBS(ConnectionStrings.KantarConnection))
            {
                cmbKapilar.ValueMember = "ID";
                cmbKapilar.DisplayMember = "ADI";
                cmbKapilar.DataSource = bs.Listele();
                if (!string.IsNullOrEmpty(KAPIID))
                {
                    cmbKapilar.SelectedItem = cmbKapilar.Items.Cast<KAPI>().Where(X => X.ID.ToString() == KAPIID).FirstOrDefault();
                }
            }
            object secilen = cmbKapilar.SelectedValue;
            if (secilen != null)
                using (KANTARLARBS bs = new KANTARLARBS(ConnectionStrings.KantarConnection))
                {
                    cmbKantarlar.ValueMember = "ID";
                    cmbKantarlar.DisplayMember = "ADI";
                    cmbKantarlar.DataSource = bs.Listele(Convert.ToInt64(secilen)); ;
                    if (!string.IsNullOrEmpty(KANTARID))
                    {
                        cmbKantarlar.SelectedItem = cmbKantarlar.Items.Cast<KANTARLAR>().Where(X => X.ID.ToString() == KANTARID).FirstOrDefault();
                    }
                }
        }

        private void cmbKapilar_SelectedIndexChanged(object sender, EventArgs e)
        {
            object secilen = cmbKapilar.SelectedValue;
            if (secilen != null)
                using (KANTARLARBS bs = new KANTARLARBS(ConnectionStrings.KantarConnection))
                {
                    cmbKantarlar.ValueMember = "ID";
                    cmbKantarlar.DisplayMember = "ADI";
                    cmbKantarlar.DataSource = bs.Listele(Convert.ToInt64(secilen));

                }
        }

        private void Kaydet_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

            config.AppSettings.Settings.Remove("KAPI");
            config.AppSettings.Settings.Remove("KANTAR");
            config.AppSettings.Settings.Add("KAPI", Petaframe.Security.Crytography.Encrypt(cmbKapilar.SelectedValue.ToString(), Petaframe.Security.Crytography.HashType.AES));
            config.AppSettings.Settings.Add("KANTAR", Petaframe.Security.Crytography.Encrypt(cmbKantarlar.SelectedValue.ToString(), Petaframe.Security.Crytography.HashType.AES));
            config.Save(ConfigurationSaveMode.Minimal);
            MessageBox.Show("Kayıt İşlemi Başarıyla Tamamlanmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
