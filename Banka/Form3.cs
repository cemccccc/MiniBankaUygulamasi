using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka
{
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
		}

		private void Form3_Load(object sender, EventArgs e)
		{
			this.BackColor = ColorTranslator.FromHtml("0xffeda0");
		}

		SqlConnection baglanti = new SqlConnection(@"Data Source=CEMC\SQLEXPRESS01;Initial Catalog=DbBanka;Integrated Security=True");

		private void BtnKaydet_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlCommand komut = new SqlCommand("insert into TblKisiler (AD,SOYAD,TCKN,TELEFON,HESAPNO,SIFRE) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
			komut.Parameters.AddWithValue("p1", TxtAd.Text);
			komut.Parameters.AddWithValue("p2", TxtSoyad.Text);
			komut.Parameters.AddWithValue("p3", MskTckn.Text);
			komut.Parameters.AddWithValue("p4", MskTelefon.Text);
			komut.Parameters.AddWithValue("p5", MskHesapNo.Text);
			komut.Parameters.AddWithValue("p6", TxtSifre.Text);
			SqlCommand komut2 = new SqlCommand("insert into TblHesap (HESAPNO,BAKIYE) values (@p7,0)", baglanti);
			komut2.Parameters.AddWithValue("@p7", MskHesapNo.Text);
			komut.ExecuteNonQuery();
			komut2.ExecuteNonQuery();
			MessageBox.Show("Kaydetme işlemi başarı ile gerçekleşti.","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
			baglanti.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			int hesapNumarasi = rnd.Next(100000, 999999);
			MskHesapNo.Text= hesapNumarasi.ToString();
		}
	}
}
