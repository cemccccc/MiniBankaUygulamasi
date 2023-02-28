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
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		public string hesapNo;

		private void Form2_Load(object sender, EventArgs e)
		{
			this.BackColor = ColorTranslator.FromHtml("0xffeda0");
			LblHesapNo.Text = hesapNo;
			bilgileriCek();
		}

		SqlConnection baglanti = new SqlConnection(@"Data Source=CEMC\SQLEXPRESS01;Initial Catalog=DbBanka;Integrated Security=True");

		public void bilgileriCek()
		{
			baglanti.Open();
			SqlCommand komut = new SqlCommand("select * from TblKisiler where HESAPNO=" + hesapNo, baglanti);
			SqlDataReader dr = komut.ExecuteReader();
			while (dr.Read())
			{
				LblAdSoyad.Text = dr[1] + " " + dr[2];
				LblTckn.Text = dr[3].ToString();
				LblTelefon.Text = dr[4].ToString();
			}
			baglanti.Close();
		}

		private void BtnGonder_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlCommand komut = new SqlCommand("update TblHesap set BAKIYE=BAKIYE+@p1 where hesapno=@p2",baglanti);
			SqlCommand komut2 = new SqlCommand("update TblHesap set BAKIYE=BAKIYE-@p3 where hesapno=@p4",baglanti);
			SqlCommand komut3 = new SqlCommand("insert into TblHareket (GONDEREN,ALICI,TUTAR) values (@p5,@p6,@p7)",baglanti);
			komut.Parameters.AddWithValue("p1", TxtTutar.Text);
			komut.Parameters.AddWithValue("p2", MskHesapNo.Text);
			komut2.Parameters.AddWithValue("p3", TxtTutar.Text);
			komut2.Parameters.AddWithValue("p4", LblHesapNo.Text);
			komut3.Parameters.AddWithValue("p5", LblHesapNo.Text);
			komut3.Parameters.AddWithValue("p6", MskHesapNo.Text);
			komut3.Parameters.AddWithValue("p7", TxtTutar.Text);
			komut.ExecuteNonQuery();
			komut2.ExecuteNonQuery();
			komut3.ExecuteNonQuery();
			MessageBox.Show("Transfer işlemi başarı ile gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			baglanti.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form4 frm = new Form4();
			frm.Show();
		}
	}
}
