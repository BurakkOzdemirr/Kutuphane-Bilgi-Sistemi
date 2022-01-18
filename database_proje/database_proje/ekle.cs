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

namespace database_proje
{
    public partial class ekle : Form
    {
        public ekle()
        {
            InitializeComponent();
        }
        public void listelekat()
        {
            try
            {
                DataSet ds = new DataSet();
                string komut = "Select * from sube";
                SqlDataAdapter da = new SqlDataAdapter(komut, Form1.con);
                da.Fill(ds, "sube");
                dataGridView1.DataSource = ds.Tables["sube"];
                Form1.con.Close();
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message, "Listelemede bir hata meydana geldi");
            }
        }
        public void listeleyaz()
        {
            try
            {
                DataSet ds1 = new DataSet();
                string komut = "Select * from stokturu";
                SqlDataAdapter da1 = new SqlDataAdapter(komut, Form1.con);
                da1.Fill(ds1, "stokturu");
                dataGridView2.DataSource = ds1.Tables["stokturu"];
                Form1.con.Close();
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message, "Listelemede bir hata meydana geldi");
            }
        }
        public void listeleyay()
        {
            try
            {
                DataSet ds2 = new DataSet();
                string komut = "Select * from silme";
                SqlDataAdapter da2 = new SqlDataAdapter(komut, Form1.con);
                da2.Fill(ds2, "silme");
                dataGridView3.DataSource = ds2.Tables["silme"];
                Form1.con.Close();
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message, "Listelemede bir hata meydana geldi");
            }
        }

        private void ekle_Load(object sender, EventArgs e)
        {
            Form1.conac();
            this.silmeTableAdapter.Fill(this.stokDataSet4.silme);
            this.stokturuTableAdapter.Fill(this.stokDataSet2.stokturu);
            this.subeTableAdapter1.Fill(this.stokDataSet5.sube);
            Form1.con.Close();
            if (stok.ekle == 1)
            {
                kat.Visible = true;
                yay.Visible = false;
                yaz.Visible = false;
            }
            else if (stok.ekle == 2)
            {
                kat.Visible = false;
                yay.Visible = true;
                yaz.Visible = false;
            }
            else
            {
                kat.Visible = false;
                yay.Visible = false;
                yaz.Visible = true;
            }

        }

        private void sil_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.conac();
                string komut = "Delete From sube where subekodu=" + id.Text;
                SqlCommand cmd = new SqlCommand(komut, Form1.con);
                if (cmd.ExecuteNonQuery() == 1)
                    MessageBox.Show("Kaydınız Silindi");
                Form1.con.Close();
                listelekat();
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message, "Silerken bir hata oluştu");
            }
        }

        private void yeni_Click(object sender, EventArgs e)
        {
            kaydet.Visible = false;
            tamam.Visible = true;
            adi.Text = "";
            subtel.Text = "";
            subeadres.Text = "";
        }

        private void tamam_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.conac();
                string komut = "Insert Into sube (subeadi,subeadres,subetel) Values (@ka,@a,@t)";
                SqlCommand com = new SqlCommand(komut, Form1.con);
                com.Parameters.AddWithValue("@ka", adi.Text);
                com.Parameters.AddWithValue("@a", subeadres.Text);
                com.Parameters.AddWithValue("@t", subtel.Text);
                if (com.ExecuteNonQuery() == 1)
                    MessageBox.Show("Kayıt Eklendi");
                Form1.con.Close();
                listelekat();
                kaydet.Visible = true;
                tamam.Visible = false;

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Kayıt eklerken bir hata oluştu");
            }
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.conac();
                string komut = "update sube set subeadi=@ka,subeadres=@a,subetel=@t where subekodu=@id";
                SqlCommand com = new SqlCommand(komut, Form1.con);
                com.Parameters.AddWithValue("@ka", adi.Text);
                com.Parameters.AddWithValue("@a", subeadres.Text);
                com.Parameters.AddWithValue("@t", subtel.Text);
                com.Parameters.AddWithValue("@id", id.Text);
                if (com.ExecuteNonQuery() == 1)
                    MessageBox.Show("Kayıt Güncellendi");
                Form1.con.Close();
                listelekat();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Kayıt güncellerken bir hata oluştu");
            }
        }

        private void iptal_Click(object sender, EventArgs e)
        {
            adi.Text = "";
            subtel.Text = "";
            subeadres.Text = "";
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            adi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            subtel.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            subeadres.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void yazyeni_Click(object sender, EventArgs e)
        {
            yazkaydet.Visible = false;
            yaztamam.Visible = true;
            yazadi.Text = "";
        }

        private void yaztamam_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.conac();
                string komut = "Insert Into stokturu (stokturu) Values (@ka)";
                SqlCommand com = new SqlCommand(komut, Form1.con);
                com.Parameters.AddWithValue("@ka", yazadi.Text);
                if (com.ExecuteNonQuery() == 1)
                    MessageBox.Show("Kayıt Eklendi");
                Form1.con.Close();
                listeleyaz();
                yazkaydet.Visible = true;
                yaztamam.Visible = false;

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Kayıt eklerken bir hata oluştu");
            }
        }

        private void yazkaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.conac();
                string komut = "update stokturu set stokturu=@ka where stokid=@id";
                SqlCommand com = new SqlCommand(komut, Form1.con);
                com.Parameters.AddWithValue("@ka", yazadi.Text);
                com.Parameters.AddWithValue("@id", yazid.Text);
                if (com.ExecuteNonQuery() == 1)
                    MessageBox.Show("Kayıt Güncellendi");
                Form1.con.Close();
                listeleyaz();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Kayıt güncellerken bir hata oluştu");
            }
        }

        private void yaziptal_Click(object sender, EventArgs e)
        {
            yazadi.Text = "";
        }

        private void yazsil_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.conac();
                string komut = "Delete From stokturu where stokid=" + yazid.Text;
                SqlCommand cmd = new SqlCommand(komut, Form1.con);
                if (cmd.ExecuteNonQuery() == 1)
                    MessageBox.Show("Kaydınız Silindi");
                Form1.con.Close();
                listeleyaz();
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message, "Silerken bir hata oluştu");
            }
        }

        private void yayyeni_Click(object sender, EventArgs e)
        {
            yaykaydet.Visible = false;
            yaytamam.Visible = true;
            yayadi.Text = "";
        }

        private void yaytamam_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.conac();
                string komut = "Insert Into silme (silmeneden) Values (@ka)";
                SqlCommand com = new SqlCommand(komut, Form1.con);
                com.Parameters.AddWithValue("@ka", yayadi.Text);
                if (com.ExecuteNonQuery() == 1)
                    MessageBox.Show("Kayıt Eklendi");
                Form1.con.Close();
                listeleyay();
                yaykaydet.Visible = true;
                yaytamam.Visible = false;

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Kayıt eklerken bir hata oluştu");
            }
        }

        private void yaykaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.conac();
                string komut = "update silme set silmeneden=@ka where silmeid=@id";
                SqlCommand com = new SqlCommand(komut, Form1.con);
                com.Parameters.AddWithValue("@ka", yayadi.Text);
                com.Parameters.AddWithValue("@id", yayid.Text);
                if (com.ExecuteNonQuery() == 1)
                    MessageBox.Show("Kayıt Güncellendi");
                Form1.con.Close();
                listeleyay();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Kayıt güncellerken bir hata oluştu");
            }
        }

        private void yayiptal_Click(object sender, EventArgs e)
        {
            yayadi.Text = "";
        }

        private void yaysil_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.conac();
                string komut = "Delete From silme where silmeid=" + yayid.Text;
                SqlCommand cmd = new SqlCommand(komut, Form1.con);
                if (cmd.ExecuteNonQuery() == 1)
                    MessageBox.Show("Kaydınız Silindi");
                Form1.con.Close();
                listeleyay();
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message, "Silerken bir hata oluştu");
            }
        }

        private void dataGridView3_Click(object sender, EventArgs e)
        {
            yayid.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            yayadi.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            yazid.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            yazadi.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            kat.Visible = true;
            yaz.Visible = false;
            yay.Visible = false;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            kat.Visible = false;
            yaz.Visible = true;
            yay.Visible = false;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            kat.Visible = false;
            yaz.Visible = false;
            yay.Visible = true;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            stok s = new stok();
            s.ShowDialog();
        }
    }
}
