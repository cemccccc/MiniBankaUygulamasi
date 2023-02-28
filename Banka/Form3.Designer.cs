namespace Banka
{
	partial class Form3
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.TxtAd = new System.Windows.Forms.TextBox();
			this.TxtSoyad = new System.Windows.Forms.TextBox();
			this.TxtSifre = new System.Windows.Forms.TextBox();
			this.MskTckn = new System.Windows.Forms.MaskedTextBox();
			this.MskTelefon = new System.Windows.Forms.MaskedTextBox();
			this.MskHesapNo = new System.Windows.Forms.MaskedTextBox();
			this.BtnKaydet = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ad:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 19);
			this.label2.TabIndex = 0;
			this.label2.Text = "Soyad:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 90);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 19);
			this.label3.TabIndex = 0;
			this.label3.Text = "Tckn:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 124);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 19);
			this.label4.TabIndex = 0;
			this.label4.Text = "Telefon:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 158);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(76, 19);
			this.label5.TabIndex = 0;
			this.label5.Text = "Hesap No:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 192);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(42, 19);
			this.label6.TabIndex = 0;
			this.label6.Text = "Şifre:";
			// 
			// TxtAd
			// 
			this.TxtAd.Location = new System.Drawing.Point(94, 23);
			this.TxtAd.Name = "TxtAd";
			this.TxtAd.Size = new System.Drawing.Size(192, 27);
			this.TxtAd.TabIndex = 1;
			// 
			// TxtSoyad
			// 
			this.TxtSoyad.Location = new System.Drawing.Point(94, 56);
			this.TxtSoyad.Name = "TxtSoyad";
			this.TxtSoyad.Size = new System.Drawing.Size(192, 27);
			this.TxtSoyad.TabIndex = 2;
			// 
			// TxtSifre
			// 
			this.TxtSifre.Location = new System.Drawing.Point(94, 188);
			this.TxtSifre.Name = "TxtSifre";
			this.TxtSifre.PasswordChar = '*';
			this.TxtSifre.Size = new System.Drawing.Size(192, 27);
			this.TxtSifre.TabIndex = 7;
			// 
			// MskTckn
			// 
			this.MskTckn.Location = new System.Drawing.Point(94, 89);
			this.MskTckn.Mask = "00000000000";
			this.MskTckn.Name = "MskTckn";
			this.MskTckn.Size = new System.Drawing.Size(192, 27);
			this.MskTckn.TabIndex = 3;
			this.MskTckn.ValidatingType = typeof(int);
			// 
			// MskTelefon
			// 
			this.MskTelefon.Location = new System.Drawing.Point(94, 122);
			this.MskTelefon.Mask = "(999) 000-0000";
			this.MskTelefon.Name = "MskTelefon";
			this.MskTelefon.Size = new System.Drawing.Size(192, 27);
			this.MskTelefon.TabIndex = 4;
			// 
			// MskHesapNo
			// 
			this.MskHesapNo.Enabled = false;
			this.MskHesapNo.Location = new System.Drawing.Point(94, 155);
			this.MskHesapNo.Mask = "000000";
			this.MskHesapNo.Name = "MskHesapNo";
			this.MskHesapNo.Size = new System.Drawing.Size(192, 27);
			this.MskHesapNo.TabIndex = 5;
			this.MskHesapNo.ValidatingType = typeof(int);
			// 
			// BtnKaydet
			// 
			this.BtnKaydet.Location = new System.Drawing.Point(157, 221);
			this.BtnKaydet.Name = "BtnKaydet";
			this.BtnKaydet.Size = new System.Drawing.Size(129, 30);
			this.BtnKaydet.TabIndex = 8;
			this.BtnKaydet.Text = "Kaydet";
			this.BtnKaydet.UseVisualStyleBackColor = true;
			this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(292, 155);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(31, 27);
			this.button1.TabIndex = 6;
			this.button1.Text = "...";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(335, 279);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.BtnKaydet);
			this.Controls.Add(this.MskHesapNo);
			this.Controls.Add(this.MskTelefon);
			this.Controls.Add(this.MskTckn);
			this.Controls.Add(this.TxtSifre);
			this.Controls.Add(this.TxtSoyad);
			this.Controls.Add(this.TxtAd);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Form3";
			this.Text = "Kişi Kaydet";
			this.Load += new System.EventHandler(this.Form3_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox TxtAd;
		private System.Windows.Forms.TextBox TxtSoyad;
		private System.Windows.Forms.TextBox TxtSifre;
		private System.Windows.Forms.MaskedTextBox MskTckn;
		private System.Windows.Forms.MaskedTextBox MskTelefon;
		private System.Windows.Forms.MaskedTextBox MskHesapNo;
		private System.Windows.Forms.Button BtnKaydet;
		private System.Windows.Forms.Button button1;
	}
}