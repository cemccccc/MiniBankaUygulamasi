namespace Banka
{
	partial class Form2
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
			this.LblAdSoyad = new System.Windows.Forms.Label();
			this.LblHesapNo = new System.Windows.Forms.Label();
			this.LblTelefon = new System.Windows.Forms.Label();
			this.LblTckn = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.BtnGonder = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.TxtTutar = new System.Windows.Forms.TextBox();
			this.MskHesapNo = new System.Windows.Forms.MaskedTextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ad Soyad:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 19);
			this.label2.TabIndex = 0;
			this.label2.Text = "Hesap no:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 92);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 19);
			this.label3.TabIndex = 0;
			this.label3.Text = "Telefon:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 119);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(42, 19);
			this.label4.TabIndex = 0;
			this.label4.Text = "Tckn:";
			// 
			// LblAdSoyad
			// 
			this.LblAdSoyad.AutoSize = true;
			this.LblAdSoyad.Location = new System.Drawing.Point(108, 38);
			this.LblAdSoyad.Name = "LblAdSoyad";
			this.LblAdSoyad.Size = new System.Drawing.Size(33, 19);
			this.LblAdSoyad.TabIndex = 1;
			this.LblAdSoyad.Text = "null";
			// 
			// LblHesapNo
			// 
			this.LblHesapNo.AutoSize = true;
			this.LblHesapNo.Location = new System.Drawing.Point(108, 65);
			this.LblHesapNo.Name = "LblHesapNo";
			this.LblHesapNo.Size = new System.Drawing.Size(33, 19);
			this.LblHesapNo.TabIndex = 1;
			this.LblHesapNo.Text = "null";
			// 
			// LblTelefon
			// 
			this.LblTelefon.AutoSize = true;
			this.LblTelefon.Location = new System.Drawing.Point(108, 92);
			this.LblTelefon.Name = "LblTelefon";
			this.LblTelefon.Size = new System.Drawing.Size(33, 19);
			this.LblTelefon.TabIndex = 1;
			this.LblTelefon.Text = "null";
			// 
			// LblTckn
			// 
			this.LblTckn.AutoSize = true;
			this.LblTckn.Location = new System.Drawing.Point(108, 119);
			this.LblTckn.Name = "LblTckn";
			this.LblTckn.Size = new System.Drawing.Size(33, 19);
			this.LblTckn.TabIndex = 1;
			this.LblTckn.Text = "null";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.BtnGonder);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.TxtTutar);
			this.groupBox1.Controls.Add(this.MskHesapNo);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Location = new System.Drawing.Point(13, 233);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(485, 244);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Havale";
			// 
			// BtnGonder
			// 
			this.BtnGonder.Location = new System.Drawing.Point(160, 114);
			this.BtnGonder.Name = "BtnGonder";
			this.BtnGonder.Size = new System.Drawing.Size(98, 25);
			this.BtnGonder.TabIndex = 4;
			this.BtnGonder.Text = "Gönder";
			this.BtnGonder.UseVisualStyleBackColor = true;
			this.BtnGonder.Click += new System.EventHandler(this.BtnGonder_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(16, 88);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(46, 19);
			this.label5.TabIndex = 3;
			this.label5.Text = "Tutar:";
			// 
			// TxtTutar
			// 
			this.TxtTutar.Location = new System.Drawing.Point(110, 80);
			this.TxtTutar.Name = "TxtTutar";
			this.TxtTutar.Size = new System.Drawing.Size(148, 27);
			this.TxtTutar.TabIndex = 2;
			// 
			// MskHesapNo
			// 
			this.MskHesapNo.Location = new System.Drawing.Point(110, 47);
			this.MskHesapNo.Mask = "000000";
			this.MskHesapNo.Name = "MskHesapNo";
			this.MskHesapNo.Size = new System.Drawing.Size(148, 27);
			this.MskHesapNo.TabIndex = 1;
			this.MskHesapNo.ValidatingType = typeof(int);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(16, 55);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(76, 19);
			this.label9.TabIndex = 0;
			this.label9.Text = "Hesap No:";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(343, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(159, 35);
			this.button1.TabIndex = 5;
			this.button1.Text = "Hesap Hareketleri";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(514, 489);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.LblTckn);
			this.Controls.Add(this.LblTelefon);
			this.Controls.Add(this.LblHesapNo);
			this.Controls.Add(this.LblAdSoyad);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form2";
			this.Text = "Havale Yap";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label LblAdSoyad;
		private System.Windows.Forms.Label LblHesapNo;
		private System.Windows.Forms.Label LblTelefon;
		private System.Windows.Forms.Label LblTckn;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button BtnGonder;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox TxtTutar;
		private System.Windows.Forms.MaskedTextBox MskHesapNo;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button button1;
	}
}