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
    public partial class pgiriscs : Form
    {
        public pgiriscs()
        {
            InitializeComponent();
        }
        public static string tc;
        public static Boolean ht;
        public static string ka;
        SqlCommand cmd1 = new SqlCommand();

        private void bg_Click(object sender, EventArgs e)
        {
            try
            {
                string sec = "select * from personel";
                SqlCommand cmd = new SqlCommand(sec, Form1.con);
                SqlDataReader dr;
                Form1.con.Open();
                cmd.Connection = Form1.con;
                cmd.CommandText = "SELECT * FROM personel where  ka='" + tbka.Text + "' AND sifre='" + tbs.Text + "'";
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    tc = dr["tc"].ToString();
                    ht =bool.Parse( dr["hesapturu"].ToString());
                    ka = tbka.Text;
                    this.Hide();
                    stok s = new stok();
                    s.ShowDialog();

                }
                else
                    MessageBox.Show("Bilgilerinizi kontrol ediniz.");

                dr.Close();
                Form1.con.Close();

            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message, "Bir hata oluştu");
                Form1.con.Close();
            }
        }

        private void bi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            unuttum u = new unuttum();
            u.ShowDialog();
        }

        private void pgiriscs_Activated(object sender, EventArgs e)
        {
            tbka.Clear();
            tbs.Clear();
            tbka.Focus();
        }
    }
}
