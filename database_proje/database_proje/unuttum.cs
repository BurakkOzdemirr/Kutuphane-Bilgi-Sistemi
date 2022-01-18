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
    public partial class unuttum : Form
    {
        public unuttum()
        {
            InitializeComponent();
        }
        SqlDataReader dr;

        private void geridön_Click(object sender, EventArgs e)
        {
            this.Hide();
            pgiriscs p = new pgiriscs();
            p.ShowDialog();
        }

        private void unuttum_Activated(object sender, EventArgs e)
        {
            tbc.Clear();
            tbka.Clear();
            tbtc.Clear();
            tbys.Clear();
            lys.Visible = false;
            tbys.Visible = false;
            kaydet.Visible = false;
        }

        private void tamam_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand cmd = new SqlCommand();
                if (Form1.con.State == ConnectionState.Closed) Form1.conac();;
                cmd.Connection = Form1.con;
                cmd.CommandText = "SELECT * FROM personel where ka='" + tbka.Text + "' AND tc='" + tbtc.Text + "' AND annekizlik='" + tbc.Text + "'";
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    lys.Visible = true;
                    tbys.Visible = true;
                    kaydet.Visible = true;
                   

                }
                else
                    MessageBox.Show("Bilgilerinizi kontrol ediniz.");
                Form1.con.Close();

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Bir hata oluştu");
            }
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                if (Form1.con.State == ConnectionState.Closed) Form1.conac(); ;
                cmd.Connection = Form1.con;
                cmd.CommandText = "update personel set sifre=@sf where tc=@tc";
                cmd.Parameters.AddWithValue("@sf", tbys.Text);
                cmd.Parameters.AddWithValue("@tc", tbtc.Text);
                cmd.ExecuteNonQuery();
                Form1.con.Close();
                MessageBox.Show("Şifreniz değiştirilmiştir.");
                this.Hide();
                pgiriscs p = new pgiriscs();
                p.ShowDialog();
                

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Bir hata oluştu");
            }
        }
    }
}
