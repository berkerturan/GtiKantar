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
            tslblKullanici.Text = frmLogin.GirişYapan.FNAME + " " + frmLogin.GirişYapan.LNAME;
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

        private void yeniTartımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = Helpers.Tools.Varmi("Firma", this as frmMain);
            if (f == null)
            {
                f = new Tanimlar.Firma();
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
