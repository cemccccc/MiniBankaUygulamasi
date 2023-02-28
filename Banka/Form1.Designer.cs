namespace Banka
{
	partial class Form1
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
			this.TxtSifre = new System.Windows.Forms.TextBox();
			this.MskHesapNo = new System.Windows.Forms.MaskedTextBox();
			this.BtnGirisYap = new System.Windows.Forms.Button();
			this.LnkKayitOl = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Hesap No:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 91);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 19);
			this.label2.TabIndex = 0;
			this.label2.Text = "Şifre:";
			// 
			// TxtSifre
			// 
			this.TxtSifre.Location = new System.Drawing.Point(107, 88);
			this.TxtSifre.Name = "TxtSifre";
			this.TxtSifre.PasswordChar = '*';
			this.TxtSifre.Size = new System.Drawing.Size(173, 27);
			this.TxtSifre.TabIndex = 2;
			// 
			// MskHesapNo
			// 
			this.MskHesapNo.Location = new System.Drawing.Point(107, 57);
			this.MskHesapNo.Mask = "000000";
			this.MskHesapNo.Name = "MskHesapNo";
			this.MskHesapNo.Size = new System.Drawing.Size(173, 27);
			this.MskHesapNo.TabIndex = 1;
			this.MskHesapNo.ValidatingType = typeof(int);
			// 
			// BtnGirisYap
			// 
			this.BtnGirisYap.Location = new System.Drawing.Point(173, 122);
			this.BtnGirisYap.Name = "BtnGirisYap";
			this.BtnGirisYap.Size = new System.Drawing.Size(107, 28);
			this.BtnGirisYap.TabIndex = 3;
			this.BtnGirisYap.Text = "Giriş Yap";
			this.BtnGirisYap.UseVisualStyleBackColor = true;
			this.BtnGirisYap.Click += new System.EventHandler(this.BtnGirisYap_Click);
			// 
			// LnkKayitOl
			// 
			this.LnkKayitOl.AutoSize = true;
			this.LnkKayitOl.Font = new System.Drawing.Font("Calibri", 10F);
			this.LnkKayitOl.Location = new System.Drawing.Point(229, 153);
			this.LnkKayitOl.Name = "LnkKayitOl";
			this.LnkKayitOl.Size = new System.Drawing.Size(51, 17);
			this.LnkKayitOl.TabIndex = 4;
			this.LnkKayitOl.TabStop = true;
			this.LnkKayitOl.Text = "Kayıt Ol";
			this.LnkKayitOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkKayitOl_LinkClicked);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(306, 202);
			this.Controls.Add(this.LnkKayitOl);
			this.Controls.Add(this.BtnGirisYap);
			this.Controls.Add(this.MskHesapNo);
			this.Controls.Add(this.TxtSifre);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "Sisteme Giriş";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox TxtSifre;
		private System.Windows.Forms.MaskedTextBox MskHesapNo;
		private System.Windows.Forms.Button BtnGirisYap;
		private System.Windows.Forms.LinkLabel LnkKayitOl;
	}
}

