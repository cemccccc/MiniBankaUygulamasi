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
	public partial class Form4 : Form
	{
		public Form4()
		{
			InitializeComponent();
		}

		SqlConnection baglanti = new SqlConnection(@"Data Source=CEMC\SQLEXPRESS01;Initial Catalog=DbBanka;Integrated Security=True");


		private void Form4_Load(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlCommand komut = new SqlCommand("select k.ID,k.AD,k.SOYAD,h.TUTAR from TblHareket h\r\ninner join TblKisiler k on h.GONDEREN=k.HESAPNO\r\n", baglanti);
			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter(komut);
			da.Fill(dt);
			dataGridView1.DataSource = dt;
			baglanti.Close();
		}
	}
}
