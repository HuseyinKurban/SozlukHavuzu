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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-32Q9FH5;Initial Catalog=DbSozlukHavuzu;Integrated Security=True;");

        void listele()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLKELİMELER", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLKELİMELER (Ingilizce,Turkce) values (@p1,@p2) ", baglanti);
            komut.Parameters.AddWithValue("@p1", txtingilizce.Text);
            komut.Parameters.AddWithValue("@p2", txtturkce.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kelime Başarıyla Listeye Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtid.Text= dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtingilizce.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtturkce.Text=dataGridView1.Rows[secilen].Cells[2].Value.ToString();

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TBLKELİMELER set Ingilizce=@p1 , Turkce=@p2 where ID=@p3", baglanti);
            komut.Parameters.AddWithValue("@p1", txtingilizce.Text);
            komut.Parameters.AddWithValue("@p2", txtturkce.Text);
            komut.Parameters.AddWithValue("@p3", txtid.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            listele();
            MessageBox.Show("Kelime Güncellendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from TBLKELİMELER where ID=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txtid.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            listele();
            MessageBox.Show("Kelime Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
