namespace GTIKANTAR
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tartımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniTartımToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tartımGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametrelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veriTabanıBağlantılarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seriPortAyarlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kantarAyarlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslblTarih = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslblKullanici = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkışToolStripMenuItem,
            this.tartımToolStripMenuItem,
            this.parametrelerToolStripMenuItem,
            this.hakkındaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1277, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // tartımToolStripMenuItem
            // 
            this.tartımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniTartımToolStripMenuItem1,
            this.tartımGüncelleToolStripMenuItem});
            this.tartımToolStripMenuItem.Name = "tartımToolStripMenuItem";
            this.tartımToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.tartımToolStripMenuItem.Text = "Tartım";
            // 
            // yeniTartımToolStripMenuItem1
            // 
            this.yeniTartımToolStripMenuItem1.Name = "yeniTartımToolStripMenuItem1";
            this.yeniTartımToolStripMenuItem1.Size = new System.Drawing.Size(182, 24);
            this.yeniTartımToolStripMenuItem1.Text = "Yeni Tartım";
            this.yeniTartımToolStripMenuItem1.Click += new System.EventHandler(this.yeniTartımToolStripMenuItem1_Click);
            // 
            // tartımGüncelleToolStripMenuItem
            // 
            this.tartımGüncelleToolStripMenuItem.Name = "tartımGüncelleToolStripMenuItem";
            this.tartımGüncelleToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.tartımGüncelleToolStripMenuItem.Text = "Tartım Güncelle";
            // 
            // parametrelerToolStripMenuItem
            // 
            this.parametrelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veriTabanıBağlantılarıToolStripMenuItem,
            this.seriPortAyarlarıToolStripMenuItem,
            this.kantarAyarlarıToolStripMenuItem});
            this.parametrelerToolStripMenuItem.Name = "parametrelerToolStripMenuItem";
            this.parametrelerToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.parametrelerToolStripMenuItem.Text = "Parametreler";
            // 
            // veriTabanıBağlantılarıToolStripMenuItem
            // 
            this.veriTabanıBağlantılarıToolStripMenuItem.Name = "veriTabanıBağlantılarıToolStripMenuItem";
            this.veriTabanıBağlantılarıToolStripMenuItem.Size = new System.Drawing.Size(233, 24);
            this.veriTabanıBağlantılarıToolStripMenuItem.Text = "Veri Tabanı Bağlantıları";
            this.veriTabanıBağlantılarıToolStripMenuItem.Click += new System.EventHandler(this.veriTabanıBağlantılarıToolStripMenuItem_Click);
            // 
            // seriPortAyarlarıToolStripMenuItem
            // 
            this.seriPortAyarlarıToolStripMenuItem.Name = "seriPortAyarlarıToolStripMenuItem";
            this.seriPortAyarlarıToolStripMenuItem.Size = new System.Drawing.Size(233, 24);
            this.seriPortAyarlarıToolStripMenuItem.Text = "Seri Port Ayarları";
            this.seriPortAyarlarıToolStripMenuItem.Click += new System.EventHandler(this.seriPortAyarlarıToolStripMenuItem_Click);
            // 
            // kantarAyarlarıToolStripMenuItem
            // 
            this.kantarAyarlarıToolStripMenuItem.Name = "kantarAyarlarıToolStripMenuItem";
            this.kantarAyarlarıToolStripMenuItem.Size = new System.Drawing.Size(233, 24);
            this.kantarAyarlarıToolStripMenuItem.Text = "Kantar Ayarları";
            this.kantarAyarlarıToolStripMenuItem.Click += new System.EventHandler(this.kantarAyarlarıToolStripMenuItem_Click);
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblTarih,
            this.toolStripSeparator1,
            this.tslblKullanici});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(1277, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tslblTarih
            // 
            this.tslblTarih.Name = "tslblTarih";
            this.tslblTarih.Size = new System.Drawing.Size(70, 22);
            this.tslblTarih.Text = "tslblTarih";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tslblKullanici
            // 
            this.tslblKullanici.Name = "tslblKullanici";
            this.tslblKullanici.Size = new System.Drawing.Size(93, 22);
            this.tslblKullanici.Text = "tslblKullanici";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 445);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.Text = "Ana Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tartımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniTartımToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tartımGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametrelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veriTabanıBağlantılarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seriPortAyarlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslblTarih;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tslblKullanici;
        private System.Windows.Forms.ToolStripMenuItem kantarAyarlarıToolStripMenuItem;
    }
}