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
    public partial class FrmAdminGirisi : Form
    {
        public FrmAdminGirisi()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 frm= new Form1();
            frm.Show();
            this.Hide();
        }

        private void btngirisyap_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-32Q9FH5;Initial Catalog=DbSozlukHavuzu;Integrated Security=True;");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLADMIN where ADMINAD=@p1 and SIFRE=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", txtadminad.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
               FrmAdmin frm = new FrmAdmin();
                frm.Show();
                frm.Text ="Hoşgeldiniz: "+txtadminad.Text;
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı ya da Parola", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            baglanti.Close();
        }
    }
}
