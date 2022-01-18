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
    public partial class sil : Form
    {
        public sil()
        {
            InitializeComponent();
        }
        public static DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        void listele()
        {
            string sec = "select  s.*,su.subeadi,st.stokturu,per.ad,si.silmeneden from ss as s,sube as su,stokturu as st,personel as per,silme as si where s.ssturu=st.stokid and s.sstc=per.tc and s.ssubekodu=su.subekodu and s.silmeid=si.silmeid";
            SqlDataAdapter da = new SqlDataAdapter(sec, Form1.con);
            if (ds.Tables["ss"] != null)
                ds.Tables["ss"].Clear();
            da.Fill(ds, "ss");
            toolStripLabel1.Text = "Silinen stok sayısı=" + ds.Tables["ss"].Rows.Count;

        }

        private void sil_Load(object sender, EventArgs e)
        {
            
            this.ssTableAdapter.Fill(this.stokDataSet6.ss);
            listele();
            bs.DataSource = ds.Tables["ss"];
            dataGridView1.DataSource = bs;

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            starih.Text = "Silinen Tarih:"+dataGridView1.CurrentRow.Cells[13].Value.ToString();
            skul.Text ="Silen Kullanıcı:"+ dataGridView1.CurrentRow.Cells[12].Value.ToString();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            stok s = new stok();
            s.ShowDialog();
        }
    }
}
