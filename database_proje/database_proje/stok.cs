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
    public partial class stok : Form
    { 
        public static DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        int kacincikayit;
        int baş;
        Boolean s;
        public static int ekle;
        public stok()
        {
            InitializeComponent();
        }
       
        void listele()
        {
            string sec = "select  s.*,su.subeadi,st.stokturu,per.ad from stok as s,sube as su,stokturu as st,personel as per where s.stokid=st.stokid and s.tc=per.tc and s.subekodu=su.subekodu";
            SqlDataAdapter da = new SqlDataAdapter(sec, Form1.con);
            if (ds.Tables["stok"] != null)
                ds.Tables["stok"].Clear();
            da.Fill(ds, "stok");
            toolStripLabel1.Text = "Stok sayısı=" + ds.Tables["stok"].Rows.Count;

        }

        private void stok_Load(object sender, EventArgs e)
        {



            if (pgiriscs.ht == true)
                kul.Visible = true;
            kullaniciadi.Text = pgiriscs.ka;
            skodu.ReadOnly = true;
            bkaydet.Visible = false;
            
            if (Form1.con.State == ConnectionState.Closed) Form1.conac();
            this.stokTableAdapter.Fill(this.stokDataSet.stok);
            this.subeTableAdapter.Fill(this.stokDataSet3.sube);
            this.stokturuTableAdapter.Fill(this.stokDataSet2.stokturu);
            this.personelTableAdapter.Fill(this.stokDataSet1.personel);
            this.silmeTableAdapter.Fill(this.stokDataSet4.silme);
            Form1.con.Close();
            listele();
            bs.DataSource = ds.Tables["stok"];
            dataGridView1.DataSource = bs;
            
        }

        private void by_Click(object sender, EventArgs e)
        {
            tbsadi.Focus();
            bkaydet.Visible = biptal.Visible = true;
            bkaydet.BackColor = Color.Aqua;
            kacincikayit = ds.Tables["stok"].Rows.Count;
            bd.Visible = false;
            tbekleyenka.Text = pgiriscs.ka;
            skodu.Text = "";
            tbaciklama.Text = "";
            tbsadedi.Text = "";
            tbsadi.Text = "";
            tbtf.Text = "";
            
        }

        private void bd_Click(object sender, EventArgs e)
        {
            
            tbsadi.Focus();
            kacincikayit = bs.Position;
            try
            {
                Form1.conac();
                string komut = "update stok set stokid=@ka,sadi=@sa,smik=@yt,starih=@s,tc=@ki,sfiyat=@yayin,aciklama=@yazar,subekodu=@saa where skodu=@id";
                SqlCommand com = new SqlCommand(komut, Form1.con);
                com.Parameters.AddWithValue("@ka", int.Parse(cbst.SelectedValue.ToString()));
                com.Parameters.AddWithValue("@sa", tbsadi.Text);
                com.Parameters.AddWithValue("@yt", tbsadedi.Text.ToString());
                com.Parameters.AddWithValue("@s", DateTime.Parse( dateTimePicker1.Text));
                com.Parameters.AddWithValue("@ki", pgiriscs.tc);
                com.Parameters.AddWithValue("@yayin", tbtf.Text.ToString());
                com.Parameters.AddWithValue("@yazar", tbaciklama.Text);
                com.Parameters.AddWithValue("@saa", int.Parse(cbsa.SelectedValue.ToString()));
                com.Parameters.AddWithValue("@id", skodu.Text);
                if (com.ExecuteNonQuery() == 1)
                    MessageBox.Show("Kayıt Güncellendi");
                Form1.con.Close();
                listele();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Kayıt güncellerken bir hata oluştu");
            }

        }

        private void bkaydet_Click(object sender, EventArgs e)
        {
            if(s)
            {
                Form1.conac();
                string komut = "Insert Into ss (ssturu,ssadi,ssmik,sstarih,sstc,ssubekodu,ssaciklama,silmeid,ektarihi,skullanici) Values (@sa,@sadi,@mik,@tarih,@tc,@sk,@aciklama,@sid,@e,@s)";
                SqlCommand cmd = new SqlCommand(komut, Form1.con);
                cmd.Parameters.AddWithValue("@sa", int.Parse(cbst.SelectedValue.ToString()));
                cmd.Parameters.AddWithValue("@sadi", tbsadi.Text);
                cmd.Parameters.AddWithValue("@mik", tbsadedi.Text.ToString());
                cmd.Parameters.AddWithValue("@tarih", DateTime.Now);
                cmd.Parameters.AddWithValue("@tc", pgiriscs.tc);
                cmd.Parameters.AddWithValue("@sk", int.Parse(cbsa.SelectedValue.ToString()));
                cmd.Parameters.AddWithValue("@aciklama", tbaciklama.Text);
                cmd.Parameters.AddWithValue("@sid", int.Parse(cbsn.SelectedValue.ToString()));
                cmd.Parameters.AddWithValue("@e", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@s",kullaniciadi.Text );
                cmd.ExecuteNonQuery();
                Form1.con.Close();
                silme.Visible = false;
                cbsn.Visible = false;
                bkaydet.Visible = false;
                sil.Visible = false;
                try
                {
                    Form1.conac();
                    string komu = "Delete From stok where skodu=" + skodu.Text;
                    SqlCommand cm = new SqlCommand(komu, Form1.con);
                    if (cm.ExecuteNonQuery() == 1)
                        MessageBox.Show("Kaydınız Silindi");
                    Form1.con.Close();
                    listele();
                }
                catch (Exception hata)
                {

                    MessageBox.Show(hata.Message, "Silerken bir hata oluştu");
                }
            }
            else
            {
                try
                {
                    Form1.conac();
                    string komut = "Insert Into stok (stokid,sadi,smik,starih,tc,sfiyat,aciklama,subekodu) Values (@sa,@sadi,@mik,@tarih,@tc,@f,@aciklama,@sk)";
                    SqlCommand cmd = new SqlCommand(komut, Form1.con);
                    cmd.Parameters.AddWithValue("@sa", int.Parse(cbst.SelectedValue.ToString()));
                    cmd.Parameters.AddWithValue("@sadi", tbsadi.Text);
                    cmd.Parameters.AddWithValue("@mik", tbsadedi.Text.ToString());
                    cmd.Parameters.AddWithValue("@tarih", DateTime.Parse( dateTimePicker1.Text));
                    cmd.Parameters.AddWithValue("@tc", pgiriscs.tc);
                    cmd.Parameters.AddWithValue("@f", tbtf.Text.ToString());
                    cmd.Parameters.AddWithValue("@aciklama", tbaciklama.Text);
                    cmd.Parameters.AddWithValue("@sk", int.Parse(cbsa.SelectedValue.ToString()));
                    if (cmd.ExecuteNonQuery() == 1)
                        MessageBox.Show("Kayıt Eklendi");
                    Form1.con.Close();
                    listele();
                    bkaydet.Visible = false;
                    biptal.Visible = false;
                    bd.Visible = true;
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message, "Kayıt eklerken bir hata oluştu");
                }
            }
           
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
           
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tbsadedi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tbsadi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbtf.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            tbaciklama.Text= dataGridView1.CurrentRow.Cells[7].Value.ToString();
            cbsa.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            cbst.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            skodu.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            tbekleyenka.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            
        }

        private void ileri_Click(object sender, EventArgs e)
        {
            geri.Enabled = true;
            baş = ds.Tables["stok"].Rows.Count;
            bs.Position++;
            if (--baş == bs.Position)
                ileri.Enabled = false;
        }

        private void geri_Click(object sender, EventArgs e)
        {
            ileri.Enabled = true;
            bs.Position--;
            if (0 == bs.Position)
                geri.Enabled = false;
        }

        private void biptal_Click(object sender, EventArgs e)
        {
            bkaydet.Visible = false;
            silme.Visible = false;
            cbsn.Visible = false;
            bd.Visible = true;
            sil.Visible = false;
            skodu.Text = "";
            tbaciklama.Text = "";
            tbekleyenka.Text = "";
            tbsadedi.Text = "";
            tbsadi.Text = "";
            tbtf.Text = "";
            
        }

        private void saarama_TextChanged(object sender, EventArgs e)
        {
            string sec = "select  s.*,su.subeadi,st.stokturu,per.ad from stok as s,sube as su,stokturu as st,personel as per where s.stokid=st.stokid and s.tc=per.tc and s.subekodu=su.subekodu and sadi like '%" + saarama.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sec, Form1.con);
            if (ds.Tables["stok"] != null)
                ds.Tables["stok"].Clear();
            da.Fill(ds, "stok");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            { listele(); saarama.Clear(); } 
        }

        private void checkBox1_MouseLeave(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
        }

        private void cbka_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                string sec = "select  s.*,p.ad from stok as s,personel as p where s.tc=p.tc and s.tc='" + cbka.SelectedValue + "'";
                SqlDataAdapter da = new SqlDataAdapter(sec, Form1.con);
                if (ds.Tables["stok"] != null)
                    ds.Tables["stok"].Clear();
                da.Fill(ds, "stok");

            }
            catch(Exception hata)
            {
                MessageBox.Show(hata.Message, "Listelenirken bir hata oluştu");
            }
        }

        private void tbsadedi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void bsil_Click(object sender, EventArgs e)
        {
            s = true;
            bkaydet.Visible = true;
            bkaydet.BackColor = Color.Red;
            cbsn.Visible = true;
            silme.Visible = true;
            sil.Visible = true;
        }

        private void stur_Click(object sender, EventArgs e)
        {
            this.Hide();
            ekle = 3;
            ekle ek = new ekle();
            ek.ShowDialog();
        }

        private void sube_Click(object sender, EventArgs e)
        {
            this.Hide();
            ekle = 1;
            ekle ek = new ekle();
            ek.ShowDialog();
        }

        private void sil_Click(object sender, EventArgs e)
        {
            this.Hide();
            ekle = 2;
            ekle ek = new ekle();
            ek.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            sil s = new sil();
            s.ShowDialog();
        }

        private void kul_Click(object sender, EventArgs e)
        {
            this.Hide();
            kullanici k = new kullanici();
            k.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
