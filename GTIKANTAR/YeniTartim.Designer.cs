namespace GTIKANTAR
{
    partial class YeniTartim
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
            this.components = new System.ComponentModel.Container();
            this.port = new System.IO.Ports.SerialPort(this.components);
            this.txtTartim = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.txtDorse = new System.Windows.Forms.TextBox();
            this.txtSaati = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAlinan = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.cmbAlan1 = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtAlan2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // port
            // 
            this.port.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.port_DataReceived);
            // 
            // txtTartim
            // 
            this.txtTartim.Enabled = false;
            this.txtTartim.Location = new System.Drawing.Point(494, 46);
            this.txtTartim.Name = "txtTartim";
            this.txtTartim.Size = new System.Drawing.Size(140, 22);
            this.txtTartim.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(13, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(145, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Plaka";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(13, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(145, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Dorse";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(13, 102);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(145, 22);
            this.textBox3.TabIndex = 1;
            this.textBox3.Text = "Geliş Saati";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(171, 46);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(115, 22);
            this.txtPlaka.TabIndex = 0;
            this.txtPlaka.TextChanged += new System.EventHandler(this.txtPlaka_TextChanged);
            // 
            // txtDorse
            // 
            this.txtDorse.Location = new System.Drawing.Point(171, 74);
            this.txtDorse.Name = "txtDorse";
            this.txtDorse.Size = new System.Drawing.Size(115, 22);
            this.txtDorse.TabIndex = 1;
            // 
            // txtSaati
            // 
            this.txtSaati.Location = new System.Drawing.Point(170, 102);
            this.txtSaati.Name = "txtSaati";
            this.txtSaati.Size = new System.Drawing.Size(116, 22);
            this.txtSaati.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(494, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tartım (kg)";
            // 
            // txtAlinan
            // 
            this.txtAlinan.Enabled = false;
            this.txtAlinan.Location = new System.Drawing.Point(171, 132);
            this.txtAlinan.Name = "txtAlinan";
            this.txtAlinan.Size = new System.Drawing.Size(115, 22);
            this.txtAlinan.TabIndex = 4;
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(13, 131);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(145, 22);
            this.textBox6.TabIndex = 1;
            this.textBox6.Text = "Tartim (kg)";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(544, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "Tartımı Sabitle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(170, 218);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(115, 32);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbAlan1
            // 
            this.cmbAlan1.FormattingEnabled = true;
            this.cmbAlan1.Items.AddRange(new object[] {
            "Dolu",
            "Boş"});
            this.cmbAlan1.Location = new System.Drawing.Point(170, 160);
            this.cmbAlan1.Name = "cmbAlan1";
            this.cmbAlan1.Size = new System.Drawing.Size(115, 24);
            this.cmbAlan1.TabIndex = 7;
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(13, 190);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(145, 22);
            this.textBox5.TabIndex = 1;
            this.textBox5.Text = "Tartim Tekrarı Açıklam";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAlan2
            // 
            this.txtAlan2.Enabled = false;
            this.txtAlan2.Location = new System.Drawing.Point(170, 190);
            this.txtAlan2.Multiline = true;
            this.txtAlan2.Name = "txtAlan2";
            this.txtAlan2.Size = new System.Drawing.Size(186, 22);
            this.txtAlan2.TabIndex = 4;
            // 
            // YeniTartim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 284);
            this.Controls.Add(this.cmbAlan1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAlan2);
            this.Controls.Add(this.txtAlinan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSaati);
            this.Controls.Add(this.txtDorse);
            this.Controls.Add(this.txtPlaka);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtTartim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "YeniTartim";
            this.Text = "Yeni Tartim";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.YeniTartim_FormClosing);
            this.Load += new System.EventHandler(this.YeniTartim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort port;
        private System.Windows.Forms.TextBox txtTartim;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.TextBox txtDorse;
        private System.Windows.Forms.TextBox txtSaati;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAlinan;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ComboBox cmbAlan1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txtAlan2;
    }
}