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
using System.Linq;
using System.Text;
using System.Transactions;
using System.Windows.Forms;

namespace GTIKANTAR
{
    public partial class TartimGuncelle : Form
    {
        public TartimGuncelle()
        {
            InitializeComponent();
        }
        KANTAR_KAPI Veri;
        private void TartimGuncelle_Load(object sender, EventArgs e)
        {
            string KAPIID = Crytography.Decrypt(ConfigurationManager.AppSettings["KAPI"].ToString(), Petaframe.Security.Crytography.HashType.AES);
            using (KANTARLARBS bs = new KANTARLARBS(ConnectionStrings.KantarConnection))
            {
                cmbKantarlar.ValueMember = "ID";
                cmbKantarlar.DisplayMember = "ADI";
                //IEnumerable<KANTARLAR> Kantarlar = bs.Listele(Convert.ToDecimal(KAPIID));
                if (Helpers.Tools.PingAtilabiliyor(ConnectionStrings.KapiConnection))
                    cmbKantarlar.DataSource = bs.Listele(Convert.ToDecimal(KAPIID));
                else
                {
                    MessageBox.Show("Kapıdaki DataBase'e Ping Atılamadığından Güncelleme İşlemi yapamazsınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.Close();
                    //cmbKantarlar.DataSource = Kantarlar.ToList().Where(x => x.ID == Convert.ToDecimal(Crytography.Decrypt(ConfigurationManager.AppSettings["KANTAR"].ToString(), Petaframe.Security.Crytography.HashType.AES)));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                decimal _tartimno;
                if (string.IsNullOrEmpty(txtTartimNo.Text) || !decimal.TryParse(txtTartimNo.Text, out _tartimno))
                {
                    MessageBox.Show("Tartım No Alanına Eksik Veya Yanlış Veri Girdiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (cmbKantarlar.SelectedItem == null)
                {
                    MessageBox.Show("Güncelleyeceğiniz Kaydın Yapıldığı Kantarı Seçmediniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (Helpers.Tools.PingAtilabiliyor(ConnectionStrings.KapiConnection))
                    {
                        using (KANTAR_KAPIBS bs = new KANTAR_KAPIBS(ConnectionStrings.KapiConnection))
                        {
                            Veri = bs.Listele(Convert.ToDecimal(cmbKantarlar.SelectedValue), _tartimno);
                            if (Veri != null)
                            {
                                panel2.Enabled = true;
                                txtPlaka.Text = Veri.PLAKA;
                                txtDorse.Text = Veri.DORSE;
                                txtTartinNoGuncellenecek.Text = Veri.TARTIMNO.Value.ToString();
                                txtZamanGuncellenecek.Text = Veri.ILKTARTIMTARIHI.ToString();
                                txtAgirlikGuncellenecek.Text = Veri.TARTIM1.Value.ToString();
                                txtAlan1Guncellenecek.Text = Veri.ALAN1;
                                txtAlan2Guncellenecek.Text = Veri.ALAN2;
                            }
                            else
                            {
                                MessageBox.Show("Böyle Bir Kayıt Bulunmamaktadır", "Yanlış Veri", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        //else
                        //{
                        //    using (KANTAR_LOCALBS bs = new KANTAR_LOCALBS(ConnectionStrings.KantarConnection))
                        //    {
                        //        KANTAR_LOCAL Veri = bs.Listele(_tartimno);
                        //        txtPlaka.Text = Veri.PLAKA;
                        //        txtDorse.Text = Veri.DORSE;
                        //        txtTartinNoGuncellenecek.Text = Veri.ID.ToString();
                        //        txtZamanGuncellenecek.Text = Veri.ILKTARTIMTARIHI.ToString();
                        //        txtAgirlikGuncellenecek.Text = Veri.TARTIM1.Value.ToString();
                        //        txtAlan1Guncellenecek.Text = Veri.ALAN1;
                        //        txtAlan2Guncellenecek.Text = Veri.ALAN2;
                        //    }
                        //}

                    }
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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    if (string.IsNullOrEmpty(txtPlaka.Text))
                    {
                        MessageBox.Show("Plaka Alanını Boş Geçemezsiniz!", "Eksik Veri", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Veri.PLAKA = txtPlaka.Text;
                        Veri.DORSE = txtDorse.Text;
                        Veri.TIP = "D";
                        Veri.MERKEZEYAZILDIMI = false;
                        Veri.SONTARTIMTARIHI = DateTime.Now;
                        using (KANTAR_KAPIBS bs = new KANTAR_KAPIBS(ConnectionStrings.KapiConnection))
                        {
                            if (bs.Kaydet(Veri))
                            {
                                MessageBox.Show("İşleminiz Başarıyla Tamamlanmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                scope.Complete();
                            }
                            else
                            {
                                MessageBox.Show("İşleminiz Başarıyla Tamamlanmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                scope.Complete();
                                this.Close();
                            }
                        }
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
