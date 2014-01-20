using GTIKANTAR.Business;
using GTIKANTAR.DataType;
using GTIKANTAR.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Transactions;
using System.Windows.Forms;

namespace GTIKANTAR.Tanimlar
{
    public partial class Firma : Form
    {
        bool Ping;
        IEnumerable<KANTAR_FIRM> Firmalar;
        public Firma()
        {
            InitializeComponent();
        }

        private void Firma_Load(object sender, EventArgs e)
        {
            Ping = Tools.PingAtilabiliyor(ConnectionStrings.MerkezNexusConnection);
            GetFirms();
        }

        private void GetFirms()
        {            
            if (Ping)
            {
                btnDuzenle.Enabled = false;
                btnSil.Enabled = false;
                using (KANTAR_FIRMBS BS = new KANTAR_FIRMBS(ConnectionStrings.MerkezNexusConnection))
                {
                    Firmalar = BS.Listele();
                }
            }
            else
            {
                btnEkle.Enabled = true;
                btnDuzenle.Enabled = false;
                btnSil.Enabled = false;
                using (KANTAR_FIRMBS BS = new KANTAR_FIRMBS(ConnectionStrings.KantarConnection))
                {
                    Firmalar = BS.Listele();
                }
            }
            FirmaAra();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    if (string.IsNullOrEmpty(txtAdi.Text) || string.IsNullOrEmpty(txtKodu.Text))
                    {
                        MessageBox.Show("Firma Adı ve Firma Kodu Alanları Boş Geçilemez!", "Eksik Veri", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        if (Firmalar.ToList().Where(z => z.FIRMAKODU == txtKodu.Text.Trim().ToLower() || z.FIRMAADI == txtAdi.Text.Trim().ToLower()).Count() > 0)
                        {
                            MessageBox.Show("Aynı Firma Adına ve(ya) Aynı Firma Koduna Sahip Firma Vardır!", "Aynı Veri", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {
                            using (KANTAR_FIRMBS bs = new KANTAR_FIRMBS(ConnectionStrings.MerkezNexusConnection))
                            {
                                KANTAR_FIRM firm = new KANTAR_FIRM()
                                {
                                    ADRES1 = txtAdres1.Text,
                                    ADRES2 = txtAdres2.Text,
                                    VERGINO = txtVergiNo.Text,
                                    FIRMAADI = txtAdi.Text,
                                    VERGIDAIRESI = txtVergiDairesi.Text,
                                    FIRMAKODU = txtKodu.Text,
                                    FIRMID = Guid.NewGuid(),
                                };
                                if (bs.Kaydet(firm))
                                {
                                    using (KANTAR_FIRMBS bsk = new KANTAR_FIRMBS(ConnectionStrings.KantarConnection))
                                    {
                                        if (bsk.Kaydet(firm))
                                        {
                                            MessageBox.Show("İşleminiz Başarı İle Tamamlanmıştır!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            GetFirms();
                                            Temizle();
                                            scope.Complete();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Firma Local Veritabanına Kaydedilemediğinden İşleminiz Gerçekleşmemiştir!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Firma Merkez Veritabanına Kaydedilemediğinden İşleminiz Gerçekleşmemiştir!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
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

        private void grdFirms_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Ping)
            {
                btnSil.Enabled = true;
                btnEkle.Enabled = false;
                btnDuzenle.Enabled = true;
            }
            DataGridViewRow row = grdFirms.Rows[e.RowIndex];
            txtKodu.Text = row.Cells["FIRMAKODU"].Value.ToString();
            txtAdi.Text = row.Cells["FIRMAADI"].Value.ToString();
            txtAdres1.Text = row.Cells["ADRES1"].Value.ToString();
            txtAdres2.Text = row.Cells["ADRES2"].Value.ToString();
            txtVergiDairesi.Text = row.Cells["VERGIDAIRESI"].Value.ToString();
            txtVergiNo.Text = row.Cells["VERGINO"].Value.ToString();
            btnDuzenle.Tag = row.Cells["FIRMID"].Value.ToString();
            btnSil.Tag = row.Cells["FIRMID"].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                Ping = Tools.PingAtilabiliyor(ConnectionStrings.MerkezNexusConnection);
                using (TransactionScope scope = new TransactionScope())
                {
                    if (Ping)
                    {
                        KANTAR_FIRM entity = new KANTAR_FIRM()
                        {
                            FIRMID = new Guid(btnSil.Tag.ToString())
                        };
                        using (KANTAR_FIRMBS bs = new KANTAR_FIRMBS(ConnectionStrings.MerkezNexusConnection))
                        {
                            if (bs.Sil(entity))
                            {
                                using (KANTAR_FIRMBS bsk = new KANTAR_FIRMBS(ConnectionStrings.KantarConnection))
                                {
                                    if (bsk.Sil(entity))
                                    {
                                        MessageBox.Show("Kayıt Başarı İle Silinmiştir!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        Temizle();
                                        GetFirms();
                                        scope.Complete();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Firma Local Veritabanından Silinemediğinden İşleminiz Gerçekleşmemiştir!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Firma Merkez Veritabanından Silinemediğinden İşleminiz Gerçekleşmemiştir!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
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

        private void txtAraFirmaKod_TextChanged(object sender, EventArgs e)
        {
            FirmaAra();
        }

        protected void FirmaAra()
        {
            IEnumerable<KANTAR_FIRM> aramaSonucu;
            if (!string.IsNullOrEmpty(txtAraFirmaKod.Text))
            {
                aramaSonucu = Firmalar.ToList().Where(X => X.FIRMAKODU.ToLower().Contains(txtAraFirmaKod.Text.ToLower()));               
            }
            else
            {
                aramaSonucu = Firmalar;
            }
            if (!string.IsNullOrEmpty(txtAraFirmaAdi.Text))
            {
                aramaSonucu = aramaSonucu.ToList().Where(X => X.FIRMAADI.ToLower().Contains(txtAraFirmaAdi.Text.ToLower()));
            }
            if (!string.IsNullOrEmpty(txtAraAdres1.Text))
            {
                aramaSonucu = aramaSonucu.ToList().Where(X => X.ADRES1.ToLower().Contains(txtAraAdres1.Text.ToLower()));
            }
            if (!string.IsNullOrEmpty(txtAraAdres2.Text))
            {
                aramaSonucu = aramaSonucu.ToList().Where(X => X.ADRES1.ToLower().Contains(txtAraAdres2.Text.ToLower()));
            }
            if (!string.IsNullOrEmpty(txtAraVergiDairesi.Text))
            {
                aramaSonucu = aramaSonucu.ToList().Where(X => X.VERGIDAIRESI.ToLower().Contains(txtAraVergiDairesi.Text.ToLower()));
            }
            if (!string.IsNullOrEmpty(txtaraVergiNo.Text))
            {
                aramaSonucu = aramaSonucu.ToList().Where(X => X.VERGINO.ToLower().Contains(txtaraVergiNo.Text.ToLower()));
            }
            grdFirms.Columns["FIRMID"].Visible = false;
            grdFirms.DataSource = aramaSonucu.ToList();
        }

        private void txtAraFirmaAdi_TextChanged(object sender, EventArgs e)
        {
            FirmaAra();
        }

        private void txtAraAdres1_TextChanged(object sender, EventArgs e)
        {
            FirmaAra();
        }

        private void txtAraAdres2_TextChanged(object sender, EventArgs e)
        {
            FirmaAra();
        }

        private void txtAraVergiDairesi_TextChanged(object sender, EventArgs e)
        {
            FirmaAra();
        }

        private void txtaraVergiNo_TextChanged(object sender, EventArgs e)
        {
            FirmaAra();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                Ping = Tools.PingAtilabiliyor(ConnectionStrings.MerkezNexusConnection);
                using (TransactionScope scope = new TransactionScope())
                {
                    if (Ping)
                    {
                        if (string.IsNullOrEmpty(txtAdi.Text) || string.IsNullOrEmpty(txtKodu.Text))
                        {
                            MessageBox.Show("Firma Adı ve Firma Kodu Alanları Boş Geçilemez!", "Eksik Veri", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {
                            if (Firmalar.ToList().Where(z => z.FIRMID != new Guid(btnDuzenle.Tag.ToString()) && (z.FIRMAKODU == txtKodu.Text.Trim().ToLower() || z.FIRMAADI == txtAdi.Text.Trim().ToLower())).Count() > 0)
                            {
                                MessageBox.Show("Aynı Firma Adına ve(ya) Aynı Firma Koduna Sahip Firma Vardır!", "Aynı Veri", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            else
                            {
                                KANTAR_FIRM entity = new KANTAR_FIRM()
                                {
                                    FIRMID = new Guid(btnSil.Tag.ToString()),
                                    FIRMAADI = txtAdi.Text,
                                    FIRMAKODU = txtKodu.Text,
                                    ADRES1 = txtAdres1.Text,
                                    ADRES2 = txtAdres2.Text,
                                    VERGIDAIRESI = txtVergiDairesi.Text,
                                    VERGINO = txtVergiNo.Text
                                };
                                using (KANTAR_FIRMBS bs = new KANTAR_FIRMBS(ConnectionStrings.MerkezNexusConnection))
                                {
                                    if (bs.Guncelle(entity))
                                    {
                                        using (KANTAR_FIRMBS bsk = new KANTAR_FIRMBS(ConnectionStrings.KantarConnection))
                                        {
                                            if (bsk.Guncelle(entity))
                                            {
                                                MessageBox.Show("Kayıt Başarı İle Güncellenmiştir!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                Temizle();
                                                GetFirms();
                                                scope.Complete();
                                            }
                                            else
                                            {
                                                MessageBox.Show("Firma Local Veritabanından Güncellenemediğinden İşleminiz Gerçekleşmemiştir!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Firma Merkez Veritabanından Güncellenemediğinden İşleminiz Gerçekleşmemiştir!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            Ping = Tools.PingAtilabiliyor(ConnectionStrings.MerkezNexusConnection);
            if (Ping)
            {
                btnEkle.Enabled = true;

            }
            else
            {
                btnEkle.Enabled = false;
                MessageBox.Show("Merkeze Ping Atamadığınızdan Kayıt İşlemi Yapamazsınız!", "Uyar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            btnDuzenle.Enabled = false;
            btnSil.Enabled = false;
            txtKodu.Text = "";
            txtAdi.Text = "";
            txtAdres1.Text = "";
            txtAdres2.Text = "";
            txtVergiDairesi.Text = "";
            txtVergiNo.Text = "";
            btnDuzenle.Tag = "";
            btnSil.Tag = "";
        }

    }
}

