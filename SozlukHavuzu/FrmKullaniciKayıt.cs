using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SozlukHavuzu
{
    public partial class FrmKullaniciKayıt : Form
    {
        public FrmKullaniciKayıt()
        {
            InitializeComponent();
        }

        private void btnkaydol_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-32Q9FH5;Initial Catalog=DbSozlukHavuzu;Integrated Security=True;");

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLKULLANICI (ADSOYAD,SIFRE) values (@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtadsoyad.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
