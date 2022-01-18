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
    public partial class kullanici : Form
    {
        public kullanici()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        int kacincikayit;
        int baş;
        SqlDataReader dr;
        void listele()
        {
            string sec = "select * from personel";
            SqlDataAdapter da = new SqlDataAdapter(sec, Form1.con);
            ds.Clear();
            da.Fill(ds, "personel");

            dataGridView1.DataSource = bs;

        }
        private void kullanici_Load(object sender, EventArgs e)
        {
            if (Form1.con.State == ConnectionState.Closed) Form1.conac();
            this.personelTableAdapter1.Fill(this.stokDataSet7.personel);
            bkaydet.Visible = biptal.Visible = false;
            listele();
            bs.DataSource = ds.Tables["personel"];
            dataGridView1.DataSource = bs;
        }

        private void by_Click(object sender, EventArgs e)
        {
            tbad.Clear();
            tbtc.Clear();
            tbsoy.Clear();
            tbka.Clear();
            tbs.Clear();
            tbak.Clear();
            tbtc.Focus();
            bkaydet.Visible = biptal.Visible = true;
            kacincikayit = ds.Tables["personel"].Rows.Count;
        }

        private void bsil_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult c = MessageBox.Show("Eminmisiniz?", "Bilgi", MessageBoxButtons.YesNo);
                if (c == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = Form1.con;
                    cmd.CommandText = "delete from personel where tc=@tc";
                    cmd.Parameters.AddWithValue("@tc", tbtc.Text);
                    cmd.ExecuteNonQuery();
                    listele();
                    MessageBox.Show("Kaydınız Silindi");
                }

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Silerken bir hata oluştu");
            }
        }

        private void bd_Click(object sender, EventArgs e)
        {
            tbad.Focus();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Form1.con;
            cmd.CommandText = "update personel set ad=@ad,soyad=@soy,ka=@ka,sifre=@sif,hesapturu=@ht,annekizlik=@ak,tel=@t,eposta=@e where tc=@tc";
            cmd.Parameters.AddWithValue("@ad", tbad.Text);
            cmd.Parameters.AddWithValue("@soy", tbsoy.Text);
            cmd.Parameters.AddWithValue("@ka", tbka.Text);
            cmd.Parameters.AddWithValue("@sif", tbs.Text);
            if(cbht.Text=="Yönetici")
                cmd.Parameters.AddWithValue("@ht", true);
            else
                cmd.Parameters.AddWithValue("@ht", false);
            cmd.Parameters.AddWithValue("@ak", tbak.Text);
            cmd.Parameters.AddWithValue("@t",tbtel.Text );
            cmd.Parameters.AddWithValue("@e", tbe.Text);
            cmd.Parameters.AddWithValue("@tc", tbtc.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Kaydınız Düzeltildi.");
            listele();
            kacincikayit = bs.Position;
        }

        private void bkaydet_Click(object sender, EventArgs e)
        {
           
            if (tbad.Text == "" || tbak.Text == "" || tbka.Text == "" || tbs.Text == "" || tbsoy.Text == "" || tbtc.Text == "")
                MessageBox.Show("Lütfen boş alan bırakmayınız.");
            else
            {
                bkaydet.Visible = biptal.Visible = false;
                SqlCommand cmd = new SqlCommand();
                SqlCommand cmd1 = new SqlCommand();
                cmd.Connection = Form1.con;
                cmd1.Connection = Form1.con;
                cmd1.CommandText = "Select * from personel where tc=@tc1";
                cmd1.Parameters.AddWithValue("@tc1", tbtc.Text);
                dr = cmd1.ExecuteReader();
                if (dr.Read())
                { 
                    MessageBox.Show("Bu TC kimlik numarası ile daha önce kayıt yapılmış."); 
                    dr.Close(); 
                    tbtc.Clear();
                    bkaydet.Visible = biptal.Visible = true; 
                }
                else
                {
                    try
                    {
                        dr.Close();
                        cmd.CommandText = "insert into personel (tc,ad,soyad,ka,sifre,hesapturu,annekizlik,tel,eposta) Values (@tc,@ad,@soy,@ka,@sif,@ht,@ak,@t,@e)";
                        cmd.Parameters.AddWithValue("@tc", tbtc.Text);
                        cmd.Parameters.AddWithValue("@ad", tbad.Text);
                        cmd.Parameters.AddWithValue("@soy", tbsoy.Text);
                        cmd.Parameters.AddWithValue("@ka", tbka.Text);
                        cmd.Parameters.AddWithValue("@sif", tbs.Text);
                        if (cbht.Text == "Yönetici")
                            cmd.Parameters.AddWithValue("@ht", true);
                        else
                            cmd.Parameters.AddWithValue("@ht", false);
                        cmd.Parameters.AddWithValue("@ak", tbak.Text);
                        cmd.Parameters.AddWithValue("@t", tbtel.Text);
                        cmd.Parameters.AddWithValue("@e", tbe.Text);

                    }
                    catch (Exception hata)
                    {

                        MessageBox.Show(hata.Message, "Kayıt eklerken bir hata oluştu");
                    } 


                    string tc = tbtc.Text;
                    int a = tc.Length;
                    if (a == 11)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kayıt Gerçekleştirildi");
                        listele();
                        bs.Position = kacincikayit;
                    }
                    else
                    {
                        tbtc.Clear();
                        MessageBox.Show("TC kimlik numarası 11 haneli olmalıdır.");
                        bkaydet.Visible = biptal.Visible = true;
                    }


                }
            }
        }

        private void biptal_Click(object sender, EventArgs e)
        {
            bkaydet.Visible = biptal.Visible = false; 
            listele();
            tbad.Clear();
            tbtc.Clear();
            tbsoy.Clear();
            tbka.Clear();
            tbs.Clear();
            tbak.Clear();
            tbtc.Focus();
        }

        private void tcarama_TextChanged(object sender, EventArgs e)
        {
            string sec = "select * from personel where tc like '%" + tcarama.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sec, Form1.con);
            ds.Clear();
            da.Fill(ds, "personel");
        }

        private void aramad_TextChanged(object sender, EventArgs e)
        {
            string sec = "select * from personel where ad like '%" + aramad.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sec, Form1.con);
            ds.Clear();
            da.Fill(ds, "personel");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            listele();
            aramad.Text = "";
            tcarama.Text = "";
        }

        private void checkBox1_MouseLeave(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
        }

        private void geri_Click(object sender, EventArgs e)
        {
            ileri.Enabled = true;
            bs.Position--;
            if (0 == bs.Position)
                geri.Enabled = false;
        }

        private void ileri_Click(object sender, EventArgs e)
        {
            geri.Enabled = true;
            baş = ds.Tables["personel"].Rows.Count;
            bs.Position++;
            if (--baş == bs.Position)
                ileri.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            stok s = new stok();
            s.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {   
            bool a;
            tbka.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tbsoy.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tbad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbak.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            tbtel.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            a = bool.Parse( dataGridView1.CurrentRow.Cells[5].Value.ToString());
            if (a == true)
                cbht.Text = "Yönetici";
            else
                cbht.Text = "Personel";
            tbtc.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbe.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            tbs.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
