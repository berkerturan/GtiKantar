using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTIKANTAR
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            tslblKullanici.Text = Helpers.GlobalVeriler.ACTIVEUSER.FNAME + " " + Helpers.GlobalVeriler.ACTIVEUSER.LNAME;
            tslblTarih.Text = DateTime.Today.ToString("dd.MM.yyyy");
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıkmak İstediğinize Emin misiniz?", "Emin Misiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.ApplicationExitCall)
            {
                DialogResult result = MessageBox.Show("Çıkmak İstediğinize Emin misiniz?", "Emin Misiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        

        private void veriTabanıBağlantılarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = Helpers.Tools.Varmi("ConnectionStrings", this as frmMain);
            if (f == null)
            {
                f = new Parametreler.ConnectionStrings();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                f.BringToFront();
                this.ActivateMdiChild(f);
            }
        }

        private void seriPortAyarlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = Helpers.Tools.Varmi("SeriPortParameters", this as frmMain);
            if (f == null)
            {
                f = new Parametreler.SeriPortParameters();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                f.BringToFront();
                this.ActivateMdiChild(f);
            }
        }

        private void yeniTartımToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form f = Helpers.Tools.Varmi("YeniTartim", this as frmMain);
            if (f == null)
            {
                f = new YeniTartim();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                f.BringToFront();
                this.ActivateMdiChild(f);
            }
        }

        private void kantarAyarlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = Helpers.Tools.Varmi("KantarGenelBilgileri", this as frmMain);
            if (f == null)
            {
                f = new KantarGenelBilgileri();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                f.BringToFront();
                this.ActivateMdiChild(f);
            }
        }

        private void tartımGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = Helpers.Tools.Varmi("TartimGuncelle", this as frmMain);
            if (f == null)
            {
                f = new TartimGuncelle();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                f.BringToFront();
                this.ActivateMdiChild(f);
            }
        }
    }
}
