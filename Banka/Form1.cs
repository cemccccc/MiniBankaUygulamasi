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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		SqlConnection baglanti = new SqlConnection(@"Data Source=CEMC\SQLEXPRESS01;Initial Catalog=DbBanka;Integrated Security=True");
		public string hesapNo;
		

		private void Form1_Load(object sender, EventArgs e)
		{
			this.BackColor = ColorTranslator.FromHtml("0xffeda0");
			
		}

		private void LnkKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Form3 frm = new Form3();
			frm.Show();
		}



		public void BtnGirisYap_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlCommand komut = new SqlCommand("select * from TblKisiler where HESAPNO=@p1 and SIFRE=@p2",baglanti);
			komut.Parameters.AddWithValue("p1", MskHesapNo.Text);
			komut.Parameters.AddWithValue("p2", TxtSifre.Text);
			SqlDataReader dr = komut.ExecuteReader();
			if (dr.Read())
			{
				Form2 frm = new Form2();
				frm.hesapNo = MskHesapNo.Text;
				frm.Show();
			}
			else
			{
				MessageBox.Show("Hatalı Bilgi Girişi.","Dikkat",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			baglanti.Close();
		}
	}
}
