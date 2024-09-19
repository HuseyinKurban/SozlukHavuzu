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
    public partial class FrmKullanici : Form
    {
        public FrmKullanici()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-32Q9FH5;Initial Catalog=DbSozlukHavuzu;Integrated Security=True;");
        Random rnd = new Random();
        int sure = 90;
        int kelime = 0;
        public int id;

        void getir()
        {
            int sayi;
            sayi = rnd.Next(1, 101);

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TBLKELİMELER where ID=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", sayi);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtingilizce.Text = dr[1].ToString();
                lblcevap.Text = dr[2].ToString();
                lblcevap.Text = lblcevap.Text.ToLower();


            }

            baglanti.Close();

        }

        void puanguncelle()
        {
          

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TBLKULLANICI where ID=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", id);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
              lblpuan.Text = dr[3].ToString();
            }

            baglanti.Close();
        }


        private void FrmKullanici_Load(object sender, EventArgs e)
        {
            getir();
            puanguncelle();
            timer1.Start();
            lblid.Text=id.ToString();

        }

        private void txturkce_TextChanged(object sender, EventArgs e)
        {
            if (txturkce.Text == lblcevap.Text)
            {
                kelime++;
                lblkelime.Text = kelime.ToString();
                txturkce.Text = "";
                getir();
                puanguncelle();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            lblsure.Text = sure.ToString();
            if (sure == 0)
            {
                txturkce.Enabled = false;
                txtingilizce.Enabled = false;
                timer1.Stop();

                baglanti.Open();
                SqlCommand komut = new SqlCommand("update TBLKULLANICI set DOGRUSAYISI=DOGRUSAYISI+@p1 where ID=@p2", baglanti);
                komut.Parameters.AddWithValue("@p1", lblkelime.Text);
                komut.Parameters.AddWithValue("@p2", id);
                komut.ExecuteNonQuery();
                baglanti.Close();
                puanguncelle();


            }
                
        }
    }
}
