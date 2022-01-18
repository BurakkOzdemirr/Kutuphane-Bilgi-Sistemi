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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static SqlConnection con = new SqlConnection("Data Source=CASPER_NIRVANA;Initial Catalog=stok;Integrated Security=True");
        
        
        public static void conac()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Bağlantı Hatası Penceresi");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            giris.Visible = false;
            stok.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            pgiriscs p = new pgiriscs();
            p.ShowDialog();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            int c = 1;
            if (c == 1)
            {

                c++;
                progressBar1.Maximum = 100;
                progressBar1.Value = 0;
                for (int i = 1; i <= 100; i++)
                {
                    progressBar1.Value = i;
                    System.Threading.Thread.Sleep(15);
                }

                giris.Visible = true; stok.Visible = true;  progressBar1.Visible = false;
            }
        }
    }
}
