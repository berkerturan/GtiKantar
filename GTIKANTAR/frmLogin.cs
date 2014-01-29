using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GTIKANTAR.Business;
using GTIKANTAR.DataType;
using System.Configuration;
using System.Transactions;
using System.Diagnostics;

namespace GTIKANTAR
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public static EMPLOYEES GirişYapan;
        private void Form1_Load(object sender, EventArgs e)
        {
            GetEmployees();
        }

        private void GetKapis()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    if (!Helpers.Tools.PingAtilabiliyor(ConnectionStrings.MerkezErpConnection))
                    {
                        lblStatus.Text = "Merkez Veritabanına Ping Atılamadığından Kapı Bilgileri Çekilemedi.";
                        return;
                    }
                    else
                    {
                        lblStatus.Text = "Kapı Verileri Çekiliyor!";
                        //  string conname1 = Petaframe.Security.Crytography.Encrypt(@"Server=.\KapiMerkez;Database=KANTARDB;User Id=AppUser;Password=AppUsergtierp", Petaframe.Security.Crytography.HashType.AES);
                        IEnumerable<KAPI> MerkezKapis;
                        IEnumerable<KAPI> KapiKapis;
                        using (KAPIBS bs = new KAPIBS(ConnectionStrings.MerkezNexusConnection))
                        {
                            MerkezKapis = bs.Listele();
                        }
                        using (KAPIBS bs = new KAPIBS(ConnectionStrings.KantarConnection))
                        {
                            KapiKapis = bs.Listele();
                        }
                        if (KapiKapis.Count() == 0)
                        {
                            using (KAPIBS bs = new KAPIBS(ConnectionStrings.KantarConnection))
                            {
                                MerkezKapis.ToList().ForEach(X =>
                                {
                                    bs.Kaydet(X);
                                });
                            }
                        }
                        else
                        {
                            using (KAPIBS bs = new KAPIBS(ConnectionStrings.KantarConnection))
                            {
                                MerkezKapis.ToList().ForEach(X =>
                                {
                                    KAPI SecilenKapiEmp = KapiKapis.ToList().Where(Y => Y.ID == X.ID).FirstOrDefault();
                                    if (SecilenKapiEmp == null)
                                    {
                                        bs.Kaydet(SecilenKapiEmp);
                                    }
                                    else
                                    {
                                        bs.Guncelle(SecilenKapiEmp);
                                    }
                                });
                            }
                        }
                        lblStatus.Text = "Kapı Verileri Çekildi";
                        scope.Complete();
                    }
                }

                catch (Exception exp)
                {
                    lblStatus.Text = "Kapı Verileri Çekilirken Hata Oluştu";
                    StackTrace st = new StackTrace();
                    StackFrame sf = new StackFrame();
                    new Helpers.ExceptionLogger().ThrowExp(exp, this as Form, sf.GetMethod().Name);
                    return;
                }
            }
        }
        private void GetKantars()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    if (!Helpers.Tools.PingAtilabiliyor(ConnectionStrings.MerkezErpConnection))
                    {
                        lblStatus.Text = "Merkez Veritabanına Ping Kantar Bilgileri Çekilemedi.";
                        return;
                    }
                    else
                    {
                        lblStatus.Text = "Kantar Verileri Çekiliyor!";
                        //  string conname1 = Petaframe.Security.Crytography.Encrypt(@"Server=.\KapiMerkez;Database=KANTARDB;User Id=AppUser;Password=AppUsergtierp", Petaframe.Security.Crytography.HashType.AES);
                        IEnumerable<KANTARLAR> MerkezKapis;
                        IEnumerable<KANTARLAR> KapiKapis;
                        using (KANTARLARBS bs = new KANTARLARBS(ConnectionStrings.MerkezNexusConnection))
                        {
                            MerkezKapis = bs.Listele();
                        }
                        using (KANTARLARBS bs = new KANTARLARBS(ConnectionStrings.KantarConnection))
                        {
                            KapiKapis = bs.Listele();
                        }
                        if (KapiKapis.Count() == 0)
                        {
                            using (KANTARLARBS bs = new KANTARLARBS(ConnectionStrings.KantarConnection))
                            {
                                MerkezKapis.ToList().ForEach(X =>
                                {
                                    bs.Kaydet(X);
                                });
                            }
                        }
                        else
                        {
                            using (KANTARLARBS bs = new KANTARLARBS(ConnectionStrings.KantarConnection))
                            {
                                MerkezKapis.ToList().ForEach(X =>
                                {
                                    KANTARLAR SecilenKapiEmp = KapiKapis.ToList().Where(Y => Y.ID == X.ID).FirstOrDefault();
                                    if (SecilenKapiEmp == null)
                                    {
                                        bs.Kaydet(SecilenKapiEmp);
                                    }
                                    else
                                    {
                                        bs.Guncelle(SecilenKapiEmp);
                                    }
                                });
                            }
                        }
                        lblStatus.Text = "Kantar Verileri Çekildi";
                        scope.Complete();
                    }
                }

                catch (Exception exp)
                {
                    lblStatus.Text = "Kantar Verileri Çekilirken Hata Oluştu";
                    StackTrace st = new StackTrace();
                    StackFrame sf = new StackFrame();
                    new Helpers.ExceptionLogger().ThrowExp(exp, this as Form, sf.GetMethod().Name);
                    return;
                }
            }
        }
        private void GetEmployees()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    if (!Helpers.Tools.PingAtilabiliyor(ConnectionStrings.MerkezErpConnection))
                    {
                        lblStatus.Text = "Merkez Veritabanına Ping Atılamadığından Firma Verileri Eşlenemedi.";
                        return;
                    }
                    else
                    {
                        lblStatus.Text = "Kullanıcı Verileri Çekiliyor!";
                        IEnumerable<EMPLOYEES> MerkezEmployees;
                        IEnumerable<EMPLOYEES> KapiEmployees;
                        using (EMPLOYEESBS bs = new EMPLOYEESBS(ConnectionStrings.MerkezErpConnection))
                        {
                            MerkezEmployees = bs.Listele();
                        }
                        using (EMPLOYEESBS bs = new EMPLOYEESBS(ConnectionStrings.KantarConnection))
                        {
                            KapiEmployees = bs.Listele();
                        }
                        if (KapiEmployees.Count() == 0)
                        {
                            using (EMPLOYEESBS bs = new EMPLOYEESBS(ConnectionStrings.KantarConnection))
                            {
                                MerkezEmployees.ToList().ForEach(X =>
                                {
                                    bs.Kaydet(X);
                                });
                            }
                        }
                        else
                        {
                            using (EMPLOYEESBS bs = new EMPLOYEESBS(ConnectionStrings.KantarConnection))
                            {
                                MerkezEmployees.ToList().ForEach(X =>
                                {
                                    EMPLOYEES SecilenKapiEmp = KapiEmployees.ToList().Where(Y => Y.EMPLOYEEID == X.EMPLOYEEID).FirstOrDefault();
                                    if (SecilenKapiEmp == null)
                                    {
                                        bs.Kaydet(SecilenKapiEmp);
                                    }
                                    else
                                    {
                                        bs.Guncelle(SecilenKapiEmp);
                                    }
                                });
                            }
                        }
                        lblStatus.Text = "Kullanıcı Verileri Çekildi";
                        scope.Complete();
                    }
                }

                catch (Exception exp)
                {
                    lblStatus.Text = "Kullanıcı Verileri Çekilirken Hata Oluştu";
                    StackTrace st = new StackTrace();
                    StackFrame sf = new StackFrame();
                    new Helpers.ExceptionLogger().ThrowExp(exp, this as Form, sf.GetMethod().Name);
                    return;
                }
            }
        }
        private void GetFirms()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    if (!Helpers.Tools.PingAtilabiliyor(ConnectionStrings.MerkezErpConnection))
                    {
                        lblStatus.Text = "Merkez Veritabanına Ping Atılamadığından Kullanıcı Verileri Çekilemedi.";
                        return;
                    }
                    else
                    {
                        lblStatus.Text = "Firma Verileri Eşleniyor!";
                        IEnumerable<KANTAR_FIRM> MerkezData;
                        IEnumerable<KANTAR_FIRM> KapiData;
                        using (KANTAR_FIRMBS bs = new KANTAR_FIRMBS(ConnectionStrings.MerkezNexusConnection))
                        {
                            MerkezData = bs.Listele();
                        }
                        using (KANTAR_FIRMBS bs = new KANTAR_FIRMBS(ConnectionStrings.KantarConnection))
                        {
                            KapiData = bs.Listele();
                        }
                        if (KapiData.Count() == 0)
                        {
                            using (KANTAR_FIRMBS bs = new KANTAR_FIRMBS(ConnectionStrings.KantarConnection))
                            {
                                MerkezData.ToList().ForEach(X =>
                                {
                                    bs.Kaydet(X);
                                });
                            }
                        }
                        else
                        {
                            using (KANTAR_FIRMBS bs = new KANTAR_FIRMBS(ConnectionStrings.KantarConnection))
                            {
                                MerkezData.ToList().ForEach(X =>
                                {
                                    KANTAR_FIRM SecilenKapiEmp = KapiData.ToList().Where(Y => Y.FIRMID == X.FIRMID).FirstOrDefault();
                                    if (SecilenKapiEmp == null)
                                    {
                                        bs.Kaydet(SecilenKapiEmp);
                                    }
                                    else
                                    {
                                        bs.Guncelle(SecilenKapiEmp);
                                    }
                                });
                            }
                        }
                        lblStatus.Text = "Firma Verileri Çekildi";
                        scope.Complete();
                    }
                }
                catch (Exception exp)
                {
                    lblStatus.Text = "Firma Verileri Eşlenirken Hata Oluştu";
                    StackTrace st = new StackTrace();
                    StackFrame sf = new StackFrame();
                    new Helpers.ExceptionLogger().ThrowExp(exp, this as Form, sf.GetMethod().Name);
                    return;
                }
            }
        }
        private void GetMalzemes()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    if (!Helpers.Tools.PingAtilabiliyor(ConnectionStrings.MerkezErpConnection))
                    {
                        lblStatus.Text = "Merkez Veritabanına Ping Atılamadığından Malzeme Verileri Eşlenemedi.";
                        return;
                    }
                    else
                    {
                        lblStatus.Text = "Malzeme Verileri Eşleniyor!";
                        IEnumerable<KANTAR_MALZEME> MerkezData;
                        IEnumerable<KANTAR_MALZEME> KapiData;
                        using (KANTAR_MALZEMEBS bs = new KANTAR_MALZEMEBS(ConnectionStrings.MerkezNexusConnection))
                        {
                            MerkezData = bs.Listele();
                        }
                        using (KANTAR_MALZEMEBS bs = new KANTAR_MALZEMEBS(ConnectionStrings.KantarConnection))
                        {
                            KapiData = bs.Listele();
                        }
                        if (KapiData.Count() == 0)
                        {
                            using (KANTAR_MALZEMEBS bs = new KANTAR_MALZEMEBS(ConnectionStrings.KantarConnection))
                            {
                                MerkezData.ToList().ForEach(X =>
                                {
                                    bs.Kaydet(X);
                                });
                            }
                        }
                        else
                        {
                            using (KANTAR_MALZEMEBS bs = new KANTAR_MALZEMEBS(ConnectionStrings.KantarConnection))
                            {
                                MerkezData.ToList().ForEach(X =>
                                {
                                    KANTAR_MALZEME SecilenKapiEmp = KapiData.ToList().Where(Y => Y.MALZEMEID == X.MALZEMEID).FirstOrDefault();
                                    if (SecilenKapiEmp == null)
                                    {
                                        bs.Kaydet(SecilenKapiEmp);
                                    }
                                    else
                                    {
                                        bs.Guncelle(SecilenKapiEmp);
                                    }
                                });
                            }
                        }
                        lblStatus.Text = "Malzeme Verileri Çekildi";
                        scope.Complete();
                    }

                }
                catch (Exception exp)
                {
                    lblStatus.Text = "Malzeme Verileri Eşlenirken Hata Oluştu";
                    StackTrace st = new StackTrace();
                    StackFrame sf = new StackFrame();
                    new Helpers.ExceptionLogger().ThrowExp(exp, this as Form, sf.GetMethod().Name);
                    return;
                }
            }
        }
        private void GetAracs()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    if (!Helpers.Tools.PingAtilabiliyor(ConnectionStrings.MerkezErpConnection))
                    {
                        lblStatus.Text = "Merkez Veritabanına Ping Atılamadığından Araç Verileri Eşlenemedi.";
                        return;
                    }

                    else
                    {
                        lblStatus.Text = "Araç Verileri Eşleniyor!";
                        IEnumerable<KANTAR_ARAC> MerkezData;
                        IEnumerable<KANTAR_ARAC> KapiData;
                        using (KANTAR_ARACBS bs = new KANTAR_ARACBS(ConnectionStrings.MerkezNexusConnection))
                        {
                            MerkezData = bs.Listele();
                        }
                        using (KANTAR_ARACBS bs = new KANTAR_ARACBS(ConnectionStrings.KantarConnection))
                        {
                            KapiData = bs.Listele();
                        }
                        if (KapiData.Count() == 0)
                        {
                            using (KANTAR_ARACBS bs = new KANTAR_ARACBS(ConnectionStrings.KantarConnection))
                            {
                                MerkezData.ToList().ForEach(X =>
                                {
                                    bs.Kaydet(X);
                                });
                            }
                        }
                        else
                        {
                            using (KANTAR_ARACBS bs = new KANTAR_ARACBS(ConnectionStrings.KantarConnection))
                            {
                                MerkezData.ToList().ForEach(X =>
                                {
                                    KANTAR_ARAC SecilenKapiEmp = KapiData.ToList().Where(Y => Y.ARACID == X.ARACID).FirstOrDefault();
                                    if (SecilenKapiEmp == null)
                                    {
                                        bs.Kaydet(SecilenKapiEmp);
                                    }
                                    else
                                    {
                                        bs.Guncelle(SecilenKapiEmp);
                                    }
                                });
                            }
                        }
                        lblStatus.Text = "Araç Verileri Çekildi";
                        scope.Complete();
                    }
                }
                catch (Exception exp)
                {
                    lblStatus.Text = "Araç Verileri Eşlenirken Hata Oluştu";
                    StackTrace st = new StackTrace();
                    StackFrame sf = new StackFrame();
                    new Helpers.ExceptionLogger().ThrowExp(exp, this as Form, sf.GetMethod().Name);
                    return;
                }
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKullaniciAdi.Text) || string.IsNullOrEmpty(txtSifre.Text))
            {
                MessageBox.Show("Kullanıcı Adı-Şifre Alanlarını Doldurunuz", "Eksik Veri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                using (EMPLOYEESBS bs = new EMPLOYEESBS(ConnectionStrings.KantarConnection))
                {
                    GirişYapan = bs.KullaniciAdiSifreKontrol(txtKullaniciAdi.Text.ToLower().Trim(), txtSifre.Text.ToLower().Trim());
                    if (GirişYapan == null)
                    {
                        MessageBox.Show("Kullanıcı Adı-Şifre Uyumsuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        GetKapis();
                        GetKantars();
                       // GetFirms();
                      //  GetMalzemes();
                      //  GetAracs();
                        frmMain f = new frmMain();
                        f.Show();
                        this.Hide();
                    }
                }
            }
        }
    }
}
