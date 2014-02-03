namespace GTIKANTAR
{
    partial class KantarGenelBilgileri
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbKapilar = new System.Windows.Forms.ComboBox();
            this.cmbKantarlar = new System.Windows.Forms.ComboBox();
            this.Kaydet = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnSifre = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(3, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(126, 22);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "KANTAR";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(3, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(126, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "KAPI";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmbKapilar
            // 
            this.cmbKapilar.FormattingEnabled = true;
            this.cmbKapilar.Location = new System.Drawing.Point(158, 7);
            this.cmbKapilar.Name = "cmbKapilar";
            this.cmbKapilar.Size = new System.Drawing.Size(173, 24);
            this.cmbKapilar.TabIndex = 0;
            this.cmbKapilar.SelectedIndexChanged += new System.EventHandler(this.cmbKapilar_SelectedIndexChanged);
            // 
            // cmbKantarlar
            // 
            this.cmbKantarlar.FormattingEnabled = true;
            this.cmbKantarlar.Location = new System.Drawing.Point(158, 37);
            this.cmbKantarlar.Name = "cmbKantarlar";
            this.cmbKantarlar.Size = new System.Drawing.Size(173, 24);
            this.cmbKantarlar.TabIndex = 1;
            // 
            // Kaydet
            // 
            this.Kaydet.Location = new System.Drawing.Point(256, 67);
            this.Kaydet.Name = "Kaydet";
            this.Kaydet.Size = new System.Drawing.Size(75, 23);
            this.Kaydet.TabIndex = 2;
            this.Kaydet.Text = "Kaydet";
            this.Kaydet.UseVisualStyleBackColor = true;
            this.Kaydet.Click += new System.EventHandler(this.Kaydet_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.Kaydet);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.cmbKantarlar);
            this.panel1.Controls.Add(this.cmbKapilar);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(9, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 96);
            this.panel1.TabIndex = 5;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(9, 13);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(254, 22);
            this.txtSifre.TabIndex = 13;
            // 
            // btnSifre
            // 
            this.btnSifre.Location = new System.Drawing.Point(269, 12);
            this.btnSifre.Name = "btnSifre";
            this.btnSifre.Size = new System.Drawing.Size(75, 23);
            this.btnSifre.TabIndex = 12;
            this.btnSifre.Text = "Paneli Aç";
            this.btnSifre.UseVisualStyleBackColor = true;
            this.btnSifre.Click += new System.EventHandler(this.btnSifre_Click);
            // 
            // KantarGenelBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 155);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.btnSifre);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KantarGenelBilgileri";
            this.Text = "KantarGenelBilgileri";
            this.Load += new System.EventHandler(this.KantarGenelBilgileri_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbKapilar;
        private System.Windows.Forms.ComboBox cmbKantarlar;
        private System.Windows.Forms.Button Kaydet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnSifre;
    }
}