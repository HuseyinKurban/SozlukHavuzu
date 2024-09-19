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
    public partial class FrmKullaniciGirisi : Form
    {
        public FrmKullaniciGirisi()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void btngirisyap_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-32Q9FH5;Initial Catalog=DbSozlukHavuzu;Integrated Security=True;");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLKULLANICI where ADSOYAD=@p1 and SIFRE=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", txtkullaniciad.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                int kullaniciID = Convert.ToInt32(dr["ID"]);
                FrmKullanici frm = new FrmKullanici();
                frm.id = (int)dr["ID"];
                frm.Text = "Hoşgeldiniz: " + txtkullaniciad.Text;
                frm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı ya da Parola", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            baglanti.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmKullaniciKayıt frm=new FrmKullaniciKayıt();
            frm.Show();

        }
    }
}
