using GTIKANTAR.Business;
using GTIKANTAR.DataType;
using GTIKANTAR.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        IEnumerable<KANTAR_FIRM> Merkezfirmalar;
        DataTable Firmalar;
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
                btnEkle.Enabled = false;
                using (KANTAR_FIRMBS BS = new KANTAR_FIRMBS(ConnectionStrings.MerkezNexusConnection))
                {
                    IEnumerable<KANTAR_FIRM> Merkezfirmalar = BS.Listele();
                  grdFirms.DataSource=Merkezfirmalar;
                }
            }
            else
            {
                btnDuzenle.Enabled = false;
                btnSil.Enabled = false;
                using (KANTAR_FIRMBS BS = new KANTAR_FIRMBS(ConnectionStrings.KantarConnection))
                {
                    IEnumerable<KANTAR_FIRM> Kapıfirmalar = BS.Listele();
                    grdFirms.DataSource = Kapıfirmalar;
                }
            }
           
        }

        private void btnEkle_Click(object sender, EventArgs e)
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
                    if (Merkezfirmalar.ToList().Where(z => z.FIRMAKODU == txtKodu.Text.Trim().ToLower() || z.FIRMAADI == txtAdi.Text.Trim().ToLower()).Count() > 0)
                    {
                        MessageBox.Show("Aynı Firma Adına ve(ya) Aynı Firma Koduna Sahip Firma Vardır!", "Aynı Veri", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        Guid guid = new Guid();
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
                                FIRMID = guid,
                            };
                            if (bs.Kaydet(firm))
                            {
                                using (KANTAR_FIRMBS bsk = new KANTAR_FIRMBS(ConnectionStrings.KantarConnection))
                                {
                                    if (bsk.Kaydet(firm))
                                    {
                                        MessageBox.Show("İşleminiz Başarı İle Tamamlanmıştır!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        GetFirms();
                                        scope.Complete();
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

