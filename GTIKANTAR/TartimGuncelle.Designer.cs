namespace GTIKANTAR
{
    partial class TartimGuncelle
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
            this.txtTartimNo = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbKantarlar = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.txtDorse = new System.Windows.Forms.TextBox();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtTartinNoGuncellenecek = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.txtKantarIDGuncellenecek = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtZamanGuncellenecek = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.txtAgirlikGuncellenecek = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.txtAlan1Guncellenecek = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.txtAlan2Guncellenecek = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTartimNo
            // 
            this.txtTartimNo.Location = new System.Drawing.Point(199, 9);
            this.txtTartimNo.MaxLength = 50;
            this.txtTartimNo.Name = "txtTartimNo";
            this.txtTartimNo.Size = new System.Drawing.Size(199, 22);
            this.txtTartimNo.TabIndex = 27;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(6, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox2.Size = new System.Drawing.Size(163, 22);
            this.textBox2.TabIndex = 30;
            this.textBox2.Text = "KANTAR";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(6, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(163, 22);
            this.textBox1.TabIndex = 29;
            this.textBox1.Text = "TARTIM NO";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 32);
            this.button1.TabIndex = 31;
            this.button1.Text = "Kaydı Getir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbKantarlar);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.txtTartimNo);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 101);
            this.panel1.TabIndex = 32;
            // 
            // cmbKantarlar
            // 
            this.cmbKantarlar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbKantarlar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbKantarlar.FormattingEnabled = true;
            this.cmbKantarlar.Location = new System.Drawing.Point(199, 37);
            this.cmbKantarlar.Name = "cmbKantarlar";
            this.cmbKantarlar.Size = new System.Drawing.Size(199, 24);
            this.cmbKantarlar.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtKantarIDGuncellenecek);
            this.panel2.Controls.Add(this.textBox7);
            this.panel2.Controls.Add(this.txtAlan2Guncellenecek);
            this.panel2.Controls.Add(this.txtAgirlikGuncellenecek);
            this.panel2.Controls.Add(this.textBox11);
            this.panel2.Controls.Add(this.txtAlan1Guncellenecek);
            this.panel2.Controls.Add(this.textBox9);
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Controls.Add(this.txtZamanGuncellenecek);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.txtTartinNoGuncellenecek);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.btnGuncelle);
            this.panel2.Controls.Add(this.txtDorse);
            this.panel2.Controls.Add(this.txtPlaka);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(12, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 300);
            this.panel2.TabIndex = 33;
            // 
            // txtDorse
            // 
            this.txtDorse.Location = new System.Drawing.Point(199, 205);
            this.txtDorse.Name = "txtDorse";
            this.txtDorse.Size = new System.Drawing.Size(199, 22);
            this.txtDorse.TabIndex = 3;
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(199, 177);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(199, 22);
            this.txtPlaka.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(6, 205);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(163, 22);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "Dorse";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(6, 177);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(163, 22);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = "Plaka";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(280, 233);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(118, 32);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "Kaydet";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtTartinNoGuncellenecek
            // 
            this.txtTartinNoGuncellenecek.Enabled = false;
            this.txtTartinNoGuncellenecek.Location = new System.Drawing.Point(199, 38);
            this.txtTartinNoGuncellenecek.Name = "txtTartinNoGuncellenecek";
            this.txtTartinNoGuncellenecek.Size = new System.Drawing.Size(199, 22);
            this.txtTartinNoGuncellenecek.TabIndex = 8;
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(6, 38);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(163, 22);
            this.textBox6.TabIndex = 9;
            this.textBox6.Text = "Tartım No";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtKantarIDGuncellenecek
            // 
            this.txtKantarIDGuncellenecek.Enabled = false;
            this.txtKantarIDGuncellenecek.Location = new System.Drawing.Point(199, 10);
            this.txtKantarIDGuncellenecek.Name = "txtKantarIDGuncellenecek";
            this.txtKantarIDGuncellenecek.Size = new System.Drawing.Size(199, 22);
            this.txtKantarIDGuncellenecek.TabIndex = 10;
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(6, 10);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(163, 22);
            this.textBox7.TabIndex = 11;
            this.textBox7.Text = "Kantar ID";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(6, 66);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(163, 22);
            this.textBox5.TabIndex = 9;
            this.textBox5.Text = "Geliş Zamanı";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtZamanGuncellenecek
            // 
            this.txtZamanGuncellenecek.Enabled = false;
            this.txtZamanGuncellenecek.Location = new System.Drawing.Point(199, 66);
            this.txtZamanGuncellenecek.Name = "txtZamanGuncellenecek";
            this.txtZamanGuncellenecek.Size = new System.Drawing.Size(199, 22);
            this.txtZamanGuncellenecek.TabIndex = 8;
            // 
            // textBox9
            // 
            this.textBox9.Enabled = false;
            this.textBox9.Location = new System.Drawing.Point(6, 94);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(163, 22);
            this.textBox9.TabIndex = 9;
            this.textBox9.Text = "Ağırlığo (kg)";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAgirlikGuncellenecek
            // 
            this.txtAgirlikGuncellenecek.Enabled = false;
            this.txtAgirlikGuncellenecek.Location = new System.Drawing.Point(199, 94);
            this.txtAgirlikGuncellenecek.Name = "txtAgirlikGuncellenecek";
            this.txtAgirlikGuncellenecek.Size = new System.Drawing.Size(199, 22);
            this.txtAgirlikGuncellenecek.TabIndex = 8;
            // 
            // textBox8
            // 
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(6, 121);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(163, 22);
            this.textBox8.TabIndex = 9;
            this.textBox8.Text = "Golu/Boş";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAlan1Guncellenecek
            // 
            this.txtAlan1Guncellenecek.Enabled = false;
            this.txtAlan1Guncellenecek.Location = new System.Drawing.Point(199, 121);
            this.txtAlan1Guncellenecek.Name = "txtAlan1Guncellenecek";
            this.txtAlan1Guncellenecek.Size = new System.Drawing.Size(199, 22);
            this.txtAlan1Guncellenecek.TabIndex = 8;
            // 
            // textBox11
            // 
            this.textBox11.Enabled = false;
            this.textBox11.Location = new System.Drawing.Point(6, 149);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(163, 22);
            this.textBox11.TabIndex = 9;
            this.textBox11.Text = "Açıklama";
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAlan2Guncellenecek
            // 
            this.txtAlan2Guncellenecek.Enabled = false;
            this.txtAlan2Guncellenecek.Location = new System.Drawing.Point(199, 149);
            this.txtAlan2Guncellenecek.Name = "txtAlan2Guncellenecek";
            this.txtAlan2Guncellenecek.Size = new System.Drawing.Size(199, 22);
            this.txtAlan2Guncellenecek.TabIndex = 8;
            // 
            // TartimGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 425);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TartimGuncelle";
            this.ShowIcon = false;
            this.Text = "Tartım Güncelle";
            this.Load += new System.EventHandler(this.TartimGuncelle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTartimNo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbKantarlar;
        private System.Windows.Forms.Panel panel2;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.TextBox txtDorse;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtTartinNoGuncellenecek;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox txtKantarIDGuncellenecek;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox txtAgirlikGuncellenecek;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox txtZamanGuncellenecek;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txtAlan2Guncellenecek;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox txtAlan1Guncellenecek;
        private System.Windows.Forms.TextBox textBox8;

    }
}