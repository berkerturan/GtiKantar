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
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(12, 40);
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
            this.textBox1.Location = new System.Drawing.Point(12, 12);
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
            this.cmbKapilar.Location = new System.Drawing.Point(167, 8);
            this.cmbKapilar.Name = "cmbKapilar";
            this.cmbKapilar.Size = new System.Drawing.Size(173, 24);
            this.cmbKapilar.TabIndex = 0;
            this.cmbKapilar.SelectedIndexChanged += new System.EventHandler(this.cmbKapilar_SelectedIndexChanged);
            // 
            // cmbKantarlar
            // 
            this.cmbKantarlar.FormattingEnabled = true;
            this.cmbKantarlar.Location = new System.Drawing.Point(167, 38);
            this.cmbKantarlar.Name = "cmbKantarlar";
            this.cmbKantarlar.Size = new System.Drawing.Size(173, 24);
            this.cmbKantarlar.TabIndex = 1;
            // 
            // Kaydet
            // 
            this.Kaydet.Location = new System.Drawing.Point(265, 68);
            this.Kaydet.Name = "Kaydet";
            this.Kaydet.Size = new System.Drawing.Size(75, 23);
            this.Kaydet.TabIndex = 2;
            this.Kaydet.Text = "Kaydet";
            this.Kaydet.UseVisualStyleBackColor = true;
            this.Kaydet.Click += new System.EventHandler(this.Kaydet_Click);
            // 
            // KantarGenelBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 253);
            this.Controls.Add(this.Kaydet);
            this.Controls.Add(this.cmbKantarlar);
            this.Controls.Add(this.cmbKapilar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KantarGenelBilgileri";
            this.Text = "KantarGenelBilgileri";
            this.Load += new System.EventHandler(this.KantarGenelBilgileri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbKapilar;
        private System.Windows.Forms.ComboBox cmbKantarlar;
        private System.Windows.Forms.Button Kaydet;
    }
}